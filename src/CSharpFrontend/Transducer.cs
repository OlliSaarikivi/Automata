using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend
{
    public abstract class Transducer<TIn, TOut>
    {
        public abstract IEnumerable<TOut> Update(TIn datum);
        public virtual IEnumerable<TOut> Finish() { yield break; }
    }

    public abstract class Composition<TInner, TOuter>
    {
    }

    public abstract class SpecialTransducer { }
}
