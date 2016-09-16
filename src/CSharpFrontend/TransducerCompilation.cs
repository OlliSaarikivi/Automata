using Microsoft.Automata;
using Microsoft.CodeAnalysis;
using Microsoft.Automata.CSharpFrontend.Runtime.Transducer;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend
{
    abstract class TransducerCompilation
    {
        public INamedTypeSymbol DeclarationType { get; private set; }
        public HashSet<ShowGraph.Stage> ShowGraphStages { get; set; }
        public abstract STb<FuncDecl, Expr, Sort> Transducer { get; }
        /// <summary>
        /// The background functions used in this transducer for which code has to be generated.
        /// </summary>
        public abstract IEnumerable<Tuple<FuncDecl, Expr, Expr[]>> FunctionBodies { get; }
        public abstract ITypeSymbol InputTypeSymbol { get; }
        public abstract ITypeSymbol OutputTypeSymbol { get; }

        public bool UseMinimization { get; set; }

        public TransducerCompilation(INamedTypeSymbol declarationType)
        {
            DeclarationType = declarationType;
            ShowGraphStages = new HashSet<ShowGraph.Stage>();
        }
    }
}
