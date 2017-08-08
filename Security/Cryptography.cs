using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Softveloper.Security
{
    public class Cryptography
    {
        public byte[] AditionalEntropy { get; set; } = { 9, 8, 7, 6, 5 };
        public DataProtectionScope ProtectionScope { get; set; } = DataProtectionScope.CurrentUser;

        public string Protect(string s)
        {
            var secret = Encoding.UTF8.GetBytes(s);
            var protect = ProtectedData.Protect(secret, AditionalEntropy, ProtectionScope);
            s = Convert.ToBase64String(protect);
            return s;
        }

        public string Unprotect(string s)
        {
            var bytes = Convert.FromBase64String(s);
            var unprotect = ProtectedData.Unprotect(bytes, AditionalEntropy, ProtectionScope);
            return Encoding.UTF8.GetString(unprotect);
        }
    }
}
