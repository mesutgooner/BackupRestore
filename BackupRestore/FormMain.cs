using System;
using System.Windows.Forms;

namespace BackupRestore
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            FormBackup formBackup = new FormBackup();
            Hide();
            formBackup.ShowDialog();
            Show();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            FormRestore formRestore = new FormRestore();
            Hide();
            formRestore.ShowDialog();
            Show();
        }
    }
}
