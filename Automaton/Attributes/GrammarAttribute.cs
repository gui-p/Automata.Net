using System.Runtime.CompilerServices;

namespace Automaton.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    [Alphabet('A', 'B', 'C', 'D', 'E', 'F')]
    public class GrammarAttribute : Attribute
    {
    
    }
}
