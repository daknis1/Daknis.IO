using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Daknis.IO
{
    public class DaknisFileStream : IFileStream
    {
        public Stream FileStream { get; private set; }

        public bool CanRead
        {
            get
            {
                return this.FileStream.CanRead;
            }
        }

        public bool CanSeek
        {
            get
            {
                return this.FileStream.CanSeek;
            }
        }

        public bool CanTimeout
        {
            get
            {
                return this.FileStream.CanTimeout;
            }
        }

        public bool CanWrite
        {
            get
            {
                return this.FileStream.CanWrite;
            }
        }

        public long Length
        {
            get
            {
                return this.FileStream.Length;
            }
        }

        public long Position
        {
            get
            {
                return this.FileStream.Position;
            }
        }

        public int ReadTimeout
        {
            get
            {
                return this.FileStream.ReadTimeout;
            }
        }

        public int WriteTimeout
        {
            get
            {
                return this.FileStream.WriteTimeout;
            }
        }

        #region Constructors
        public DaknisFileStream(Microsoft.Win32.SafeHandles.SafeFileHandle handle, FileAccess access)
        {
            this.FileStream = new FileStream(handle, access);
        }

        public DaknisFileStream(Microsoft.Win32.SafeHandles.SafeFileHandle handle, FileAccess access, int bufferSize)
        {
            this.FileStream = new FileStream(handle, access, bufferSize);
        }

        public DaknisFileStream(Microsoft.Win32.SafeHandles.SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
        {
            this.FileStream = new FileStream(handle, access, bufferSize, isAsync);
        }

        public DaknisFileStream(string path, FileMode mode)
        {
            this.FileStream = new FileStream(path, mode);
        }

        public DaknisFileStream(string path, FileMode mode, FileAccess access)
        {
            this.FileStream = new FileStream(path, mode, access);
        }

        public DaknisFileStream(string path, FileMode mode, FileAccess access, FileShare share)
        {
            this.FileStream = new FileStream(path, mode, access, share);
        }

        public DaknisFileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
        {
            this.FileStream = new FileStream(path, mode, access, share, bufferSize);
        }

        public DaknisFileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
        {
            this.FileStream = new FileStream(path, mode, access, share, bufferSize, useAsync);
        }

        public DaknisFileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
        {
            this.FileStream = new FileStream(path, mode, access, share, bufferSize, options);
        }
        #endregion Constructors

        public void CopyTo(Stream destination)
        {
            this.FileStream.CopyTo(destination);
        }

        public void CopyTo(Stream destination, int bufferSize)
        {
            this.FileStream.CopyTo(destination, bufferSize);
        }

        public Task CopyToAsync(Stream destination)
        {
            return this.FileStream.CopyToAsync(destination);
        }

        public Task CopyToAsync(Stream destination, int bufferSize)
        {
            return this.FileStream.CopyToAsync(destination, bufferSize);
        }

        public Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
        {
            return this.FileStream.CopyToAsync(destination, bufferSize, cancellationToken);
        }

        public void Flush()
        {
            this.FileStream.Flush();
        }

        public Task FlushAsync()
        {
            return this.FileStream.FlushAsync();
        }

        public Task FlushAsync(CancellationToken cancellationToken)
        {
            return this.FileStream.FlushAsync(cancellationToken);
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            return this.FileStream.Read(buffer, offset, count);
        }

        public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return this.FileStream.ReadAsync(buffer, offset, count, cancellationToken);
        }

        public Task<int> ReadAsync(byte[] buffer, int offset, int count)
        {
            return this.FileStream.ReadAsync(buffer, offset, count);
        }

        public int ReadByte()
        {
            return this.FileStream.ReadByte();
        }

        public long Seek(long offset, SeekOrigin origin)
        {
            return this.FileStream.Seek(offset, origin);
        }

        public void SetLength(long value)
        {
            this.FileStream.SetLength(value);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            this.FileStream.Write(buffer, offset, count);
        }

        public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return this.FileStream.WriteAsync(buffer, offset, count, cancellationToken);
        }

        public Task WriteAsync(byte[] buffer, int offset, int count)
        {
            return this.FileStream.WriteAsync(buffer, offset, count);
        }

        public void WriteByte(byte value)
        {
            this.FileStream.WriteByte(value);
        }

        #region IDisposable Support
        public bool IsDisposed { get; private set; } = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.IsDisposed && this.FileStream != null)
            {
                if (disposing)
                {
                    this.FileStream.Dispose();
                }

                this.IsDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion IDisposable Support
    }
}
