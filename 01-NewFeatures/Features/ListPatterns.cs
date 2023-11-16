namespace _01_NewFeatures.Features;

internal class ListPatterns
{
    public void Demo()
    {
        var numbers = new[] { -10, 0, 5, 7 };

        // Comparison with constant patterns
        Console.WriteLine(numbers is [-10, 0, 5, 7]); // True
        Console.WriteLine(numbers is [-10, 0, 5]); // False
        Console.WriteLine(numbers is [7, -10, 0, 5]);    // False

        // Comparison with discard patterns
        Console.WriteLine(numbers is [_, 0, _, 7]); // True

        // Comparison with range pattern
        Console.WriteLine(numbers is [.., 5, _]);   // True

        // Comparison with logical patterns
        Console.WriteLine(numbers is [_, <= 2, _, _]); // True

        // Comparison with length pattern
        if (numbers is [< 0, .. { Length: 2 or 4 }, > 0]) //true
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");

        // Comparison with var pattern
        if ("Curious" is ['c' or 'C', 'u', .. var str, 'u', 's' or 'S']) //true
            Console.WriteLine($"Matches, inner string: {str}");
        else
            Console.WriteLine($"No match");
    }
}
