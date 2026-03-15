using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Runtime;

/// <summary>
/// Represents a value that can be either a string or a long integer.
/// Used for OpenAPI schemas with <c>type: ['string', 'integer']</c>.
/// </summary>
[JsonConverter(typeof(StringOrLongConverter))]
public readonly struct StringOrLong : IEquatable<StringOrLong>
{
	private readonly string? _stringValue;
	private readonly long _longValue;
	private readonly bool _isLong;

	private StringOrLong(string value)
	{
		_stringValue = value;
		_longValue = 0;
		_isLong = false;
	}

	private StringOrLong(long value)
	{
		_stringValue = null;
		_longValue = value;
		_isLong = true;
	}

	/// <summary>True if this holds a long value, false if it holds a string.</summary>
	public bool IsLong => _isLong;

	/// <summary>True if this holds a string value.</summary>
	public bool IsString => !_isLong;

	/// <summary>Get the string value. Throws if this holds a long.</summary>
	public string AsString => _isLong
		? throw new InvalidOperationException("Value is a long, not a string.")
		: _stringValue ?? "";

	/// <summary>Get the long value. Throws if this holds a string.</summary>
	public long AsLong => _isLong
		? _longValue
		: throw new InvalidOperationException("Value is a string, not a long.");

	public static implicit operator StringOrLong(string value) => new(value);
	public static implicit operator StringOrLong(long value) => new(value);

	public bool Equals(StringOrLong other) =>
		_isLong == other._isLong
		&& (_isLong ? _longValue == other._longValue : _stringValue == other._stringValue);

	public override bool Equals(object? obj) => obj is StringOrLong other && Equals(other);

	public override int GetHashCode() =>
		_isLong ? HashCode.Combine(true, _longValue) : HashCode.Combine(false, _stringValue);

	public override string ToString() => _isLong ? _longValue.ToString() : _stringValue ?? "";

	public static bool operator ==(StringOrLong left, StringOrLong right) => left.Equals(right);
	public static bool operator !=(StringOrLong left, StringOrLong right) => !left.Equals(right);
}

internal sealed class StringOrLongConverter : JsonConverter<StringOrLong>
{
	public override StringOrLong Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		return reader.TokenType switch
		{
			JsonTokenType.String => (StringOrLong)(reader.GetString() ?? ""),
			JsonTokenType.Number => (StringOrLong)reader.GetInt64(),
			_ => throw new JsonException($"Cannot convert {reader.TokenType} to StringOrLong."),
		};
	}

	public override void Write(Utf8JsonWriter writer, StringOrLong value, JsonSerializerOptions options)
	{
		if (value.IsLong)
		{
			writer.WriteNumberValue(value.AsLong);
		}
		else
		{
			writer.WriteStringValue(value.AsString);
		}
	}
}
