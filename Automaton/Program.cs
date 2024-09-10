using Automaton;

Language language = new();
language.Strings.Add("Hello world!");

Console.WriteLine(language.Strings[0]);

Attribute[] attributes = Attribute.GetCustomAttributes(typeof(Language));
foreach(Attribute attr in attributes)
{
    if (attr is AuthorAttribute author)
    {
        string name = author.Name;
        double v = author.Version;

        Console.WriteLine($"Author={name} and Version={v}");
    }
}