namespace Lolzteam.Api.Runtime;

public sealed record RetryInfo(int Attempt, TimeSpan Delay, Exception Error, string Method, string Path);
