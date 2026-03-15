namespace Lolzteam.Api.Runtime;

public sealed record ClientConfig
{
	public required string Token { get; init; }
	public string? BaseUrl { get; init; }
	public ProxyConfig? Proxy { get; init; }
	public RetryConfig Retry { get; init; } = new();
	public RateLimitConfig? RateLimit { get; init; }
	public RateLimitConfig? SearchRateLimit { get; init; }

	public ClientConfig WithToken(string token) => this with { Token = token };
	public ClientConfig WithBaseUrl(string baseUrl) => this with { BaseUrl = baseUrl };
	public ClientConfig WithProxy(ProxyConfig proxy) => this with { Proxy = proxy };
	public ClientConfig WithRetry(RetryConfig retry) => this with { Retry = retry };
	public ClientConfig WithRateLimit(RateLimitConfig rateLimit) => this with { RateLimit = rateLimit };
	public ClientConfig WithSearchRateLimit(RateLimitConfig searchRateLimit) => this with { SearchRateLimit = searchRateLimit };
}
