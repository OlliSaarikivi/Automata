using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators
{
    class BigIntMutator : LeafExprMutator<BigIntSortMapping, IntSort, IntExpr>
    {
        public BigIntMutator(BigIntSortMapping sortMapping, IntExpr initialValue)
            : base(sortMapping, initialValue)
        {
        }

        public override Mutator WithValue(Expr value)
        {
            try
            {
                return new BigIntMutator(_sortMapping, (IntExpr)value);
            }
            catch (InvalidCastException)
            {
                throw new SymbolicExplorationException("Value is not an integer");
            }
        }
    }
}
