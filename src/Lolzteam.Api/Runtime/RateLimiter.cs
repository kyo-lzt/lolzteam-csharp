namespace Lolzteam.Api.Runtime;

public sealed class RateLimiter : IDisposable
{
	private readonly int _maxTokens;
	private readonly double _refillRate;
	private readonly SemaphoreSlim _semaphore = new(1, 1);
	private double _tokens;
	private long _lastRefillTimestamp;
	private bool _disposed;

	public RateLimiter(int requestsPerMinute)
	{
		_maxTokens = requestsPerMinute;
		_refillRate = requestsPerMinute / 60000.0;
		_tokens = requestsPerMinute;
		_lastRefillTimestamp = Environment.TickCount64;
	}

	public async Task AcquireAsync(CancellationToken cancellationToken = default)
	{
		ObjectDisposedException.ThrowIf(_disposed, this);

		while (true)
		{
			await _semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
			Refill();

			if (_tokens >= 1.0)
			{
				_tokens -= 1.0;
				_semaphore.Release();
				return;
			}

			var waitMs = (int)Math.Ceiling((1.0 - _tokens) / _refillRate);
			_semaphore.Release();
			await Task.Delay(waitMs, cancellationToken).ConfigureAwait(false);
		}
	}

	private void Refill()
	{
		var now = Environment.TickCount64;
		var elapsed = now - _lastRefillTimestamp;
		if (elapsed > 0)
		{
			_tokens = Math.Min(_maxTokens, _tokens + elapsed * _refillRate);
			_lastRefillTimestamp = now;
		}
	}

	public void Dispose()
	{
		if (_disposed) return;
		_disposed = true;
		_semaphore.Dispose();
	}
}
