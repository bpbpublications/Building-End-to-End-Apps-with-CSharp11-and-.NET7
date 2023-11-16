namespace _01_NewFeatures.Features;

internal class PatternMatchingWithSpanChar
{
    public void Demo()
    {
        var readOnlySpan = "Keep it simple!".AsSpan();
        if (readOnlySpan is "Keep it simple!")
        {
            Console.WriteLine("Simplicity!");
        }

        Span<char> spanChar = new Span<char>(new char[] { 'a', 'b', 'c' });
        if (spanChar is "abc")
        {
            Console.WriteLine("Alphabets!");
        }
    }
}