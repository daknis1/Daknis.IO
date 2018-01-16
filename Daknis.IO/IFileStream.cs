using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Daknis.IO
{
    public interface IFileStream
    {
        bool CanRead { get; }
        bool CanSeek { get; }
        bool CanTimeout { get; }
        bool CanWrite { get; }
        Stream FileStream { get; }
        bool IsDisposed { get; }
        long Length { get; }
        long Position { get; }
        int ReadTimeout { get; }
        int WriteTimeout { get; }

        void CopyTo(Stream destination);
        void CopyTo(Stream destination, int bufferSize);
        Task CopyToAsync(Stream destination);
        Task CopyToAsync(Stream destination, int bufferSize);
        Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken);
        void Dispose();
        void Flush();
        Task FlushAsync();
        Task FlushAsync(CancellationToken cancellationToken);
        int Read(byte[] buffer, int offset, int count);
        Task<int> ReadAsync(byte[] buffer, int offset, int count);
        Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        int ReadByte();
        long Seek(long offset, SeekOrigin origin);
        void SetLength(long value);
        void Write(byte[] buffer, int offset, int count);
        Task WriteAsync(byte[] buffer, int offset, int count);
        Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        void WriteByte(byte value);
    }
}