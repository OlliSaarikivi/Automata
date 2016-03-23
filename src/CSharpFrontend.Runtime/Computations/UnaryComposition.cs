using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    [Serializable]
    public abstract class UnaryCompositionBase<Domain, Interface, Range> : TotalComputation<Domain, Range>
    {
        public TotalComputation<Domain, Interface> Inner { get; private set; }

        public UnaryCompositionBase(TotalComputation<Domain, Interface> inner)
        {
            Inner = inner;
        }

        public abstract TotalComputation<Domain, Range> WithInner(TotalComputation<Domain, Interface> newInner);

        protected abstract string OuterToString();
        public override string ToString()
        {
            if (Inner is Identity<Domain>)
            {
                return OuterToString();
            }
            else
            {
                return "(" + Inner.ToString() + "∘" + OuterToString() + ")";
            }
        }

        protected virtual TotalComputation<Domain, Range> OuterSimplify(Context<Domain> context)
        {
            return this;
        }
        public override TotalComputation<Domain, Range> Simplify(Context<Domain> context)
        {
            Inner = Inner.Simplify(context);
            return OuterSimplify(context);
        }

        protected abstract bool OuterEquals(UnaryCompositionBase<Domain, Interface, Range> obj);
        public override bool Equals(object obj)
        {
            if (obj == this) return true;
            var casted = obj as UnaryCompositionBase<Domain, Interface, Range>;
            if (casted != null)
            {
                return OuterEquals(casted) && Inner.Equals(casted.Inner);
            }
            return false;
        }

        [NonSerialized]
        int? _hash;
        protected abstract int OuterGetHashCode();
        public override int GetHashCode()
        {
            if (!_hash.HasValue)
            {
                _hash = Utils.HashCombine(Inner.GetHashCode(), OuterGetHashCode());
            }
            return _hash.Value;
        }
    }

    [Serializable]
    public abstract class UnaryComposition<Domain, Interface, Range> : UnaryCompositionBase<Domain, Interface, Range>
    {
        public UnaryComposition(TotalComputation<Domain, Interface> inner)
            : base(inner)
        {
        }

        public abstract Range ApplyOuter(Interface argument);

        public sealed override Range Apply(Domain argument)
        {
            return ApplyOuter(Inner.Apply(argument));
        }
    }
}
