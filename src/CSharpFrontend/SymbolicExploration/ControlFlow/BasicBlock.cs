using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration.ControlFlow
{
    class BasicBlock
    {
        public List<CSharpSyntaxNode> Nodes { get; private set; }
        public Terminator Terminator { get; set; }

        public BasicBlock(Terminator terminator)
        {
            Nodes = new List<CSharpSyntaxNode>();
            Terminator = terminator;
        }
    }
}
