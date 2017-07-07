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
        public static string ToValidFileFolderName(this string path)
        {
            var invalidFileNameChars = Path.GetInvalidFileNameChars().ToList();
            var invalidPathChars = Path.GetInvalidPathChars().ToList();

            invalidFileNameChars.ForEach(character => path = path.Replace(character.ToString(), string.Empty));
            invalidPathChars.ForEach(character => path = path.Replace(character.ToString(), string.Empty));

            return path;
        }

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
    }
}
