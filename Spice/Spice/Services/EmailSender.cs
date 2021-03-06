using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailOptions options { get; set; }
        public EmailSender(IOptions<EmailOptions> emailOptions)
        {
            options = emailOptions.Value;
        }
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(options.EmailKey, subject, message, email);
        }

        private Task Execute(string emailKey, string subject, string message, string email)
        {
            var client = new SendGridClient(emailKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("admin@spice.com", "Spice Restaurant"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));
            try
            {
                return client.SendEmailAsync(msg);
            }
            catch (Exception ex)
            { }
            return null;
        }
    }
}
