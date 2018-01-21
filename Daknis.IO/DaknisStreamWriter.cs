using System;
using System.Collections.Generic;
using System.IO;

namespace Daknis.IO
{
    public class DaknisStreamWriter : DaknisTextWriter
    {
        public DaknisStreamWriter(Stream stream) : base(new StreamWriter(stream))
        {
            
        }

        public DaknisStreamWriter(StreamWriter streamWriter) : base(streamWriter)
        {

        }
    }
}
