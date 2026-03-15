using System.Text.Json.Nodes;

namespace Lolzteam.Codegen;

internal static class Parser
{
	private static readonly string[] HttpMethods = ["get", "post", "put", "delete", "patch"];

	internal static ParseResult ParseSpec(JsonNode rawSpec)
	{
		// Extract component schemas before dereferencing (we need $ref info preserved)
		var componentSchemas = ExtractComponentSchemas(rawSpec);
		var componentSchemaNames = new HashSet<string>(componentSchemas.Keys);

		// Resolve all $refs first
		var spec = Transforms.DerefDeep(rawSpec, rawSpec, []);

		var paths = (spec as JsonObject)?["paths"];
		if (paths is not JsonObject pathsObj)
		{
			return new ParseResult([], "https://localhost", componentSchemas);
		}

		var groupMap = new SortedDictionary<string, List<MethodDefinition>>();

		foreach (var pathEntry in pathsObj)
		{
			var path = pathEntry.Key;
			var pathItem = pathEntry.Value;
			if (pathItem is not JsonObject pathItemObj) continue;

			foreach (var method in HttpMethods)
			{
				var operation = pathItemObj[method];
				if (operation is not JsonObject operationObj) continue;

				var operationIdNode = operationObj["operationId"];
				if (operationIdNode is not JsonValue opIdVal || !opIdVal.TryGetValue<string>(out var operationId))
					continue;

				var group = Naming.OperationIdToGroup(operationId);
				var methodName = Naming.OperationIdToMethod(operationId);

				// Get operation from RAW spec (before deref) for response schema $ref detection
				var rawOperation = GetRawOperation(rawSpec, path, method);

				var methodDef = Transforms.ExtractMethodDefinition(
					operationId, methodName, method, path, operation,
					rawOperation, rawSpec, componentSchemaNames
				);

				if (!groupMap.TryGetValue(group, out var methods))
				{
					methods = [];
					groupMap[group] = methods;
				}
				methods.Add(methodDef);
			}
		}

		var groups = new List<ParsedGroup>();
		foreach (var entry in groupMap)
		{
			groups.Add(new ParsedGroup(entry.Key, entry.Value));
		}

		var servers = (spec as JsonObject)?["servers"];
		var baseUrl = "https://localhost";
		if (servers is JsonArray serversArr && serversArr.Count > 0)
		{
			var firstServer = serversArr[0];
			if (firstServer is JsonObject serverObj)
			{
				var urlNode = serverObj["url"];
				if (urlNode is JsonValue uv && uv.TryGetValue<string>(out var url))
				{
					baseUrl = url;
				}
			}
		}

		return new ParseResult(groups, baseUrl, componentSchemas);
	}

	private static SortedDictionary<string, JsonObject> ExtractComponentSchemas(JsonNode rawSpec)
	{
		var result = new SortedDictionary<string, JsonObject>();
		if (rawSpec is not JsonObject root) return result;
		var components = root["components"];
		if (components is not JsonObject compObj) return result;
		var schemas = compObj["schemas"];
		if (schemas is not JsonObject schemasObj) return result;

		foreach (var kvp in schemasObj)
		{
			if (kvp.Value is JsonObject schemaObj)
			{
				// Skip non-object schemas (no properties and not type: "object")
				var hasProperties = schemaObj["properties"] is JsonObject propsObj && propsObj.Count > 0;
				var typeNode = schemaObj["type"];
				var isObject = typeNode is JsonValue tv && tv.TryGetValue<string>(out var t) && t == "object";
				if (!hasProperties && !isObject) continue;

				// Deep clone so we can resolve $refs within component schemas later
				var cloned = JsonNode.Parse(schemaObj.ToJsonString());
				if (cloned is JsonObject clonedObj)
				{
					result[kvp.Key] = clonedObj;
				}
			}
		}
		return result;
	}

	private static JsonNode? GetRawOperation(JsonNode rawSpec, string path, string method)
	{
		if (rawSpec is not JsonObject root) return null;
		var paths = root["paths"];
		if (paths is not JsonObject pathsObj) return null;
		var pathItem = pathsObj[path];
		if (pathItem is not JsonObject pathItemObj) return null;
		return pathItemObj[method];
	}
}
