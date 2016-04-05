using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.SimplificationSolver
{
    class Program
    {
        public Expr Body { get; set; }
        public Expr StateParam { get; set; }
        public Expr InputParam { get; set; }
        public List<Shape> Shapes { get; private set; } = new List<Shape>();
        public Expr InitialApplication { get; set; }
    }
}
