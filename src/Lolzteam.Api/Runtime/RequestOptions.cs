using System.Text.Json;

namespace Lolzteam.Api.Runtime;

public sealed record RequestOptions
{
    public required string Method { get; init; }
    public required string Path { get; init; }
    public JsonElement? Query { get; init; }
    public JsonElement? Body { get; init; }
    public BodyEncoding BodyEncoding { get; init; } = BodyEncoding.Form;
    public Dictionary<string, byte[]>? ByteArrayFields { get; init; }
    public bool IsSearch { get; init; }
}
