namespace _01_NewFeatures.Features;

internal class SimplifiedOrdering
{
    public void Demo()
    {
        var data = new[] { 2, 1, 3, 0, -10, 25, 8, -4, 22 };

        //Existing way (still supported)
        var sorted = data.OrderBy(e => e);
        var sortedDesc = data.OrderByDescending(e => e);

        //New simplified way
        var sortedSimplified = data.Order();
        var sortedDescSimplified = data.OrderDescending();
    }
}