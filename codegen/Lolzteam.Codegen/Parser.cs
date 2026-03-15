using System.Text.Json.Nodes;

namespace Lolzteam.Codegen;

internal static class Parser
{
	private static readonly string[] HttpMethods = ["get", "post", "put", "delete", "patch"];

	internal static ParseResult ParseSpec(JsonNode rawSpec)
	{
		// Resolve all $refs first
		var spec = Transforms.DerefDeep(rawSpec, rawSpec, []);

		var paths = (spec as JsonObject)?["paths"];
		if (paths is not JsonObject pathsObj)
		{
			return new ParseResult([], "https://localhost");
		}

		var groupMap = new Dictionary<string, List<MethodDefinition>>();

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

				var methodDef = Transforms.ExtractMethodDefinition(
					operationId, methodName, method, path, operation
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

		return new ParseResult(groups, baseUrl);
	}
}
