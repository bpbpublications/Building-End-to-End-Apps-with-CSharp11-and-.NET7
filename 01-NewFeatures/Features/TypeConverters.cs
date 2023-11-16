using System.ComponentModel;
namespace _01_NewFeatures.Features;

internal class TypeConverters
{
    public void Demo()
    {
        // DateOnly TypeConverter
        var dateOnly = TypeDescriptor.GetConverter(typeof(DateOnly))
            .ConvertFromString("2022-11-08") as DateOnly?;
        
        // TimeOnly TypeConverter
        var timeOnly = TypeDescriptor.GetConverter(typeof(TimeOnly))
            .ConvertFromString("19:45:30") as TimeOnly?;
        
        // Half TypeConverter
        var half = TypeDescriptor.GetConverter(typeof(Half))
            .ConvertFromString(((Half)(-100.5)).ToString()) as Half?;
        
        // Int128 TypeConverter
        var int128 = TypeDescriptor.GetConverter(typeof(Int128))
            .ConvertFromString("-1701") as Int128?;
        
        // UInt128 TypeConverter
        var uint128 = TypeDescriptor.GetConverter(typeof(UInt128))
            .ConvertFromString("3402823669209") as UInt128?;
    }
}