using System;
using System.IO;
using System.Threading.Tasks;

namespace Daknis.IO
{
    public interface ITextReader : IDisposable
    {
        TextReader TextReader { get; }

        void Close();
        int Peek();
        int Read();
        int Read(char[] buffer, int index, int count);
        Task<int> ReadAsync(char[] buffer, int index, int count);
        int ReadBlock(char[] buffer, int index, int count);
        Task<int> ReadBlockAsync(char[] buffer, int index, int count);
        string ReadLine();
        Task<string> ReadLineAsync();
        string ReadToEnd();
        Task<string> ReadToEndAsync();
    }
}