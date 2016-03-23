using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators
{
    /// <summary>
    /// Encapsulates construction of Z3 expressions representing updates. Mutators instances are immutable and all
    /// operations on them return new instances.
    /// </summary>
    abstract class Mutator : AccessorOrMutator, IAccessorVisitor
    {
        public override Mutator GetMutator(IAccessorVisitor visitor)
        {
            return this;
        }

        public abstract SortMapping GetSortMapping();

        public abstract Expr CreateUpdate();

        public virtual Mutator Cast(SortMapping target)
        {
            if (target == GetSortMapping())
            {
                return this;
            }
            throw new SymbolicExplorationException("Cast from " + GetSortMapping() + " to " + target + " undefined");
        }

        public virtual Mutator WithValue(Expr value)
        {
            throw new NotImplementedException();
        }

        public Mutator WithAssignment(Accessor accessor, Mutator value)
        {
            if (accessor == null)
            {
                return value.Cast(GetSortMapping());
            }
            else
            {
                return accessor.AcceptAssignment(this, value);
            }
        }
        public virtual Mutator WithAssignment(FieldAccessor accessor, Mutator value)
        {
            throw new NotImplementedException();
        }
        public Mutator WithAssignment(LocalAccessor accessor, Mutator value)
        {
            Debug.Assert(false, "A local access reached a Mutator?!");
            throw new NotImplementedException();
        }
        public Mutator WithAssignment(ParameterAccessor accessor, Mutator value)
        {
            Debug.Assert(false, "A parameter access reached a Mutator?!");
            throw new NotImplementedException();
        }

        public Mutator Extract(Accessor accessor)
        {
            if (accessor == null)
            {
                return this;
            }
            else
            {
                return accessor.AcceptExtract(this);
            }
        }
        public virtual Mutator Extract(FieldAccessor accessor)
        {
            throw new NotImplementedException();
        }
        public Mutator Extract(LocalAccessor accessor)
        {
            Debug.Assert(false, "A local access reached a Mutator?!");
            throw new NotImplementedException();
        }
        public Mutator Extract(ParameterAccessor accessor)
        {
            Debug.Assert(false, "A parameter access reached a Mutator?!");
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Convenience class for a mutator for a specific <see cref="SortMapping"/> and Z3 sort
    /// </summary>
    /// <typeparam name="TSortMapping"></typeparam>
    /// <typeparam name="TSort"></typeparam>
    abstract class Mutator<TSortMapping, TSort> : Mutator
        where TSortMapping : SortMapping<TSort>
        where TSort : Sort
    {
        protected readonly TSortMapping _sortMapping;

        public override SortMapping GetSortMapping()
        {
            return _sortMapping;
        }

        protected Context Ctx
        {
            get
            {
                return _sortMapping.Ctx;
            }
        }

        protected TSort Sort
        {
            get
            {
                return _sortMapping.Sort;
            }
        }

        public Mutator(TSortMapping sortMapping)
        {
            _sortMapping = sortMapping;
        }
    }

    abstract class LeafExprMutator<TSortMapping, TSort, TExpr> : Mutator<TSortMapping, TSort>
        where TSortMapping : SortMapping<TSort>
        where TSort : Sort
        where TExpr : Expr
    {
        public TExpr Value { get; private set; }

        public LeafExprMutator(TSortMapping sortMapping, TExpr initialValue)
            : base(sortMapping)
        {
            Value = initialValue;
        }

        public override Expr CreateUpdate()
        {
            return Value;
        }
    }
}
