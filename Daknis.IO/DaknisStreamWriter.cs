using System;
using System.IO;
using System.Text;

namespace Daknis.IO
{
    public class DaknisStreamWriter : DaknisTextWriter, IStreamWriter
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
                TextWriter = streamWriter = value;
            }
        }

        public bool AutoFlush
        {
            get
            {
                return StreamWriter.AutoFlush;
            }
            set
            {
                StreamWriter.AutoFlush = value;
            }
        }

        public Stream BaseStream
        {
            get
            {
                return StreamWriter.BaseStream;
            }
        }        

        public DaknisStreamWriter(StreamWriter streamWriter) : base()
        {
            StreamWriter = streamWriter ?? throw new ArgumentNullException(nameof(streamWriter));
        }

        public DaknisStreamWriter(Stream stream) : base()
        {
            StreamWriter = new StreamWriter(stream);
        }

        public DaknisStreamWriter(Stream stream, Encoding encoding) : base()
        {
            StreamWriter = new StreamWriter(stream, encoding);
        }

        public DaknisStreamWriter(Stream stream, Encoding encoding, int bufferSize) : base()
        {
            StreamWriter = new StreamWriter(stream, encoding, bufferSize);
        }

        public DaknisStreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) : base()
        {
            StreamWriter = new StreamWriter(stream, encoding, bufferSize, leaveOpen);
        }

        public DaknisStreamWriter(string path, bool append) : base()
        {
            StreamWriter = new StreamWriter(path, append);
        }

        public DaknisStreamWriter(string path, bool append, Encoding encoding) : base()
        {
            StreamWriter = new StreamWriter(path, append, encoding);
        }

        public DaknisStreamWriter(string path, bool append, Encoding encoding, int bufferSize) : base()
        {
            StreamWriter = new StreamWriter(path, append, encoding, bufferSize);
        }
    }
}
