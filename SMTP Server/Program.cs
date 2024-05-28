using System;
using System.Net;
using System.Net.Mail;
namespace EmailSender
{
    using System;
    using System.Net;
    using System.Net.Mail;

    class Program
    {
        static void Main()
        {
            string fromAddress = "your_email@example.com";
            string toAddress = "recipient_email@example.com";
            string subject = "Mail Subject";
            string body = "Mail Body";

            string smtpServer = "smtp.example.com";
            int smtpPort = 587; // SMTP Port
            string smtpUser = "your_email@example.com"; // SMTP username
            string smtpPass = "your_password"; // SMTP password

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromAddress);
                mail.To.Add(toAddress);
                mail.Subject = subject;
                mail.Body = body;

                SmtpClient smtp = new SmtpClient(smtpServer, smtpPort);
                smtp.Credentials = new NetworkCredential(smtpUser, smtpPass);
                smtp.EnableSsl = true; // Enable SSL if required

                smtp.Send(mail);

                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }
    }

}
