using BackupRestore.Helper;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BackupRestore
{
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
            progressBar.Maximum = 100;
            progressBar.Minimum = 0;
        }

        private void btnChooseBackupDirectory_Click(object sender, EventArgs e)
        {
            fbdBackup.SelectedPath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Google\Chrome\User Data";
            fbdBackup.ShowNewFolderButton = false;
            DialogResult result = fbdBackup.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    rtbBackupDirectory.Text = fbdBackup.SelectedPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnChooseTargetDirectory_Click(object sender, EventArgs e)
        {
            sfdBackup.InitialDirectory = Path.GetFullPath(@"C:\Users\" + Environment.UserName + @"\AppData\Local\Google\Chrome\User Data");
            sfdBackup.RestoreDirectory = true;
            sfdBackup.DefaultExt = "zip";
            sfdBackup.Filter = "ZIP files (*.zip)|*.zip|All files (*.*)|*.*";
            sfdBackup.FileName = "User Data";
            DialogResult result = sfdBackup.ShowDialog();
            if (result == DialogResult.OK)
            {
                rtbTargetDirectory.Text = sfdBackup.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Thread threadZip = new Thread(new ThreadStart(zipFile));
            threadZip.Start();
        }

        private void zipFile()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                    {
                        try
                        {
                            ZipFileWithProgress.CreateFromDirectory(rtbBackupDirectory.Text, rtbTargetDirectory.Text,
                        new BasicProgress<double>(p => progressBar.Value = Convert.ToInt32(p * 100)
                        ));
                            MessageBox.Show("Backup file saved to " + rtbTargetDirectory.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }));
            }
        }
    }
}
