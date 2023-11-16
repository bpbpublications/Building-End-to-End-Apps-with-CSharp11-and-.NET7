using System.Formats.Tar;
using System.IO.Compression;
namespace _01_NewFeatures.Features;

/// <summary>
/// Extended the sample https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.gzipstream?view=net-7.0
/// </summary>
internal class TarAPI
{
    public void Demo()
    {
        const string DemoRootFolder = "./TarApiDemo/";
        const string OriginalFolder = $"{DemoRootFolder}Original/";
        const string DecompressedFolder = $"{DemoRootFolder}Decompressed/";

        const string TarFilePath = $"{DemoRootFolder}TarApiDemo.tar";
        const string GzFilePath = $"{DemoRootFolder}TarApiDemo.tar.gz";
        const string DecompressedFilePath = $"{DemoRootFolder}TarApiDemoDecompressed.tar";

        const string SampleMessage = "I am excited to announce that C# 11 is out! As always, C# opens some entirely new fronts, "
            + "even while advancing several themes that have been in motion over past releases. "
            + "There are many features and many details, which are beautifully covered under "
            + "What’s new in C# 11 on our docs pages. What follows here is an appetizer of some "
            + "of the highlights – small and big.";

        //Delete any left overs of previous run
        if (Directory.Exists(DemoRootFolder))
            Directory.Delete(DemoRootFolder, true);

        //Create sample file
        Directory.CreateDirectory(OriginalFolder);
        File.WriteAllText($"{OriginalFolder}CSharpFeatures.txt", SampleMessage);

        //Create tarball
        TarFile.CreateFromDirectory(OriginalFolder, TarFilePath, false);

        CompressTar();

        DecompressTar();

        ReadArchiveEntry();

        //Extract tarball
        Directory.CreateDirectory(DecompressedFolder);
        TarFile.ExtractToDirectory(DecompressedFilePath, DecompressedFolder, true);

        static void CompressTar()
        {
            using FileStream originalFileStream = File.Open(TarFilePath, FileMode.Open);
            using FileStream compressedFileStream = File.Create(GzFilePath);
            using GZipStream compressor = new(compressedFileStream, CompressionMode.Compress);
            originalFileStream.CopyTo(compressor);
        }

        static void DecompressTar()
        {
            using FileStream compressedFileStream2 = File.Open(GzFilePath, FileMode.Open);
            using FileStream outputFileStream = File.Create(DecompressedFilePath);
            using GZipStream decompressor = new(compressedFileStream2, CompressionMode.Decompress);
            decompressor.CopyTo(outputFileStream);
        }

        static void ReadArchiveEntry()
        {
            FileStream archiveStream = File.OpenRead(DecompressedFilePath);
            TarReader reader = new(archiveStream, leaveOpen: true);
            TarEntry? entry;
            while ((entry = reader.GetNextEntry()) != null)
                Console.WriteLine(entry.Name);
        }
    }
}
