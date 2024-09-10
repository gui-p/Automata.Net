using Automaton.Attributes;

namespace Automaton.Languages
{
    [Author("gui-p", Version = 1.0)]
    [Alphabet('a', 'b', 'c')]
    public class Language
    {
        public List<string> Strings {get;} = [];
    }

}

