using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoKun
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool CheckPassword(string pw)
        {
            int pwSize = pw.Length;
            if (4 <= pwSize && pwSize <= 16) return true;
            messageListBox.Items.Add("4~16文字のパスワードに設定してください。");
            return false;
        }

        private async void cryptoButton_Click(object sender, EventArgs e)
        {
            if (!CheckPassword(pwTextBox.Text)) return;
            string[] fileNames = FileDialog.Open(openFileDialog, messageListBox, FileDialog.Mode.Crypt);
            await Crypter.EncryptAsync(fileNames, pwTextBox.Text);
            messageListBox.Items.Add("暗号化が完了しました。");
        }

        private async void decryptoButton_Click(object sender, EventArgs e)
        {
            if (!CheckPassword(pwTextBox.Text)) return;
            string[] fileNames = FileDialog.Open(openFileDialog, messageListBox, FileDialog.Mode.Decrypt);
            await Crypter.DecryptAsync(fileNames, pwTextBox.Text);
            messageListBox.Items.Add("複合化が完了しました。");
        }

    }
}

