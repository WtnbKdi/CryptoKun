using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoKun
{
    static class FileDialog
    {
        public enum Mode
        {
            Crypt,
            Decrypt
        }

        public static void ShowDialog(OpenFileDialog ofd, Mode mode)
        {
            ofd.InitialDirectory = @"c:\";
            if(mode == Mode.Crypt) ofd.Filter = "テキストファイル(*.*)|*.*";
            else ofd.Filter = "暗号化ファイル(*.encrypted)|*.encrypted";
            ofd.Multiselect = true;
            ofd.ShowDialog();
            if (ofd.FileNames[0] == "openFileDialog") 
                throw new Exception("ファイルを選択してください。");
        }

        public static string[] GetFileNames(OpenFileDialog ofd)
        {
            return ofd.FileNames;
        }

        public static void PrintSelectedFiles(OpenFileDialog ofd, ListBox msgLbx)
        {
            msgLbx.Items.Add("選択されたファイル");
            foreach (var file in ofd.FileNames)
                msgLbx.Items.Add(file);
        }

        public static string[] Open(OpenFileDialog ofd, ListBox lb, Mode mode)
        {
            try { FileDialog.ShowDialog(ofd, mode); }
            catch (Exception) { return null; }
            FileDialog.PrintSelectedFiles(ofd, lb);
            return FileDialog.GetFileNames(ofd);
        }
    }
}
