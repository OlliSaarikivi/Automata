using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    [Serializable]
    public class ListComputation<Domain, ElementRange> : TotalComputation<Domain, IEnumerable<ElementRange>>, ISerializable
    {
        public ImmutableList<TotalComputation<Domain, ElementRange>> ElementComps { get; private set; }

        public ListComputation(ImmutableList<TotalComputation<Domain, ElementRange>> elementComps)
        {
            ElementComps = elementComps;
        }

        public override IEnumerable<ElementRange> Apply(Domain argument)
        {
            return ElementComps.ConvertAll(x => x.Apply(argument));
        }

        public override string ToString()
        {
            return "[" + ElementComps.ToSeparatedString() + "]";
        }

        public override void AddAssertions(Context<Domain> context, bool negate)
        {
        }

        public override TotalComputation<Domain, IEnumerable<ElementRange>> Simplify(Context<Domain> context)
        {
            //for (int i = 0; i < ElementComps.Length; ++i)
            //{
            //    ElementComps[i] = ElementComps[i].Simplify(context);
            //}
            return this;
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("e", ElementComps.ToArray());
        }

        public ListComputation(SerializationInfo info, StreamingContext context)
        {
            ElementComps = ((TotalComputation<Domain, ElementRange>[])info.GetValue("e", typeof(TotalComputation<Domain, ElementRange>[]))).ToImmutableList();
        }
    }

    [Serializable]
    public class Append<Domain, ElementRange> : TotalComputation<Domain, IEnumerable<ElementRange>>
    {
        public TotalComputation<Domain, IEnumerable<ElementRange>> Prefix { get; private set; }
        public TotalComputation<Domain, IEnumerable<ElementRange>> Postfix { get; private set; }

        public Append(TotalComputation<Domain, IEnumerable<ElementRange>> prefix, TotalComputation<Domain, IEnumerable<ElementRange>> postfix)
        {
            Prefix = prefix;
            Postfix = postfix;
        }

        public override IEnumerable<ElementRange> Apply(Domain argument)
        {
            return Prefix.Apply(argument).Concat(Postfix.Apply(argument));
        }

        public override string ToString()
        {
            return "(" + Prefix + ":" + Postfix + ")";
        }

        //protected override TotalComputation<Domain, IEnumerable<ElementRange>> OuterSimplify(Context<Domain> context)
        //{
        //    //Postfix = Postfix.Simplify(context);
        //    return this;
        //}

        public override void AddAssertions(Context<Domain> context, bool negate)
        {
            throw new NotImplementedException();
        }

        //protected override bool OuterEquals(UnaryCompositionBase<Domain, IEnumerable<ElementRange>, IEnumerable<ElementRange>> obj)
        //{
        //    throw new NotImplementedException();
        //}

        //protected override int OuterGetHashCode()
        //{
        //    throw new NotImplementedException();
        //}

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public static partial class InstructionSet<Domain>
    {
        public static TotalComputation<Domain, IEnumerable<ElementRange>> List<ElementRange>(params TotalComputation<Domain, ElementRange>[] elements)
        {
            //var consts = new ElementRange[elements.Length];
            //for (int i = 0; i < elements.Length; ++i)
            //{
            //    var elementConst = elements[i] as Constant<Domain, ElementRange>;
            //    if (elementConst != null)
            //    {
            //        consts[i] = elementConst.Value;
            //    }
            //    else
            //    {
                    return new ListComputation<Domain, ElementRange>(elements.ToImmutableList());
            //    }
            //}
            //return InstructionSet<Domain>.Constant<IEnumerable<ElementRange>>(consts);
        }

        public static TotalComputation<Domain, IEnumerable<ElementRange>> Append<ElementRange>(TotalComputation<Domain, IEnumerable<ElementRange>> prefix, TotalComputation<Domain, IEnumerable<ElementRange>> postfix)
        {
            var append = prefix as Append<Domain, ElementRange>;
            if (append != null)
            {
                return Append(append.Prefix, Append(append.Postfix, postfix));
            }

            var prefixConst = prefix as Constant<Domain, IEnumerable<ElementRange>>;
            var postfixConst = postfix as Constant<Domain, IEnumerable<ElementRange>>;
            var prefixList = prefix as ListComputation<Domain, ElementRange>;
            var postfixList = postfix as ListComputation<Domain, ElementRange>;
            if (prefixConst != null)
            {
                if (postfixConst != null)
                {
                    return InstructionSet<Domain>.Constant<IEnumerable<ElementRange>>(prefixConst.Value.Concat(postfixConst.Value));
                }
                else if (postfixList != null)
                {
                    return new ListComputation<Domain, ElementRange>(postfixList.ElementComps.InsertRange(0, prefixConst.Value.Select(x => InstructionSet<Domain>.Constant(x))));
                }
            }
            else if (prefixList != null)
            {
                if (postfixConst != null)
                {
                    return new ListComputation<Domain, ElementRange>(prefixList.ElementComps.AddRange(postfixConst.Value.Select(x => InstructionSet<Domain>.Constant(x))));
                }
                else if (postfixList != null)
                {
                    return new ListComputation<Domain, ElementRange>(prefixList.ElementComps.AddRange(postfixList.ElementComps));
                }
            }
            return new Append<Domain, ElementRange>(prefix, postfix);
        }
    }
}
