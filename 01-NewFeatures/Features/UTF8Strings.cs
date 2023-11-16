using System.Text;
namespace _01_NewFeatures.Features;

internal class UTF8Strings
{
    public void Demo()
    {
        // Option 1
        byte[] csharp10HelloWorld = Encoding.UTF8.GetBytes("Hello World");

        // Option 2
        ReadOnlySpan<byte> arrayHelloWorld = new byte[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20, 0x57, 0x6f, 0x72, 0x6c, 0x64 };

        //Option 3 - New way
        ReadOnlySpan<byte> span = "Hello World"u8;
        byte[] csharp11HelloWorld = span.ToArray();

        Console.WriteLine(Encoding.Default.GetString(csharp10HelloWorld)); //Output: Hello World
        Console.WriteLine(Encoding.Default.GetString(csharp11HelloWorld)); //Output: Hello World
        Console.WriteLine(Encoding.Default.GetString(arrayHelloWorld)); //Output: Hello World
    }
}