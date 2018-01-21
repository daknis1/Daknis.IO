using System.IO;
using System.Text;

namespace Daknis.IO
{
    public interface IStreamReader : ITextReader
    {
        StreamReader StreamReader { get; }

        Stream BaseStream { get; }
        Encoding CurrentEncoding { get; }
        bool EndOfStream { get; }

        void DiscardBufferedData();
    }
}