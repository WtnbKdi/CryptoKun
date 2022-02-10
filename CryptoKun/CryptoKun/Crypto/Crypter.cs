using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoKun
{
    internal class Crypter
    {
        static byte[] _pwBytes = new byte[16]; // パスワード 16byte

        // 暗号化
        public static async Task EncryptAsync(string[] fileNames, string pw)
        {
            byte[] srcPwBytes = Encoding.UTF8.GetBytes(pw);
            Array.Copy(srcPwBytes, _pwBytes, srcPwBytes.Length);
            foreach (var file in fileNames)
            {
                string fileDataStr = Converter.BytesToUTF8String(await Filer.ReadAsync(file));  //ファイルの中身を読み込む   
                string encryptData = AES.Encrypt(fileDataStr, _pwBytes, _pwBytes);              // ファイル暗号化
                Filer.DeleteFile(file);                                                         // 暗号化前のファイルを削除
                Filer.CreateEncryptedFile(file);                                                // 暗号化ファイル作成                        
                await Filer.WriteAsync(Filer.GetEncryptedFileName(file), encryptData);          // 暗号化ファイルに元ファイルの中身を書き込む
            }
        }

        // 複合化
        public static async Task DecryptAsync(string[] fileNames, string pw)
        {
            byte[] srcPwBytes = Encoding.UTF8.GetBytes(pw);
            Array.Copy(srcPwBytes, _pwBytes, srcPwBytes.Length);
            foreach (var file in fileNames)
            {
                string fileDataStr = Converter.BytesToUTF8String(await Filer.ReadAsync(file)); 
                string decryptData = AES.Decrypt(fileDataStr, _pwBytes, _pwBytes);
                string decryptFile = Filer.CutEncryptExtention(file);
                Filer.DeleteFile(file);
                Filer.CreateFile(decryptFile);
                await Filer.WriteAsync(decryptFile, decryptData);                              
            }
        }
    }
}
