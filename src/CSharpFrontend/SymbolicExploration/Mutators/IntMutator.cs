using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators
{
    class IntMutator : LeafExprMutator<IntSortMapping, BitVecSort, BitVecExpr>
    {
        bool IsSigned
        {
            get
            {
                return _sortMapping.IsSigned;
            }
        }

        uint Size
        {
            get
            {
                return Sort.Size;
            }
        }

        public IntMutator(IntSortMapping sortMapping, BitVecExpr initialValue)
            : base(sortMapping, initialValue)
        {
        }

        public override Mutator WithValue(Expr value)
        {
            try
            {
                return new IntMutator(_sortMapping, (BitVecExpr)value);
            }
            catch (InvalidCastException)
            {
                throw new SymbolicExplorationException("Value is not a bitvector");
            }
        }

        public override Mutator Cast(SortMapping target)
        {
            var intTarget = target as IntSortMapping;
            if (intTarget != null)
            {
                if (intTarget == _sortMapping)
                {
                    return this;
                }
                else if (intTarget.Sort.Size > Size)
                {
                    return new IntMutator(intTarget,
                        IsSigned ? Ctx.MkSignExt(intTarget.Sort.Size - Size, Value) : Ctx.MkZeroExt(intTarget.Sort.Size - Size, Value));
                }
                else
                {
                    return new IntMutator(intTarget, Ctx.MkExtract(intTarget.Sort.Size - 1, 0, Value));
                }
            }
            return base.Cast(target);
        }
    }
}
