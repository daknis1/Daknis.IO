using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Daknis.IO
{
    public abstract class DaknisTextWriter : ITextWriter
    {
        public TextWriter TextWriter { get; protected set; }

        public Encoding Encoding
        {
            get
            {
                return TextWriter.Encoding;
            }
        }

        public IFormatProvider FormatProvider
        {
            get
            {
                return TextWriter.FormatProvider;
            }
        }

        public string NewLine
        {
            get
            {
                return TextWriter.NewLine;
            }
            set
            {
                TextWriter.NewLine = value;
            }
        }

        protected DaknisTextWriter()
        {
            
        }

        public DaknisTextWriter(TextWriter writer)
        {
            TextWriter = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public void Close()
        {
            TextWriter.Close();
        }

        public void Flush()
        {
            TextWriter.Flush();
        }

        public Task FlushAsync()
        {
            return TextWriter.FlushAsync();
        }

        public void Write(bool value)
        {
            TextWriter.Write(value);
        }

        public void Write(char value)
        {
            TextWriter.Write(value);
        }

        public void Write(char[] value)
        {
            TextWriter.Write(value);
        }

        public void Write(char[] value, int index, int count)
        {
            TextWriter.Write(value, index, count);
        }

        public void Write(decimal value)
        {
            TextWriter.Write(value);
        }

        public void Write(double value)
        {
            TextWriter.Write(value);
        }

        public void Write(Int32 value)
        {
            TextWriter.Write(value);
        }

        public void Write(Int64 value)
        {
            TextWriter.Write(value);
        }

        public void Write(object value)
        {
            TextWriter.Write(value);
        }

        public void Write(Single value)
        {
            TextWriter.Write(value);
        }

        public void Write(string value)
        {
            TextWriter.Write(value);
        }

        public void Write(string value, object arg0)
        {
            TextWriter.Write(value, arg0);
        }

        public void Write(string value, params object[] arg)
        {
            TextWriter.Write(value, arg);
        }

        public void Write(UInt32 value)
        {
            TextWriter.Write(value);
        }

        public void Write(UInt64 value)
        {
            TextWriter.Write(value);
        }

        public void WriteAsync(char value)
        {
            TextWriter.WriteAsync(value);
        }

        public void WriteAsync(char[] value)
        {
            TextWriter.WriteAsync(value);
        }

        public void WriteAsync(char[] value, int index, int count)
        {
            TextWriter.WriteAsync(value, index, count);
        }

        public void WriteAsync(string value)
        {
            TextWriter.WriteAsync(value);
        }

        public void WriteLine(bool value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(char value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(char[] value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(char[] value, int index, int count)
        {
            TextWriter.WriteLine(value, index, count);
        }

        public void WriteLine(decimal value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(double value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(Int32 value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(Int64 value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(object value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(Single value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(string value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(string value, object arg0)
        {
            TextWriter.WriteLine(value, arg0);
        }

        public void WriteLine(string value, params object[] arg)
        {
            TextWriter.WriteLine(value, arg);
        }

        public void WriteLine(UInt32 value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLine(UInt64 value)
        {
            TextWriter.WriteLine(value);
        }

        public void WriteLineAsync(char value)
        {
            TextWriter.WriteLineAsync(value);
        }

        public void WriteLineAsync(char[] value)
        {
            TextWriter.WriteLineAsync(value);
        }

        public void WriteLineAsync(char[] value, int index, int count)
        {
            TextWriter.WriteLineAsync(value, index, count);
        }

        public void WriteLineAsync(string value)
        {
            TextWriter.WriteLineAsync(value);
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    TextWriter.Dispose();
                }

                TextWriter = null;

                disposedValue = true;
            }
        }
        
        void IDisposable.Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
