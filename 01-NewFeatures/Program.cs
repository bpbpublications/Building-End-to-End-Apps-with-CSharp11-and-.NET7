using _01_NewFeatures.Exercises;
using _01_NewFeatures.Features;

#region Feature Demo

new AutoDefaultStructure().Demo();

new ExtendedNameOfScope().Demo(new List<int> { 1, 2, 3 });

new GenericMath().Demo();

new ListPatterns().Demo();

new MicroAndNanoSeconds().Demo();

new NewlineInStringInterpolation().Demo();

new PatternMatchingWithSpanChar().Demo();

new RawStringLiterals().Demo();

new RegexSourceGenerator().Demo();

new RequiredMembers().Demo();

new SimplifiedOrdering().Demo();

new StreamReading().Demo();

new TarAPI().Demo();

new TypeConverters().Demo();

new UTF8Strings().Demo();

#endregion

#region Exercises

new _01().Run();
new _02().Run();

#endregion

Console.ReadKey();