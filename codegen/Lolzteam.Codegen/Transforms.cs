using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace Lolzteam.Codegen;

internal static partial class Transforms
{
	[GeneratedRegex(@"^Array<(.+)>$")]
	private static partial Regex ArrayTypePattern();

	// ─── Ref Resolution ───────────────────────────────────────────────

	/// <summary>Follow a JSON pointer path like #/components/schemas/Foo.</summary>
	internal static JsonNode? ResolveRef(string reference, JsonNode spec)
	{
		var parts = reference.TrimStart('#', '/').Split('/');
		var current = spec;
		foreach (var part in parts)
		{
			if (current is not JsonObject obj) return null;
			current = obj[part];
			if (current is null) return null;
		}
		return current;
	}

	/// <summary>Shallow $ref resolution.</summary>
	internal static JsonNode DerefShallow(JsonNode value, JsonNode spec)
	{
		if (value is JsonObject obj)
		{
			var refNode = obj["$ref"];
			if (refNode is JsonValue jv && jv.TryGetValue<string>(out var refStr))
			{
				var resolved = ResolveRef(refStr, spec);
				if (resolved is not null)
				{
					return DerefShallow(resolved, spec);
				}
			}
		}
		return value;
	}

	/// <summary>Recursively resolve all $ref pointers.</summary>
	internal static JsonNode DerefDeep(JsonNode value, JsonNode spec, HashSet<string> visited)
	{
		if (value is JsonObject obj)
		{
			var refNode = obj["$ref"];
			if (refNode is JsonValue jv && jv.TryGetValue<string>(out var refStr))
			{
				if (visited.Contains(refStr))
				{
					return new JsonObject();
				}
				var newVisited = new HashSet<string>(visited) { refStr };
				var resolved = ResolveRef(refStr, spec);
				if (resolved is null) return value;
				return DerefDeep(resolved, spec, newVisited);
			}
			var result = new JsonObject();
			foreach (var kvp in obj)
			{
				if (kvp.Value is null) continue;
				result[kvp.Key] = DerefDeep(kvp.Value, spec, new HashSet<string>(visited));
			}
			return result;
		}
		if (value is JsonArray arr)
		{
			var result = new JsonArray();
			foreach (var item in arr)
			{
				if (item is null)
				{
					result.Add(null);
					continue;
				}
				result.Add(DerefDeep(item, spec, new HashSet<string>(visited)));
			}
			return result;
		}
		return value.DeepClone();
	}

	// ─── OpenAPI Schema → Type String ─────────────────────────────────

	/// <summary>Convert an OpenAPI schema to an intermediate type string.</summary>
	internal static string SchemaToTypeString(JsonNode? schema, JsonNode spec)
	{
		if (schema is null) return "unknown";
		if (schema is JsonObject schemaObj && schemaObj.Count == 0) return "unknown";

		// $ref
		if (schema is JsonObject refObj)
		{
			var refNode = refObj["$ref"];
			if (refNode is JsonValue jv && jv.TryGetValue<string>(out _))
			{
				var resolved = DerefShallow(schema, spec);
				return SchemaToTypeString(resolved, spec);
			}
		}

		if (schema is not JsonObject sObj) return "unknown";

		// enum
		var enumValues = sObj["enum"];
		if (enumValues is JsonArray enumArr && enumArr.Count > 0)
		{
			var literals = new List<string>();
			foreach (var el in enumArr)
			{
				if (el is JsonValue ev)
				{
					if (ev.TryGetValue<string>(out var str))
					{
						literals.Add("\"" + str.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"");
					}
					else
					{
						literals.Add(el!.ToString());
					}
				}
			}
			if (literals.Count > 0) return string.Join(" | ", literals);
		}

		// oneOf / anyOf
		var oneOf = sObj["oneOf"];
		if (oneOf is JsonArray oneOfArr && oneOfArr.Count > 0)
		{
			var types = new List<string>();
			foreach (var item in oneOfArr) types.Add(SchemaToTypeString(item, spec));
			return string.Join(" | ", types);
		}
		var anyOf = sObj["anyOf"];
		if (anyOf is JsonArray anyOfArr && anyOfArr.Count > 0)
		{
			var types = new List<string>();
			foreach (var item in anyOfArr) types.Add(SchemaToTypeString(item, spec));
			return string.Join(" | ", types);
		}

		// allOf
		var allOf = sObj["allOf"];
		if (allOf is JsonArray allOfArr && allOfArr.Count > 0)
		{
			var types = new List<string>();
			foreach (var item in allOfArr) types.Add(SchemaToTypeString(item, spec));
			return string.Join(" & ", types);
		}

		// Multi-type array: type: ['string', 'integer']
		var typeEl = sObj["type"];
		if (typeEl is JsonArray typeArr)
		{
			var types = new List<string>();
			var hasNull = false;
			foreach (var t in typeArr)
			{
				var typeStr = t!.GetValue<string>();
				if (typeStr == "null")
				{
					hasNull = true;
				}
				else
				{
					types.Add(PrimitiveType(typeStr));
				}
			}
			var result = string.Join(" | ", types);
			return hasNull ? result + " | null" : result;
		}

		string? type = null;
		if (typeEl is JsonValue typeVal && typeVal.TryGetValue<string>(out var tv))
		{
			type = tv;
		}

		if (type == "array")
		{
			var itemType = SchemaToTypeString(sObj["items"], spec);
			return "Array<" + itemType + ">";
		}

		if (type == "object" || sObj["properties"] is not null)
		{
			var props = sObj["properties"];
			if (props is null || props is not JsonObject propsObj || propsObj.Count == 0)
			{
				var addlProps = sObj["additionalProperties"];
				if (addlProps is not null && addlProps is not JsonValue)
				{
					var valType = SchemaToTypeString(addlProps, spec);
					return "Record<string, " + valType + ">";
				}
				return "Record<string, unknown>";
			}
			return "{}";
		}

		if (type is not null) return PrimitiveType(type);

		return "unknown";
	}

	private static string PrimitiveType(string t) => t switch
	{
		"string" => "string",
		"integer" => "integer",
		"number" => "number",
		"boolean" => "boolean",
		"null" => "null",
		_ => "unknown",
	};

	/// <summary>Map intermediate type string to C# type.</summary>
	internal static string ToCSharpType(string tsType)
	{
		// Union / intersection types
		if (tsType.Contains(" | ") || tsType.Contains(" & "))
		{
			var parts = tsType.Split(" | ");
			var nonNull = new List<string>();
			foreach (var p in parts)
			{
				var trimmed = p.Trim();
				if (trimmed != "null")
				{
					nonNull.Add(trimmed);
				}
			}
			if (nonNull.Count == 1 && parts.Length > nonNull.Count)
			{
				// nullable single type
				return ToCSharpType(nonNull[0]);
			}
			// All string literals → string
			if (nonNull.Count > 0 && nonNull.TrueForAll(s => s.StartsWith('"') && s.EndsWith('"')))
			{
				return "string";
			}
			return "JsonElement";
		}

		// Array<T>
		var arrayMatch = ArrayTypePattern().Match(tsType);
		if (arrayMatch.Success)
		{
			return "List<" + ToCSharpType(arrayMatch.Groups[1].Value) + ">";
		}

		// Inline objects
		if (tsType.StartsWith('{') || tsType.Contains("Record<"))
		{
			return "JsonElement";
		}

		return tsType switch
		{
			"string" => "string",
			"number" => "double?",
			"integer" => "int?",
			"boolean" => "bool?",
			"unknown" => "JsonElement",
			"Blob" => "byte[]",
			_ when tsType.StartsWith('"') || Regex.IsMatch(tsType, @"^\d+$") => "string",
			_ => "JsonElement",
		};
	}

	// ─── Parameter Extraction ─────────────────────────────────────────

	internal static OperationParameters ExtractParameters(JsonNode operation, JsonNode spec)
	{
		var pathParams = new List<ParsedParameter>();
		var queryParams = new List<ParsedParameter>();

		var rawParams = (operation as JsonObject)?["parameters"];
		if (rawParams is not JsonArray paramsArr)
		{
			return new OperationParameters(pathParams, queryParams);
		}

		foreach (var rawParam in paramsArr)
		{
			if (rawParam is null) continue;
			var param = DerefShallow(rawParam, spec);
			if (param is not JsonObject paramObj) continue;

			var inNode = paramObj["in"];
			string? inValue = null;
			if (inNode is JsonValue inVal && inVal.TryGetValue<string>(out var iv))
			{
				inValue = iv;
			}
			if (inValue is null || inValue == "header" || inValue == "cookie") continue;

			var nameNode = paramObj["name"];
			if (nameNode is null) continue;
			var name = nameNode.GetValue<string>();
			var type = SchemaToTypeString(paramObj["schema"], spec);
			var requiredNode = paramObj["required"];
			var required = requiredNode is JsonValue rv && rv.TryGetValue<bool>(out var rBool) && rBool;

			var parsed = new ParsedParameter(
				name,
				type,
				inValue == "path" || required
			);

			if (inValue == "path")
			{
				pathParams.Add(parsed);
			}
			else if (inValue == "query")
			{
				queryParams.Add(parsed);
			}
		}

		return new OperationParameters(pathParams, queryParams);
	}

	// ─── Body Extraction ──────────────────────────────────────────────

	internal static BodyExtractionResult ExtractBody(JsonNode operation, JsonNode spec)
	{
		var empty = new BodyExtractionResult([]);

		var rawRequestBody = (operation as JsonObject)?["requestBody"];
		if (rawRequestBody is null) return empty;

		var requestBody = DerefShallow(rawRequestBody, spec);
		if (requestBody is not JsonObject rbObj) return empty;

		var content = rbObj["content"];
		if (content is not JsonObject contentObj) return empty;

		// 3-way content-type detection
		var hasForm = contentObj["application/x-www-form-urlencoded"] is not null;
		var hasJson = contentObj["application/json"] is not null;
		var hasMultipart = contentObj["multipart/form-data"] is not null;

		string bodyEncoding;
		if (hasMultipart && !hasForm)
		{
			bodyEncoding = "multipart";
		}
		else if (hasJson && !hasForm)
		{
			bodyEncoding = "json";
		}
		else
		{
			bodyEncoding = "form";
		}

		// Pick schema from best available content type
		JsonNode? mediaType = contentObj["application/x-www-form-urlencoded"];
		mediaType ??= contentObj["application/json"];
		mediaType ??= contentObj["multipart/form-data"];
		if (mediaType is not JsonObject mtObj) return empty;

		var schema = mtObj["schema"];
		if (schema is not JsonObject schemaObj) return empty;

		// Array body
		var schemaTypeNode = schemaObj["type"];
		string? schemaType = null;
		if (schemaTypeNode is JsonValue stv && stv.TryGetValue<string>(out var st))
		{
			schemaType = st;
		}
		if (schemaType == "array" && schemaObj["properties"] is null)
		{
			var items = schemaObj["items"];
			var itemType = items is not null ? SchemaToTypeString(items, spec) : "unknown";
			return new BodyExtractionResult([], true, itemType, bodyEncoding);
		}

		var bodyProperties = new List<BodyProperty>();

		// oneOf
		var oneOf = schemaObj["oneOf"];
		if (oneOf is JsonArray oneOfArr)
		{
			var allProps = new Dictionary<string, JsonNode>();
			foreach (var variant in oneOfArr)
			{
				if (variant is not JsonObject variantObj) continue;
				var variantProps = variantObj["properties"];
				if (variantProps is not JsonObject vpObj) continue;
				foreach (var kvp in vpObj)
				{
					allProps[kvp.Key] = kvp.Value!;
				}
			}
			foreach (var kvp in allProps)
			{
				bodyProperties.Add(new BodyProperty(
					kvp.Key,
					SchemaToTypeString(kvp.Value, spec),
					false
				));
			}
		}
		else
		{
			var properties = schemaObj["properties"];
			if (properties is JsonObject propsObj)
			{
				var requiredSet = new HashSet<string>();
				var requiredArr = schemaObj["required"];
				if (requiredArr is JsonArray reqArr)
				{
					foreach (var r in reqArr)
					{
						requiredSet.Add(r!.GetValue<string>());
					}
				}

				foreach (var kvp in propsObj)
				{
					var propName = kvp.Key;
					var propSchema = kvp.Value!;
					string? format = null;
					if (propSchema is JsonObject psObj)
					{
						var fmtNode = psObj["format"];
						if (fmtNode is JsonValue fv && fv.TryGetValue<string>(out var fmt))
						{
							format = fmt;
						}
					}
					var propType = format == "binary" ? "Blob" : SchemaToTypeString(propSchema, spec);
					bodyProperties.Add(new BodyProperty(propName, propType, requiredSet.Contains(propName)));
				}
			}
		}

		return new BodyExtractionResult(bodyProperties, false, null, bodyEncoding);
	}

	// ─── Response Extraction ──────────────────────────────────────────

	internal static string ExtractResponseType(JsonNode operation, JsonNode spec)
	{
		var responses = (operation as JsonObject)?["responses"];
		if (responses is not JsonObject respObj) return "unknown";
		var rawSuccess = respObj["200"] ?? respObj["201"];
		if (rawSuccess is null) return "unknown";
		var success = DerefShallow(rawSuccess, spec);
		if (success is not JsonObject successObj) return "unknown";
		var content = successObj["content"];
		if (content is not JsonObject contentObj) return "unknown";
		var jsonContent = contentObj["application/json"];
		if (jsonContent is not JsonObject jsonObj) return "unknown";
		var rawSchema = jsonObj["schema"];
		if (rawSchema is null) return "unknown";
		var schema = DerefShallow(rawSchema, spec);
		return SchemaToTypeString(schema, spec);
	}

	// ─── Response Schema Extraction (with $ref preservation) ─────────

	/// <summary>
	/// Extract typed response schema info from the raw (pre-deref) operation,
	/// preserving component schema $ref names.
	/// </summary>
	internal static ResponseSchemaInfo? ExtractResponseSchema(
		JsonNode? rawOperation, JsonNode rawSpec, HashSet<string> componentSchemaNames)
	{
		if (rawOperation is not JsonObject rawOpObj) return null;

		var responses = rawOpObj["responses"];
		if (responses is not JsonObject respObj) return null;
		var rawSuccess = respObj["200"] ?? respObj["201"];
		if (rawSuccess is null) return null;
		var success = DerefShallow(rawSuccess, rawSpec);
		if (success is not JsonObject successObj) return null;
		var content = successObj["content"];
		if (content is not JsonObject contentObj) return null;
		var jsonContent = contentObj["application/json"];
		if (jsonContent is not JsonObject jsonObj) return null;
		var rawSchema = jsonObj["schema"];
		if (rawSchema is null) return null;
		var schema = DerefShallow(rawSchema, rawSpec);
		if (schema is not JsonObject schemaObj) return null;

		var properties = schemaObj["properties"];
		if (properties is not JsonObject propsObj || propsObj.Count == 0) return null;

		var requiredSet = new HashSet<string>();
		var requiredArr = schemaObj["required"];
		if (requiredArr is JsonArray reqArr)
		{
			foreach (var r in reqArr)
			{
				requiredSet.Add(r!.GetValue<string>());
			}
		}

		var result = new List<ResponseProperty>();
		foreach (var kvp in propsObj)
		{
			var propName = kvp.Key;
			var propSchema = kvp.Value;
			if (propSchema is null) continue;

			var required = requiredSet.Contains(propName);
			var (csharpType, componentRef) = ResolvePropertyType(propSchema, rawSpec, componentSchemaNames);
			result.Add(new ResponseProperty(propName, csharpType, required, componentRef));
		}

		return result.Count > 0 ? new ResponseSchemaInfo(result) : null;
	}

	/// <summary>
	/// Resolve a property schema to a C# type, preserving component schema references.
	/// Returns (csharpType, componentSchemaRef or null).
	/// </summary>
	private static (string CSharpType, string? ComponentRef) ResolvePropertyType(
		JsonNode schema, JsonNode rawSpec, HashSet<string> componentSchemaNames)
	{
		// Direct $ref to component schema
		if (schema is JsonObject refObj)
		{
			var refNode = refObj["$ref"];
			if (refNode is JsonValue jv && jv.TryGetValue<string>(out var refStr))
			{
				if (refStr.StartsWith("#/components/schemas/"))
				{
					var schemaName = refStr["#/components/schemas/".Length..];
					if (componentSchemaNames.Contains(schemaName))
					{
						return (schemaName, schemaName);
					}
				}
				// Resolve and recurse
				var resolved = ResolveRef(refStr, rawSpec);
				if (resolved is not null)
				{
					return ResolvePropertyType(resolved, rawSpec, componentSchemaNames);
				}
			}
		}

		if (schema is not JsonObject sObj) return ("JsonElement", null);

		// Multi-type array: type: ['string', 'integer'] → JsonElement
		var typeEl = sObj["type"];
		if (typeEl is JsonArray)
		{
			return ("JsonElement", null);
		}

		string? type = null;
		if (typeEl is JsonValue typeVal && typeVal.TryGetValue<string>(out var tv))
		{
			type = tv;
		}

		// Array — check if items ref a component schema
		if (type == "array")
		{
			var items = sObj["items"];
			if (items is not null)
			{
				var (itemType, itemRef) = ResolvePropertyType(items, rawSpec, componentSchemaNames);
				return ($"List<{itemType}>", itemRef);
			}
			return ("List<JsonElement>", null);
		}

		// Object with properties → inline object (will be JsonElement for now, could be nested record)
		if (type == "object" || sObj["properties"] is not null)
		{
			var props = sObj["properties"];
			if (props is not null && props is JsonObject propsObj && propsObj.Count > 0)
			{
				return ("JsonElement", null);
			}
			return ("JsonElement", null);
		}

		// Primitives
		if (type is not null)
		{
			var csharp = type switch
			{
				"string" => "string",
				"integer" => "long",
				"number" => "double",
				"boolean" => "bool",
				_ => "JsonElement",
			};
			return (csharp, null);
		}

		// enum → string
		var enumValues = sObj["enum"];
		if (enumValues is JsonArray enumArr && enumArr.Count > 0)
		{
			return ("string", null);
		}

		// oneOf / anyOf → JsonElement
		if (sObj["oneOf"] is JsonArray || sObj["anyOf"] is JsonArray)
		{
			return ("JsonElement", null);
		}

		return ("JsonElement", null);
	}

	// ─── Method Definition ────────────────────────────────────────────

	internal static MethodDefinition ExtractMethodDefinition(
		string operationId,
		string methodName,
		string httpMethod,
		string path,
		JsonNode operation,
		JsonNode? rawOperation,
		JsonNode rawSpec,
		HashSet<string> componentSchemaNames)
	{
		var emptySpec = new JsonObject();
		var parameters = ExtractParameters(operation, emptySpec);
		var body = ExtractBody(operation, emptySpec);
		var responseType = ExtractResponseType(operation, emptySpec);
		var responseSchema = ExtractResponseSchema(rawOperation, rawSpec, componentSchemaNames);

		var isGet = httpMethod.Equals("GET", StringComparison.OrdinalIgnoreCase);

		// GET requests can't have body — treat body properties as query params
		List<ParsedParameter> effectiveQueryParams;
		if (isGet)
		{
			var combined = new List<ParsedParameter>(parameters.QueryParams);
			foreach (var prop in body.Properties)
			{
				combined.Add(new ParsedParameter(prop.Name, prop.Type, false));
			}
			effectiveQueryParams = combined;
		}
		else
		{
			effectiveQueryParams = parameters.QueryParams;
		}

		var rawRequestBody = (operation as JsonObject)?["requestBody"];
		bool bodyRequired;
		if (isGet)
		{
			bodyRequired = false;
		}
		else if (rawRequestBody is not null)
		{
			var rb = DerefShallow(rawRequestBody, emptySpec);
			var reqNode = (rb as JsonObject)?["required"];
			bodyRequired = reqNode is JsonValue rv && rv.TryGetValue<bool>(out var rBool) && rBool;
		}
		else
		{
			bodyRequired = false;
		}

		return new MethodDefinition(
			operationId,
			methodName,
			httpMethod.ToUpperInvariant(),
			path,
			new OperationParameters(parameters.PathParams, effectiveQueryParams),
			isGet ? [] : body.Properties,
			!isGet && rawRequestBody is not null,
			bodyRequired,
			responseType,
			!isGet && body.BodyIsArray,
			isGet ? null : body.BodyArrayItemType,
			isGet ? "form" : body.BodyEncoding,
			responseSchema
		);
	}
}
