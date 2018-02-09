using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapter1.Library.HelloLib;

namespace Chapter1.Library.HelloWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            var helloMessage = new HelloWorld();
            var yourName = NameTextBox.Text;

            MessageBox.Show(helloMessage.SayHello(yourName));
        }
    }
}
