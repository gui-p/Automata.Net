using System.Reflection;
using Automaton;

var assembly = Assembly.GetExecutingAssembly();
Type[] types = assembly.GetExportedTypes();

foreach (var type in types)
{
    AlphabetAttribute? attr = type.GetCustomAttribute<AlphabetAttribute>();
    if ( attr is not null)
    {
        Console.WriteLine($"Language {type.FullName} has alphabet \"{attr}\"");
    }    
}

