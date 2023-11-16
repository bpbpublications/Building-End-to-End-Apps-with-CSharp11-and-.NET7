using System.Numerics;
namespace _01_NewFeatures.Exercises;

internal class _01
{
    public void Run()
    {
        //Standard deviation for student strength
        Console.WriteLine(CustomMathLibrary.StandardDeviation(new List<int> { 30, 25, 32, 38, 24})); //Outputs: 5.674504383644443

        //Standard deviation for temperatures
        Console.WriteLine(CustomMathLibrary.StandardDeviation(new List<double> { 25.5, 28.2, 26.2, 24.0, 27.0, 22.1, 23.4 })); //Outputs: 2.1455380055672126
    }
}

internal static class CustomMathLibrary
{
    public static double StandardDeviation<T>(IEnumerable<T> values)
    where T : INumber<T>
    {
        var standardDeviation = 0d;

        if (values.Any())
        {
            var average = Average(values);
            var squaredDeviations = values.Select(value =>
            {
                var deviation = double.CreateChecked(value) - average;
                return deviation * deviation;
            });

            var variance = AddNumbers<double, double>(squaredDeviations);
            
            standardDeviation = Math.Sqrt(variance / double.CreateChecked(values.Count() - 1));
        }

        return standardDeviation;
    }

    public static double Average<T>(IEnumerable<T> values)
    where T : INumber<T>
    {
        var sum = AddNumbers<T, double>(values);
        return double.CreateChecked(sum) / double.CreateChecked(values.Count());
    }

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
}
