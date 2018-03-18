using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapter7.Networking.ReadIPLib;

namespace Chapter7.Networking.IPListWindows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            var ipLib = new IPReader();
            IPListBox.Items.AddRange(ipLib.GetMyIPAddress().ToArray());

        }
    }
}
