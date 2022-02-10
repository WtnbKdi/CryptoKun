using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoKun
{
    internal class Filer
    {
        static string _encryptedExt = ".encrypted"; // 暗号化ファイル拡張子

        public static void DeleteFile(string file)
        {
            File.Delete(file);
        }

        // 暗号拡張子削除
        public static string CutEncryptExtention(string file)
        {
            return file.Replace(_encryptedExt, "");
        }

        public static void CreateFile(string file)
        {
            using (FileStream fs = File.Create(file)) ;
        }

        public static void CreateEncryptedFile(string file)
        {
            using (FileStream fs = File.Create(file + _encryptedExt)) ;
        }

        public static string GetEncryptedFileName(string file)
        {
            return file + _encryptedExt;
        }

        // ファイルの中身を読み込む
        public static async Task<byte[]> ReadAsync(string file)
        {
            byte[] fileByte;
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                long fileSize = fs.Length;
                fileByte = new byte[fileSize];
                await fs.ReadAsync(fileByte, 0, (int)fileSize);
            }
            return fileByte;
        }

        // ファイルへ書き込む
        public static async Task WriteAsync(string file, string writeStr)
        {
            byte[] writeData = Encoding.UTF8.GetBytes(writeStr);
            using (FileStream fs = new FileStream(file, FileMode.Open))
                await fs.WriteAsync(writeData, 0, writeData.Length);
        }
    }
}
