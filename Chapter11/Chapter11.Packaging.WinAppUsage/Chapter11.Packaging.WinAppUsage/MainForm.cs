using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapter11.Packaging.CalcLib;

namespace Chapter11.Packaging.WinAppUsage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var calculator = new Calculator();
            var answer = calculator.Add(10, 20);
            MessageBox.Show($"The answer is {answer}");
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            var calculator = new Calculator();
            var answer = calculator.Subtract(50, 20);
            MessageBox.Show($"The answer is {answer}");
        }
    }
}
