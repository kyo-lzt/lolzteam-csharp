// Polyfills for netstandard2.0 compatibility with modern C# features.

#if NETSTANDARD2_0

// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices
{
	/// <summary>Required for records and init-only properties on netstandard2.0.</summary>
	internal static class IsExternalInit;

	/// <summary>Required for the 'required' keyword on netstandard2.0.</summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	internal sealed class CompilerFeatureRequiredAttribute : Attribute
	{
		public CompilerFeatureRequiredAttribute(string featureName)
		{
			FeatureName = featureName;
		}

		public string FeatureName { get; }
		public bool IsOptional { get; init; }
	}

	/// <summary>Required for collection expressions on netstandard2.0.</summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = false)]
	internal sealed class CollectionBuilderAttribute : Attribute
	{
		public CollectionBuilderAttribute(Type builderType, string methodName)
		{
			BuilderType = builderType;
			MethodName = methodName;
		}

		public Type BuilderType { get; }
		public string MethodName { get; }
	}
}

// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices
{
	/// <summary>Required for the 'required' keyword on netstandard2.0.</summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
	internal sealed class RequiredMemberAttribute : Attribute;
}

// ReSharper disable once CheckNamespace
namespace System.Diagnostics.CodeAnalysis
{
	/// <summary>Required for the 'required' keyword on netstandard2.0.</summary>
	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
	internal sealed class SetsRequiredMembersAttribute : Attribute;
}

#endif
