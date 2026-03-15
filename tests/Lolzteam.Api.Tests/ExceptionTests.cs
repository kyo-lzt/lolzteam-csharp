using System.Net.Http.Headers;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests;

public class ExceptionTests
{
	private static readonly HttpResponseHeaders EmptyHeaders = CreateEmptyHeaders();

	private static HttpResponseHeaders CreateEmptyHeaders()
	{
		using var msg = new HttpResponseMessage();
		return msg.Headers;
	}

	[Fact]
	public void HttpExceptionFactory429()
	{
		var ex = HttpException.Create(429, "body", EmptyHeaders);
		Assert.IsType<RateLimitException>(ex);
		Assert.Equal(429, ex.StatusCode);
	}

	[Fact]
	public void HttpExceptionFactory401()
	{
		var ex = HttpException.Create(401, "body", EmptyHeaders);
		Assert.IsType<AuthException>(ex);
	}

	[Fact]
	public void HttpExceptionFactory404()
	{
		var ex = HttpException.Create(404, "body", EmptyHeaders);
		Assert.IsType<NotFoundException>(ex);
	}

	[Fact]
	public void HttpExceptionFactory500()
	{
		var ex = HttpException.Create(500, "body", EmptyHeaders);
		Assert.IsType<ServerException>(ex);
	}

	[Fact]
	public void HttpExceptionFactory418()
	{
		var ex = HttpException.Create(418, "body", EmptyHeaders);
		Assert.Equal(typeof(HttpException), ex.GetType());
	}

	[Fact]
	public void RateLimitExceptionParsesRetryAfter()
	{
		using var response = new HttpResponseMessage();
		response.Headers.Add("Retry-After", "30");
		var ex = new RateLimitException("body", response.Headers);
		Assert.Equal(TimeSpan.FromSeconds(30), ex.RetryAfter);
	}

	[Fact]
	public void RateLimitExceptionNullRetryAfterWhenMissing()
	{
		var ex = new RateLimitException("body", EmptyHeaders);
		Assert.Null(ex.RetryAfter);
	}

	[Fact]
	public void ConfigExceptionMessage()
	{
		var ex = new ConfigException("bad config");
		Assert.Equal("bad config", ex.Message);
	}

	[Fact]
	public void NetworkExceptionWraps()
	{
		var cause = new HttpRequestException("connection refused");
		var ex = new NetworkException("connection refused", cause);
		Assert.Equal("connection refused", ex.Message);
		Assert.Equal(cause, ex.InnerException);
	}
}
