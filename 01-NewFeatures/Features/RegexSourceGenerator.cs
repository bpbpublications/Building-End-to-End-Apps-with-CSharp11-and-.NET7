using System.Text.RegularExpressions;
namespace _01_NewFeatures.Features;

internal partial class RegexSourceGenerator
{
    private static readonly Regex VowelRegex =
    new(pattern: "[aeiou]",
        options: RegexOptions.Compiled | RegexOptions.IgnoreCase);

    [GeneratedRegex("[aeiou]", RegexOptions.IgnoreCase | RegexOptions.Compiled, "en-US")]
    private static partial Regex VowelGeneratedRegex();

    private string IsVowel(char c)
    {
        var d = VowelRegex.IsMatch(c.ToString()) ? "" : " not";
        return $"VowelRegex: {c} is{d} vowel";
    }

    private string IsVowelGeneratedRegex(char c)
    {
        var d = VowelGeneratedRegex().IsMatch(c.ToString()) ? "" : " not";
        return $"VowelGeneratedRegex: {c} is{d} vowel";
    }

    public void Demo()
    {
        Console.WriteLine(IsVowel('A')); //VowelRegex: A is vowel
        Console.WriteLine(IsVowelGeneratedRegex('e')); //VowelGeneratedRegex: e is vowel

        Console.WriteLine(IsVowel('c')); //VowelRegex: c is not vowel
        Console.WriteLine(IsVowelGeneratedRegex('S')); //VowelGeneratedRegex: S is not vowel

        Console.WriteLine(IsVowel('o')); //VowelRegex: o is vowel
        Console.WriteLine(IsVowelGeneratedRegex('I')); //VowelGeneratedRegex: I is vowel
    }
}