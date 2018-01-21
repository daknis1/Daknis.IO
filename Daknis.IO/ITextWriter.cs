namespace Daknis.IO
{
    public interface ITextWriter
    {
        void Close();
        void Write(string value);
        void WriteLine(string value);
    }
}