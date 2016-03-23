using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.CodeGeneration
{
    class ComputationTree
    {
        public ComputationNode Move { get; set; }
        public ComputationNode Finish { get; set; }
        public Expr InitialState { get; set; }
        public EnumSort[] EnumSorts { get; set; }
    }
}
