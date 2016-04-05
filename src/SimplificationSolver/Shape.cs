using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.SimplificationSolver
{
    class Shape
    {
        public FuncDecl Declaration { get; set; }
        public Expr Body { get; set; }
        public List<Expr> Parameters { get; private set; } = new List<Expr>();
        public Expr Composition { get; set; }
        public Expr CompositionTemplate { get; set; }
    }
}
