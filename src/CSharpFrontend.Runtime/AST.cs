using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    public class EFSMFactory<Input, Register> where Register : ISemiring<Register>, new()
    {
        public static EFSM<Input, Register> Star(EFSM<Input, Register> r)
        {
            return new Star<Input, Register>(r);
        }
        public static EFSM<Input, Register> Any()
        {
            return new Symbol<Input, Register>((_0, _1, _2) => EFSM<Input, Register>.One, (_0, r) => r);
        }
        public static EFSM<Input, Register> Symbol(Func<int, Input, Register, Register> pred, Func<int, Register, Register> update)
        {
            return new Symbol<Input, Register>(pred, update);
        }
        public static EFSM<Input, Register> Eps()
        {
            return new Eps<Input, Register>();
        }
        public static EFSM<Input, Register> Seq(EFSM<Input, Register> lhs, EFSM<Input, Register> rhs)
        {
            return new Seq<Input, Register>(lhs, rhs);
        }
        public static EFSM<Input, Register> Or(EFSM<Input, Register> lhs, EFSM<Input, Register> rhs)
        {
            return new Or<Input, Register>(lhs, rhs);
        }
    }

    public class EFSMFactory<Input, Policy, SymbolicType> 
        where Policy : IPolicy<Policy, Input, SymbolicType>, ISemiring<Policy>, new()
        where SymbolicType : ISymbolic<SymbolicType>, new()
    {

        private static readonly Func<int, Input, Policy, Func<int, Input, SymbolicType, SymbolicType>, Policy> ApplyPredicate;
        private static readonly Func<int, Policy, Func<int, SymbolicType, SymbolicType>, Policy> ApplyUpdate;
        private static readonly Func<SymbolicType, Policy> FromSymbolic;
        private static readonly SymbolicType Undefined;
        
        static EFSMFactory()
        {
            var builder = new Policy();
            EFSMFactory<Input, Policy, SymbolicType>.ApplyPredicate = builder.ApplyPredicate;
            EFSMFactory<Input, Policy, SymbolicType>.ApplyUpdate = builder.ApplyUpdate;
            EFSMFactory<Input, Policy, SymbolicType>.FromSymbolic = builder.FromSymbolic;

            var symbolicbuilder = new SymbolicType();
            EFSMFactory<Input, Policy, SymbolicType>.Undefined = symbolicbuilder.Undefined;
        }

        public static EFSM<Input, Policy> Star(EFSM<Input, Policy> r)
        {
            return new Star<Input, Policy>(r);
        }
        public static EFSM<Input, Policy> Any()
        {
            return new Symbol<Input, Policy>((_0, _1, _2) => EFSM<Input, Policy>.One, (_0, r) => r);
        }

        public static EFSM<Input, Policy> Symbol(Func<int, Input, SymbolicType, SymbolicType> pred, Func<int, SymbolicType, SymbolicType> update)
        {
            // pass predicate, update, and arguments through to the policy.
            return new Symbol<Input, Policy>(
                (pos, input, reg) => EFSMFactory<Input, Policy, SymbolicType>.ApplyPredicate(pos, input, reg, pred), 
                (pos, reg) => EFSMFactory<Input, Policy, SymbolicType>.ApplyUpdate(pos, reg, update)
                );
        }

        public static EFSM<Input, Policy> Symbol(Func<int, Input, bool> pred, Func<int, SymbolicType, SymbolicType> update)
        {
            Func<int, Input, SymbolicType, SymbolicType> wrappedpred = (pos, input, reg) =>
            {
                // if predicate is true just return the register unchanged
                if (pred(pos, input)) return reg;
                // else if predicate is false, return the undefined symbolic type.
                return EFSMFactory<Input, Policy, SymbolicType>.Undefined;
            };

            return EFSMFactory<Input, Policy, SymbolicType>.Symbol(wrappedpred, update);
        }

        public static EFSM<Input, Policy> Symbol(Func<int, Input, SymbolicType, bool> pred, Func<int, SymbolicType, SymbolicType> update)
        {
            Func<int, Input, SymbolicType, SymbolicType> wrappedpred = (pos, input, reg) =>
            {
                // if predicate is true just return the register unchanged
                if (pred(pos, input, reg)) return reg;
                // else if predicate is false, return the undefined symbolic type.
                return EFSMFactory<Input, Policy, SymbolicType>.Undefined;
            };

            return EFSMFactory<Input, Policy, SymbolicType>.Symbol(wrappedpred, update);
        }

        
        public static EFSM<Input, Policy> Eps()
        {
            return new Eps<Input, Policy>();
        }
        public static EFSM<Input, Policy> Seq(EFSM<Input, Policy> lhs, EFSM<Input, Policy> rhs)
        {
            return new Seq<Input, Policy>(lhs, rhs);
        }
        public static EFSM<Input, Policy> Or(EFSM<Input, Policy> lhs, EFSM<Input, Policy> rhs)
        {
            return new Or<Input, Policy>(lhs, rhs);
        }
    }
    public abstract class EFSM<Input, Register> where Register : ISemiring<Register>, new()
    {
        internal static readonly Register Zero;
        internal static readonly Register One;
        protected static readonly Func<Register, Register, Register> Add;
        protected static readonly Func<Register, Register, Register> Mul;

        static EFSM()
        {
            var builder = new Register();
            EFSM<Input, Register>.Zero = builder.Zero;
            EFSM<Input, Register>.One = builder.One;
            EFSM<Input, Register>.Add = builder.Add;
            EFSM<Input, Register>.Mul = builder.Mul;
        }

        public static EFSM<Input, Register> operator |(EFSM<Input, Register> lhs, EFSM<Input, Register> rhs)
        {
            return new Or<Input, Register>(lhs, rhs);
        }
        public static EFSM<Input, Register> operator +(EFSM<Input, Register> lhs, EFSM<Input, Register> rhs)
        {
            return new Seq<Input, Register>(lhs, rhs);
        }

        // Shift: Given the current AST and a mark
        // return a new AST with the mark propagated 
        // through the leaves of the AST.
        // The mark representes the set of "active" states 
        // in the AST.
        internal abstract EFSM<Input, Register> Shift(Register mark, Input datum, int pos);
        // Given the current AST: does it match the empty string?
        internal abstract Register IsMatchEmpty();
        // Given the current AST: is any marked state an
        // output state?
        internal abstract Register IsMatchFinal();
        // Given the current AST: does it contain at 
        // least one leaf which is marked?
        internal abstract Register IsAnyMarked();
    }

    public abstract class BinaryEFSM<Input, Register> : EFSM<Input, Register> where Register : ISemiring<Register>, new()
    {
        internal readonly EFSM<Input, Register> lhs, rhs;
        protected BinaryEFSM(EFSM<Input, Register> lhs, EFSM<Input, Register> rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        internal override Register IsAnyMarked()
        {
            return EFSM<Input, Register>.Add(this.lhs.IsAnyMarked(), this.rhs.IsAnyMarked());
        }
    }

    public class Eps<Input, Register> : EFSM<Input, Register> where Register : ISemiring<Register>, new()
    {
        internal Eps() { }
        /// <summary>
        /// Nop: return "this"
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="datum"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        internal override EFSM<Input, Register> Shift(Register mark, Input datum, int pos)
        {
            return this;
        }
        /// <summary>
        ///  Always matches the empty string
        /// </summary>
        /// <returns></returns>
        internal override Register IsMatchEmpty()
        {
            return EFSM<Input, Register>.One;
        }
        /// <summary>
        /// Never a final state
        /// </summary>
        /// <returns></returns>
        internal override Register IsMatchFinal()
        {
            return EFSM<Input, Register>.Zero;
        }
        /// <summary>
        /// Never marked
        /// </summary>
        /// <returns></returns>
        internal override Register IsAnyMarked()
        {
            return EFSM<Input, Register>.Zero;
        }

        public override string ToString()
        {
            return "EPS";
        }
    }

    /// <summary>
    /// Leaf node: only AST which can be marked.
    /// </summary>
    /// <typeparam name="Input"></typeparam>
    /// <typeparam name="Register"></typeparam>
    public class Symbol<Input, Register> : EFSM<Input, Register> where Register : ISemiring<Register>, new()
    {
        // current mark for this AST node
        private readonly Register marked;
        internal readonly Func<int, Input, Register, Register> pred;
        internal readonly Func<int, Register, Register> update;

        internal Symbol(Func<int, Input, Register, Register> pred, Func<int, Register, Register> update) : this(pred, update, EFSM<Input, Register>.Zero) { }

        internal Symbol(Func<int, Input, Register, Register> pred, Func<int, Register, Register> update, Register m) 
        {
            this.pred = pred;
            this.update = update;
            this.marked = m;
        }

        /// <summary>
        /// A symbol is marked if 
        ///     (i)  some previous symbol is marked
        ///        AND (or semiring mul)
        ///     (ii) the lambda returns a non-zero 
        ///          value for the current input 
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="datum"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        internal override EFSM<Input, Register> Shift(Register mark, Input datum, int pos)
        {
            var reg = EFSM<Input, Register>.Zero;
            if (!EqualityComparer<Register>.Default.Equals(mark, EFSM<Input, Register>.Zero))
            {
                //var predicate = this.pred(datum, this.marked);
                var predicate = this.pred(pos, datum, mark);
                if (!EqualityComparer<Register>.Default.Equals(predicate, EFSM<Input, Register>.Zero))
                {
                    reg = this.update(pos, predicate);
                }
            }
            return new Symbol<Input, Register>(this.pred, this.update, reg);
        }
        /// <summary>
        /// Never matches empty string
        /// </summary>
        /// <returns></returns>
        internal override Register IsMatchEmpty()
        {
            return EFSM<Input, Register>.Zero;
        }

        /// <summary>
        /// If this leaf is marked, then return it.
        /// </summary>
        /// <returns></returns>
        internal override Register IsMatchFinal()
        {
            return this.marked;
        }
        /// <summary>
        /// If this leaf is marked, then return it.
        /// </summary>
        /// <returns></returns>
        internal override Register IsAnyMarked()
        {
            return this.marked;
        }

        public override string ToString()
        {
            return String.Format("S:{0}", this.marked.ToString());
        }
    }

    public class Or<Input, Register> : BinaryEFSM<Input, Register> where Register : ISemiring<Register>, new()
    {

        internal Or(EFSM<Input, Register> lhs, EFSM<Input, Register> rhs) : base(lhs, rhs) { }
        /// <summary>
        /// Just pass mark down each branch.
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="datum"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        internal override EFSM<Input, Register> Shift(Register mark, Input datum, int pos)
        {
            return new Or<Input, Register>(this.lhs.Shift(mark, datum, pos), this.rhs.Shift(mark, datum, pos));
        }
        /// <summary>
        /// If either lhs or rhs match the empty string
        /// then this whole statement matches the empty string
        /// </summary>
        /// <returns></returns>
        internal override Register IsMatchEmpty()
        {
            return EFSM<Input, Register>.Add(this.lhs.IsMatchEmpty(), this.rhs.IsMatchEmpty());
        }

        /// <summary>
        /// If either lhs or rhs has a final match
        /// then this whole statement has a final match
        /// </summary>
        /// <returns></returns>
        internal override Register IsMatchFinal()
        {
            return EFSM<Input, Register>.Add(this.lhs.IsMatchFinal(), this.rhs.IsMatchFinal());
        }

        public override string ToString()
        {
            return String.Format("Or({0},{1})", this.lhs.ToString(), this.rhs.ToString());
        }
    }

    public class Seq<Input, Register> : BinaryEFSM<Input, Register> where Register : ISemiring<Register>, new()
    {
        internal Seq(EFSM<Input, Register> lhs, EFSM<Input, Register> rhs) : base(lhs, rhs) { }
        /// <summary>
        /// The input mark is shifted to the lhs,
        /// but we also have to shift it to the rhs *if* the lhs
        /// accepts the empty string. Additionally, if the lhs matches
        /// a final character we have to shift its mark into rhs.
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="datum"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        internal override EFSM<Input, Register> Shift(Register mark, Input datum, int pos)
        {
            var lhsmark = this.lhs.Shift(mark, datum, pos); // shift lhs
            var markandempty = EFSM<Input, Register>.Mul(mark, lhs.IsMatchEmpty());
            var lhsfinal = this.lhs.IsMatchFinal();

            var newmark = EFSM<Input, Register>.Add(
                markandempty, // mark AND lhs.IsMatchEmpty
                lhsfinal); // lhs is final?

            var rhsmark = this.rhs.Shift(newmark, datum, pos);

            return new Seq<Input, Register>(lhsmark, rhsmark);
        }
        /// <summary>
        /// Empty if lhs is empty  AND rhs is empty
        /// </summary>
        /// <returns></returns>
        internal override Register IsMatchEmpty()
        {
            return EFSM<Input, Register>.Mul(this.lhs.IsMatchEmpty(), this.rhs.IsMatchEmpty());
        }
        /// <summary>
        /// If 
        /// (i) lhs matches final AND rhs is empty
        ///    OR
        ///  (ii) rhs is a final match
        /// </summary>
        /// <returns></returns>
        internal override Register IsMatchFinal()
        {
            return EFSM<Input, Register>.Add(
                EFSM<Input, Register>.Mul(this.lhs.IsMatchFinal(), this.rhs.IsMatchEmpty()),
                this.rhs.IsMatchFinal());
        }
        public override string ToString()
        {
            return String.Format("Seq({0},{1})", this.lhs.ToString(), this.rhs.ToString());
        }

    }

    public class Star<Input, Register> : EFSM<Input, Register> where Register : ISemiring<Register>, new()
    {
        internal readonly EFSM<Input, Register> re;
        internal Star(EFSM<Input, Register> r)
        {
            this.re = r;
        }
        /// <summary>
        ///  Shift a mark into the next AST node if
        ///  the previous node was marked or the re matches a final state.
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="datum"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        internal override EFSM<Input, Register> Shift(Register mark, Input datum, int pos)
        {
            return new Star<Input, Register>(
                this.re.Shift(EFSM<Input, Register>.Add(mark, this.re.IsMatchFinal()), datum, pos));
        }

        /// <summary>
        ///  Always matches empty
        /// </summary>
        /// <returns></returns>
        internal override Register IsMatchEmpty()
        {
            return EFSM<Input, Register>.One;
        }
        /// <summary>
        /// Only matches final if its underlying
        /// re matches final
        /// </summary>
        /// <returns></returns>
        internal override Register IsMatchFinal()
        {
            return this.re.IsMatchFinal();
        }

        /// <summary>
        /// Only marked if underlying re is marked.
        /// </summary>
        /// <returns></returns>
        internal override Register IsAnyMarked()
        {
            return this.re.IsAnyMarked();
        }

        public override string ToString()
        {
            return String.Format("Star({0})", this.re.ToString());
        }

    }
}
