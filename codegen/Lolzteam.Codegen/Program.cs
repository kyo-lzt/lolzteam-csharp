using System.Text.Json.Nodes;
using Lolzteam.Codegen;

var root = Directory.GetCurrentDirectory();
// Go up to find project root (where schemas/ dir is)
while (!Directory.Exists(Path.Combine(root, "schemas")) && root != Path.GetPathRoot(root))
    root = Path.GetDirectoryName(root)!;

var apis = new[]
{
    new ApiConfig(
        Path.Combine(root, "schemas", "forum.json"),
        Path.Combine(root, "src", "Lolzteam.Api", "Generated", "Forum"),
        "ForumClient",
        "https://prod-api.lolz.live",
        300,
        "Forum",
        0
    ),
    new ApiConfig(
        Path.Combine(root, "schemas", "market.json"),
        Path.Combine(root, "src", "Lolzteam.Api", "Generated", "Market"),
        "MarketClient",
        "https://prod-api.lzt.market",
        120,
        "Market",
        20
    ),
};

foreach (var config in apis)
{
    Console.WriteLine($"Generating {config.ClientName}...");

    var rawSpec = JsonNode.Parse(File.ReadAllText(config.SchemaPath))!;
    var result = Parser.ParseSpec(rawSpec);

    Directory.CreateDirectory(config.OutputDir);

    // Clean old files
    foreach (var file in Directory.GetFiles(config.OutputDir, "*.cs"))
    {
        File.Delete(file);
        Console.WriteLine($"  Deleted old {Path.GetFileName(file)}");
    }

    // Collect enums
    var (enumDefs, paramToEnumType) = EnumCollector.Collect(result.Groups);
    Console.WriteLine($"  Enums: {enumDefs.Count} types");

    // Write Types
    var typesContent = Emitter.EmitCSharpTypesFile(
        result.Groups, config.SubPackage, result.ComponentSchemas, rawSpec, enumDefs, paramToEnumType);
    File.WriteAllText(Path.Combine(config.OutputDir, "Types.cs"), typesContent);
    Console.WriteLine("  Types.cs");

    // Write Client
    var clientContent = Emitter.EmitCSharpClientFile(
        result.Groups, config.ClientName, config.DefaultBaseUrl,
        config.DefaultRateLimit, config.SubPackage, config.DefaultSearchRateLimit
    );
    File.WriteAllText(Path.Combine(config.OutputDir, $"{config.ClientName}.cs"), clientContent);
    Console.WriteLine($"  {config.ClientName}.cs");

    var totalOps = result.Groups.Sum(g => g.Methods.Count);
    Console.WriteLine($"  Done: {result.Groups.Count} groups, {totalOps} operations\n");
}
