using System.Collections;

namespace Automaton.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AlphabetAttribute(params char[] symbols) : Attribute, ICollection<char>
    {
        public List<char> Symbols { get; private set; } = [.. symbols];

        public IEnumerator<char> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Join("", Symbols);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(char item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(char item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(char[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(char item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }
}

