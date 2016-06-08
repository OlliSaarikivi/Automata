using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators
{
    class BoolMutator : LeafExprMutator<BoolSortMapping, BoolSort, BoolExpr>
    {
        public BoolMutator(BoolSortMapping sortMapping, BoolExpr initialValue)
            : base(sortMapping, initialValue)
        {
        }

        public override Mutator WithValue(Expr value)
        {
            try
            {
                return new BoolMutator(_sortMapping, (BoolExpr)value);
            }
            catch (InvalidCastException)
            {
                throw new SymbolicExplorationException("Value is not a boolean");
            }
        }
    }
}
