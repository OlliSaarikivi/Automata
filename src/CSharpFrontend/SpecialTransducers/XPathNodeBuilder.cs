using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using CodePlex.XPathParser;

namespace Microsoft.Automata.CSharpFrontend.SpecialTransducers
{
    class XPathNodeBuilder : IXPathBuilder<IXPathNode>
    {
        public void StartBuild() { }

        public IXPathNode EndBuild(IXPathNode result)
        {
            return result;
        }

        public IXPathNode Axis(XPathAxis axis, XPathNodeType type, string prefix, string name)
        {
            string label = name;
            if ((prefix ?? "") != "")
                label = prefix + ":" + name;
            return new XPathAxisNode
            {
                Axis = axis,
                Type = type,
                Label = label,
            };
        }

        public IXPathNode JoinStep(IXPathNode left, IXPathNode right)
        {
            return new XPathStepNode
            {
                Left = left,
                Right = right,
            };
        }


        public IXPathNode Function(string prefix, string name, IList<IXPathNode> args)
        {
            throw new NotImplementedException();
        }

        public IXPathNode Number(string value)
        {
            throw new NotImplementedException();
        }

        public IXPathNode Operator(XPathOperator op, IXPathNode left, IXPathNode right)
        {
            throw new NotImplementedException();
        }

        public IXPathNode Predicate(IXPathNode node, IXPathNode condition, bool reverseStep)
        {
            throw new NotImplementedException();
        }

        public IXPathNode String(string value)
        {
            throw new NotImplementedException();
        }

        public IXPathNode Variable(string prefix, string name)
        {
            throw new NotImplementedException();
        }
    }
}
