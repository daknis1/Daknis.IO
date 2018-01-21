using System;
using System.Collections.Generic;
using System.IO;

namespace Daknis.IO
{
    public abstract class DaknisTextWriter : ITextWriter, IDisposable
    {
        protected TextWriter Writer;

        public DaknisTextWriter(TextWriter writer)
        {
            Writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public void Close()
        {
            Writer.Close();
        }

        public void Write(string value)
        {
            Writer.Write(value);
        }

        public void WriteLine(string value)
        {
            Writer.WriteLine(value);
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Writer.Dispose();
                }

                Writer = null;

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
