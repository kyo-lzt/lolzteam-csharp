using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Runtime;

/// <summary>
/// A converter factory that handles API type mismatches gracefully.
/// When the API returns a JSON shape that doesn't match the expected C# type
/// (e.g. object where array expected, or string where list expected),
/// this converter returns a default value instead of throwing.
/// </summary>
public sealed class LenientConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(List<>);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var elementType = typeToConvert.GetGenericArguments()[0];
        var converterType = typeof(LenientListConverter<>).MakeGenericType(elementType);
        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }

    private sealed class LenientListConverter<T> : JsonConverter<List<T>>
    {
        public override List<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            if (reader.TokenType != JsonTokenType.StartArray)
            {
                // API returned non-array (object, string, number, etc.) — skip it, return empty list
                reader.Skip();
                return new List<T>();
            }

            // Read the entire array as a JsonElement to guarantee the reader advances correctly,
            // then deserialize each element individually.
            using var doc = JsonDocument.ParseValue(ref reader);
            var list = new List<T>();

            foreach (var element in doc.RootElement.EnumerateArray())
            {
                try
                {
                    var item = element.Deserialize<T>(options);
                    if (item is not null)
                    {
                        list.Add(item);
                    }
                }
                catch (JsonException)
                {
                    // Individual item shape mismatch — skip it
                }
            }

            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}
