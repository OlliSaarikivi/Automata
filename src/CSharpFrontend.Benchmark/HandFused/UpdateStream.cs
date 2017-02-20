using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransducerBenchmarks.HandFused
{
    class UpdateStream
    {
        private Stream stream;

        public UpdateStream(Stream stream)
        {
            this.stream = stream;
        }

        public void Update(byte b)
        {
            stream.WriteByte(b);
        }
    }
}
