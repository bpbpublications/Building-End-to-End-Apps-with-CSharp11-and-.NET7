namespace _01_NewFeatures.Features;

internal class StreamReading
{
    public void Demo()
    {
        using FileStream f = File.OpenRead("01-NewFeatures.dll");

        f.ReadExactly(buffer: new byte[100]); // guaranteed to read 100 bytes from the file

        int bytesRead = f.ReadAtLeast(buffer: new byte[100],
                                      minimumBytes: 10,
                                      throwOnEndOfStream: false); // 10 <= bytesRead <= 100
    }
}