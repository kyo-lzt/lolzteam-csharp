namespace Lolzteam.Api.Runtime;

public static class RetryHandler
{
	private static readonly Random Rng = new();

	public static async Task<T> WithRetryAsync<T>(
		RetryConfig config,
		Func<Task<T>> block,
		Action<RetryInfo>? onRetry = null,
		string? method = null,
		string? path = null)
	{
		Exception lastException = null!;

		for (var attempt = 0; attempt <= config.MaxRetries; attempt++)
		{
			try
			{
				return await block().ConfigureAwait(false);
			}
			catch (Exception ex) when (attempt < config.MaxRetries && IsRetryable(ex))
			{
				lastException = ex;
				var delay = ComputeDelay(config, attempt, ex);

				if (onRetry is not null && ex is LolzteamException lolzEx)
				{
					onRetry(new RetryInfo(attempt + 1, delay, lolzEx, method ?? "", path ?? ""));
				}

				await Task.Delay(delay).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		throw lastException;
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
		double jitter;
		lock (Rng)
		{
			jitter = Rng.NextDouble() * baseMs;
		}
		var totalMs = exponential + jitter;
		var delay = TimeSpan.FromMilliseconds(totalMs);

		return delay > config.MaxDelay ? config.MaxDelay : delay;
	}
}
