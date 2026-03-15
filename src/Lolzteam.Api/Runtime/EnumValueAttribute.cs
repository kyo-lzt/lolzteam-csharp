namespace Lolzteam.Api.Runtime;

/// <summary>Maps a string enum member to its serialized value.</summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class EnumValueAttribute : Attribute
{
	public string Value { get; }

	public EnumValueAttribute(string value)
	{
		Value = value;
	}
}
