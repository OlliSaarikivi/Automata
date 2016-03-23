using Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration
{
    interface IAccessorVisitor
    {
        Mutator WithAssignment(FieldAccessor accessor, Mutator value);
        Mutator WithAssignment(LocalAccessor accessor, Mutator value);
        Mutator WithAssignment(ParameterAccessor accessor, Mutator value);

        Mutator Extract(FieldAccessor accessor);
        Mutator Extract(LocalAccessor accessor);
        Mutator Extract(ParameterAccessor accessor);
    }
}
