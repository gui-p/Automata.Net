namespace Automaton;

[AttributeUsage(AttributeTargets.Class)]
public class AlphabetAttribute(params char[] symbols) : Attribute
{
    public List<char> Symbols { get; private set; } = [.. symbols];

    public override string ToString()
    {
        return string.Join("", Symbols);
    }
}