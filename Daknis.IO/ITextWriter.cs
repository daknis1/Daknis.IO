using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Daknis.IO
{
    public interface ITextWriter
    {
        Encoding Encoding { get; }
        IFormatProvider FormatProvider { get; }
        string NewLine { get; set; }
        TextWriter TextWriter { get; }

        void Close();
        void Flush();
        Task FlushAsync();
        void Write(bool value);
        void Write(char value);
        void Write(char[] value);
        void Write(char[] value, int index, int count);
        void Write(decimal value);
        void Write(double value);
        void Write(float value);
        void Write(int value);
        void Write(long value);
        void Write(object value);
        void Write(string value);
        void Write(string value, object arg0);
        void Write(string value, params object[] arg);
        void Write(uint value);
        void Write(ulong value);
        void WriteAsync(char value);
        void WriteAsync(char[] value);
        void WriteAsync(char[] value, int index, int count);
        void WriteAsync(string value);
        void WriteLine(bool value);
        void WriteLine(char value);
        void WriteLine(char[] value);
        void WriteLine(char[] value, int index, int count);
        void WriteLine(decimal value);
        void WriteLine(double value);
        void WriteLine(float value);
        void WriteLine(int value);
        void WriteLine(long value);
        void WriteLine(object value);
        void WriteLine(string value);
        void WriteLine(string value, object arg0);
        void WriteLine(string value, params object[] arg);
        void WriteLine(uint value);
        void WriteLine(ulong value);
        void WriteLineAsync(char value);
        void WriteLineAsync(char[] value);
        void WriteLineAsync(char[] value, int index, int count);
        void WriteLineAsync(string value);
    }
}