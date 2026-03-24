using System.Text;
using System.Text.RegularExpressions;

namespace Lolzteam.Codegen;

internal static partial class Naming
{
    private static readonly HashSet<string> CSharpKeywords =
    [
        "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char",
        "checked", "class", "const", "continue", "decimal", "default", "delegate", "do",
        "double", "else", "enum", "event", "explicit", "extern", "false", "finally",
        "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int",
        "interface", "internal", "is", "lock", "long", "namespace", "new", "null",
        "object", "operator", "out", "override", "params", "private", "protected",
        "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof",
        "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true",
        "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using",
        "virtual", "void", "volatile", "while"
    ];

    [GeneratedRegex("_([a-z])")]
    private static partial Regex SnakePattern();

    /// <summary>Extract method name from operationId: everything after first dot, PascalCased.</summary>
    internal static string OperationIdToMethod(string operationId)
    {
        var parts = operationId.Split('.');
        if (parts.Length < 2) return CapitalizeFirst(LowercaseFirst(operationId));

        var sb = new StringBuilder();
        for (var i = 1; i < parts.Length; i++)
        {
            var part = parts[i];
            if (i == 1)
            {
                sb.Append(IsAllUppercase(part) ? part.ToLowerInvariant() : LowercaseFirst(part));
            }
            else
            {
                var p = IsAllUppercase(part) ? part.ToLowerInvariant() : part;
                sb.Append(CapitalizeFirst(p));
            }
        }

        // Java version returns camelCase; C# needs PascalCase
        return CapitalizeFirst(sb.ToString());
    }

    /// <summary>Extract group name from operationId: first segment.</summary>
    internal static string OperationIdToGroup(string operationId)
    {
        var first = operationId.Split('.')[0];
        var group = LowercaseFirst(first);
        if (group == "manging") return "managing";
        return group;
    }

    /// <summary>Convert tag to PascalCase property name.</summary>
    internal static string GroupToPropertyName(string tag)
    {
        return CapitalizeFirst(tag);
    }

    /// <summary>Convert tag to class name: PascalCase + "Api".</summary>
    internal static string GroupToClassName(string tag)
    {
        return CapitalizeFirst(tag) + "Api";
    }

    /// <summary>Build a type name prefix from group + method.</summary>
    internal static string BuildTypeName(string group, string method)
    {
        return CapitalizeFirst(group) + CapitalizeFirst(method);
    }

    internal static string SnakeToPascal(string name)
    {
        // Normalize hyphens to underscores before conversion
        var normalized = name.Replace('-', '_');
        var camel = SnakePattern().Replace(normalized, m => m.Groups[1].Value.ToUpperInvariant());
        return CapitalizeFirst(camel);
    }

    /// <summary>Strip trailing [] and replace non-alphanumeric/underscore chars from parameter names.</summary>
    internal static string SanitizeName(string name)
    {
        if (name.EndsWith("[]"))
        {
            name = name[..^2];
        }
        // Replace characters invalid in C# identifiers (e.g. ':', '.') with '_'
        if (InvalidIdentifierChars().IsMatch(name))
        {
            name = InvalidIdentifierChars().Replace(name, "_");
        }
        return name;
    }

    [GeneratedRegex(@"[^a-zA-Z0-9_]")]
    private static partial Regex InvalidIdentifierChars();

    /// <summary>Convert a parameter name to a safe C# identifier. Uses @ prefix for keywords.</summary>
    internal static string SafeCSharpName(string name)
    {
        var pascal = SnakeToPascal(SanitizeName(name));
        if (pascal.Length > 0 && char.IsDigit(pascal[0]))
        {
            return "_" + pascal;
        }
        if (CSharpKeywords.Contains(pascal))
        {
            return "@" + pascal;
        }
        return pascal;
    }

    /// <summary>Whether a parameter name needs [JsonPropertyName] attribute.</summary>
    internal static bool NeedsJsonPropertyName(string name)
    {
        var sanitized = SanitizeName(name);
        var pascal = SnakeToPascal(sanitized);
        return name != pascal || name != sanitized
            || (pascal.Length > 0 && char.IsDigit(pascal[0]));
    }

    internal static string LowercaseFirst(string s)
    {
        if (s.Length == 0) return s;
        return char.ToLowerInvariant(s[0]) + s[1..];
    }

    internal static string CapitalizeFirst(string s)
    {
        if (s.Length == 0) return s;
        return char.ToUpperInvariant(s[0]) + s[1..];
    }

    private static bool IsAllUppercase(string s)
    {
        return s.Length > 1 && s == s.ToUpperInvariant();
    }
}
