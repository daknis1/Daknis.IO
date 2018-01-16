using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Daknis.IO
{
    public interface IFile
    {
        void AppendAllLines(string path, IEnumerable<string> contents);
        void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding);
        void AppendAllText(string path, string contents);
        void AppendAllText(string path, string contents, Encoding encoding);
        void Copy(string sourceFileName, string destFileName);
        void Copy(string sourceFileName, string destFileName, bool overwrite);
        void Create(string path);
        void Create(string path, int bufferSize);
        void Create(string path, int bufferSize, FileOptions options);
        void Delete(string path);
        bool Exists(string path);
        FileAttributes GetAttributes(string path);
        DateTime GetCreationTime(string path);
        DateTime GetCreationTimeUtc(string path);
        DateTime GetLastAccessTime(string path);
        DateTime GetLastAccessTimeUtc(string path);
        DateTime GetLastWriteTime(string path);
        DateTime GetLastWriteTimeUtc(string path);
        void Move(string sourceFileName, string destFileName);
        IFileStream Open(string path, FileMode mode);
        IFileStream Open(string path, FileMode mode, FileAccess access);
        IFileStream Open(string path, FileMode mode, FileAccess access, FileShare share);
        byte[] ReadAllBytes(string path);
        string[] ReadAllLines(string path);
        string[] ReadAllLines(string path, Encoding encoding);
        string ReadAllText(string path);
        string ReadAllText(string path, Encoding encoding);
        IEnumerable<string> ReadLines(string path);
        IEnumerable<string> ReadLines(string path, Encoding encoding);
        void SetAttributes(string path, FileAttributes fileAttributes);
        void SetCreationTime(string path, DateTime creationTime);
        void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
        void SetLastAccessTime(string path, DateTime lastAccessTime);
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
        void SetLastWriteTime(string path, DateTime lastWriteTime);
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
        void WriteAllBytes(string path, byte[] bytes);
        void WriteAllLines(string path, IEnumerable<string> contents);
        void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding);
        void WriteAllText(string path, string contents);
        void WriteAllText(string path, string contents, Encoding encoding);
    }
}