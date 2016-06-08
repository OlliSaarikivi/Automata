using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    public static partial class InstructionSet<Domain>
    {
        //static TComp OpOn<TComp>(object inner, Func<TComp, TComp> replace, Func<TComp> extend)
        //{
        //    return inner is TComp ? replace((TComp)inner) : extend();
        //}
        //static TotalComputation<Domain, NewRange> OpOn<TComp, NewRange>(object inner, Func<TComp, TotalComputation<Domain, NewRange>> replace, Func<TotalComputation<Domain, NewRange>> extend)
        //{
        //    return inner is TComp ? replace((TComp)inner) : extend();
        //}

        //static TotalComputation<Domain, NewRange> IfConstant<Range, NewRange>(object inner, Func<Constant<Domain, Range>, NewRange> constantPropagation,
        //    Func<TotalComputation<Domain, NewRange>> otherwise)
        //{
        //    return inner is Constant<Domain, Range> ? Constant(constantPropagation((Constant<Domain, Range>)inner)) : otherwise();
        //}

        public static Identity<Domain> Identity()
        {
            return Identity<Domain>.Instance;
        }

        public static Constant<Domain, Range> Constant<Range>(Range value)
        {
            return new Constant<Domain, Range>(value);
        }

        public static Constant<Domain, bool> Constant(bool value)
        {
            return value ? Constants<Domain>.True : Constants<Domain>.False;
        }

        public static Undefined<Domain> Undef()
        {
            return Undefined<Domain>.Instance;
        }
    }
}
