using System;
using System.IO;

namespace Softveloper.IO
{
    public static class Filerectory
    {
        public static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public static void WriteAllBytes(string path, byte[] bytes)
        {
            var directory = Path.GetDirectoryName(path);
            CreateDirectory(directory);
            File.WriteAllBytes(path, bytes);
        }

        public static void WriteAllText(string path, string contents)
        {
            var directory = Path.GetDirectoryName(path);
            CreateDirectory(directory);
            File.WriteAllText(path, contents);
        }
    }
}
