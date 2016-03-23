using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{

    public interface ISemiring<T>
    {
        T Zero { get; }
        T One { get; }
        T Add(T lhs, T rhs);
        T Mul(T lhs, T rhs);
    }


    public interface IPolicy<T, Input, SymbolicType>
    {
        T ApplyPredicate(int pos, Input input, T policy, Func<int, Input, SymbolicType, SymbolicType> pred);
        T ApplyUpdate(int pos, T policy, Func<int, SymbolicType, SymbolicType> update);

        T FromSymbolic(SymbolicType s);
    }

    public class Plute<T1, T2> : Tuple<T1,T2>, ISymbolic<Plute<T1, T2>>
        where T1 : ISymbolic<T1>, new()
        where T2 : ISymbolic<T2>, new()
    {
        private static readonly Plute<T1, T2> UndefinedInstance;

        static Plute()
        {
            var b1 = new T1();
            var b2 = new T2();
            Plute<T1, T2>.UndefinedInstance = new Plute<T1,T2>(b1, b2);
        }

        public Plute() : this(new T1().Undefined, new T2().Undefined) {}

        public Plute(T1 t1, T2 t2) : base(t1, t2) {}
            
        public bool IsDefined()
        {
            return base.Item1.IsDefined() && base.Item2.IsDefined();
        }

        public Plute<T1, T2> Undefined
        {
            get { return Plute<T1, T2>.UndefinedInstance; }
        }

        public bool Equals(Plute<T1, T2> other)
        {
            return base.Item1.Equals(other.Item1) &&
                base.Item2.Equals(other.Item2);
        }
    }


    public class Plute<T1, T2, T3> : Tuple<T1, T2, T3>, ISymbolic<Plute<T1, T2, T3>>
        where T1 : ISymbolic<T1>, new()
        where T2 : ISymbolic<T2>, new()
        where T3 : ISymbolic<T3>, new()

    {
        private static readonly Plute<T1, T2, T3> UndefinedInstance;

        static Plute()
        {
            var b1 = new T1();
            var b2 = new T2();
            var b3 = new T3();
            Plute<T1, T2, T3>.UndefinedInstance = new Plute<T1, T2, T3>(b1, b2, b3);
        }

        public Plute() : this(new T1().Undefined, new T2().Undefined, new T3().Undefined) { }

        public Plute(T1 t1, T2 t2, T3 t3) : base(t1, t2, t3) { }

        public bool IsDefined()
        {
            return base.Item1.IsDefined() && base.Item2.IsDefined()
                 && base.Item3.IsDefined();
        }

        public Plute<T1, T2, T3> Undefined
        {
            get { return Plute<T1, T2, T3>.UndefinedInstance; }
        }

        public bool Equals(Plute<T1, T2, T3> other)
        {
            return base.Item1.Equals(other.Item1) &&
                base.Item2.Equals(other.Item2) &&
                base.Item3.Equals(other.Item3);
        }
    }

    internal class MyComparer<SymbolicType> : EqualityComparer<HashSet<SymbolicType>>
    {
        public static MyComparer<SymbolicType> Default = new MyComparer<SymbolicType>();

        public override bool Equals(HashSet<SymbolicType> x, HashSet<SymbolicType> y) 
        {
            return x.SetEquals(y);
            if (x.Intersect(y).Count() == x.Count()) return true;
            return false;
        }

        public override int GetHashCode(HashSet<SymbolicType> obj)
        {
            return obj.Select(k => 
                k.GetHashCode()).Sum();
        }
    }

    public class Powerset<Input, SymbolicType> :
        IPolicy<Powerset<Input, SymbolicType>, Input, SymbolicType>,
        ISemiring<Powerset<Input, SymbolicType>>,
        IEquatable<Powerset<Input, SymbolicType>>,
        IEnumerable<SymbolicType>
        where SymbolicType : ISymbolic<SymbolicType>, new()
    {
        private static readonly SymbolicType Undefined;
        static Powerset()
        {
            var builder = new SymbolicType();
            Powerset<Input, SymbolicType>.Undefined = builder.Undefined;
        }

        private readonly ISet<ISet<SymbolicType>> sets;

        internal Powerset(ISet<ISet<SymbolicType>> s)
        {
            this.sets = s;
        }

        private static Powerset<Input, SymbolicType> Zero = new Powerset<Input, SymbolicType>(null); // undefined
        private static Powerset<Input, SymbolicType> One = new Powerset<Input, SymbolicType>(new HashSet<ISet<SymbolicType>>()); // empty set

        // Note only used for constructing policy and semiring
        public Powerset() { }
        public Powerset(SymbolicType singleitem)
        {
            var s = new HashSet<SymbolicType>(EqualityComparer<SymbolicType>.Default);
            s.Add(singleitem);
            this.sets = new HashSet<ISet<SymbolicType>>();
            this.sets.Add(s);
        }


        public override string ToString()
        {
            if (this.Equals(Zero)) return "Zero";
            if (this.Equals(One)) return "One";
            var s = new StringBuilder("Powerset:");
            foreach (var set in this.sets)
                s.AppendFormat("[{0}]", String.Join(";", set));
            return s.ToString();
        }

        Powerset<Input, SymbolicType> ISemiring<Powerset<Input, SymbolicType>>.Zero
        {
            get { return Powerset<Input, SymbolicType>.Zero; }
        }

        Powerset<Input, SymbolicType> ISemiring<Powerset<Input, SymbolicType>>.One
        {
            get { return Powerset<Input, SymbolicType>.One; }
        }

        public Powerset<Input, SymbolicType> Add(Powerset<Input, SymbolicType> lhs, Powerset<Input, SymbolicType> rhs)
        {
            // x+0 = x for all x
            if (lhs.Equals(Zero)) return rhs;
            if (rhs.Equals(Zero)) return lhs;

            // invariant: sets is not null if here.
            var nextsets = lhs.sets.Union(rhs.sets);
            return new Powerset<Input, SymbolicType>(new HashSet<ISet<SymbolicType>>(nextsets));
        }

        public Powerset<Input, SymbolicType> Mul(Powerset<Input, SymbolicType> lhs, Powerset<Input, SymbolicType> rhs)
        {
            // x*0 = 0 for all x
            if (lhs.Equals(Zero) || rhs.Equals(Zero)) return Zero;

            // x*1 = x for all x
            if (lhs.Equals(One)) return rhs;
            if (rhs.Equals(One)) return lhs;

            // invariant: sets is not null if here.
            var nextsets = lhs.sets.Intersect(rhs.sets);
            return new Powerset<Input, SymbolicType>(new HashSet<ISet<SymbolicType>>(nextsets));
        }

        public Powerset<Input, SymbolicType> ApplyPredicate(int pos, Input input, Powerset<Input, SymbolicType> policy, Func<int, Input, SymbolicType, SymbolicType> pred)
        {
            // if policy is undefined so too is result
            if (policy.Equals(Zero)) return Zero;
            
            // if the policy is the empty set (i.e., one) 
            // this node is marked but does not contain
            // any symbolic variables.
            // The client, however, may want to do some operations
            // on a register type.
            if (policy.Equals(One))
            {
                var output = pred(pos, input, Powerset<Input, SymbolicType>.Undefined);
                if (output.IsDefined())
                {
                    return new Powerset<Input, SymbolicType>(output);
                }

                // if output is not defined, return 0
                return Powerset<Input, SymbolicType>.Zero;
            }

            // Apply the predicate to create a new set
            var sets = new HashSet<HashSet<SymbolicType>>(MyComparer<SymbolicType>.Default);
            foreach (var set in policy.sets)
            {
                HashSet<SymbolicType> next = null;
                foreach (var s in set)
                {
                    // apply predicate to produce output of lambda
                    var output = pred(pos, input, s);
                    // only add if it is defined
                    if (output.IsDefined()) {
                        if (next == null)
                            next = new HashSet<SymbolicType>();
                        next.Add(output);
                    }
                }
                // only add if we need to
                if (next != null)
                    sets.Add(next);
            }
            return new Powerset<Input, SymbolicType>(new HashSet<ISet<SymbolicType>>(sets));
        }

        public Powerset<Input, SymbolicType> ApplyUpdate(int pos, Powerset<Input, SymbolicType> policy, Func<int, SymbolicType, SymbolicType> update)
        {
            // if policy is undefined so too is result
            if (policy.Equals(Zero)) return Zero;

            // if the policy is the empty set (i.e., one) 
            // this node is marked but does not contain
            // any symbolic variables.
            // The client, however, may want to do some operations
            // on a register type.
            if (policy.Equals(One))
            {
                var output = update(pos, Powerset<Input, SymbolicType>.Undefined);
                if (output.IsDefined())
                {
                    return new Powerset<Input, SymbolicType>(output);
                }

                // if output is not defined, return 0
                return Powerset<Input, SymbolicType>.Zero;
            }


            // Apply the update to create a new set
            // Apply the predicate to create a new set
            var sets = new HashSet<HashSet<SymbolicType>>();
            foreach (var set in policy.sets)
            {
                HashSet<SymbolicType> next = null;
                foreach (var s in set)
                {
                    // apply predicate to produce output of lambda
                    var output = update(pos, s);
                    // only add if it is defined
                    if (output.IsDefined())
                    {
                        if (next == null)
                            next = new HashSet<SymbolicType>();
                        next.Add(output);
                    }
                }
                // only add if we need to
                if (next != null)
                    sets.Add(next);
            }

            return new Powerset<Input, SymbolicType>(new HashSet<ISet<SymbolicType>>(sets));
        }

        public Powerset<Input, SymbolicType> FromSymbolic(SymbolicType s)
        {
            return new Powerset<Input, SymbolicType>(s);
        }

        public bool Equals(Powerset<Input, SymbolicType> other)
        {
            if (Object.ReferenceEquals(this, other))
                return true;

            if (this.sets == null && other.sets == null) return true;

            if (this.sets == null) return false;
            if (other.sets == null) return false;

            var tmp = this.sets.SetEquals(other.sets);

            // invariant: sets is not null if here.
            return tmp;
        }

        public void Insert(SymbolicType singleitem)
        {
            var s = new HashSet<SymbolicType>(EqualityComparer<SymbolicType>.Default);
            s.Add(singleitem);
            this.sets.Add(s);
        }

        public IEnumerator<SymbolicType> GetEnumerator()
        {
            return this.sets.SelectMany(s => s).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Standard<Input, SymbolicType> :
        IPolicy<Standard<Input, SymbolicType>, Input, SymbolicType>,
        ISemiring<Standard<Input, SymbolicType>>,
        IEquatable<Standard<Input, SymbolicType>>
        where SymbolicType : ISymbolic<SymbolicType>, new()
    {

        private static readonly SymbolicType Undefined;
        static Standard()
        {
            var builder = new SymbolicType();
            Standard<Input, SymbolicType>.Undefined = builder.Undefined;
        }

        private readonly bool noleft; // did we find a match yet?
        private readonly int? start;  // if we did find a match, where is the start?
        private readonly SymbolicType payload;

        public static Standard<Input, SymbolicType> Zero = new Standard<Input, SymbolicType>(true, null, Standard<Input, SymbolicType>.Undefined);
        public static Standard<Input, SymbolicType> One = new Standard<Input, SymbolicType>(false, null, Standard<Input, SymbolicType>.Undefined);
        private LinearRegisterWithConstraints initstate2;

        public Standard() : this(true, null, Standard<Input, SymbolicType>.Undefined) { }

        public Standard(bool noleft, int? pos, SymbolicType payload)
        {
            this.noleft = noleft;
            this.start = pos;
            this.payload = payload;
        }

        public Standard(SymbolicType initstate) : this(false, null, initstate) { }

        private bool IsNoStart()
        {
            return this.noleft == false && this.start != null;
        }

        public Standard<Input, SymbolicType> Add(Standard<Input, SymbolicType> lhs, Standard<Input, SymbolicType> rhs)
        {
            // x+0=x for all x
            if (lhs.Equals(Zero)) return rhs;
            if (rhs.Equals(Zero)) return lhs;
            
            if (lhs.IsNoStart() && rhs.IsNoStart()) return new Standard<Input, SymbolicType>(false, null, Standard<Input, SymbolicType>.Undefined);
            if (lhs.IsNoStart()) return new Standard<Input, SymbolicType>(false, rhs.start, rhs.payload);
            if (!lhs.IsNoStart() && rhs.IsNoStart()) return new Standard<Input, SymbolicType>(false, lhs.start, lhs.payload);
            
            return new Standard<Input, SymbolicType>(
                false, 
                lhs.start.Value <= rhs.start.Value ? lhs.start.Value : rhs.start.Value, 
                lhs.start.Value <= rhs.start.Value ? lhs.payload : rhs.payload);
        }

        public Standard<Input, SymbolicType> Mul(Standard<Input, SymbolicType> lhs, Standard<Input, SymbolicType> rhs)
        {
            // x*0=0 for all x
            if (lhs.Equals(Zero) || rhs.Equals(Zero)) return Zero;

            // x*1=1 for all x
            if (lhs.Equals(One)) return rhs;

            return lhs;
        }

        public override string ToString()
        {
            if (this.Equals(Zero)) return "No Match";
            if (this.Equals(One)) return this.payload == null ? "Match: startpos = 0" : String.Format("Match: startpos = 0: {0}", this.payload);
            return String.Format("Match: startpos = {0}: [{1}]", this.start.Value, this.payload == null ? "null" : this.payload.ToString());
        }

        public Standard<Input, SymbolicType> ApplyPredicate(int pos, Input input, Standard<Input, SymbolicType> policy, Func<int, Input, SymbolicType, SymbolicType> pred)
        {
            // if policy is undefined so too is result
            if (policy.Equals(Zero)) return Zero;

            // This node is marked 
            // The client, however, may want to do some operations
            // on a register type.
            var output = pred(pos, input, policy.payload);
            if (output.IsDefined())
            {
                var tmp = new Standard<Input, SymbolicType>(false, policy.start == null ? pos : policy.start, output);
                return tmp;
            }

            // if output is not defined, return 0
            return Standard<Input, SymbolicType>.Zero;
        }

        public Standard<Input, SymbolicType> ApplyUpdate(int pos, Standard<Input, SymbolicType> policy, Func<int, SymbolicType, SymbolicType> update)
        {
            // if policy is undefined so too is result
            if (policy.Equals(Zero)) return Zero;

            // This node is marked 
            // The client, however, may want to do some operations
            // on a register type.
            var output = update(pos, policy.payload);
            if (output.IsDefined())
            {
                var tmp = new Standard<Input, SymbolicType>(false, policy.start == null ? pos : policy.start, output);
                return tmp;
            }

            // if output is not defined, return 0
            return Standard<Input, SymbolicType>.Zero;
        }

        public Standard<Input, SymbolicType> FromSymbolic(SymbolicType s)
        {
            throw new NotImplementedException();
        }

        Standard<Input, SymbolicType> ISemiring<Standard<Input, SymbolicType>>.Zero
        {
            get { return Standard<Input, SymbolicType>.Zero; }
        }

        Standard<Input, SymbolicType> ISemiring<Standard<Input, SymbolicType>>.One
        {
            get { return Standard<Input, SymbolicType>.One; }
        }

        public bool Equals(Standard<Input, SymbolicType> other)
        {
            if (Object.ReferenceEquals(this, other))
                return true;

            return this.noleft == other.noleft && this.start == other.start;
        }
    }

    public class LeftLong<Input, SymbolicType> : 
        IPolicy<LeftLong<Input, SymbolicType>, Input, SymbolicType>,
        ISemiring<LeftLong<Input, SymbolicType>>,
        IEquatable<LeftLong<Input, SymbolicType>>
        where SymbolicType : ISymbolic<SymbolicType>, new()
    {

        private static readonly SymbolicType Undefined;
        static LeftLong()
        {
            var builder = new SymbolicType();
            LeftLong<Input, SymbolicType>.Undefined = builder.Undefined;
        }

        private readonly SymbolicType payload;
        private readonly bool noLeftLong; // did we find a match yet?
        private readonly Tuple<int, int> range; // if we did find a match, where is the start/end?

        public static LeftLong<Input, SymbolicType> Zero = new LeftLong<Input, SymbolicType>(true, LeftLong<Input, SymbolicType>.Undefined, null);
        public static LeftLong<Input, SymbolicType> One = new LeftLong<Input, SymbolicType>(false, LeftLong<Input, SymbolicType>.Undefined, null);

        public LeftLong() : this(false, LeftLong<Input, SymbolicType>.Undefined, null) { } 

        public LeftLong(int pos, SymbolicType item) : this(false, item, Tuple.Create(pos, pos)) {}

        public LeftLong(SymbolicType item) : this(false, item, null) {}

        public LeftLong(bool noLeftLong, SymbolicType payload, Tuple<int, int> range)
        {
            this.noLeftLong = noLeftLong;
            this.payload = payload;
            this.range = range;
        }

        private bool IsNoStart()
        {
            return this.noLeftLong == false && this.range == null;
        }

        //public static LeftLong<Input, SymbolicType> operator <=(LeftLong<Input, SymbolicType> lhs, ConcreteType rhs)
        //{
        //    if (lhs.Equals(Zero)) return Zero;


        //    if (lhs.Equals(One))
        //        return new LeftLong<SymbolicType, ConcreteType>()
        //        {
        //            noLeftLong = lhs.noLeftLong,
        //            payload = (SymbolicType)Activator.CreateInstance(typeof(ConcreteType), rhs),
        //            range = lhs.range
        //        };

        //    return new LeftLong<SymbolicType, ConcreteType>()
        //    {
        //        noLeftLong = lhs.noLeftLong,
        //        payload = (SymbolicType)((dynamic)lhs.payload <= rhs),
        //        range = lhs.range
        //    };
        //}
        //public static LeftLong<SymbolicType, ConcreteType> operator >=(LeftLong<SymbolicType, ConcreteType> lhs, ConcreteType rhs)
        //{
        //    return (LeftLong<SymbolicType, ConcreteType>)((dynamic)lhs.payload >= rhs);
        //}

        //public static LeftLong<SymbolicType, ConcreteType> operator &(bool lhs, LeftLong<SymbolicType, ConcreteType> rhs)
        //{
        //    if (lhs) return rhs;
        //    return Zero;
        //}

        //public static LeftLong<SymbolicType, ConcreteType> operator +(LeftLong<SymbolicType, ConcreteType> lhs, ConcreteType rhs)
        //{
        //    if (lhs.Equals(Zero)) return Zero;
        //    return new LeftLong<SymbolicType, ConcreteType>()
        //    {
        //        noLeftLong = lhs.noLeftLong,
        //        payload = (SymbolicType)((dynamic)lhs.payload + rhs),
        //        range = lhs.range
        //    };
        //}

        //public static LeftLong<SymbolicType, ConcreteType> operator +(LeftLong<SymbolicType, ConcreteType> lhs, LeftLong<SymbolicType, ConcreteType> rhs)
        //{
        //    // x+0=x for all x
        //    if (lhs.Equals(Zero)) return rhs;
        //    if (rhs.Equals(Zero)) return lhs;

        //    if (lhs.IsNoStart() && rhs.IsNoStart()) return One;
        //    if (lhs.IsNoStart()) return new LeftLong<SymbolicType, ConcreteType> { noLeftLong = false, range = rhs.range };
        //    if (!lhs.IsNoStart() && rhs.IsNoStart()) return new LeftLong<SymbolicType, ConcreteType> { noLeftLong = false, range = lhs.range };

        //    var i = lhs.range.Item1;
        //    var j = lhs.range.Item2;

        //    var k = rhs.range.Item1;
        //    var l = rhs.range.Item2;

        //    if ((i < k || i == k) && j >= l)
        //        return new LeftLong<SymbolicType, ConcreteType> { noLeftLong = false, range = Tuple.Create(i, j) };
        //    return new LeftLong<SymbolicType, ConcreteType> { noLeftLong = false, range = Tuple.Create(k, l) };
        //}

        //public static LeftLong<SymbolicType, ConcreteType> operator *(LeftLong<SymbolicType, ConcreteType> lhs, LeftLong<SymbolicType, ConcreteType> rhs)
        //{
        //    // x*0=0 for all x
        //    if (lhs.Equals(Zero) || rhs.Equals(Zero)) return Zero;

        //    // x*1=1 for all x
        //    if (lhs.Equals(One)) return rhs;

        //    var i = lhs.range.Item1;
        //    var j = rhs.range.Item2;

        //    return new LeftLong<SymbolicType, ConcreteType> { noLeftLong = false, range = Tuple.Create(i, j) };
        //}

        public override string ToString()
        {
            //if (this.Equals(Zero)) return "No Match";
            //if (this.Equals(One)) return "Match: startpos = 0";
            if (this.Equals(Zero)) return "Zero";
            if (this.Equals(One)) return "One";

            return String.Format("Match: startpos = {0}, endpos = {1} [{2}]", this.range.Item1, this.range.Item2, this.payload == null ? "null" : this.payload.ToString());
        }


        public bool Equals(LeftLong<Input, SymbolicType> other)
        {
            if (Object.ReferenceEquals(this, other))
                return true;

            //if (this.payload == null && other.payload == null)
                return this.noLeftLong == other.noLeftLong && this.range == other.range;
            //if (this.payload == null)
            //    return false;
            //if (other.payload == null)
              //  return false;

            //return this.noLeftLong == other.noLeftLong && this.payload.Equals(other.payload) && this.range == other.range;
        }

        LeftLong<Input, SymbolicType> ISemiring<LeftLong<Input, SymbolicType>>.Zero
        {
            get { return Zero; }
        }

        LeftLong<Input, SymbolicType> ISemiring<LeftLong<Input, SymbolicType>>.One
        {
            get { return One; }
        }

        public LeftLong<Input, SymbolicType> Add(LeftLong<Input, SymbolicType> lhs, LeftLong<Input, SymbolicType> rhs)
        {
            // x+0=x for all x
            if (lhs.Equals(Zero)) return rhs;
            if (rhs.Equals(Zero)) return lhs;

            if (lhs.IsNoStart() && rhs.IsNoStart()) return One;
            if (lhs.IsNoStart()) return new LeftLong<Input, SymbolicType>(false, rhs.payload, rhs.range);
            if (!lhs.IsNoStart() && rhs.IsNoStart()) return new LeftLong<Input, SymbolicType>(false, lhs.payload, lhs.range);

            var i = lhs.range.Item1;
            var j = lhs.range.Item2;

            var k = rhs.range.Item1;
            var l = rhs.range.Item2;

            if ((i < k || i == k) && j >= l)
                return new LeftLong<Input, SymbolicType>(false, lhs.payload, lhs.range);
            return new LeftLong<Input, SymbolicType>(false, rhs.payload, rhs.range);
        }

        public LeftLong<Input, SymbolicType> Mul(LeftLong<Input, SymbolicType> lhs, LeftLong<Input, SymbolicType> rhs)
        {
            // x*0=0 for all x
            if (lhs.Equals(Zero) || rhs.Equals(Zero)) return Zero;

            // x*1=1 for all x
            if (lhs.Equals(One)) return rhs;

            var i = lhs.range.Item1;
            var j = rhs.range.Item2;

            return new LeftLong<Input, SymbolicType>(false, rhs.payload, Tuple.Create(i, j)); 
        }

        public LeftLong<Input, SymbolicType> ApplyPredicate(int pos, Input input, LeftLong<Input, SymbolicType> policy, Func<int, Input, SymbolicType, SymbolicType> pred)
        {
            // if policy is undefined so too is result
            if (policy.Equals(Zero)) return Zero;

            // This node is marked 
            // The client, however, may want to do some operations
            // on a register type.
            var output = pred(pos, input, policy.payload);
            if (output.IsDefined())
            {

                var tmp = new LeftLong<Input, SymbolicType>(pos, output);
                var tmp1 = Mul(policy, tmp);
                return tmp1;
            }

            // if output is not defined, return 0
            return LeftLong<Input, SymbolicType>.Zero;
        }

        public LeftLong<Input, SymbolicType> ApplyUpdate(int pos, LeftLong<Input, SymbolicType> policy, Func<int, SymbolicType, SymbolicType> update)
        {
            // if policy is undefined so too is result
            if (policy.Equals(Zero)) return Zero;

            // This node is marked 
            // The client, however, may want to do some operations
            // on a register type.
            var output = update(pos, policy.payload);
            if (output.IsDefined())
            {
                var tmp = new LeftLong<Input, SymbolicType>(pos, output);
                var tmp1 = Mul(policy, tmp);
                return tmp1;
            }

            // if output is not defined, return 0
            return LeftLong<Input, SymbolicType>.Zero;
        }

        public LeftLong<Input, SymbolicType> FromSymbolic(SymbolicType s)
        {
            throw new NotImplementedException();
        }
    }
}
