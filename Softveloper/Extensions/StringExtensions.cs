using System;
using System.Security.Cryptography;
using System.Text;

namespace Softveloper.Extensions
{
    public static class StringExtensions
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
    }
}
