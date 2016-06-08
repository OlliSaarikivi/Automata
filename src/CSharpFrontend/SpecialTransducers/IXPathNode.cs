using CodePlex.XPathParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SpecialTransducers
{
    interface IXPathNode
    {
    }

    class XPathAxisNode : IXPathNode
    {
        public XPathAxis Axis { get; set; }
        public System.Xml.XPath.XPathNodeType Type { get; set; }
        public string Label { get; set; }

        public override string ToString()
        {
            return Axis.ToString() + ":" + Type + ":" + Label;
        }
    }

    class XPathStepNode : IXPathNode
    {
        public IXPathNode Left { get; set; }
        public IXPathNode Right { get; set; }

        public override string ToString()
        {
            var leftString = Left.ToString().Replace("\n", "\n\t");
            var rightString = Right.ToString().Replace("\n", "\n\t");
            return "Step\n\t" + leftString + "\n\t" + rightString;
        }
    }

}
