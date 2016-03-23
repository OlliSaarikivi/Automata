using Microsoft.CodeAnalysis;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration
{
    abstract class Accessor : AccessorOrMutator
    {
        public Accessor Next { get; private set; }

        public Accessor(Accessor next)
        {
            Next = next;
        }

        public override Mutator GetMutator(IAccessorVisitor visitor)
        {
            return AcceptExtract(visitor);
        }

        public abstract Mutator AcceptAssignment(IAccessorVisitor visitor, Mutator value);
        public abstract Mutator AcceptExtract(IAccessorVisitor visitor);

        public void Append(Accessor rightAccessor)
        {
            if (Next != null)
            {
                Next.Append(rightAccessor);
            }
            else
            {
                Next = rightAccessor;
            }
        }
    }

    class FieldAccessor : Accessor
    {
        public IFieldSymbol Symbol { get; private set; }

        public FieldAccessor(IFieldSymbol symbol, Accessor next = null)
            : base(next)
        {
            Symbol = symbol;
        }

        public override Mutator AcceptAssignment(IAccessorVisitor visitor, Mutator value)
        {
            return visitor.WithAssignment(this, value);
        }

        public override Mutator AcceptExtract(IAccessorVisitor visitor)
        {
            return visitor.Extract(this);
        }
    }

    class LocalAccessor : Accessor
    {
        public ILocalSymbol Symbol { get; private set; }

        public LocalAccessor(ILocalSymbol symbol, Accessor next = null)
            : base(next)
        {
            Symbol = symbol;
        }

        public override Mutator AcceptAssignment(IAccessorVisitor visitor, Mutator value)
        {
            return visitor.WithAssignment(this, value);
        }

        public override Mutator AcceptExtract(IAccessorVisitor visitor)
        {
            return visitor.Extract(this);
        }
    }

    class ParameterAccessor : Accessor
    {
        public IParameterSymbol Symbol { get; private set; }

        public ParameterAccessor(IParameterSymbol symbol, Accessor next = null)
            : base(next)
        {
            Symbol = symbol;
        }

        public override Mutator AcceptAssignment(IAccessorVisitor visitor, Mutator value)
        {
            return visitor.WithAssignment(this, value);
        }

        public override Mutator AcceptExtract(IAccessorVisitor visitor)
        {
            return visitor.Extract(this);
        }
    }
}
