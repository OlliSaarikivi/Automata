using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    class LZWEncoder
    {
        Dictionary<string, long> patternIndices = new Dictionary<string, long>();
        long nextIndex = 256;
        string pattern = "";
        long currentIndex = 0;

        public LZWEncoder()
        {
            for (int i = 0; i < 256; ++i)
            {
                patternIndices["" + ((char)i)] = i + 1;
            }
        }

        public IEnumerable<long> Update(byte c)
        {
            pattern += (char)c;
            if (!patternIndices.ContainsKey(pattern))
            {
                yield return currentIndex;
                patternIndices[pattern] = nextIndex++;
                pattern = "" + (char)c;
            }
            currentIndex = patternIndices[pattern];
        }

        public IEnumerable<long> Finish()
        {
            if (currentIndex > 0)
            {
                yield return currentIndex;
            }
        }
    }

    class LZWDecoder
    {
        Dictionary<long, string> patternIndices = new Dictionary<long, string>();
        HashSet<string> patterns = new HashSet<string>();
        long nextIndex = 256;
        string pattern = "";

        public LZWDecoder()
        {
            for (int i = 0; i < 256; ++i)
            {
                patternIndices[i + 1] = "" + ((char)i);
                patterns.Add("" + ((char)i));
            }
        }

        public IEnumerable<byte> Update(long i)
        {
            if (i == nextIndex)
            {
                var oldPattern = pattern;
                foreach (char c in oldPattern)
                {
                    pattern += c;
                    if (!patterns.Contains(pattern))
                    {
                        patternIndices[nextIndex++] = pattern;
                        patterns.Add(pattern);
                        pattern = oldPattern;
                        break;
                    }
                }
            }

            if (!patternIndices.ContainsKey(i))
            {
                throw new Exception();
            }
            string decoded = patternIndices[i];
            foreach (char c in decoded)
            {
                yield return (byte)c;
                pattern += c;
                if (!patterns.Contains(pattern))
                {
                    patternIndices[nextIndex++] = pattern;
                    patterns.Add(pattern);
                    pattern = "" + c;
                }
            }
        }
    }
}
