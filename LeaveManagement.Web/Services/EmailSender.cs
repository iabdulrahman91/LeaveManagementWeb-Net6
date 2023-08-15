using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagement.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private string smtpServer;
        private int smtpPort;
        private string senderEmail;

        public EmailSender(string smtpServer, int smtpPort, string senderEmail)
        {
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
            this.senderEmail = senderEmail;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var msg = new MailMessage()
            {
                From = new MailAddress(this.senderEmail),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            msg.To.Add(new MailAddress(email));

            using var client = new SmtpClient(this.smtpServer, this.smtpPort);
            client.Send(msg);

            return Task.CompletedTask;
        }
    }
}
