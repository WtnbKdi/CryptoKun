using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoKun
{
    internal class AES
    {
        // AES暗号化
        public static string Encrypt(string text, byte[] key, byte[] iv)
        {
            Aes aes = Aes.Create();
            byte[] encrypteds;
            aes.Key = key;
            aes.IV = iv;
            ICryptoTransform ctf = aes.CreateEncryptor(key, iv);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, ctf, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(text);
                    }
                }
                encrypteds = ms.ToArray();
            }
            return Convert.ToBase64String(encrypteds);
        }

        // AES複号化
        public static string Decrypt(string text, byte[] key, byte[] iv)
        {
            byte[] cryptoText = Convert.FromBase64String(text);
            string decryptoText;
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                ICryptoTransform ctf = aes.CreateDecryptor(key, iv);
                using (MemoryStream ms = new MemoryStream(cryptoText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, ctf, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            decryptoText = sr.ReadToEnd();
                        }
                    }
                }
            }

            return decryptoText;
        }
    }
}
