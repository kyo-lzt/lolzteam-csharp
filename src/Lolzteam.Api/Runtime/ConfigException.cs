namespace Lolzteam.Api.Runtime;

public sealed class ConfigException : LolzteamException
{
	public ConfigException(string message) : base(message) { }
}
