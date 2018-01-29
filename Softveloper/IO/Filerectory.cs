using System;
using System.IO;

namespace Softveloper.IO
{
    public class Filerectory
    {
        public static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
