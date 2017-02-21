using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    public partial class OnlyFibonacci : Transducer<int, int>
    {
        static Boolean Fun0(UInt32 v0)
        {
            return (Boolean)(((((((((((((((((((((((((((((((((((((((((((((((((uint)(v0)) == ((uint)((uint)1U)))) || ((((uint)(v0)) == ((uint)((uint)2U))))) || ((((uint)(v0)) == ((uint)((uint)3U))))) || ((((uint)(v0)) == ((uint)((uint)5U))))) || ((((uint)(v0)) == ((uint)((uint)8U))))) || ((((uint)(v0)) == ((uint)((uint)13U))))) || ((((uint)(v0)) == ((uint)((uint)21U))))) || ((((uint)(v0)) == ((uint)((uint)34U))))) || ((((uint)(v0)) == ((uint)((uint)55U))))) || ((((uint)(v0)) == ((uint)((uint)89U))))) || ((((uint)(v0)) == ((uint)((uint)144U))))) || ((((uint)(v0)) == ((uint)((uint)233U))))) || ((((uint)(v0)) == ((uint)((uint)377U))))) || ((((uint)(v0)) == ((uint)((uint)610U))))) || ((((uint)(v0)) == ((uint)((uint)987U))))) || ((((uint)(v0)) == ((uint)((uint)1597U))))) || ((((uint)(v0)) == ((uint)((uint)2584U))))) || ((((uint)(v0)) == ((uint)((uint)4181U))))) || ((((uint)(v0)) == ((uint)((uint)6765U))))) || ((((uint)(v0)) == ((uint)((uint)10946U))))) || ((((uint)(v0)) == ((uint)((uint)17711U))))) || ((((uint)(v0)) == ((uint)((uint)28657U))))) || ((((uint)(v0)) == ((uint)((uint)46368U))))) || ((((uint)(v0)) == ((uint)((uint)75025U))))) || ((((uint)(v0)) == ((uint)((uint)121393U))))) || ((((uint)(v0)) == ((uint)((uint)196418U))))) || ((((uint)(v0)) == ((uint)((uint)317811U))))) || ((((uint)(v0)) == ((uint)((uint)514229U))))) || ((((uint)(v0)) == ((uint)((uint)832040U))))) || ((((uint)(v0)) == ((uint)((uint)1346269U))))) || ((((uint)(v0)) == ((uint)((uint)2178309U))))) || ((((uint)(v0)) == ((uint)((uint)3524578U))))) || ((((uint)(v0)) == ((uint)((uint)5702887U))))) || ((((uint)(v0)) == ((uint)((uint)9227465U))))) || ((((uint)(v0)) == ((uint)((uint)14930352U))))) || ((((uint)(v0)) == ((uint)((uint)24157817U))))) || ((((uint)(v0)) == ((uint)((uint)39088169U))))) || ((((uint)(v0)) == ((uint)((uint)63245986U))))) || ((((uint)(v0)) == ((uint)((uint)102334155U))))) || ((((uint)(v0)) == ((uint)((uint)165580141U))))) || ((((uint)(v0)) == ((uint)((uint)267914296U))))) || ((((uint)(v0)) == ((uint)((uint)433494437U))))) || ((((uint)(v0)) == ((uint)((uint)701408733U))))) || ((((uint)(v0)) == ((uint)((uint)1134903170U))))) || ((((uint)(v0)) == ((uint)((uint)1836311903U))))));
        }

        public static IEnumerable<Int32> Transduce(IEnumerable<Int32> input)
        {
            unchecked
            {
                IEnumerator<Int32> ie = input.GetEnumerator();
                object s = new object ();
                Int32 i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = Fun0(((uint)(i)));
                        if (temp0)
                        {
                            yield return (Int32)(i);
                            goto M0;
                        }
                        else
                        {
                            goto M0;
                        }
                    }
                }

                F0:
                {
                    yield break;
                }
            }
        }
    }
}