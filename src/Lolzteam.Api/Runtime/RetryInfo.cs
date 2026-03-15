namespace Lolzteam.Api.Runtime;

public sealed record RetryInfo(int Attempt, TimeSpan Delay, LolzteamException Error, string Method, string Path);
