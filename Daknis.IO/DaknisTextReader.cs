using System;
using System.IO;
using System.Threading.Tasks;

namespace Daknis.IO
{
    public abstract class DaknisTextReader : ITextReader, IDisposable
    {
        public TextReader TextReader { get; protected set; }

        protected DaknisTextReader()
        {

        }

        public DaknisTextReader(TextReader reader)
        {
            TextReader = reader ?? throw new ArgumentNullException(nameof(reader));
        }

        public void Close()
        {
            TextReader.Close();
        }

        public object GetLifetimeService()
        {
            return TextReader.GetLifetimeService();
        }

        public void InitializeLifetimeService()
        {
            TextReader.InitializeLifetimeService();
        }

        public int Peek()
        {
            return TextReader.Peek();
        }

        public int Read()
        {
            return TextReader.Read();
        }

        public int Read(char[] buffer, int index, int count)
        {
            return TextReader.Read(buffer, index, count);
        }

        public Task<int> ReadAsync(char[] buffer, int index, int count)
        {
            return TextReader.ReadAsync(buffer, index, count);
        }

        public int ReadBlock(char[] buffer, int index, int count)
        {
            return TextReader.ReadBlock(buffer, index, count);
        }

        public Task<int> ReadBlockAsync(char[] buffer, int index, int count)
        {
            return TextReader.ReadBlockAsync(buffer, index, count);
        }

        public string ReadLine()
        {
            return TextReader.ReadLine();
        }

        public Task<string> ReadLineAsync()
        {
            return TextReader.ReadLineAsync();
        }

        public string ReadToEnd()
        {
            return TextReader.ReadToEnd();
        }

        public Task<string> ReadToEndAsync()
        {
            return TextReader.ReadLineAsync();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    TextReader.Dispose();
                }

                TextReader = null;

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
