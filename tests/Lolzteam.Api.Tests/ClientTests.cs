using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Lolzteam.Api.Generated.Forum;
using Lolzteam.Api.Generated.Market;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests;

/// <summary>
/// Captures HTTP requests and returns pre-configured responses.
/// </summary>
internal sealed class MockHandler : HttpMessageHandler
{
    private readonly Queue<(HttpStatusCode Status, string Body, Dictionary<string, string>? Headers)> _responses = new();
    private readonly List<HttpRequestMessage> _requests = new();

    public IReadOnlyList<HttpRequestMessage> Requests => _requests;

    public void Enqueue(HttpStatusCode status, string body, Dictionary<string, string>? headers = null)
    {
        _responses.Enqueue((status, body, headers));
    }

    protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        _requests.Add(request);

        if (_responses.Count == 0)
        {
            throw new InvalidOperationException("No more mock responses queued.");
        }

        var (status, body, headers) = _responses.Dequeue();
        var response = new HttpResponseMessage(status)
        {
            Content = new StringContent(body, Encoding.UTF8, "application/json"),
        };

        if (headers is not null)
        {
            foreach (var (key, value) in headers)
            {
                response.Headers.TryAddWithoutValidation(key, value);
            }
        }

        return Task.FromResult(response);
    }
}

public class ClientTests
{
    private static LolzteamHttpClient CreateClient(
        MockHandler handler,
        string token = "test-token",
        RetryConfig? retry = null)
    {
        var httpClient = new HttpClient(handler);
        var config = new ClientConfig
        {
            Token = token,
            BaseUrl = "https://api.test.local",
            Retry = retry ?? new RetryConfig { MaxRetries = 0 },
        };
        return new LolzteamHttpClient(config, httpClient);
    }

    // ── 1. Successful request ──────────────────────────────────────

    [Fact]
    public async Task SuccessfulRequest_ReturnsJsonElement()
    {
        var handler = new MockHandler();
        handler.Enqueue(HttpStatusCode.OK, """{"threads":[]}""");
        using var client = CreateClient(handler);

        var result = await client.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/threads",
        });

        Assert.Equal(JsonValueKind.Object, result.ValueKind);
        Assert.True(result.TryGetProperty("threads", out _));
    }

    // ── 2. Auth header verification ────────────────────────────────

    [Fact]
    public async Task BearerTokenSentInAuthHeader()
    {
        var handler = new MockHandler();
        handler.Enqueue(HttpStatusCode.OK, """{"ok":true}""");
        using var client = CreateClient(handler, token: "secret-abc-123");

        await client.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/me",
        });

        Assert.Single(handler.Requests);
        var authHeader = handler.Requests[0].Headers.Authorization;
        Assert.NotNull(authHeader);
        Assert.Equal("Bearer", authHeader.Scheme);
        Assert.Equal("secret-abc-123", authHeader.Parameter);
    }

    // ── 3. 401 → AuthException ─────────────────────────────────────

    [Fact]
    public async Task Http401_ThrowsAuthException()
    {
        var handler = new MockHandler();
        handler.Enqueue(HttpStatusCode.Unauthorized, """{"error":"unauthorized"}""");
        using var client = CreateClient(handler);

        var ex = await Assert.ThrowsAsync<AuthException>(() =>
            client.RequestAsync(new RequestOptions
            {
                Method = "GET",
                Path = "/secret",
            }));

        Assert.Equal(401, ex.StatusCode);
    }

    // ── 4. 404 → NotFoundException ─────────────────────────────────

    [Fact]
    public async Task Http404_ThrowsNotFoundException()
    {
        var handler = new MockHandler();
        handler.Enqueue(HttpStatusCode.NotFound, """{"error":"not found"}""");
        using var client = CreateClient(handler);

        var ex = await Assert.ThrowsAsync<NotFoundException>(() =>
            client.RequestAsync(new RequestOptions
            {
                Method = "GET",
                Path = "/threads/999",
            }));

        Assert.Equal(404, ex.StatusCode);
    }

    // ── 5. 429 → RateLimitException ────────────────────────────────

    [Fact]
    public async Task Http429_ThrowsRateLimitException()
    {
        var handler = new MockHandler();
        handler.Enqueue(HttpStatusCode.TooManyRequests, """{"error":"rate limited"}""");
        using var client = CreateClient(handler);

        await Assert.ThrowsAsync<RateLimitException>(() =>
            client.RequestAsync(new RequestOptions
            {
                Method = "GET",
                Path = "/threads",
            }));
    }

    // ── 6. 429 retry then success ──────────────────────────────────

    [Fact]
    public async Task Retry_429ThenSuccess()
    {
        var handler = new MockHandler();
        handler.Enqueue(
            HttpStatusCode.TooManyRequests,
            """{"error":"rate limited"}""",
            new Dictionary<string, string> { ["Retry-After"] = "0" });
        handler.Enqueue(HttpStatusCode.OK, """{"retried":true}""");

        var retry = new RetryConfig
        {
            MaxRetries = 1,
            BaseDelay = TimeSpan.FromMilliseconds(1),
            MaxDelay = TimeSpan.FromMilliseconds(10),
        };
        using var client = CreateClient(handler, retry: retry);

        var result = await client.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/threads",
        });

        Assert.True(result.GetProperty("retried").GetBoolean());
        Assert.Equal(2, handler.Requests.Count);
    }

    // ── 7. 502 retry then success ──────────────────────────────────

    [Fact]
    public async Task Retry_502ThenSuccess()
    {
        var handler = new MockHandler();
        handler.Enqueue(HttpStatusCode.BadGateway, """{"error":"bad gateway"}""");
        handler.Enqueue(HttpStatusCode.OK, """{"recovered":true}""");

        var retry = new RetryConfig
        {
            MaxRetries = 1,
            BaseDelay = TimeSpan.FromMilliseconds(1),
            MaxDelay = TimeSpan.FromMilliseconds(10),
        };
        using var client = CreateClient(handler, retry: retry);

        var result = await client.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/unstable",
        });

        Assert.True(result.GetProperty("recovered").GetBoolean());
        Assert.Equal(2, handler.Requests.Count);
    }

    // ── 8. Path parameter substitution ─────────────────────────────

    [Fact]
    public async Task PathParamSubstitution()
    {
        var handler = new MockHandler();
        handler.Enqueue(HttpStatusCode.OK, """{"thread_id":123}""");
        using var client = CreateClient(handler);

        var threadId = 123;
        await client.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/threads/{threadId}",
        });

        Assert.Single(handler.Requests);
        var uri = handler.Requests[0].RequestUri!;
        Assert.Equal("/threads/123", uri.AbsolutePath);
    }

    // ── 9. ForumClient basic usage ─────────────────────────────────

    [Fact]
    public void ForumClient_ConstructsWithConfig()
    {
        var config = new ClientConfig { Token = "test-token" };
        using var client = new ForumClient(config);

        Assert.NotNull(client.Threads);
        Assert.NotNull(client.Users);
        Assert.NotNull(client.Categories);
        Assert.NotNull(client.Forums);
    }

    // ── 10. MarketClient basic usage ───────────────────────────────

    [Fact]
    public void MarketClient_ConstructsWithConfig()
    {
        var config = new ClientConfig { Token = "test-token" };
        using var client = new MarketClient(config);

        Assert.NotNull(client.Category);
        Assert.NotNull(client.List);
        Assert.NotNull(client.Payments);
        Assert.NotNull(client.Purchasing);
    }
}
