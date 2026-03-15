using System.Net.Http.Headers;

namespace Lolzteam.Api.Runtime;

public sealed class RateLimitException : HttpException
{
	public TimeSpan? RetryAfter { get; }

	public RateLimitException(string responseBody, HttpResponseHeaders headers)
		: base(429, responseBody, headers)
	{
		RetryAfter = ParseRetryAfter(headers);
	}

	private static TimeSpan? ParseRetryAfter(HttpResponseHeaders headers)
	{
		if (headers.RetryAfter is null)
		{
			return null;
		}

		if (headers.RetryAfter.Delta is { } delta)
		{
			return delta;
		}

		if (headers.RetryAfter.Date is { } date)
		{
			var delay = date - DateTimeOffset.UtcNow;
			return delay > TimeSpan.Zero ? delay : TimeSpan.Zero;
		}

		return null;
	}
}
