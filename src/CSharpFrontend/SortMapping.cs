using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Automata.CSharpFrontend.CodeGeneration;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend
{
    /// <summary>
    /// Represents a C# type. Maps the type to a Z3 sort and a symbolic type for code generation.
    /// </summary>
    abstract class SortMapping
    {
        public Context Ctx { get { return _info.Ctx; } }
        public TypeSymbolToSortMapper Mapper { get { return _info.Mapper; } }
        public abstract Sort Sort { get; }

        protected CompilationInfo _info;

        public SortMapping(CompilationInfo info)
        {
            _info = info;
        }

        public abstract Mutator MutatorForValue(Expr initialValue);
        public abstract Mutator MutatorForDefaultValue();
    }

    #region Convenience base classes

    abstract class BaseSortMapping<TSort> : SortMapping
        where TSort : Sort
    {
        public override Sort Sort
        {
            get
            {
                return _sort;
            }
        }

        protected TSort _sort;

        public BaseSortMapping(CompilationInfo info)
            : base(info)
        {
        }

        public BaseSortMapping(CompilationInfo info, TSort sort)
            : base(info)
        {
            _sort = sort;
        }
    }

    abstract class SortMapping<TSort> : BaseSortMapping<TSort>
        where TSort : Sort
    {
        public new TSort Sort
        {
            get
            {
                return _sort;
            }
            protected set
            {
                _sort = value;
            }
        }

        public SortMapping(CompilationInfo info)
            : base(info)
        {
        }

        public SortMapping(CompilationInfo info, TSort sort)
            : base(info, sort)
        {
        }
    }

    #endregion

    class BoolSortMapping : SortMapping<BoolSort>
    {
        public BoolSortMapping(CompilationInfo info)
            : base(info, info.Ctx.BoolSort)
        {
        }

        public override Mutator MutatorForValue(Expr initialValue)
        {
            Contract.Requires(initialValue.Sort == Sort);
            return new BoolMutator(this, (BoolExpr)initialValue);
        }

        public override Mutator MutatorForDefaultValue()
        {
            return new BoolMutator(this, Ctx.MkBool(default(bool)));
        }
    }

    // Z3 bitvectors
    class IntSortMapping : SortMapping<BitVecSort>
    {
        public bool IsSigned { get; private set; }

        public IntSortMapping(CompilationInfo info, bool isSigned, uint size)
            : base(info, info.Ctx.MkBitVecSort(size))
        {
            IsSigned = isSigned;
        }

        public override Mutator MutatorForValue(Expr initialValue)
        {
            Contract.Requires(initialValue.Sort == Sort);
            return new IntMutator(this, (BitVecExpr)initialValue);
        }

        public override Mutator MutatorForDefaultValue()
        {
            return new IntMutator(this, Ctx.MkBV(0, Sort.Size));
        }
    }

    // Z3 Ints
    class BigIntSortMapping : SortMapping<IntSort>
    {
        public BigIntSortMapping(CompilationInfo info)
            : base(info, info.Ctx.IntSort)
        {
        }

        public override Mutator MutatorForValue(Expr initialValue)
        {
            Contract.Requires(initialValue.Sort == Sort);
            return new BigIntMutator(this, (IntExpr)initialValue);
        }

        public override Mutator MutatorForDefaultValue()
        {
            return new BigIntMutator(this, Ctx.MkInt(0));
        }
    }
}
