namespace _01_NewFeatures.Features;

internal class RawStringLiterals
{
    public void Demo()
    {
        //Example 1: string with quote, newline and tab
        var xml = """
          <element attr="content">
            <body>
            </body>
          </element>
          """;
        Console.WriteLine(xml);

        //Example 2: string with four quotes
        var line = """""
                This line needs four quotes """" so 
                    should terminate with five.
          """"";
        Console.WriteLine(line);

        //Example 3: string interpolation
        string key = "100", value = "C#";
        string jsonString =
            $$"""
            {
                "Key": {{key}},
                "Value": {{value}}
            }
        """;
        Console.WriteLine(jsonString);
    }
}