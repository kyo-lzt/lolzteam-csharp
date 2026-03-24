namespace Lolzteam.Api.Runtime;

public class RetryExhaustedException : LolzteamException
{
    public int Attempts { get; }
    public Exception LastError { get; }

    public RetryExhaustedException(int attempts, Exception lastError)
        : base($"Request failed after {attempts} attempts: {lastError.Message}", lastError)
    {
        Attempts = attempts;
        LastError = lastError;
    }
}
