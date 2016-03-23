using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{

    public static class TypeConverter
    {
        /// <summary>
        /// Returns a delegate that can be used to cast a subtype back to its base type. 
        /// </summary>
        /// <typeparam name="T">The derived type</typeparam>
        /// <typeparam name="U">The base type</typeparam>
        /// <returns>Delegate that can be used to cast a subtype back to its base type. </returns>
        public static Converter<T, U> UpCast<T, U>() where T : U
        {
            return delegate(T item) { return (U)item; };
        }

        public static T Convert<T, U>(U item) where T : U
        {
            return (T)item;
        }
    }

    public interface IRegister<T>
    {
        T MinValue { get; }
        T MaxValue { get; }

        T Undefined { get; }
        T Apply(T input);

        # region Linear Arithmetic
        IRegister<T> Add(IRegister<T> lhs, IRegister<T> rhs);
        IRegister<T> Add(IRegister<T> lhs, T rhs);
        IRegister<T> Add(T lhs, IRegister<T> rhs);

        IRegister<T> Sub(IRegister<T> lhs, IRegister<T> rhs);
        IRegister<T> Sub(IRegister<T> lhs, T rhs);
        IRegister<T> Sub(T lhs, IRegister<T> rhs);


        // Note lack of nonlinear operation! IRegister<T> * IRegister<T>
        IRegister<T> Mul(IRegister<T> lhs, T rhs);
        IRegister<T> Mul(T lhs, IRegister<T> rhs);
        
        IRegister<T> Div(IRegister<T> lhs, T rhs);
        IRegister<T> Div(T lhs, IRegister<T> rhs);

        IRegister<T> Mod(IRegister<T> lhs, T rhs);
        IRegister<T> Mod(T lhs, IRegister<T> rhs);

        IRegister<T> RShift(IRegister<T> lhs, int rhs);
        IRegister<T> LShift(IRegister<T> lhs, int rhs);

        #endregion

        # region Comparison Operators
        IRegister<T> LessThan(IRegister<T> lhs, T rhs);
        IRegister<T> LessThanEqual(IRegister<T> lhs, T rhs);
        IRegister<T> LessThan(T lhs, IRegister<T> rhs);
        IRegister<T> LessThanEqual(T lhs, IRegister<T> rhs);

        IRegister<T> GreaterThan(IRegister<T> lhs, T rhs);
        IRegister<T> GreaterThanEqual(IRegister<T> lhs, T rhs);
        IRegister<T> GreaterThan(T lhs, IRegister<T> rhs);
        IRegister<T> GreaterThanEqual(T lhs, IRegister<T> rhs);

        IRegister<T> Equal(IRegister<T> lhs, T rhs);
        IRegister<T> Equal(T lhs, IRegister<T> rhs);        
        #endregion

        #region Logical Operators
        IRegister<T> And(IRegister<T> lhs, bool b);
        IRegister<T> And(bool b, IRegister<T> rhs);

        IRegister<T> Or(IRegister<T> lhs, bool b);
        IRegister<T> Or(bool b, IRegister<T> rhs);
        #endregion
    }

    public abstract class Number<T> where T : IComparable<T>, IEquatable<T>
    {

        protected readonly T value;
        
        public Number(T value)
        {
            this.value = value;
        }

        public bool Equals(Number<T> other)
        {
            return this.value.Equals(other.value);
        }

        public bool Equals(T other)
        {
            return this.value.Equals(other);
        }

        public int CompareTo(Number<T> other)
        {
            return this.value.CompareTo(other.value);
        }

        public int CompareTo(T other)
        {
            return this.value.CompareTo(other);
        }

        public override bool Equals(object obj)
        {
            return obj != null && (obj is T
                ? this.value.Equals((T)obj)
                : obj is Number<T> && this.value.Equals(((Number<T>)obj).value));
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        //public static bool operator ==(Number<T> a, Number<T> b)
        //{
        //    return a.value.Equals(b.value);
        //}

        //public static bool operator !=(Number<T> a, Number<T> b)
        //{
        //    return !a.value.Equals(b.value);
        //}

        //public static bool operator <(Number<T> a, Number<T> b)
        //{
        //    return a.value.CompareTo(b.value) < 0;
        //}

        //public static bool operator <=(Number<T> a, Number<T> b)
        //{
        //    return a.value.CompareTo(b.value) <= 0;
        //}

        //public static bool operator >(Number<T> a, Number<T> b)
        //{
        //    return a.value.CompareTo(b.value) > 0;
        //}

        //public static bool operator >=(Number<T> a, Number<T> b)
        //{
        //    return a.value.CompareTo(b.value) >= 0;
        //}

        //public static Number<T> operator !(Number<T> a)
        //{
        //    return new Number<T>(defaultCalculator.Negate(a.value));
        //}

        //public static Number<T> operator +(Number<T> a, Number<T> b)
        //{
        //    return new Number<T>(defaultCalculator.Add(a.value, b.value));
        //}

        //public static Number<T> operator -(Number<T> a, Number<T> b)
        //{
        //    return new Number<T>(defaultCalculator.Subtract(a.value, b.value));
        //}

        //public static Number<T> operator *(Number<T> a, Number<T> b)
        //{
        //    return new Number<T>(defaultCalculator.Multiply(a.value, b.value));
        //}

        //public static Number<T> operator /(Number<T> a, Number<T> b)
        //{
        //    return new Number<T>(defaultCalculator.Divide(a.value, b.value));
        //}

        //public static Number<T> operator %(Number<T> a, Number<T> b)
        //{
        //    return new Number<T>(defaultCalculator.Modulo(a.value, b.value));
        //}

        //public static Number<T> operator -(Number<T> a)
        //{
        //    return new Number<T>(defaultCalculator.Negate(a.value));
        //}

        //public static Number<T> operator +(Number<T> a)
        //{
        //    return new Number<T>(defaultCalculator.Plus(a.value));
        //}

        //public static Number<T> operator ++(Number<T> a)
        //{
        //    return new Number<T>(defaultCalculator.Increment(a.value));
        //}

        //public static Number<T> operator --(Number<T> a)
        //{
        //    return new Number<T>(defaultCalculator.Decrement(a.value));
        //}

        //public static Number<T> operator <<(Number<T> a, int b)
        //{
        //    return new Number<T>(defaultCalculator.LeftShift(a.value, b));
        //}

        //public static Number<T> operator >>(Number<T> a, int b)
        //{
        //    return new Number<T>(defaultCalculator.RightShift(a.value, b));
        //}

        //public static Number<T> operator &(Number<T> a, Number<T> b)
        //{
        //    return new Number<T>(defaultCalculator.And(a.value, b.value));
        //}

        //public static Number<T> operator |(Number<T> a, Number<T> b)
        //{
        //    return new Number<T>(defaultCalculator.Or(a.value, b.value));
        //}

        //public static Number<T> operator ^(Number<T> a, Number<T> b)
        //{
        //    return new Number<T>(defaultCalculator.Xor(a.value, b.value));
        //}

        //public static Number<T> operator ~(Number<T> a)
        //{
        //    return new Number<T>(defaultCalculator.OnesComplement(a.value));
        //}

        //public static implicit operator Number<T>(T value)
        //{
        //    return new Number<T>(value);
        //}

        //public static explicit operator T(Number<T> value)
        //{
        //    return value.value;
        //}

        public override string ToString()
        {
            return String.Format("S:{0}", this.value.ToString());
        }
    }

    public interface ISymbolic<T> : IEquatable<T>
    {
        //T Apply(T input);
        bool IsDefined();
        T Undefined { get; }
        //T Initial(Func<T> init);
    }

    //public class LinearRegister : Symbolic<int>
    //{
    //    public static LinearRegister Undefined = new LinearRegister { isundefined = true };

    //    private bool isundefined;
    //    private int m, c; // mx + c

    //    public static implicit operator LinearRegister(int t)
    //    {
    //        // constant
    //        return new LinearRegister { isundefined = false, m = 0, c = t };
    //    }

    //    public static LinearRegister operator +(LinearRegister lhs, int rhs)
    //    {
    //        // symbolic type is undefined
    //        if (lhs.isundefined) return Undefined;

    //        return new LinearRegister { isundefined = false, m = lhs.m, c = lhs.c + rhs };
    //    }
    //    public static LinearRegister operator +(int lhs, LinearRegister rhs)
    //    {
    //        return rhs + lhs;
    //    }

    //    public static LinearRegister operator +(LinearRegister lhs, LinearRegister rhs)
    //    {
    //        if (lhs.isundefined) return rhs;
    //        if (rhs.isundefined) return lhs;

    //        // (a0x+c0) + (a1x+c1) => (a0+a1)x + (c0+c1)
    //        return new LinearRegister
    //        {
    //            isundefined = false,
    //            m = lhs.m + rhs.m,
    //            c = lhs.c + rhs.c
    //        };
    //    }
    //    public static LinearRegister operator *(LinearRegister lhs, LinearRegister rhs)
    //    {
    //        if (lhs.isundefined || rhs.isundefined) return Undefined;

    //        if (lhs.m > 0 && rhs.m > 0)
    //            throw new Exception("Nonlinear arithmetic");

    //        // (a0x+c0) * (a1x+c1) => (a0*a1x^2 + a0*c1x + a1*c0x + c0*c1) where a0*a1=0
    //        return new LinearRegister
    //        {
    //            isundefined = false,
    //            m = lhs.m * rhs.c + rhs.m * lhs.c,
    //            c = lhs.c * rhs.c
    //        };
    //    }

    //    public override string ToString()
    //    {
    //        if (this.Equals(Undefined)) return ("Zero");

    //        return String.Format("{0}.x + {1}", this.m, this.c);
    //    }

    //    public int Apply(int input)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int IsDefined()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    int Symbolic<int>.Undefined()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int Initial(Func<int> init)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool Equals(int other)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    public class SymbolicList<T> : List<T>, ISymbolic<SymbolicList<T>>
    {
        private static readonly SymbolicList<T> UndefinedInstance;
        static SymbolicList()
        {
            SymbolicList<T>.UndefinedInstance = new SymbolicList<T>();
        }

        public bool IsDefined()
        {
            return this == UndefinedInstance;
        }

        public SymbolicList<T> Undefined
        {
            get { return SymbolicList<T>.UndefinedInstance; }
        }

        public bool Equals(SymbolicList<T> other)
        {
            throw new NotImplementedException();
        }
    }

    public class SymbolicEnum<E> : 
        ISymbolic<SymbolicEnum<E>>, 
        IEquatable<SymbolicEnum<E>> 
        where E : struct // cannot constrain on enum type so struct is as good as it gets :(
    {
        private readonly E? e;

        private static readonly SymbolicEnum<E> UndefinedInstance = new SymbolicEnum<E>();
        private SymbolicEnum(E? e)
        {
            this.e = e;
        }

        public SymbolicEnum() : this(null) {}

        public E Value
        {
            get
            {
                if (this.e.HasValue == false)
                    throw new Exception("Undefined Enum Value"); // UndefinedInstance
                return this.e.Value;
            }
        }

        public static implicit operator SymbolicEnum<E>(E e)
        {
            return new SymbolicEnum<E>(e);
        }
        public static explicit operator E(SymbolicEnum<E> s)
        {
            return s.Value;
        }

        public bool IsDefined()
        {
            return this.e != null;
        }

        public SymbolicEnum<E> Undefined
        {
            get { return UndefinedInstance; }
        }

        public bool Equals(SymbolicEnum<E> other)
        {
            if (object.ReferenceEquals(this, other))
                return true;

            if (this.e == null && other.e == null) return true;

            if (this.e == null) return false;
            if (other.e == null) return false;

            return this.e.Equals(other.e);
        }

        public static IEnumerable<SymbolicEnum<E>> All()
        {
            if (typeof(E).IsEnum == false) 
                throw new Exception("Expected an Enum type");

            foreach (var value in Enum.GetValues(typeof(E)))
            {
                E tmp = (E)Enum.ToObject(typeof(E), value);         
                var output = new SymbolicEnum<E>(tmp);
                yield return output;
            }
        }

        public override string ToString()
        {
            if (this.Equals(UndefinedInstance)) return "Undefined";
            return this.Value.ToString();
        }
    }

    public class LinearRegisterWithConstraints : ISymbolic<LinearRegisterWithConstraints>, IEquatable<LinearRegisterWithConstraints>
    {
        private static int Max(int a, int b)
        {
            if (a == int.MaxValue || b == int.MaxValue) return int.MaxValue;
            return Math.Max(a, b);
        }

        private static int Min(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue) return int.MinValue;
            return Math.Min(a, b);
        }

        private bool isundefined;
        private int lowerboud, upperbound; //[L,U] implies mx + c
        private int m, c; // mx + c where m and c in int

        private static LinearRegisterWithConstraints UndefinedInstance = new LinearRegisterWithConstraints { isundefined = true };

        public static implicit operator LinearRegisterWithConstraints(int t)
        {
            return new LinearRegisterWithConstraints
            {
                isundefined = false,
                lowerboud = int.MinValue,
                upperbound = int.MaxValue,
                m = 0,
                c = t
            };
        }

        public LinearRegisterWithConstraints()
        {
            this.isundefined = false;
            this.lowerboud = int.MinValue;
            this.upperbound = int.MaxValue;
            this.m = 1;
            this.c = 0;
        }
        public static LinearRegisterWithConstraints operator &(bool lhs, LinearRegisterWithConstraints rhs)
        {
            if (lhs) return rhs;
            return UndefinedInstance;
        }

        public static LinearRegisterWithConstraints operator +(LinearRegisterWithConstraints lhs, int rhs)
        {
            if (lhs.isundefined) return UndefinedInstance;

            var r = new LinearRegisterWithConstraints
            {
                isundefined = false,
                lowerboud = lhs.lowerboud,
                upperbound = lhs.upperbound,
                m = lhs.m,
                c = lhs.c + rhs
            };
            return r;
        }
        public static LinearRegisterWithConstraints operator +(int lhs, LinearRegisterWithConstraints rhs)
        {
            return rhs + lhs;
        }

        //public static LinearRegisterWithConstraints operator -(LinearRegisterWithConstraints lhs, int rhs)
        //{
        //    var r = new LinearRegisterWithConstraints { lowerboud = lhs.lowerboud, upperbound = lhs.upperbound, m = lhs.m, c = lhs.c - rhs };
        //    return r;
        //}
        //public static LinearRegisterWithConstraints operator -(int lhs, LinearRegisterWithConstraints rhs)
        //{
        //    return rhs - lhs;
        //}

        //public static LinearRegisterWithConstraints operator *(LinearRegisterWithConstraints lhs, int rhs)
        //{
        //    var r = new LinearRegisterWithConstraints { lowerboud = lhs.lowerboud, upperbound = lhs.upperbound, m = lhs.m * rhs, c = lhs.c * rhs };
        //    return r;
        //}
        //public static LinearRegisterWithConstraints operator *(int lhs, LinearRegisterWithConstraints rhs)
        //{
        //    return rhs * lhs;
        //}

        //public static LinearRegisterWithConstraints operator /(LinearRegisterWithConstraints lhs, int rhs)
        //{
        //    var r = new LinearRegisterWithConstraints { lowerboud = lhs.lowerboud, upperbound = lhs.upperbound, m = lhs.m / rhs, c = lhs.c / rhs };
        //    return r;
        //}
        //public static LinearRegisterWithConstraints operator /(int lhs, LinearRegisterWithConstraints rhs)
        //{
        //    var r = new LinearRegisterWithConstraints { lowerboud = rhs.lowerboud, upperbound = rhs.upperbound, m = lhs / rhs.m, c = lhs / rhs.c };
        //    return r;
        //}

        //public static LinearRegisterWithConstraints operator %(LinearRegisterWithConstraints lhs, int rhs)
        //{
        //    var r = new LinearRegisterWithConstraints { lowerboud = lhs.lowerboud, upperbound = lhs.upperbound, m = lhs.m % rhs, c = lhs.c % rhs };
        //    return r;
        //}

        //public static LinearRegisterWithConstraints operator >(LinearRegisterWithConstraints lhs, int rhs)
        //{
        //    return lhs >= (rhs - 1);
        //}
        //public static LinearRegisterWithConstraints operator <(LinearRegisterWithConstraints lhs, int rhs)
        //{
        //    return lhs <= (rhs - 1);
        //}

        public static LinearRegisterWithConstraints operator >=(LinearRegisterWithConstraints lhs, int rhs)
        {
            if (lhs.isundefined) return UndefinedInstance;

            if (lhs.m == 0 && lhs.c >= rhs)
            {
                return new LinearRegisterWithConstraints { isundefined = false, lowerboud = lhs.lowerboud, upperbound = lhs.upperbound, m = 0, c = lhs.c };
            }
            else if (lhs.m > 0 && lhs.upperbound >= (rhs - lhs.c))
            {
                return new LinearRegisterWithConstraints { isundefined = false, lowerboud = Max(lhs.lowerboud, rhs - lhs.c), upperbound = lhs.upperbound, m = 1, c = lhs.c };
            }

            return LinearRegisterWithConstraints.UndefinedInstance;
        }
        public static LinearRegisterWithConstraints operator <=(LinearRegisterWithConstraints lhs, int rhs)
        {
            if (lhs.isundefined) return UndefinedInstance;

            if (lhs.m == 0 && lhs.c <= rhs)
            {
                return new LinearRegisterWithConstraints { isundefined = false, lowerboud = lhs.lowerboud, upperbound = lhs.upperbound, m = 0, c = lhs.c };
            }
            else if (lhs.m > 0 && lhs.lowerboud <= rhs - lhs.c)
            {
                return new LinearRegisterWithConstraints { isundefined = false, lowerboud = lhs.lowerboud, upperbound = Min(lhs.upperbound, rhs - lhs.c), m = 1, c = lhs.c };
            }

            return LinearRegisterWithConstraints.UndefinedInstance;
        }


        public static LinearRegisterWithConstraints operator +(LinearRegisterWithConstraints lhs, LinearRegisterWithConstraints rhs)
        {
            // x + 0 = x for all x
            if (rhs.Equals(UndefinedInstance)) return lhs;
            if (lhs.Equals(UndefinedInstance)) return rhs;

            //// [a,b] + [c,d] => [a+c, b+d]
            // a0x + c0 + a1x + c1 = (a0+a1)x = (c0+c1)
            var low =
                lhs.lowerboud == int.MinValue && rhs.lowerboud == int.MinValue ? int.MinValue :
                lhs.lowerboud == int.MinValue ? rhs.lowerboud :
                rhs.lowerboud == int.MinValue ? lhs.lowerboud :
                lhs.lowerboud + rhs.lowerboud;

            var hi =
                lhs.upperbound == int.MaxValue && rhs.upperbound == int.MaxValue ? int.MaxValue :
                lhs.upperbound == int.MaxValue ? rhs.upperbound :
                rhs.upperbound == int.MaxValue ? lhs.upperbound :
                lhs.upperbound + rhs.upperbound;


            return new LinearRegisterWithConstraints
            {
                isundefined = false,
                lowerboud = low,
                upperbound = hi,
                m = lhs.m + rhs.m,
                c = lhs.c + rhs.c
            };
        }
        public static LinearRegisterWithConstraints operator *(LinearRegisterWithConstraints lhs, LinearRegisterWithConstraints rhs)
        {
            // x * 0 = 0 for all x
            if (lhs.Equals(UndefinedInstance) || rhs.Equals(UndefinedInstance)) return UndefinedInstance;

            if (lhs.m * rhs.m != 0)
            {
                throw new Exception("nonlinear operation!");
            }
            return new LinearRegisterWithConstraints
            {
                isundefined = false,
                lowerboud = Min(Min(lhs.lowerboud * rhs.lowerboud, lhs.lowerboud * rhs.upperbound), Min(lhs.upperbound * rhs.lowerboud, lhs.upperbound * rhs.upperbound)),
                upperbound = Max(Max(lhs.lowerboud * rhs.lowerboud, lhs.lowerboud * rhs.upperbound), Max(lhs.upperbound * rhs.lowerboud, lhs.upperbound * rhs.upperbound)),
                m = lhs.m * rhs.c + rhs.m * lhs.c,
                c = lhs.c + rhs.c
            };
        }

        public int? Apply(int x)
        {
            if (x >= this.lowerboud && x <= this.upperbound)
                return x * this.m + this.c;
            return null;
        }
        public override string ToString()
        {
            if (this.Equals(Undefined)) return ("Undefined");

            if (this.m == 0)
                return this.c.ToString();

            //return String.Format("{0} + {1}", 'x', this.c);

            return String.Format("[{0} {1}] {2}.x + {3}",
                this.lowerboud == int.MinValue ? "" : this.lowerboud.ToString(),
                this.upperbound == int.MaxValue ? "" : this.upperbound.ToString(),
                this.m, this.c);
        }

        public int GetHashCode(LinearRegisterWithConstraints obj)
        {
            throw new NotImplementedException();
        }

        public bool Equals(LinearRegisterWithConstraints other)
        {
            if (Object.ReferenceEquals(this, other))
                return true;


            return
                this.isundefined == other.isundefined &&
                this.lowerboud == other.lowerboud &&
                this.upperbound == other.upperbound &&
                this.m == other.m &&
                this.c == other.c;
        }

        public LinearRegisterWithConstraints Undefined { get { return UndefinedInstance; } }

        public LinearRegisterWithConstraints Apply(LinearRegisterWithConstraints input)
        {
            throw new NotImplementedException();
        }

        public bool IsDefined()
        {
            return !this.isundefined;
        }

        public LinearRegisterWithConstraints Initial(Func<LinearRegisterWithConstraints> init)
        {
            throw new NotImplementedException();
        }
    }

    public class Appendable<T> : ISymbolic<Appendable<T>>
        where T : IEquatable<T>
    {
        // Appending nothing is represented by an instance where parent=null and value=default(T)

        Appendable<T> parent;
        T[] value;

        public Appendable()
        {
            parent = null;
            value = new T[0];
        }

        Appendable(Appendable<T> parent, T[] value)
        {
            this.parent = parent;
            this.value = value;
        }

        public bool IsDefined()
        {
            return true;
        }

        public Appendable<T> Undefined { get { throw new NotImplementedException(); } }

        public bool Equals(Appendable<T> other)
        {
            return value.Equals(other.value) && parent.Equals(other.parent);
        }

        public Appendable<T> Append(params T[] value)
        {
            return new Appendable<T>
            {
                parent = this,
                value = value,
            };
        }
    }
}
