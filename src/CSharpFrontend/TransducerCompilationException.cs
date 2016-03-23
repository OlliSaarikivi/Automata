using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend
{
    [Serializable]
    public class TransducerCompilationException : Exception
    {
        public TransducerCompilationException() { }
        public TransducerCompilationException(string message) : base(message) { }
        public TransducerCompilationException(string message, Exception inner) : base(message, inner) { }
        protected TransducerCompilationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
