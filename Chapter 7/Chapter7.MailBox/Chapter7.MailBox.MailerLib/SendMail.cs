using System;
using System.Net;
using System.Net.Mail;

namespace Chapter7.MailBox.MailerLib
{
    public class SendMail
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void Send()
        {
            var toAddress = new MailAddress(To);
            var fromAddress = new MailAddress(From);

            var message = new MailMessage(fromAddress, toAddress);
            message.Subject = Subject;
            message.Body = Body;

            var credentials = new NetworkCredential("<your_username>", "<your_password>");

            var smtp = new SmtpClient();
            smtp.Host = "host";
            smtp.Port = 0;
            smtp.EnableSsl = true;
            smtp.Credentials = credentials;

            smtp.Send(message);

        }
    }
}
