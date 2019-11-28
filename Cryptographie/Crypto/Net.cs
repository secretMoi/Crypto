using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Security.Cryptography;

namespace Cryptographie.Crypto
{
    public class Net : Crypto
    {
        private byte[] cle;
        private byte[] iv;
        private new string nomCryptage = ".NET";
        
        public override string NomCryptage => nomCryptage;

        public Net()
        {
        }
        
        public string ProtectPassword(string clearPassword, string cle)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(clearPassword);
            this.cle = Encoding.UTF8.GetBytes(cle);
            
            byte[] protectedBytes = ProtectedData.Protect(bytes, this.cle, DataProtectionScope.CurrentUser);
            
            return Convert.ToBase64String(protectedBytes);
        }

        public string UnprotectPassword(string protectedPassword, string cle = null)
        {
            byte[] protectedBytes = Convert.FromBase64String(protectedPassword);
            if(cle != null)
                this.cle = Encoding.UTF8.GetBytes(cle);
            
            byte[] bytes = ProtectedData.Unprotect(protectedBytes, this.cle, DataProtectionScope.CurrentUser);
            
            return Encoding.UTF8.GetString(bytes);
        }
    }
}