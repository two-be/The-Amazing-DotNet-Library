using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Softveloper.Extensions
{
    public static class StringExtensions
    {
        public static string ToSha384(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            using (var sha = new SHA384Managed())
            {
                var utf8Bytes = Encoding.UTF8.GetBytes(value);
                var hash = sha.ComputeHash(utf8Bytes);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
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

        public static string ToValidFileName(this string fileName)
        {
            var invalidFileNameChars = Path.GetInvalidFileNameChars().ToList();
            invalidFileNameChars.ForEach(character => fileName = fileName.Replace(character.ToString(), string.Empty));
            return fileName;
        }
    }
}
