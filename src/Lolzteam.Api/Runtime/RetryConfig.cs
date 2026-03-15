namespace Lolzteam.Api.Runtime;

public sealed record RetryConfig
{
	public int MaxRetries { get; init; } = 3;
	public TimeSpan BaseDelay { get; init; } = TimeSpan.FromSeconds(1);
	public TimeSpan MaxDelay { get; init; } = TimeSpan.FromSeconds(30);
}
