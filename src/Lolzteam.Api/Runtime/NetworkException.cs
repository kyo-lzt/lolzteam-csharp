namespace Lolzteam.Api.Runtime;

public sealed class NetworkException : LolzteamException
{
	public NetworkException(string message, Exception innerException)
		: base(message, innerException) { }

	public bool IsTransient => InnerException is TaskCanceledException
		or HttpRequestException { InnerException: System.Net.Sockets.SocketException };
}
