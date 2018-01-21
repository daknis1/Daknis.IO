using System;
using System.IO;
using System.Text;

namespace Daknis.IO
{
    public interface IStreamWriter
    {
        StreamWriter StreamWriter { get; }

        bool AutoFlush { get; set; }
        Stream BaseStream { get; }
    }
}
