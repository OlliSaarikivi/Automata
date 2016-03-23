using Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration
{
    abstract class AccessorOrMutator
    {
        /// <summary>
        /// Evaluate an accessor or just return a mutator
        /// </summary>
        /// <param name="visitor">The context for the evaluation</param>
        /// <returns></returns>
        public abstract Mutator GetMutator(IAccessorVisitor visitor);
    }
}
