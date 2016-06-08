using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime.Transducer
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class HuffmanDecoder : Attribute
    {
        public HuffmanDecoder(string exampleFile)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class HuffmanEncoder : Attribute
    {
        public HuffmanEncoder(string exampleFile)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class ParsingMatcher : Attribute
    {
        public ParsingMatcher(string regex, string type)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class XPathMatcher : Attribute
    {
        public XPathMatcher(string xpath, string type)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class ShowGraph : Attribute
    {
        public enum Stage {
            UnSimplified, Simplified
        }

        public ShowGraph(Stage stage = Stage.Simplified)
        {
        }
    }
}
