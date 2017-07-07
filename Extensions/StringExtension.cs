using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Softveloper.Extensions
{
    public static class StringExtension
    {
        public static string ToSha512(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            using (var sha = new SHA512Managed())
            {
                var utf8Bytes = Encoding.UTF8.GetBytes(value);
                var hash = sha.ComputeHash(utf8Bytes);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }

        public static string ToValidFileName(this string fileName)
        {
            var invalidFileNameChars = Path.GetInvalidFileNameChars().ToList();
            invalidFileNameChars.ForEach(character => fileName = fileName.Replace(character.ToString(), string.Empty));
            return fileName;
        }

        public static string ToValidPath(this string path)
        {
            var invalidPathChars = Path.GetInvalidPathChars().ToList();
            invalidPathChars.ForEach(character => path = path.Replace(character.ToString(), string.Empty));
            return path;
        }
    }
}
