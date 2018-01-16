using System;
using System.IO;
using System.Text;

namespace Daknis.IO
{
    public class DaknisStreamReader : IStreamReader
    {
        public StreamReader StreamReader { get; private set; }

        public Stream BaseStream
        {
            get
            {
                return StreamReader.BaseStream;
            }
        }

        public Encoding CurrentEncoding
        {
            get
            {
                return StreamReader.CurrentEncoding;
            }
        }

        public bool EndOfStream
        {
            get
            {
                return StreamReader.EndOfStream;
            }
        }

        public DaknisStreamReader(Stream stream)
        {
            StreamReader = new StreamReader(stream);
        }

        public DaknisStreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
        {
            StreamReader = new StreamReader(stream, detectEncodingFromByteOrderMarks);
        }

        public DaknisStreamReader(Stream stream, Encoding encoding)
        {
            StreamReader = new StreamReader(stream, encoding);
        }

        public DaknisStreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
            StreamReader = new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks);
        }

        public DaknisStreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            StreamReader = new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize);
        }

        public DaknisStreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
        {
            StreamReader = new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen);
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
}
