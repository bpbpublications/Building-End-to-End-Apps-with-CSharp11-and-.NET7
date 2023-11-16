using System.Diagnostics.CodeAnalysis;

namespace _01_NewFeatures.Features;

internal class RequiredMembers
{
    public void Demo()
    {
        //valid
        var suzuki = new Car { Make = "Suzuki", Model = string.Empty, Color = "Blue", Year = 2022 };
        Car toyota = new("", "Camry");

        //compilation error due to missing required members
        //Car car = new();
        //var someCar = new Car { Model = string.Empty, Color = "Red", Year = 2020 };
    }
}
public class Car
{
    public Car() { }

    [SetsRequiredMembers]
    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public required string Make { get; init; }
    public required string Model { get; set; }
    public string? Color { get; set; }
    public int? Year { get; set; }
}