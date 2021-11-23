namespace BackupRestore
{
    partial class FormRestore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChooseBackupFile = new System.Windows.Forms.Button();
            this.btnChooseRestorePath = new System.Windows.Forms.Button();
            this.rtbBackupFilePath = new System.Windows.Forms.RichTextBox();
            this.rtbRestorePath = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnRestore = new System.Windows.Forms.Button();
            this.ofdBackupFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdRestorePath = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnChooseBackupFile
            // 
            this.btnChooseBackupFile.Location = new System.Drawing.Point(93, 77);
            this.btnChooseBackupFile.Name = "btnChooseBackupFile";
            this.btnChooseBackupFile.Size = new System.Drawing.Size(119, 64);
            this.btnChooseBackupFile.TabIndex = 1;
            this.btnChooseBackupFile.Text = "Backup file";
            this.btnChooseBackupFile.UseVisualStyleBackColor = true;
            this.btnChooseBackupFile.Click += new System.EventHandler(this.btnChooseBackupFile_Click);
            // 
            // btnChooseRestorePath
            // 
            this.btnChooseRestorePath.Location = new System.Drawing.Point(93, 222);
            this.btnChooseRestorePath.Name = "btnChooseRestorePath";
            this.btnChooseRestorePath.Size = new System.Drawing.Size(119, 64);
            this.btnChooseRestorePath.TabIndex = 2;
            this.btnChooseRestorePath.Text = "Target directory";
            this.btnChooseRestorePath.UseVisualStyleBackColor = true;
            this.btnChooseRestorePath.Click += new System.EventHandler(this.btnChooseRestorePath_Click);
            // 
            // rtbBackupFilePath
            // 
            this.rtbBackupFilePath.Location = new System.Drawing.Point(275, 77);
            this.rtbBackupFilePath.Multiline = false;
            this.rtbBackupFilePath.Name = "rtbBackupFilePath";
            this.rtbBackupFilePath.ReadOnly = true;
            this.rtbBackupFilePath.Size = new System.Drawing.Size(425, 64);
            this.rtbBackupFilePath.TabIndex = 3;
            this.rtbBackupFilePath.Text = "";
            // 
            // rtbRestorePath
            // 
            this.rtbRestorePath.Location = new System.Drawing.Point(275, 222);
            this.rtbRestorePath.Multiline = false;
            this.rtbRestorePath.Name = "rtbRestorePath";
            this.rtbRestorePath.ReadOnly = true;
            this.rtbRestorePath.Size = new System.Drawing.Size(425, 64);
            this.rtbRestorePath.TabIndex = 4;
            this.rtbRestorePath.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(93, 404);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(607, 23);
            this.progressBar.TabIndex = 6;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(581, 315);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(119, 64);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // ofdBackupFile
            // 
            this.ofdBackupFile.FileName = "User Data.zip";
            // 
            // FormRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.rtbRestorePath);
            this.Controls.Add(this.rtbBackupFilePath);
            this.Controls.Add(this.btnChooseRestorePath);
            this.Controls.Add(this.btnChooseBackupFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRestore";
            this.Text = "FormRestore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseBackupFile;
        private System.Windows.Forms.Button btnChooseRestorePath;
        private System.Windows.Forms.RichTextBox rtbBackupFilePath;
        private System.Windows.Forms.RichTextBox rtbRestorePath;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.OpenFileDialog ofdBackupFile;
        private System.Windows.Forms.FolderBrowserDialog fbdRestorePath;
    }
}