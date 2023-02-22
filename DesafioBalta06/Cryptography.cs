using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta06
{
    internal class Cryptography
    {
        public static string GetTextEncrypted(string text, string publicKey)
        {
            return TextEncrypted(text, publicKey);
        }

        private static string TextEncrypted(string text, string publicKey)
        {
            string ToReturn = "";

            string secretkey = "BaltaÉoMaior";           

            byte[] secretkeyByte = { };
            secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);

            byte[] publickeybyte = { };
            publickeybyte = System.Text.Encoding.UTF8.GetBytes(publicKey);

            byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(text);

            MemoryStream ms = null;
            CryptoStream cs = null;

            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                ms = new MemoryStream();
                cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                cs.FlushFinalBlock();
                ToReturn = Convert.ToBase64String(ms.ToArray());
            }

            return ToReturn;
        }
    }
}
