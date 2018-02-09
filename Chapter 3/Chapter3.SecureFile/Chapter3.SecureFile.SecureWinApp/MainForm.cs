using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapter3.SecureFile.CryptLib;

namespace Chapter3.SecureFile.SecureWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                var textFileName = OpenDialog.FileName;

                var secureFile = new CryptFile(textFileName);
                secureFile.EncryptFile();

                MessageBox.Show("File encrypted", "Information", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                var textFileName = OpenDialog.FileName;

                var secureFile = new CryptFile(textFileName);
                secureFile.DecryptFile();

                MessageBox.Show("File decrypted", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
