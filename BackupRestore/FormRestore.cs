using BackupRestore.Helper;
using System;
using System.Threading;
using System.Windows.Forms;

namespace BackupRestore
{
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
        }

        private void btnChooseBackupFile_Click(object sender, EventArgs e)
        {
            ofdBackupFile.FileName = "User Data.zip";
            ofdBackupFile.Filter = "ZIP files (*.zip)|*.zip|All files (*.*)|*.*";
            if (ofdBackupFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rtbBackupFilePath.Text = ofdBackupFile.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnChooseRestorePath_Click(object sender, EventArgs e)
        {
            fbdRestorePath.SelectedPath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Google\Chrome\User Data";
            DialogResult result = fbdRestorePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                rtbRestorePath.Text = fbdRestorePath.SelectedPath;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Thread threadUnZip = new Thread(new ThreadStart(unZip));
            threadUnZip.Start();
        }

        private void unZip()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    try
                    {
                        ZipFileWithProgress.ExtractToDirectory(ofdBackupFile.FileName, fbdRestorePath.SelectedPath,
                    new BasicProgress<double>(p => progressBar.Value = Convert.ToInt32(p * 100)));
                        MessageBox.Show("File restored successfully");
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
