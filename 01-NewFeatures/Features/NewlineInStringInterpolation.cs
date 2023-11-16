namespace _01_NewFeatures.Features;

internal class NewlineInStringInterpolation
{
    public void Demo()
    {
        // Example 1 - switch expression
        int statusCode = 302;
        string message = $"HTTP status code {statusCode} is for {statusCode switch
        {
            > 599 or < 100 => "Invalid",
            > 499 => "Server error",
            > 399 => "Client error",
            > 299 => "Redirection",
            > 199 => "Successful",
            > 99 => "Informational response"
        }}";
        Console.WriteLine(message); //Output: HTTP status code 302 is for Redirection

        // Example 2 - LINQ query
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine($"The even values of {nameof(numbers)} are {string.Join(", ",
            numbers.Where(n => n % 2 == 0))}."); //Output: The even values of numbers are 2, 4, 6, 8, 10.
    }
}