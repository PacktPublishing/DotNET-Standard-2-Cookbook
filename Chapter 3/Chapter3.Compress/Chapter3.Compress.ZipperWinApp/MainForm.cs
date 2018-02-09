using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapter3.Compress.CompressLib;

namespace Chapter3.Compress.ZipperWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (ZipFolder.ShowDialog() == DialogResult.OK)
            {
                FolderTextBox.Text = ZipFolder.SelectedPath;

                string zipFileName = @"C:\Projects\Chapter3\TestFolder\result.zip";

                var zipFile = new Zipper(zipFileName);
                zipFile.CompressFile(FolderTextBox.Text);

                MessageBox.Show("You folder has been zipped.", 
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var fileList = zipFile.ListArchive(zipFileName);
                FileListBox.Items.AddRange(fileList.ToArray());
            }
                
        }
    }
}
