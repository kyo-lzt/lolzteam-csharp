using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Runtime;

/// <summary>
/// JSON converter for string enums annotated with <see cref="EnumValueAttribute"/>.
/// Reads/writes the raw string value instead of the member name or numeric value.
/// </summary>
public sealed class StringEnumConverter<T> : JsonConverter<T> where T : struct, Enum
{
	private static readonly Dictionary<T, string> ToStringMap;
	private static readonly Dictionary<string, T> FromString;

	static StringEnumConverter()
	{
		var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static);
		ToStringMap = new Dictionary<T, string>(fields.Length);
		FromString = new Dictionary<string, T>(fields.Length, StringComparer.OrdinalIgnoreCase);

		foreach (var field in fields)
		{
			var value = (T)field.GetValue(null)!;
			var attr = field.GetCustomAttribute<EnumValueAttribute>();
			var name = attr?.Value ?? field.Name;
			ToStringMap[value] = name;
			FromString[name] = value;
		}
	}

	public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var str = reader.GetString();
		if (str is not null && FromString.TryGetValue(str, out var result))
		{
			return result;
		}
		throw new JsonException($"Unknown value '{str}' for enum {typeof(T).Name}.");
	}

	public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
	{
		if (ToStringMap.TryGetValue(value, out var str))
		{
			writer.WriteStringValue(str);
		}
		else
		{
			writer.WriteStringValue(value.ToString());
		}
	}
}
