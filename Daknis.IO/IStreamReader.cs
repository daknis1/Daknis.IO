using System.IO;
using System.Text;

namespace Daknis.IO
{
    public interface IStreamReader
    {
        Stream BaseStream { get; }
        Encoding CurrentEncoding { get; }
        bool EndOfStream { get; }
        StreamReader StreamReader { get; }

        void Open();
    }
}