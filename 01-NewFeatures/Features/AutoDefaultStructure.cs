namespace _01_NewFeatures.Features;

internal class AutoDefaultStructure
{
    public void Demo()
    {
        Point p = new Point(-5);
        Console.WriteLine(p.ToString());
    }
}

internal struct Point
{
    public int X { get; init; }
    public int Y { get; init; }

    public Point(int x)
    {
        X = x;
    }

    public override string ToString()
    {
        return $"[X = {X}, Y = {Y}]";
    }
}