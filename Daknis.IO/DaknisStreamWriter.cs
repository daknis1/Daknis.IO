using System;
using System.IO;
using System.Text;

namespace Daknis.IO
{
    public class DaknisStreamWriter : DaknisTextWriter
    {
        private StreamWriter streamWriter;

        public StreamWriter StreamWriter
        {
            get
            {
                return streamWriter;
            }
            private set
            {
                
            }
        }

        public DaknisStreamWriter(Stream stream) : base(new StreamWriter(stream))
        {
            
        }

        public DaknisStreamWriter(StreamWriter streamWriter) : base(streamWriter)
        {

        }
    }
}
