using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration
{
    [Serializable]
    public class SymbolicExplorationException : Exception
    {
        public SymbolicExplorationException() { }
        public SymbolicExplorationException(string message) : base(message) { }
        public SymbolicExplorationException(string message, Exception inner) : base(message, inner) { }
        protected SymbolicExplorationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
