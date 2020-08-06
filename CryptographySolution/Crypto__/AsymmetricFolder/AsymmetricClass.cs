using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crypto__.AsymmetricFolder
{
    class AsymmetricClass
    {
        public Tuple<string, string> AssignNewKey()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);
            string publicKey = RSA.ToXmlString(false);
            string privateKey = RSA.ToXmlString(true);
            var tuple = new Tuple<string, string>(privateKey, publicKey);
            return tuple;     
        }

        public string Encryption(string strText, string publicKey)
        {            
            var testData = Encoding.UTF8.GetBytes(strText);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    // client encrypting data with public key issued by server                    
                    rsa.FromXmlString(publicKey.ToString());

                    var encryptedData = rsa.Encrypt(testData, true);

                    var base64Encrypted = Convert.ToBase64String(encryptedData);

                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
        public string Decryption(string encryptText, string privateKey)
        {
            var testData = Encoding.UTF8.GetBytes(encryptText);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    var base64Encrypted = encryptText;

                    // server decrypting data with private key                    
                    rsa.FromXmlString(privateKey);
                    var resultBytes = Convert.FromBase64String(base64Encrypted);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

    }
}
