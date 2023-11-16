namespace _01_NewFeatures.Features;

// Before C# 11 -----------
internal class BeforeCSharp11
{
    [CustomTypeAttribute(typeof(string))]
    public string? Method() => default;
}

public class CustomTypeAttribute : Attribute
{
    public CustomTypeAttribute(Type t) => ParamType = t;

    public Type ParamType { get; }
}

// ------------------------

internal class GenericAttributes
{
    [GenericAttribute<string>()]
    public string Method() => default;
}

public class GenericAttribute<T> : Attribute { }