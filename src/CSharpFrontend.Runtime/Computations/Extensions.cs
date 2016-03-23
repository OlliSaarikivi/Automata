using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    static class InternalExtensions
    {
        public static string ToSeparatedString<T>(this IEnumerable<T> elements, string ifEmpty = "", string separator = ",")
        {
            string list = null;
            foreach (var comp in elements)
            {
                if (list == null)
                {
                    list = comp.ToString();
                }
                else
                {
                    list += ',' + comp.ToString();
                }
            }
            return list != null ? list : ifEmpty;
        }

        public static string Indent(this string lines)
        {
            return "  " + new string(lines.SelectMany(x => x == '\n' ? x.ToString() + "  " : x.ToString()).ToArray());
        }

        public static V GetOrCreate<K, V>(this Dictionary<K, V> dict, K key, Func<V> creator)
        {
            V value;
            if (!dict.TryGetValue(key, out value))
            {
                value = creator();
                dict.Add(key, value);
            }
            return value;
        }
    }
}
