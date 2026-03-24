namespace Lolzteam.Api.Runtime;

public abstract class LolzteamException : Exception
{
    protected LolzteamException(string message) : base(message) { }
    protected LolzteamException(string message, Exception innerException) : base(message, innerException) { }
}
