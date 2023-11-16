using System.Numerics;
namespace _01_NewFeatures.Features;

internal class GenericMath
{
    public void Demo()
    {
        Console.WriteLine("GenericMath.Demo() ---- ");

        //Example 1
        Vector v1 = new() { X = -2, Y = 8 };
        Vector v2 = new() { X = 6, Y = -1 };

        Console.WriteLine(v1 + v2); //Outputs: Vector (X: 4; Y: 7)
        Console.WriteLine(v1 - v2); //Outputs: Vector (X: -8; Y: 9)

        //Example 2
        Console.WriteLine(new List<int> { 5, -3, 0, 25 }.AddNumbers<int, long>()); //Outputs: 27
        Console.WriteLine(new List<double> { 5.5, 3.2, 4.6, 10.7 }.AddNumbers<double, double>()); //Outputs: 24
        Console.WriteLine("----------------------- ");
    }
}

public record Vector :
    IAdditionOperators<Vector, Vector, Vector>,
    ISubtractionOperators<Vector, Vector, Vector>
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Vector operator +(Vector self, Vector other)
    {
        return new Vector { X = self.X + other.X, Y = self.Y + other.Y };
    }

    public static Vector operator -(Vector self, Vector other)
    {
        return new Vector { X = self.X - other.X, Y = self.Y - other.Y };
    }

    public override string ToString() => $"Vector (X: {X}; Y: {Y})";
}

internal static class MathExtensions
{
    public static TResult AddNumbers<T, TResult>(this IEnumerable<T> values)
    where T : INumber<T>
    where TResult : INumber<TResult>
    {
        TResult result = TResult.Zero;

        foreach (var value in values)
        {
            result += TResult.CreateChecked(value);
        }

        return result;
    }

    //Extension method which doesn't work
    //public static T? Sum<T>(this IEnumerable<T> source) //where T : INumber<T>
    //{
    //    T? sum = default;
    //    foreach (T v in source)
    //    {
    //        sum += v; //error CS0019: Operator '+=' cannot be applied to operands of type 'T' and 'T'.
    //    }

    //    return sum;
    //}
}