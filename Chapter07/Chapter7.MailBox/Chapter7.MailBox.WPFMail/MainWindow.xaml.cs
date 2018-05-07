using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Chapter7.MailBox.MailerLib;

namespace Chapter7.MailBox.WPFMail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var mailer = new SendMail();
            mailer.From = FromTextBox.Text;
            mailer.To = ToTextBox.Text;
            mailer.Subject = SubjectTextBox.Text;
            mailer.Body = BodyTextBox.Text;

            mailer.Send();

            MessageBox.Show("Your mail has bee sent.");
        }
    }
}
