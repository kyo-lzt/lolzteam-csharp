using System.Text.Json;

namespace Lolzteam.Api.Runtime;

/// <summary>
/// Shared JSON serializer options for deserializing API responses.
/// Includes lenient converters that handle API type mismatches gracefully.
/// </summary>
public static class JsonDefaults
{
    public static readonly JsonSerializerOptions Options = new()
    {
        Converters = { new LenientConverterFactory() },
    };
}
