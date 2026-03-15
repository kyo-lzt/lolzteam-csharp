using System.Net.Http.Headers;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests;

public class RetryHandlerTests
{
	private static readonly RetryConfig FastConfig = new()
	{
		MaxRetries = 2,
		BaseDelay = TimeSpan.FromMilliseconds(10),
		MaxDelay = TimeSpan.FromMilliseconds(50),
	};

	private static readonly HttpResponseHeaders EmptyHeaders = CreateEmptyHeaders();

	private static HttpResponseHeaders CreateEmptyHeaders()
	{
		using var msg = new HttpResponseMessage();
		return msg.Headers;
	}

	[Fact]
	public async Task RetriesOnRateLimitException()
	{
		var attempts = 0;
		var result = await RetryHandler.WithRetryAsync(FastConfig, () =>
		{
			attempts++;
			if (attempts < 3)
			{
				throw new RateLimitException("rate limited", EmptyHeaders);
			}
			return Task.FromResult("success");
		});

		Assert.Equal("success", result);
		Assert.Equal(3, attempts);
	}

	[Fact]
	public async Task RetriesOnServerException502()
	{
		var attempts = 0;
		var result = await RetryHandler.WithRetryAsync(FastConfig, () =>
		{
			attempts++;
			if (attempts < 2)
			{
				throw new ServerException(502, "bad gateway", EmptyHeaders);
			}
			return Task.FromResult("ok");
		});

		Assert.Equal("ok", result);
		Assert.Equal(2, attempts);
	}

	[Fact]
	public async Task DoesNotRetryOnAuthException()
	{
		var attempts = 0;
		await Assert.ThrowsAsync<AuthException>(() =>
			RetryHandler.WithRetryAsync<string>(FastConfig, () =>
			{
				attempts++;
				throw new AuthException(401, "unauthorized", EmptyHeaders);
			}));

		Assert.Equal(1, attempts);
	}

	[Fact]
	public async Task DoesNotRetryOnNotFoundException()
	{
		var attempts = 0;
		await Assert.ThrowsAsync<NotFoundException>(() =>
			RetryHandler.WithRetryAsync<string>(FastConfig, () =>
			{
				attempts++;
				throw new NotFoundException("not found", EmptyHeaders);
			}));

		Assert.Equal(1, attempts);
	}

	[Fact]
	public async Task ThrowsRetryExhaustedAfterMaxRetries()
	{
		var attempts = 0;
		var ex = await Assert.ThrowsAsync<RetryExhaustedException>(() =>
			RetryHandler.WithRetryAsync<string>(FastConfig, () =>
			{
				attempts++;
				throw new RateLimitException("rate limited", EmptyHeaders);
			}));

		Assert.Equal(3, attempts); // initial + 2 retries
		Assert.Equal(3, ex.Attempts);
		Assert.IsType<RateLimitException>(ex.LastError);
	}

	[Fact]
	public async Task ThrowsRetryExhaustedForServerException()
	{
		var attempts = 0;
		var ex = await Assert.ThrowsAsync<RetryExhaustedException>(() =>
			RetryHandler.WithRetryAsync<string>(FastConfig, () =>
			{
				attempts++;
				throw new ServerException(502, "bad gateway", EmptyHeaders);
			}));

		Assert.Equal(3, attempts);
		Assert.Equal(3, ex.Attempts);
		Assert.IsType<ServerException>(ex.LastError);
	}
}
