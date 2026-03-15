using System.Text;
using System.Text.RegularExpressions;

namespace Lolzteam.Codegen;

internal static partial class Emitter
{
	// ─── Types File ───────────────────────────────────────────────────

	private static string? EmitQueryParamsRecord(string group, MethodDefinition method)
	{
		if (method.Params.QueryParams.Count == 0) return null;

		var typeName = Naming.BuildTypeName(group, method.MethodName) + "Params";
		var sb = new StringBuilder();
		sb.Append("\tpublic sealed record ").Append(typeName).Append('\n');
		sb.Append("\t{\n");

		foreach (var param in method.Params.QueryParams)
		{
			var csharpType = Transforms.ToCSharpType(param.Type);
			var propName = Naming.SafeCSharpName(param.Name);
			if (Naming.NeedsJsonPropertyName(param.Name))
			{
				sb.Append("\t\t[JsonPropertyName(\"").Append(param.Name).Append("\")]\n");
			}
			sb.Append("\t\tpublic ").Append(MakeNullable(csharpType)).Append(' ').Append(propName).Append(" { get; init; }\n");
		}

		sb.Append("\t}");
		return sb.ToString();
	}

	private static string? EmitBodyRecord(string group, MethodDefinition method)
	{
		if (!method.HasBody) return null;

		// Array body — no record needed, method accepts List<T> directly
		if (method.BodyIsArray) return null;
		if (method.BodyProperties.Count == 0) return null;

		var typeName = Naming.BuildTypeName(group, method.MethodName) + "Body";
		var hasByteArrayFields = method.BodyProperties.Exists(p => p.Type == "Blob");

		var sb = new StringBuilder();
		sb.Append("\tpublic sealed record ").Append(typeName).Append('\n');
		sb.Append("\t{\n");

		foreach (var prop in method.BodyProperties)
		{
			var csharpType = prop.Type == "Blob" ? "byte[]" : Transforms.ToCSharpType(prop.Type);
			var propName = Naming.SafeCSharpName(prop.Name);

			if (!hasByteArrayFields && Naming.NeedsJsonPropertyName(prop.Name))
			{
				sb.Append("\t\t[JsonPropertyName(\"").Append(prop.Name).Append("\")]\n");
			}

			if (prop.Required)
			{
				sb.Append("\t\tpublic required ").Append(csharpType).Append(' ').Append(propName).Append(" { get; init; }\n");
			}
			else
			{
				sb.Append("\t\tpublic ").Append(MakeNullable(csharpType)).Append(' ').Append(propName).Append(" { get; init; }\n");
			}
		}

		sb.Append("\t}");
		return sb.ToString();
	}

	private static string EmitResponseRecord(string group, MethodDefinition method)
	{
		var typeName = Naming.BuildTypeName(group, method.MethodName) + "Response";
		return $"\tpublic sealed record {typeName}(JsonElement Data);";
	}

	internal static string EmitCSharpTypesFile(List<ParsedGroup> groups, string subPackage)
	{
		var sb = new StringBuilder();
		var ns = "Lolzteam.Api.Generated." + Naming.CapitalizeFirst(subPackage);

		sb.Append("// Auto-generated. Do not edit manually.\n\n");
		sb.Append("using System.Text.Json.Serialization;\n");
		sb.Append("using System.Text.Json;\n\n");
		sb.Append("namespace ").Append(ns).Append(";\n\n");

		foreach (var group in groups)
		{
			var className = Naming.GroupToClassName(group.GroupName);
			var groupTypes = new List<string>();

			foreach (var method in group.Methods)
			{
				var queryType = EmitQueryParamsRecord(group.GroupName, method);
				if (queryType is not null) groupTypes.Add(queryType);

				var bodyType = EmitBodyRecord(group.GroupName, method);
				if (bodyType is not null) groupTypes.Add(bodyType);

				groupTypes.Add(EmitResponseRecord(group.GroupName, method));
			}

			if (groupTypes.Count > 0)
			{
				sb.Append("// ─── ").Append(className).Append(" Types ────────────────────────────────────────\n\n");
				sb.Append("public static class ").Append(className).Append("Types\n{\n");
				for (var i = 0; i < groupTypes.Count; i++)
				{
					sb.Append(groupTypes[i]).Append('\n');
					if (i < groupTypes.Count - 1) sb.Append('\n');
				}
				sb.Append("}\n\n");
			}
		}

		return sb.ToString();
	}

	/// <summary>Make a C# type nullable if it isn't already (avoids int?? etc).</summary>
	private static string MakeNullable(string type) =>
		type.EndsWith('?') ? type : type + "?";

	// ─── Client File ──────────────────────────────────────────────────

	private static string BuildPathExpression(string path, List<ParsedParameter> pathParams)
	{
		if (!path.Contains('{')) return $"\"{path}\"";

		// Use C# string interpolation
		var result = Regex.Replace(path, @"\{([^}]+)\}", m =>
		{
			var paramName = m.Groups[1].Value;
			var csharpName = Naming.SnakeToPascal(paramName);
			// Find matching path param to use the safe name
			foreach (var p in pathParams)
			{
				if (Naming.SanitizeName(p.Name) == paramName || p.Name == paramName)
				{
					csharpName = Naming.SnakeToPascal(Naming.SanitizeName(p.Name));
					break;
				}
			}
			return $"{{{csharpName}}}";
		});

		return $"$\"{result}\"";
	}

	private static string BodyEncodingLiteral(string encoding) => encoding switch
	{
		"json" => "BodyEncoding.Json",
		"multipart" => "BodyEncoding.Multipart",
		_ => "BodyEncoding.Form",
	};

	private static string EmitCSharpMethod(string group, MethodDefinition method)
	{
		var sb = new StringBuilder();
		var typeName = Naming.BuildTypeName(group, method.MethodName);
		var className = Naming.GroupToClassName(group);

		// Build argument list
		var args = new List<string>();

		// Path params (always required, strip nullable)
		foreach (var param in method.Params.PathParams)
		{
			var csharpType = Transforms.ToCSharpType(param.Type).TrimEnd('?');
			args.Add(csharpType + " " + Naming.SnakeToPascal(Naming.SanitizeName(param.Name)));
		}

		// Body param
		var bodyTypeName = className + "Types." + typeName + "Body";
		var hasBodyType = method.HasBody && (method.BodyProperties.Count > 0 || method.BodyIsArray);
		if (hasBodyType)
		{
			if (method.BodyIsArray)
			{
				var itemType = Transforms.ToCSharpType(method.BodyArrayItemType ?? "unknown");
				bodyTypeName = "List<" + itemType + ">";
			}
			if (method.BodyRequired)
			{
				args.Add(bodyTypeName + " body");
			}
			else
			{
				args.Add(bodyTypeName + "? body = null");
			}
		}

		// Query params
		var queryTypeName = className + "Types." + typeName + "Params";
		var hasQueryType = method.Params.QueryParams.Count > 0;
		if (hasQueryType)
		{
			args.Add(queryTypeName + "? @params = null");
		}

		// CancellationToken
		args.Add("CancellationToken cancellationToken = default");

		var argStr = string.Join(", ", args);
		var pathExpr = BuildPathExpression(method.Path, method.Params.PathParams);

		var isSearch = group.Equals("category", StringComparison.OrdinalIgnoreCase);

		var hasByteArrayFields = method.BodyProperties.Exists(p => p.Type == "Blob");
		var isMultipart = method.BodyEncoding == "multipart";

		var responseTypeName = className + "Types." + typeName + "Response";
		sb.Append("\tpublic async Task<").Append(responseTypeName).Append("> ").Append(method.MethodName)
			.Append("Async(").Append(argStr).Append(")\n\t{\n");

		if (isMultipart && hasByteArrayFields)
		{
			EmitMultipartByteArrayMethod(sb, method, pathExpr, hasQueryType, isSearch, responseTypeName);
		}
		else
		{
			var encodingLiteral = BodyEncodingLiteral(method.BodyEncoding);
			sb.Append("\t\tvar __result = await _http.RequestAsync(new RequestOptions\n");
			sb.Append("\t\t{\n");
			sb.Append("\t\t\tMethod = \"").Append(method.HttpMethod).Append("\",\n");
			sb.Append("\t\t\tPath = ").Append(pathExpr).Append(",\n");

			if (hasQueryType)
			{
				sb.Append("\t\t\tQuery = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,\n");
			}

			if (hasBodyType)
			{
				if (method.BodyRequired)
				{
					sb.Append("\t\t\tBody = JsonSerializer.SerializeToElement(body),\n");
				}
				else
				{
					sb.Append("\t\t\tBody = body is not null ? JsonSerializer.SerializeToElement(body) : null,\n");
				}
				sb.Append("\t\t\tBodyEncoding = ").Append(encodingLiteral).Append(",\n");
			}
			else if (method.BodyEncoding != "form")
			{
				sb.Append("\t\t\tBodyEncoding = ").Append(encodingLiteral).Append(",\n");
			}

			if (isSearch)
			{
				sb.Append("\t\t\tIsSearch = true,\n");
			}

			sb.Append("\t\t}, cancellationToken).ConfigureAwait(false);\n");
			sb.Append("\t\treturn new ").Append(responseTypeName).Append("(__result);\n");
		}

		sb.Append("\t}");
		return sb.ToString();
	}

	private static void EmitMultipartByteArrayMethod(
		StringBuilder sb, MethodDefinition method, string pathExpr,
		bool hasQueryType, bool isSearch, string responseTypeName)
	{
		var serializableProps = method.BodyProperties.FindAll(p => p.Type != "Blob");
		var byteArrayFieldNames = method.BodyProperties.FindAll(p => p.Type == "Blob")
			.ConvertAll(p => p.Name);

		var indent = method.BodyRequired ? "\t\t" : "\t\t\t";

		void EmitBody()
		{
			// Build JsonElement from non-byte[] fields
			if (serializableProps.Count > 0)
			{
				sb.Append(indent).Append("var jsonObj = new System.Text.Json.Nodes.JsonObject();\n");
				foreach (var prop in serializableProps)
				{
					var propName = Naming.SnakeToPascal(Naming.SanitizeName(prop.Name));
					if (prop.Required)
					{
						sb.Append(indent).Append("jsonObj[\"").Append(prop.Name).Append("\"] = System.Text.Json.Nodes.JsonValue.Create(body.").Append(propName).Append(");\n");
					}
					else
					{
						sb.Append(indent).Append("if (body.").Append(propName).Append(" is not null) jsonObj[\"").Append(prop.Name).Append("\"] = System.Text.Json.Nodes.JsonValue.Create(body.").Append(propName).Append(");\n");
					}
				}
			}

			// Build byteArrayFields dictionary
			sb.Append(indent).Append("var byteFields = new Dictionary<string, byte[]>();\n");
			foreach (var name in byteArrayFieldNames)
			{
				var propName = Naming.SnakeToPascal(Naming.SanitizeName(name));
				var prop = method.BodyProperties.Find(p => p.Name == name);
				if (prop is not null && prop.Required)
				{
					sb.Append(indent).Append("byteFields[\"").Append(name).Append("\"] = body.").Append(propName).Append(";\n");
				}
				else
				{
					sb.Append(indent).Append("if (body.").Append(propName).Append(" is not null) byteFields[\"").Append(name).Append("\"] = body.").Append(propName).Append(";\n");
				}
			}

			sb.Append(indent).Append("var __result = await _http.RequestAsync(new RequestOptions\n");
			sb.Append(indent).Append("{\n");
			sb.Append(indent).Append("\tMethod = \"").Append(method.HttpMethod).Append("\",\n");
			sb.Append(indent).Append("\tPath = ").Append(pathExpr).Append(",\n");

			if (hasQueryType)
			{
				sb.Append(indent).Append("\tQuery = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,\n");
			}

			if (serializableProps.Count > 0)
			{
				sb.Append(indent).Append("\tBody = JsonSerializer.SerializeToElement(jsonObj),\n");
			}
			sb.Append(indent).Append("\tBodyEncoding = BodyEncoding.Multipart,\n");
			sb.Append(indent).Append("\tByteArrayFields = byteFields,\n");
			if (isSearch)
			{
				sb.Append(indent).Append("\tIsSearch = true,\n");
			}
			sb.Append(indent).Append("}, cancellationToken).ConfigureAwait(false);\n");
			sb.Append(indent).Append("return new ").Append(responseTypeName).Append("(__result);\n");
		}

		if (method.BodyRequired)
		{
			EmitBody();
		}
		else
		{
			sb.Append("\t\tif (body is not null)\n\t\t{\n");
			EmitBody();
			sb.Append("\t\t}\n\t\telse\n\t\t{\n");
			sb.Append("\t\t\tvar __result = await _http.RequestAsync(new RequestOptions\n");
			sb.Append("\t\t\t{\n");
			sb.Append("\t\t\t\tMethod = \"").Append(method.HttpMethod).Append("\",\n");
			sb.Append("\t\t\t\tPath = ").Append(pathExpr).Append(",\n");
			if (hasQueryType)
			{
				sb.Append("\t\t\t\tQuery = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,\n");
			}
			sb.Append("\t\t\t\tBodyEncoding = BodyEncoding.Multipart,\n");
			if (isSearch)
			{
				sb.Append("\t\t\t\tIsSearch = true,\n");
			}
			sb.Append("\t\t\t}, cancellationToken).ConfigureAwait(false);\n");
			sb.Append("\t\t\treturn new ").Append(responseTypeName).Append("(__result);\n");
			sb.Append("\t\t}\n");
		}
	}

	private static string EmitGroupClass(ParsedGroup group)
	{
		var className = Naming.GroupToClassName(group.GroupName);
		var sb = new StringBuilder();

		sb.Append("public sealed class ").Append(className).Append('\n');
		sb.Append("{\n");
		sb.Append("\tprivate readonly LolzteamHttpClient _http;\n\n");
		sb.Append("\tpublic ").Append(className).Append("(LolzteamHttpClient http)\n");
		sb.Append("\t{\n");
		sb.Append("\t\t_http = http;\n");
		sb.Append("\t}\n");

		foreach (var method in group.Methods)
		{
			sb.Append('\n');
			sb.Append(EmitCSharpMethod(group.GroupName, method));
			sb.Append('\n');
		}

		sb.Append("}\n");
		return sb.ToString();
	}

	internal static string EmitCSharpClientFile(
		List<ParsedGroup> groups,
		string clientName,
		string defaultBaseUrl,
		int defaultRateLimit,
		string subPackage,
		int defaultSearchRateLimit)
	{
		var ns = "Lolzteam.Api.Generated." + Naming.CapitalizeFirst(subPackage);
		var sb = new StringBuilder();

		sb.Append("// Auto-generated. Do not edit manually.\n\n");
		sb.Append("using System.Text.Json;\n");
		sb.Append("using Lolzteam.Api.Runtime;\n\n");
		sb.Append("namespace ").Append(ns).Append(";\n\n");

		// Group API classes
		foreach (var group in groups)
		{
			sb.Append(EmitGroupClass(group));
			sb.Append('\n');
		}

		// Main client class
		sb.Append("public sealed class ").Append(clientName).Append(" : IDisposable\n{\n");

		// Properties
		foreach (var group in groups)
		{
			var propClassName = Naming.GroupToClassName(group.GroupName);
			var propName = Naming.GroupToPropertyName(group.GroupName);
			sb.Append("\tpublic ").Append(propClassName).Append(' ').Append(propName).Append(" { get; }\n");
		}

		sb.Append("\n\tprivate readonly LolzteamHttpClient _http;\n\n");

		// Constructor
		sb.Append("\tpublic ").Append(clientName).Append("(ClientConfig config)\n\t{\n");
		sb.Append("\t\tvar resolvedConfig = config with\n\t\t{\n");
		sb.Append("\t\t\tBaseUrl = config.BaseUrl ?? \"").Append(defaultBaseUrl).Append("\",\n");
		sb.Append("\t\t\tRateLimit = config.RateLimit ?? new RateLimitConfig(").Append(defaultRateLimit).Append("),\n");
		if (defaultSearchRateLimit > 0)
		{
			sb.Append("\t\t\tSearchRateLimit = config.SearchRateLimit ?? new RateLimitConfig(").Append(defaultSearchRateLimit).Append("),\n");
		}
		sb.Append("\t\t};\n");
		sb.Append("\t\t_http = new LolzteamHttpClient(resolvedConfig);\n\n");

		foreach (var group in groups)
		{
			var propClassName = Naming.GroupToClassName(group.GroupName);
			var propName = Naming.GroupToPropertyName(group.GroupName);
			sb.Append("\t\t").Append(propName).Append(" = new ").Append(propClassName).Append("(_http);\n");
		}

		sb.Append("\t}\n\n");

		// Dispose
		sb.Append("\tpublic void Dispose()\n\t{\n");
		sb.Append("\t\t_http.Dispose();\n");
		sb.Append("\t}\n");

		sb.Append("}\n");

		return sb.ToString();
	}
}
