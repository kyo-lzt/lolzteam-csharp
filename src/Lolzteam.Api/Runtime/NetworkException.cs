namespace Lolzteam.Api.Runtime;

public sealed class NetworkException : LolzteamException
{
	public NetworkException(string message, Exception innerException)
		: base(message, innerException) { }
}
