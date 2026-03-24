namespace Lolzteam.Api.Runtime;

public static class RetryHandler
{
#if !NET6_0_OR_GREATER
	private static readonly Random SharedRandom = new();
#endif
	public static async Task<T> WithRetryAsync<T>(
		RetryConfig config,
		Func<Task<T>> block,
		Action<RetryInfo>? onRetry = null,
		string method = "",
		string path = "")
	{
		Exception? lastError = null;

		for (var attempt = 0; attempt <= config.MaxRetries; attempt++)
		{
			try
			{
				return await block().ConfigureAwait(false);
			}
			catch (Exception ex) when (IsRetryable(ex))
			{
				lastError = ex;

				if (attempt >= config.MaxRetries)
				{
					break;
				}

				var delay = ComputeDelay(config, attempt, ex);

				if (onRetry is not null)
				{
					onRetry(new RetryInfo(attempt + 1, delay, ex, method, path));
				}

				await Task.Delay(delay).ConfigureAwait(false);
			}
		}

		if (lastError is not null && config.MaxRetries > 0)
		{
			throw new RetryExhaustedException(config.MaxRetries + 1, lastError);
		}

		throw lastError ?? new InvalidOperationException("Unreachable");
	}

	private static bool IsRetryable(Exception ex) => ex switch
	{
		RateLimitException => true,
		ServerException server => server.StatusCode is 502 or 503 or 504,
		NetworkException { IsTransient: true } => true,
		_ => false,
	};

	private static TimeSpan ComputeDelay(RetryConfig config, int attempt, Exception ex)
	{
		if (ex is RateLimitException { RetryAfter: { } retryAfter })
		{
			return retryAfter > config.MaxDelay ? config.MaxDelay : retryAfter;
		}

		var baseMs = config.BaseDelay.TotalMilliseconds;
		var exponential = baseMs * Math.Pow(2, attempt);
#if NET6_0_OR_GREATER
		var jitter = Random.Shared.NextDouble() * baseMs;
#else
		double jitter;
		lock (SharedRandom)
		{
			jitter = SharedRandom.NextDouble() * baseMs;
		}
#endif
		var totalMs = exponential + jitter;
		var delay = TimeSpan.FromMilliseconds(totalMs);

		return delay > config.MaxDelay ? config.MaxDelay : delay;
	}
}
