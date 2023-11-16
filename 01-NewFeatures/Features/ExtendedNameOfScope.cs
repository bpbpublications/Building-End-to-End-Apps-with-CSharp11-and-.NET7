namespace _01_NewFeatures.Features;

public class CustomNullCheck : Attribute
{
    private readonly string _paramName;
    public CustomNullCheck(string paramName)
    {
        _paramName = paramName;
    }
}

internal class ExtendedNameOfScope
{
    [CustomNullCheck(nameof(values))] //C# 11
    public void Demo(List<int> values)
    {
        Console.WriteLine(nameof(values));  //output: numbers
        Console.WriteLine(nameof(values.Count));  // output: Count

        //Name = null; //throws exception: Name cannot be null (Parameter 'value') 

        [CustomNullCheck(nameof(T))] //C# 11
        void LocalFunction<T>(T param)
        { }

        var lambdaExpression = ([CustomNullCheck(nameof(someNumber))] int someNumber) => someNumber.ToString(); //C# 11
    }

    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value), $"{nameof(Name)} cannot be null");
    }
}