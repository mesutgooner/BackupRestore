namespace BackupRestore
{
    partial class FormBackup
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
            this.btnChooseBackupDirectory = new System.Windows.Forms.Button();
            this.btnChooseTargetDirectory = new System.Windows.Forms.Button();
            this.sfdBackup = new System.Windows.Forms.SaveFileDialog();
            this.rtbBackupDirectory = new System.Windows.Forms.RichTextBox();
            this.rtbTargetDirectory = new System.Windows.Forms.RichTextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.fbdBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnChooseBackupDirectory
            // 
            this.btnChooseBackupDirectory.Location = new System.Drawing.Point(57, 99);
            this.btnChooseBackupDirectory.Name = "btnChooseBackupDirectory";
            this.btnChooseBackupDirectory.Size = new System.Drawing.Size(119, 64);
            this.btnChooseBackupDirectory.TabIndex = 0;
            this.btnChooseBackupDirectory.Text = "Directory";
            this.btnChooseBackupDirectory.UseVisualStyleBackColor = true;
            this.btnChooseBackupDirectory.Click += new System.EventHandler(this.btnChooseBackupDirectory_Click);
            // 
            // btnChooseTargetDirectory
            // 
            this.btnChooseTargetDirectory.Location = new System.Drawing.Point(57, 215);
            this.btnChooseTargetDirectory.Name = "btnChooseTargetDirectory";
            this.btnChooseTargetDirectory.Size = new System.Drawing.Size(119, 64);
            this.btnChooseTargetDirectory.TabIndex = 1;
            this.btnChooseTargetDirectory.Text = "Target File";
            this.btnChooseTargetDirectory.UseVisualStyleBackColor = true;
            this.btnChooseTargetDirectory.Click += new System.EventHandler(this.btnChooseTargetDirectory_Click);
            // 
            // rtbBackupDirectory
            // 
            this.rtbBackupDirectory.Location = new System.Drawing.Point(219, 99);
            this.rtbBackupDirectory.Multiline = false;
            this.rtbBackupDirectory.Name = "rtbBackupDirectory";
            this.rtbBackupDirectory.ReadOnly = true;
            this.rtbBackupDirectory.Size = new System.Drawing.Size(505, 64);
            this.rtbBackupDirectory.TabIndex = 2;
            this.rtbBackupDirectory.Text = "";
            // 
            // rtbTargetDirectory
            // 
            this.rtbTargetDirectory.Location = new System.Drawing.Point(219, 215);
            this.rtbTargetDirectory.Multiline = false;
            this.rtbTargetDirectory.Name = "rtbTargetDirectory";
            this.rtbTargetDirectory.ReadOnly = true;
            this.rtbTargetDirectory.Size = new System.Drawing.Size(505, 64);
            this.rtbTargetDirectory.TabIndex = 3;
            this.rtbTargetDirectory.Text = "";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(605, 323);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(119, 64);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(57, 405);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(667, 23);
            this.progressBar.TabIndex = 5;
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.rtbTargetDirectory);
            this.Controls.Add(this.rtbBackupDirectory);
            this.Controls.Add(this.btnChooseTargetDirectory);
            this.Controls.Add(this.btnChooseBackupDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBackup";
            this.Text = "FormBackup";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChooseBackupDirectory;
        private System.Windows.Forms.Button btnChooseTargetDirectory;
        private System.Windows.Forms.SaveFileDialog sfdBackup;
        private System.Windows.Forms.RichTextBox rtbBackupDirectory;
        private System.Windows.Forms.RichTextBox rtbTargetDirectory;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.FolderBrowserDialog fbdBackup;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}