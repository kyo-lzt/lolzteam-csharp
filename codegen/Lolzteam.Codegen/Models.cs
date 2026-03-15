namespace Lolzteam.Codegen;

internal sealed record ApiConfig(
	string SchemaPath,
	string OutputDir,
	string ClientName,
	string DefaultBaseUrl,
	int DefaultRateLimit,
	string SubPackage,
	int DefaultSearchRateLimit
);

internal sealed record ParseResult(
	List<ParsedGroup> Groups,
	string BaseUrl,
	SortedDictionary<string, System.Text.Json.Nodes.JsonObject> ComponentSchemas
);

internal sealed record ParsedGroup(string GroupName, List<MethodDefinition> Methods);

internal sealed record ParsedParameter(string Name, string Type, bool Required);

internal sealed record OperationParameters(List<ParsedParameter> PathParams, List<ParsedParameter> QueryParams);

internal sealed record BodyProperty(string Name, string Type, bool Required);

internal sealed record BodyExtractionResult(
	List<BodyProperty> Properties,
	bool BodyIsArray = false,
	string? BodyArrayItemType = null,
	string BodyEncoding = "form"
);

internal sealed record ResponseProperty(string Name, string CSharpType, bool Required, string? ComponentSchemaRef);

internal sealed record ResponseSchemaInfo(List<ResponseProperty> Properties);

internal sealed record MethodDefinition(
	string OperationId,
	string MethodName,
	string HttpMethod,
	string Path,
	OperationParameters Params,
	List<BodyProperty> BodyProperties,
	bool HasBody,
	bool BodyRequired,
	string ResponseType,
	bool BodyIsArray,
	string? BodyArrayItemType,
	string BodyEncoding,
	ResponseSchemaInfo? ResponseSchema = null,
	System.Text.Json.Nodes.JsonObject? RawResponseSchema = null
);
