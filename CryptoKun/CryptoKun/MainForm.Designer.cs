namespace CryptoKun
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cryptoButton = new System.Windows.Forms.Button();
            this.decryptoButton = new System.Windows.Forms.Button();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // cryptoButton
            // 
            this.cryptoButton.Location = new System.Drawing.Point(411, 61);
            this.cryptoButton.Name = "cryptoButton";
            this.cryptoButton.Size = new System.Drawing.Size(165, 25);
            this.cryptoButton.TabIndex = 1;
            this.cryptoButton.Text = "暗号化";
            this.cryptoButton.UseVisualStyleBackColor = true;
            this.cryptoButton.Click += new System.EventHandler(this.cryptoButton_Click);
            // 
            // decryptoButton
            // 
            this.decryptoButton.Location = new System.Drawing.Point(411, 92);
            this.decryptoButton.Name = "decryptoButton";
            this.decryptoButton.Size = new System.Drawing.Size(165, 25);
            this.decryptoButton.TabIndex = 2;
            this.decryptoButton.Text = "複合化";
            this.decryptoButton.UseVisualStyleBackColor = true;
            this.decryptoButton.Click += new System.EventHandler(this.decryptoButton_Click);
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 12;
            this.messageListBox.Location = new System.Drawing.Point(12, 12);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.ScrollAlwaysVisible = true;
            this.messageListBox.Size = new System.Drawing.Size(391, 184);
            this.messageListBox.TabIndex = 3;
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(428, 27);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(148, 19);
            this.pwTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "パスワード (4～16文字)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 204);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.decryptoButton);
            this.Controls.Add(this.cryptoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "CryptoKun(テキストファイルAES暗号化ツール)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button cryptoButton;
        private System.Windows.Forms.Button decryptoButton;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.Label label1;
    }
}

