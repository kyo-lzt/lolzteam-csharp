using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace Lolzteam.Codegen;

internal static partial class Emitter
{
    // ─── Default Value Formatting ─────────────────────────────────────

    /// <summary>Format a default value for display in XML doc comments.</summary>
    private static string FormatDefaultValue(string value)
    {
        // Escape XML special characters
        return value
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;");
    }

    /// <summary>Escape XML special characters and strip markdown formatting.</summary>
    private static string EscapeXml(string text)
    {
        var escaped = text
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;");
        // Strip bold markdown (**text** → text)
        escaped = BoldPattern().Replace(escaped, "$1");
        return escaped;
    }

    [GeneratedRegex(@"\*\*(.+?)\*\*")]
    private static partial Regex BoldPattern();

    /// <summary>
    /// Format a default value as a C# literal for a property initializer.
    /// Returns null if the default cannot be represented as a compile-time constant.
    /// </summary>
    private static string? FormatDefaultLiteral(string defaultValue, string csharpType)
    {
        return FormatDefaultLiteral(defaultValue, csharpType, null);
    }

    private static string? FormatDefaultLiteral(
        string defaultValue, string csharpType, List<EnumDefinition>? enumDefs,
        string? propName = null, string? ns = null)
    {
        // Strip nullable suffix for matching
        var baseType = csharpType.TrimEnd('?');

        switch (baseType)
        {
            case "string":
                return "\"" + defaultValue.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
            case "long":
                return long.TryParse(defaultValue, out var l) ? l.ToString() : null;
            case "double":
                return double.TryParse(defaultValue, System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out var d)
                    ? d.ToString(System.Globalization.CultureInfo.InvariantCulture)
                    : null;
            case "bool":
                return defaultValue switch
                {
                    "true" or "1" => "true",
                    "false" or "0" => "false",
                    _ => null,
                };
            default:
                if (baseType.StartsWith("Lolzteam.Api.Runtime.StringOrLong"))
                {
                    return long.TryParse(defaultValue, out var lv)
                        ? "(Lolzteam.Api.Runtime.StringOrLong)" + lv
                        : "(Lolzteam.Api.Runtime.StringOrLong)\"" + defaultValue.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
                }

                // Enum types: find matching member
                if (enumDefs is not null)
                {
                    var enumDef = enumDefs.Find(e => e.TypeName == baseType);
                    if (enumDef is not null)
                    {
                        return FindEnumDefaultLiteral(enumDef, defaultValue, propName, ns);
                    }
                }
                return null;
        }
    }

    /// <summary>Find the enum member name that corresponds to a default value.</summary>
    private static string? FindEnumDefaultLiteral(
        EnumDefinition enumDef, string defaultValue, string? propName = null,
        string? ns = null)
    {
        string? memberName = null;
        if (enumDef.IsIntEnum)
        {
            if (long.TryParse(defaultValue, out var longVal))
            {
                foreach (var v in enumDef.Values)
                {
                    if (v is EnumVariant.IntVariant iv && iv.Value == longVal)
                    {
                        memberName = IntEnumMemberName(iv.Value);
                        break;
                    }
                }
            }
        }
        else
        {
            foreach (var v in enumDef.Values)
            {
                if (v is EnumVariant.StringVariant sv && sv.Value == defaultValue)
                {
                    memberName = StringEnumMemberName(sv.Value);
                    break;
                }
            }
        }

        if (memberName is null) return null;

        // If property name matches enum type name, C# resolves the name to the property.
        // Use fully-qualified type name to disambiguate.
        if (propName is not null && propName == enumDef.TypeName && ns is not null)
        {
            return "global::" + ns + "." + enumDef.TypeName + "." + memberName;
        }
        return enumDef.TypeName + "." + memberName;
    }

    // ─── Enum Definitions ─────────────────────────────────────────────

    /// <summary>Emit a single enum type definition.</summary>
    private static string EmitEnumDefinition(EnumDefinition def)
    {
        var sb = new StringBuilder();
        var seenMembers = new HashSet<string>();

        if (def.IsIntEnum)
        {
            sb.Append("public enum ").Append(def.TypeName).Append(" : long\n{\n");
            foreach (var variant in def.Values)
            {
                if (variant is EnumVariant.IntVariant iv)
                {
                    var memberName = DeduplicateName(IntEnumMemberName(iv.Value), seenMembers);
                    sb.Append("    ").Append(memberName).Append(" = ").Append(iv.Value).Append(",\n");
                }
            }
        }
        else
        {
            sb.Append("[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<")
                .Append(def.TypeName).Append(">))]\n");
            sb.Append("public enum ").Append(def.TypeName).Append("\n{\n");
            foreach (var variant in def.Values)
            {
                if (variant is EnumVariant.StringVariant sv)
                {
                    var memberName = DeduplicateName(StringEnumMemberName(sv.Value), seenMembers);
                    sb.Append("    [Lolzteam.Api.Runtime.EnumValue(\"")
                        .Append(sv.Value.Replace("\\", "\\\\").Replace("\"", "\\\""))
                        .Append("\")] ")
                        .Append(memberName).Append(",\n");
                }
            }
        }

        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>Generate a C# member name for an integer enum value.</summary>
    private static string IntEnumMemberName(long value)
    {
        if (value < 0)
        {
            return "Neg" + (-value).ToString();
        }
        return "V" + value;
    }

    /// <summary>Generate a C# member name for a string enum value.</summary>
    private static string StringEnumMemberName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return "None";
        }

        // Convert to PascalCase: split on non-alphanumeric chars
        var sb = new StringBuilder();
        var capitalizeNext = true;
        foreach (var ch in value)
        {
            if (!char.IsLetterOrDigit(ch))
            {
                capitalizeNext = true;
                continue;
            }
            if (capitalizeNext)
            {
                sb.Append(char.ToUpperInvariant(ch));
                capitalizeNext = false;
            }
            else
            {
                sb.Append(ch);
            }
        }

        var result = sb.ToString();

        // If starts with digit, prefix with V
        if (result.Length > 0 && char.IsDigit(result[0]))
        {
            result = "V" + result;
        }

        // If empty after processing, use hash
        if (result.Length == 0)
        {
            result = "Value" + Math.Abs(value.GetHashCode()).ToString();
        }

        return result;
    }

    // ─── Component Schema Records ─────────────────────────────────────

    /// <summary>Generate a sealed record for a component schema.</summary>
    private static string EmitComponentSchemaRecord(
        string name, JsonObject schema, JsonNode rawSpec, HashSet<string> componentSchemaNames)
    {
        var nestedRecords = new List<string>();
        var sb = new StringBuilder();
        sb.Append("public sealed record ").Append(name).Append("(\n");

        var requiredSet = new HashSet<string>();
        var requiredArr = schema["required"];
        if (requiredArr is JsonArray reqArr)
        {
            foreach (var r in reqArr)
            {
                requiredSet.Add(r!.GetValue<string>());
            }
        }

        var properties = schema["properties"];
        if (properties is not JsonObject propsObj || propsObj.Count == 0)
        {
            sb.Append(");\n");
            return sb.ToString();
        }

        var entries = new List<(string jsonName, string csharpType, bool required)>();
        foreach (var kvp in propsObj)
        {
            var propName = kvp.Key;
            var propSchema = kvp.Value;
            if (propSchema is null) continue;

            var required = requiredSet.Contains(propName);
            var csharpType = ResolveComponentPropertyType(
                propSchema, rawSpec, componentSchemaNames, name, propName, nestedRecords);
            entries.Add((propName, csharpType, required));
        }

        var seenNames = new HashSet<string>();
        for (var i = 0; i < entries.Count; i++)
        {
            var (jsonName, csharpType, required) = entries[i];
            var propName = DeduplicateName(Naming.SafeCSharpName(jsonName), seenNames);
            var typeStr = required ? csharpType : MakeNullable(csharpType);

            sb.Append("    [property: JsonPropertyName(\"").Append(jsonName).Append("\")] ");
            sb.Append(typeStr).Append(' ').Append(propName);

            if (i < entries.Count - 1)
                sb.Append(",\n");
            else
                sb.Append('\n');
        }

        sb.Append(");\n");

        // Append nested records after the parent record
        foreach (var nested in nestedRecords)
        {
            sb.Append('\n').Append(nested);
        }

        return sb.ToString();
    }

    /// <summary>Resolve a property type within a component schema.</summary>
    private static string ResolveComponentPropertyType(
        JsonNode schema, JsonNode rawSpec, HashSet<string> componentSchemaNames,
        string? parentTypeName = null, string? propName = null, List<string>? nestedRecords = null)
    {
        // $ref to another component schema → JsonElement (API may return [] where object expected)
        if (schema is JsonObject refObj)
        {
            var refNode = refObj["$ref"];
            if (refNode is JsonValue jv && jv.TryGetValue<string>(out var refStr))
            {
                if (refStr.StartsWith("#/components/schemas/"))
                {
                    return "JsonElement";
                }
                var resolved = Transforms.ResolveRef(refStr, rawSpec);
                if (resolved is not null)
                {
                    return ResolveComponentPropertyType(
                        resolved, rawSpec, componentSchemaNames, parentTypeName, propName, nestedRecords);
                }
            }
        }

        if (schema is not JsonObject sObj) return "JsonElement";

        var typeEl = sObj["type"];

        // Multi-type array: type: ['string', 'integer'] → StringOrLong
        if (typeEl is JsonArray multiTypeArr)
        {
            var nonNullTypes = new List<string>();
            foreach (var t in multiTypeArr)
            {
                var ts = t!.GetValue<string>();
                if (ts != "null") nonNullTypes.Add(ts);
            }
            var sortedTypes = nonNullTypes.OrderBy(s => s).ToList();
            if (sortedTypes.Count == 2 && sortedTypes[0] == "integer" && sortedTypes[1] == "string")
            {
                return "Lolzteam.Api.Runtime.StringOrLong";
            }
            return "JsonElement";
        }

        string? type = null;
        if (typeEl is JsonValue typeVal && typeVal.TryGetValue<string>(out var tv))
        {
            type = tv;
        }

        if (type == "array")
        {
            var items = sObj["items"];
            if (items is not null)
            {
                var itemType = ResolveComponentPropertyType(
                    items, rawSpec, componentSchemaNames, parentTypeName, propName, nestedRecords);
                return $"List<{itemType}>";
            }
            return "List<JsonElement>";
        }

        if (type == "object" || sObj["properties"] is not null)
        {
            var props = sObj["properties"];
            if (props is JsonObject propsObj && propsObj.Count > 0)
            {
                // Objects with all-numeric property keys → JsonElement (API may return array or mixed values)
                if (Transforms.HasAllNumericKeys(propsObj))
                {
                    return "JsonElement";
                }

                if (parentTypeName is not null && propName is not null && nestedRecords is not null)
                {
                    // Generate a nested record for inline objects with properties
                    var nestedName = parentTypeName + Naming.SnakeToPascal(Naming.SanitizeName(propName));
                    var nestedSb = new StringBuilder();
                    nestedSb.Append("public sealed record ").Append(nestedName).Append("(\n");

                    var requiredSet = new HashSet<string>();
                    var reqArr = sObj["required"];
                    if (reqArr is JsonArray rArr)
                    {
                        foreach (var r in rArr)
                        {
                            requiredSet.Add(r!.GetValue<string>());
                        }
                    }

                    var entries = new List<(string jsonName, string csharpType, bool required)>();
                    foreach (var kvp in propsObj)
                    {
                        var pName = kvp.Key;
                        var pSchema = kvp.Value;
                        if (pSchema is null) continue;
                        var req = requiredSet.Contains(pName);
                        var cType = ResolveComponentPropertyType(
                            pSchema, rawSpec, componentSchemaNames, nestedName, pName, nestedRecords);
                        entries.Add((pName, cType, req));
                    }

                    var nestedSeen = new HashSet<string>();
                    for (var i = 0; i < entries.Count; i++)
                    {
                        var (jn, ct, _) = entries[i];
                        var pn = DeduplicateName(Naming.SafeCSharpName(jn), nestedSeen);
                        var ts = MakeNullable(ct);
                        nestedSb.Append("    [property: JsonPropertyName(\"").Append(jn).Append("\")] ");
                        nestedSb.Append(ts).Append(' ').Append(pn);
                        nestedSb.Append(i < entries.Count - 1 ? ",\n" : "\n");
                    }

                    nestedSb.Append(");\n");
                    nestedRecords.Add(nestedSb.ToString());
                    return nestedName;
                }
            }
            return "JsonElement";
        }

        if (type is not null)
        {
            return type switch
            {
                "string" => "string",
                "integer" => "long",
                "number" => "double",
                "boolean" => "bool",
                _ => "JsonElement",
            };
        }

        if (sObj["enum"] is JsonArray) return "string";
        if (sObj["oneOf"] is JsonArray || sObj["anyOf"] is JsonArray) return "JsonElement";

        return "JsonElement";
    }

    // ─── Types File ───────────────────────────────────────────────────

    private static string? EmitQueryParamsRecord(
        string group, MethodDefinition method, Dictionary<string, string> paramToEnumType,
        List<EnumDefinition>? enumDefs = null, string? ns = null)
    {
        if (method.Params.QueryParams.Count == 0) return null;

        var typeName = Naming.BuildTypeName(group, method.MethodName) + "Params";
        var sb = new StringBuilder();
        sb.Append("    public sealed record ").Append(typeName).Append('\n');
        sb.Append("    {\n");

        foreach (var param in method.Params.QueryParams)
        {
            var enumKey = method.OperationId + ":" + param.Name;
            var csharpType = paramToEnumType.TryGetValue(enumKey, out var enumTypeName)
                ? (param.Type.StartsWith("Array<") ? "List<" + enumTypeName + ">" : enumTypeName)
                : Transforms.ToCSharpType(param.Type);
            var propName = Naming.SafeCSharpName(param.Name);
            if (param.Description is not null || param.DefaultValue is not null)
            {
                var parts = new List<string>();
                if (param.Description is not null) parts.Add(EscapeXml(param.Description.ReplaceLineEndings(" ")));
                if (param.DefaultValue is not null) parts.Add("Default: " + FormatDefaultValue(param.DefaultValue) + ".");
                sb.Append("        /// <summary>").Append(string.Join(" ", parts)).Append("</summary>\n");
            }
            if (Naming.NeedsJsonPropertyName(param.Name))
            {
                sb.Append("        [JsonPropertyName(\"").Append(param.Name).Append("\")]\n");
            }
            var defaultLiteral = param.DefaultValue is not null
                ? FormatDefaultLiteral(param.DefaultValue, csharpType, enumDefs, propName, ns)
                : null;
            if (param.Required && defaultLiteral is null)
            {
                // Required param without default: non-nullable with required keyword
                sb.Append("        public required ").Append(csharpType).Append(' ').Append(propName).Append(" { get; init; }\n");
            }
            else if (defaultLiteral is not null)
            {
                sb.Append("        public ").Append(MakeNullable(csharpType)).Append(' ').Append(propName)
                    .Append(" { get; init; } = ").Append(defaultLiteral).Append(";\n");
            }
            else
            {
                sb.Append("        public ").Append(MakeNullable(csharpType)).Append(' ').Append(propName).Append(" { get; init; }\n");
            }
        }

        sb.Append("    }");
        return sb.ToString();
    }

    private static string? EmitBodyRecord(
        string group, MethodDefinition method, Dictionary<string, string> paramToEnumType,
        List<EnumDefinition>? enumDefs = null, string? ns = null)
    {
        if (!method.HasBody) return null;

        // Array body — no record needed, method accepts List<T> directly
        if (method.BodyIsArray) return null;

        // Discriminated oneOf → abstract base + sealed variant records
        if (method.BodyOneOfVariants is { Count: > 0 } variants)
        {
            return EmitSealedBodyRecords(group, method, variants, paramToEnumType, enumDefs, ns);
        }

        if (method.BodyProperties.Count == 0) return null;

        var typeName = Naming.BuildTypeName(group, method.MethodName) + "Body";

        var sb = new StringBuilder();
        sb.Append("    public sealed record ").Append(typeName).Append('\n');
        sb.Append("    {\n");

        foreach (var prop in method.BodyProperties)
        {
            var enumKey = method.OperationId + ":" + prop.Name;
            var csharpType = prop.Type == "Blob"
                ? "byte[]"
                : paramToEnumType.TryGetValue(enumKey, out var enumTypeName)
                    ? (prop.Type.StartsWith("Array<") ? "List<" + enumTypeName + ">" : enumTypeName)
                    : Transforms.ToCSharpType(prop.Type);
            var propName = Naming.SafeCSharpName(prop.Name);

            if (prop.Description is not null || prop.DefaultValue is not null)
            {
                var parts = new List<string>();
                if (prop.Description is not null) parts.Add(EscapeXml(prop.Description.ReplaceLineEndings(" ")));
                if (prop.DefaultValue is not null) parts.Add("Default: " + FormatDefaultValue(prop.DefaultValue) + ".");
                sb.Append("        /// <summary>").Append(string.Join(" ", parts)).Append("</summary>\n");
            }
            if (Naming.NeedsJsonPropertyName(prop.Name))
            {
                sb.Append("        [JsonPropertyName(\"").Append(prop.Name).Append("\")]\n");
            }

            var defaultLiteral = prop.DefaultValue is not null
                ? FormatDefaultLiteral(prop.DefaultValue, csharpType, enumDefs, propName, ns)
                : null;

            if (prop.Required)
            {
                if (defaultLiteral is not null)
                {
                    // Has default → not truly "required" from user perspective, emit with initializer
                    sb.Append("        public ").Append(csharpType).Append(' ').Append(propName)
                        .Append(" { get; init; } = ").Append(defaultLiteral).Append(";\n");
                }
                else
                {
                    sb.Append("        public required ").Append(csharpType).Append(' ').Append(propName).Append(" { get; init; }\n");
                }
            }
            else
            {
                if (defaultLiteral is not null)
                {
                    sb.Append("        public ").Append(MakeNullable(csharpType)).Append(' ').Append(propName)
                        .Append(" { get; init; } = ").Append(defaultLiteral).Append(";\n");
                }
                else
                {
                    sb.Append("        public ").Append(MakeNullable(csharpType)).Append(' ').Append(propName).Append(" { get; init; }\n");
                }
            }
        }

        sb.Append("    }");
        return sb.ToString();
    }

    private static string EmitSealedBodyRecords(
        string group, MethodDefinition method, List<OneOfVariant> variants,
        Dictionary<string, string> paramToEnumType, List<EnumDefinition>? enumDefs = null,
        string? ns = null)
    {
        var baseName = Naming.BuildTypeName(group, method.MethodName) + "Body";
        var sb = new StringBuilder();

        // JsonDerivedType attributes on abstract base
        foreach (var variant in variants)
        {
            var variantName = VariantClassName(baseName, variant.Title);
            sb.Append("    [JsonDerivedType(typeof(").Append(variantName).Append("), \"")
                .Append(variant.DiscriminatorValue).Append("\")]\n");
        }
        sb.Append("    public abstract record ").Append(baseName).Append(";\n");

        // Variant records
        foreach (var variant in variants)
        {
            var variantName = VariantClassName(baseName, variant.Title);
            sb.Append('\n');
            sb.Append("    public sealed record ").Append(variantName).Append(" : ").Append(baseName).Append('\n');
            sb.Append("    {\n");

            // Discriminator field as a constant
            var discPropName = Naming.SafeCSharpName(variant.DiscriminatorField);
            sb.Append("        [JsonPropertyName(\"").Append(variant.DiscriminatorField).Append("\")]\n");

            // Determine if discriminator is int or string
            if (long.TryParse(variant.DiscriminatorValue, out var intDisc))
            {
                sb.Append("        public long ").Append(discPropName).Append(" => ").Append(intDisc).Append(";\n");
            }
            else
            {
                sb.Append("        public string ").Append(discPropName).Append(" => \"")
                    .Append(variant.DiscriminatorValue).Append("\";\n");
            }

            foreach (var prop in variant.Properties)
            {
                var enumKey = method.OperationId + ":" + prop.Name;
                var csharpType = prop.Type == "Blob"
                    ? "byte[]"
                    : paramToEnumType.TryGetValue(enumKey, out var enumTypeName)
                        ? (prop.Type.StartsWith("Array<") ? "List<" + enumTypeName + ">" : enumTypeName)
                        : Transforms.ToCSharpType(prop.Type);
                var propName = Naming.SafeCSharpName(prop.Name);

                if (prop.Description is not null || prop.DefaultValue is not null)
                {
                    var parts = new List<string>();
                    if (prop.Description is not null) parts.Add(EscapeXml(prop.Description.ReplaceLineEndings(" ")));
                    if (prop.DefaultValue is not null) parts.Add("Default: " + FormatDefaultValue(prop.DefaultValue) + ".");
                    sb.Append("        /// <summary>").Append(string.Join(" ", parts)).Append("</summary>\n");
                }
                if (Naming.NeedsJsonPropertyName(prop.Name))
                {
                    sb.Append("        [JsonPropertyName(\"").Append(prop.Name).Append("\")]\n");
                }

                var variantDefaultLiteral = prop.DefaultValue is not null
                    ? FormatDefaultLiteral(prop.DefaultValue, csharpType, enumDefs, propName, ns)
                    : null;

                if (prop.Required)
                {
                    if (variantDefaultLiteral is not null)
                    {
                        sb.Append("        public ").Append(csharpType).Append(' ').Append(propName)
                            .Append(" { get; init; } = ").Append(variantDefaultLiteral).Append(";\n");
                    }
                    else
                    {
                        sb.Append("        public required ").Append(csharpType).Append(' ').Append(propName).Append(" { get; init; }\n");
                    }
                }
                else
                {
                    if (variantDefaultLiteral is not null)
                    {
                        sb.Append("        public ").Append(MakeNullable(csharpType)).Append(' ').Append(propName)
                            .Append(" { get; init; } = ").Append(variantDefaultLiteral).Append(";\n");
                    }
                    else
                    {
                        sb.Append("        public ").Append(MakeNullable(csharpType)).Append(' ').Append(propName).Append(" { get; init; }\n");
                    }
                }
            }

            sb.Append("    }");
        }

        return sb.ToString();
    }

    /// <summary>Convert a variant title like "Client Credentials" to a class name suffix.</summary>
    private static string VariantClassName(string baseName, string title)
    {
        var parts = title.Split([' ', '_', '-'], StringSplitOptions.RemoveEmptyEntries);
        var pascal = string.Join("", parts.Select(p => char.ToUpperInvariant(p[0]) + p[1..]));
        return baseName + pascal;
    }

    private static string EmitResponseRecord(
        string group, MethodDefinition method, JsonNode rawSpec, HashSet<string> componentSchemaNames)
    {
        var typeName = Naming.BuildTypeName(group, method.MethodName) + "Response";

        // text/html endpoints return raw string
        if (method.ReturnsHtml)
        {
            return $"    public sealed record {typeName}(string Data);";
        }

        // If we have a raw response schema with properties, resolve types with nested record generation
        if (method.RawResponseSchema is { } rawSchema
            && rawSchema["properties"] is JsonObject propsObj && propsObj.Count > 0)
        {
            var nestedRecords = new List<string>();
            var sb = new StringBuilder();
            sb.Append("    public sealed record ").Append(typeName).Append("(\n");

            var requiredSet = new HashSet<string>();
            var requiredArr = rawSchema["required"];
            if (requiredArr is JsonArray reqArr)
            {
                foreach (var r in reqArr)
                {
                    requiredSet.Add(r!.GetValue<string>());
                }
            }

            var entries = new List<(string jsonName, string csharpType, bool required)>();
            foreach (var kvp in propsObj)
            {
                var propName = kvp.Key;
                var propSchema = kvp.Value;
                if (propSchema is null) continue;

                var required = requiredSet.Contains(propName);
                var csharpType = ResolveComponentPropertyType(
                    propSchema, rawSpec, componentSchemaNames, typeName, propName, nestedRecords);
                entries.Add((propName, csharpType, required));
            }

            var seenNames = new HashSet<string>();
            for (var i = 0; i < entries.Count; i++)
            {
                var (jsonName, csharpType, required) = entries[i];
                var propName = DeduplicateName(Naming.SafeCSharpName(jsonName), seenNames);
                var typeStr = required ? csharpType : MakeNullable(csharpType);

                sb.Append("        [property: JsonPropertyName(\"").Append(jsonName).Append("\")] ");
                sb.Append(typeStr).Append(' ').Append(propName);

                if (i < entries.Count - 1)
                    sb.Append(",\n");
                else
                    sb.Append('\n');
            }

            sb.Append("    );");

            // Append nested records after the response record
            foreach (var nested in nestedRecords)
            {
                sb.Append("\n\n    ").Append(nested.TrimEnd());
            }

            return sb.ToString();
        }

        // Fallback: opaque JsonElement
        var fallbackType = Transforms.ToCSharpType(method.ResponseType);
        return $"    public sealed record {typeName}({fallbackType} Data);";
    }

    internal static string EmitCSharpTypesFile(
        List<ParsedGroup> groups, string subPackage,
        SortedDictionary<string, JsonObject> componentSchemas, JsonNode rawSpec,
        List<EnumDefinition> enumDefs, Dictionary<string, string> paramToEnumType)
    {
        var sb = new StringBuilder();
        var ns = "Lolzteam.Api.Generated." + Naming.CapitalizeFirst(subPackage);
        var componentSchemaNames = new HashSet<string>(componentSchemas.Keys);

        sb.Append("// Auto-generated. Do not edit manually.\n\n");
        sb.Append("using System.Text.Json.Serialization;\n");
        sb.Append("using System.Text.Json;\n\n");
        sb.Append("namespace ").Append(ns).Append(";\n\n");

        // Emit enum definitions
        if (enumDefs.Count > 0)
        {
            sb.Append("// ─── Enums ────────────────────────────────────────────────────\n\n");
            foreach (var def in enumDefs)
            {
                sb.Append(EmitEnumDefinition(def));
                sb.Append('\n');
            }
        }

        // Emit component schema records
        if (componentSchemas.Count > 0)
        {
            sb.Append("// ─── Component Schemas ────────────────────────────────────────\n\n");
            foreach (var kvp in componentSchemas)
            {
                sb.Append(EmitComponentSchemaRecord(kvp.Key, kvp.Value, rawSpec, componentSchemaNames));
                sb.Append('\n');
            }
        }

        foreach (var group in groups)
        {
            var className = Naming.GroupToClassName(group.GroupName);
            var groupTypes = new List<string>();

            foreach (var method in group.Methods)
            {
                var queryType = EmitQueryParamsRecord(group.GroupName, method, paramToEnumType, enumDefs, ns);
                if (queryType is not null) groupTypes.Add(queryType);

                var bodyType = EmitBodyRecord(group.GroupName, method, paramToEnumType, enumDefs, ns);
                if (bodyType is not null) groupTypes.Add(bodyType);

                groupTypes.Add(EmitResponseRecord(group.GroupName, method, rawSpec, componentSchemaNames));
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

    /// <summary>Ensure a property name is unique within its record by appending a numeric suffix.</summary>
    private static string DeduplicateName(string name, HashSet<string> seen)
    {
        if (seen.Add(name)) return name;
        var suffix = 2;
        while (!seen.Add(name + suffix)) suffix++;
        return name + suffix;
    }

    /// <summary>Make a C# type nullable if it isn't already (avoids int?? etc).</summary>
    private static string MakeNullable(string type) =>
        type.EndsWith('?') ? type : type + "?";

    /// <summary>Map path param type to a native C# type, falling back to string for complex types.</summary>
    private static string PathParamToCSharpType(string intermediateType)
    {
        var csharp = Transforms.ToCSharpType(intermediateType).TrimEnd('?');
        // Path params are string-interpolated into URLs — JsonElement makes no sense here
        return csharp == "JsonElement" ? "string" : csharp;
    }

    /// <summary>Emit a return statement that constructs the response record from __result.</summary>
    private static void EmitReturnStatement(StringBuilder sb, string responseTypeName, MethodDefinition method, string indent)
    {
        if (method.ResponseSchema is { } schema && schema.Properties.Count > 0)
        {
            // Typed response — deserialize directly to the record
            sb.Append(indent).Append("return JsonSerializer.Deserialize<").Append(responseTypeName)
                .Append(">(__result, JsonDefaults.Options)!;\n");
        }
        else
        {
            var dataCSharpType = Transforms.ToCSharpType(method.ResponseType);
            if (dataCSharpType == "JsonElement")
            {
                sb.Append(indent).Append("return new ").Append(responseTypeName).Append("(__result);\n");
            }
            else
            {
                sb.Append(indent).Append("return new ").Append(responseTypeName)
                    .Append("(JsonSerializer.Deserialize<").Append(dataCSharpType).Append(">(__result, JsonDefaults.Options)!);\n");
            }
        }
    }

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

        // Path params (always required, native types)
        foreach (var param in method.Params.PathParams)
        {
            var csharpType = PathParamToCSharpType(param.Type);
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

        // XML doc comments
        if (method.Summary is not null)
        {
            sb.Append("    /// <summary>").Append(EscapeXml(method.Summary)).Append("</summary>\n");
        }
        if (method.Description is not null)
        {
            sb.Append("    /// <remarks>\n");
            foreach (var line in method.Description.Split('\n'))
            {
                var trimmed = line.TrimEnd('\r');
                sb.Append("    /// ").Append(EscapeXml(trimmed)).Append('\n');
            }
            sb.Append("    /// </remarks>\n");
        }
        foreach (var param in method.Params.PathParams)
        {
            if (param.Description is not null)
            {
                var paramName = Naming.SnakeToPascal(Naming.SanitizeName(param.Name));
                sb.Append("    /// <param name=\"").Append(paramName).Append("\">").Append(EscapeXml(param.Description.ReplaceLineEndings(" "))).Append("</param>\n");
            }
        }

        sb.Append("    public async Task<").Append(responseTypeName).Append("> ").Append(method.MethodName)
            .Append("Async(").Append(argStr).Append(")\n    {\n");

        // text/html endpoints use RequestRawAsync
        if (method.ReturnsHtml)
        {
            sb.Append("        var __result = await _http.RequestRawAsync(new RequestOptions\n");
            sb.Append("        {\n");
            sb.Append("            Method = \"").Append(method.HttpMethod).Append("\",\n");
            sb.Append("            Path = ").Append(pathExpr).Append(",\n");
            if (hasQueryType)
            {
                sb.Append("            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,\n");
            }
            if (isSearch)
            {
                sb.Append("            IsSearch = true,\n");
            }
            sb.Append("        }, cancellationToken).ConfigureAwait(false);\n");
            sb.Append("        return new ").Append(responseTypeName).Append("(__result);\n");
            sb.Append("    }");
            return sb.ToString();
        }

        if (isMultipart && hasByteArrayFields)
        {
            EmitMultipartByteArrayMethod(sb, method, pathExpr, hasQueryType, isSearch, responseTypeName);
        }
        else
        {
            var encodingLiteral = BodyEncodingLiteral(method.BodyEncoding);
            sb.Append("        var __result = await _http.RequestAsync(new RequestOptions\n");
            sb.Append("        {\n");
            sb.Append("            Method = \"").Append(method.HttpMethod).Append("\",\n");
            sb.Append("            Path = ").Append(pathExpr).Append(",\n");

            if (hasQueryType)
            {
                sb.Append("            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,\n");
            }

            if (hasBodyType)
            {
                if (method.BodyRequired)
                {
                    sb.Append("            Body = JsonSerializer.SerializeToElement(body),\n");
                }
                else
                {
                    sb.Append("            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,\n");
                }
                sb.Append("            BodyEncoding = ").Append(encodingLiteral).Append(",\n");
            }
            else if (method.BodyEncoding != "form")
            {
                sb.Append("            BodyEncoding = ").Append(encodingLiteral).Append(",\n");
            }

            if (isSearch)
            {
                sb.Append("            IsSearch = true,\n");
            }

            sb.Append("        }, cancellationToken).ConfigureAwait(false);\n");
            EmitReturnStatement(sb, responseTypeName, method, "        ");
        }

        sb.Append("    }");
        return sb.ToString();
    }

    private static void EmitMultipartByteArrayMethod(
        StringBuilder sb, MethodDefinition method, string pathExpr,
        bool hasQueryType, bool isSearch, string responseTypeName)
    {
        var serializableProps = method.BodyProperties.FindAll(p => p.Type != "Blob");
        var byteArrayFieldNames = method.BodyProperties.FindAll(p => p.Type == "Blob")
            .ConvertAll(p => p.Name);

        var indent = method.BodyRequired ? "        " : "            ";

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
            sb.Append(indent).Append("    Method = \"").Append(method.HttpMethod).Append("\",\n");
            sb.Append(indent).Append("    Path = ").Append(pathExpr).Append(",\n");

            if (hasQueryType)
            {
                sb.Append(indent).Append("    Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,\n");
            }

            if (serializableProps.Count > 0)
            {
                sb.Append(indent).Append("    Body = JsonSerializer.SerializeToElement(jsonObj),\n");
            }
            sb.Append(indent).Append("    BodyEncoding = BodyEncoding.Multipart,\n");
            sb.Append(indent).Append("    ByteArrayFields = byteFields,\n");
            if (isSearch)
            {
                sb.Append(indent).Append("    IsSearch = true,\n");
            }
            sb.Append(indent).Append("}, cancellationToken).ConfigureAwait(false);\n");
            EmitReturnStatement(sb, responseTypeName, method, indent);
        }

        if (method.BodyRequired)
        {
            EmitBody();
        }
        else
        {
            sb.Append("        if (body is not null)\n        {\n");
            EmitBody();
            sb.Append("        }\n        else\n        {\n");
            sb.Append("            var __result = await _http.RequestAsync(new RequestOptions\n");
            sb.Append("            {\n");
            sb.Append("                Method = \"").Append(method.HttpMethod).Append("\",\n");
            sb.Append("                Path = ").Append(pathExpr).Append(",\n");
            if (hasQueryType)
            {
                sb.Append("                Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,\n");
            }
            sb.Append("                BodyEncoding = BodyEncoding.Multipart,\n");
            if (isSearch)
            {
                sb.Append("                IsSearch = true,\n");
            }
            sb.Append("            }, cancellationToken).ConfigureAwait(false);\n");
            EmitReturnStatement(sb, responseTypeName, method, "            ");
            sb.Append("        }\n");
        }
    }

    private static string EmitGroupClass(ParsedGroup group)
    {
        var className = Naming.GroupToClassName(group.GroupName);
        var sb = new StringBuilder();

        sb.Append("public sealed class ").Append(className).Append('\n');
        sb.Append("{\n");
        sb.Append("    private readonly LolzteamHttpClient _http;\n\n");
        sb.Append("    public ").Append(className).Append("(LolzteamHttpClient http)\n");
        sb.Append("    {\n");
        sb.Append("        _http = http;\n");
        sb.Append("    }\n");

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
            sb.Append("    public ").Append(propClassName).Append(' ').Append(propName).Append(" { get; }\n");
        }

        sb.Append("\n    private readonly LolzteamHttpClient _http;\n\n");

        // Constructor
        sb.Append("    public ").Append(clientName).Append("(ClientConfig config)\n    {\n");
        sb.Append("        var resolvedConfig = config with\n        {\n");
        sb.Append("            BaseUrl = config.BaseUrl ?? \"").Append(defaultBaseUrl).Append("\",\n");
        sb.Append("            RateLimit = config.RateLimit ?? new RateLimitConfig(").Append(defaultRateLimit).Append("),\n");
        if (defaultSearchRateLimit > 0)
        {
            sb.Append("            SearchRateLimit = config.SearchRateLimit ?? new RateLimitConfig(").Append(defaultSearchRateLimit).Append("),\n");
        }
        sb.Append("        };\n");
        sb.Append("        _http = new LolzteamHttpClient(resolvedConfig);\n\n");

        foreach (var group in groups)
        {
            var propClassName = Naming.GroupToClassName(group.GroupName);
            var propName = Naming.GroupToPropertyName(group.GroupName);
            sb.Append("        ").Append(propName).Append(" = new ").Append(propClassName).Append("(_http);\n");
        }

        sb.Append("    }\n\n");

        sb.Append("    public static ").Append(clientName).Append(" Create(string token)\n    {\n");
        sb.Append("        return new ").Append(clientName).Append("(new ClientConfig { Token = token });\n");
        sb.Append("    }\n\n");

        // Dispose
        sb.Append("    public void Dispose()\n    {\n");
        sb.Append("        _http.Dispose();\n");
        sb.Append("    }\n");

        sb.Append("}\n");

        return sb.ToString();
    }
}
