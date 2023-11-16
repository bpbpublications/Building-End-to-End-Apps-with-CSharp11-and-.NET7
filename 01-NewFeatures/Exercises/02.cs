namespace _01_NewFeatures.Exercises;

internal class _02
{
    public void Run()
    {
        var numberPlates = new List<string> { "XYZ 1034", "AB 1038", "XY2239", "XX 2018", "ZZ8321", "XYZ 1008" };

        numberPlates.Where(s =>  s is [.., '1' or '2', _, _, '8']).ToList().ForEach(Console.WriteLine);
    }
}