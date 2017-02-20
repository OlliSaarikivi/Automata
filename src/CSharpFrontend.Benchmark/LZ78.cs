using Microsoft.Automata.CSharpFrontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    class LZ78Encoder
    {
        Dictionary<string, int> patternIndices = new Dictionary<string, int>();
        string pattern = "";
        int previousIndex = -1;
        char previousChar = '\0';
        int index = 0;
        int newIndex = 1;

        public IEnumerable<Tuple<int, char>> Update(char c)
        {
            pattern += c;
            if (patternIndices.ContainsKey(pattern))
            {
                previousIndex = index;
                previousChar = c;
                index = patternIndices[pattern];
            }
            else
            {
                yield return Tuple.Create(index, c);
                patternIndices[pattern] = newIndex++;
                pattern = "";
                previousIndex = -1;
                previousChar = '\0';
                index = 0;
            }
        }

        public IEnumerable<Tuple<int, char>> Finish()
        {
            if (previousIndex >= 0)
            {
                yield return Tuple.Create(previousIndex, previousChar);
            }
        }
    }

    class LZ78Decoder
    {
        Dictionary<int, string> indexPatterns = new Dictionary<int, string>();
        int newIndex = 1;

        public IEnumerable<char> Update(Tuple<int, char> e)
        {
            int index = e.Item1;
            char append = e.Item2;
            if (index == 0)
            {
                yield return append;
                indexPatterns[newIndex] = "" + append;
            }
            else
            {
                if (indexPatterns.ContainsKey(index))
                {
                    foreach (char c in indexPatterns[index]) yield return c;
                    yield return append;
                    indexPatterns[newIndex] = indexPatterns[index] + append;
                }
                else
                {
                    throw new Exception();
                }
            }
            ++newIndex;
        }
    }
}
