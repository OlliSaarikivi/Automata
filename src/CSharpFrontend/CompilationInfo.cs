using Microsoft.Automata.Z3;
using Microsoft.CodeAnalysis;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend
{
    // Helper class for passing around this set of classes that are commonly used together
    class CompilationInfo
    {
        public Z3Provider AutomataCtx { get; set; }
        public Context Ctx { get { return AutomataCtx.Z3; } }
        public TypeSymbolToSortMapper Mapper { get; set; }
        public SemanticModel Model { get; set; }
        public InvocationExplorer InvocationExplorer { get; set; }
        public MethodLifter Lifter { get; set; }
    }
}
