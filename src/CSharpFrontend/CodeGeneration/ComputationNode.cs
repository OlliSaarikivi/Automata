using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.CodeGeneration
{
    abstract class ComputationNode
    {
        public ComputationNode[] Children { get; private set; }

        public ComputationNode(params ComputationNode[] children)
        {
            Children = children;
        }
    }

    class IteNode : ComputationNode
    {
        public Expr Condition { get; private set; }
        public ComputationNode IfTrue { get { return Children[0]; } }
        public ComputationNode IfFalse { get { return Children[1]; } }

        public IteNode(Expr condition, ComputationNode ifTrue, ComputationNode ifFalse)
            : base(ifTrue, ifFalse)
        {
            Condition = condition;
        }
    }

    class SwitchNode : ComputationNode
    {
        public Expr[] Cases { get; private set; }

        public SwitchNode(Expr[] cases, ComputationNode[] children)
            : base(children)
        {
            Cases = cases;
        }
    }

    class UndefinedNode : ComputationNode
    {
        public UndefinedNode()
            : base()
        {
        }
    }

    class ResultNode : ComputationNode
    {
        public Expr Value { get; private set; }

        public ResultNode(Expr value)
            : base()
        {
            Value = value;
        }
    }
}
