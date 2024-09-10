namespace Automaton
{
    [AttributeUsage(System.AttributeTargets.Class)]
    public class AuthorAttribute(string name) : Attribute
    {
        public double Version {get; set;} = 1.0;
        public string Name { get; private set; } = name;
    }
}