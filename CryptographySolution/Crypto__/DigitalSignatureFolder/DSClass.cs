using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Crypto__.DigitalSignatureFolder
{
    class DSClass
    {
        public Tuple<string, string> GenerateKey()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048);
            string publicKey = RSA.ToXmlString(false);
            string privateKey = RSA.ToXmlString(true);         
            var tuple = new Tuple<string, string>(privateKey, publicKey);
            return tuple;
        }
        //readfile
        public string Readfile(string path)
        {
            string text;
            using (var streamReader = new StreamReader(@path, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
                streamReader.Close();
            }
            return text;
        }
        //savesignedtext
        public string GetNameFromFullName(string pFullName)
        {
            return pFullName.Substring(0, pFullName.LastIndexOf("."));
        }
        public void SaveSignedMessage(string signedtext, string filename)
        {
            
            System.IO.StreamWriter str = System.IO.File.AppendText(filename+"_signed.txt");
            str.WriteLine(signedtext);
            str.Close();
           
        }

        //Sign
        public string SignData(string message, string privateKey)
        {            
            string signedMessage;
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
                //Initiate a new instanse with 2048 bit key size

                rsa.FromXmlString(privateKey);
                // Load private key

                signedMessage = Convert.ToBase64String(rsa.SignData(Encoding.UTF8.GetBytes(message), CryptoConfig.MapNameToOID("SHA512")));
                //rsa.SignData( buffer, hash algorithm) - For signed data. Here I used SHA512 for hash. 
                //Encoding.UTF8.GetBytes(string) - convert string to byte messafe 
                //Convert.ToBase64String(string) - convert back to a string.
            }
            catch (Exception)
            {
                signedMessage = string.Empty;
            }
            return signedMessage;
        }

        //Verify
        public bool VerifyData(string originalMessage, string signedMessage, string publicKey)
        {            
            bool verified;
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
                rsa.FromXmlString(publicKey);
                // load public key 
                verified = rsa.VerifyData(Encoding.UTF8.GetBytes(originalMessage), CryptoConfig.MapNameToOID("SHA512"), Convert.FromBase64String(signedMessage));
            }
            catch (Exception)
            {
                verified = false;
            }

            return verified;
        }


    }
}
