using System;
using System.Threading.Tasks;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Application.Common.Models.EmailService;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Infrastructure.Services.EmailService
{
    public class EmailNotifier : IEmailNotifier
    {
        /// <summary>
        /// Sends email letter
        /// </summary>
        /// <param name="email"><seealso cref="Email"/> letter model</param>
        /// <returns>SendGrid <seealso cref="Response"/></returns>
        public async Task SendEmailAsync(Email email)
        {
            await Execute(email);
        }

        private Task Execute(Email email)
        {
            var client = new SendGridClient(email.Sender.ApiKey);
            var letter = new SendGridMessage
            {
                From = new EmailAddress(email.Sender.Email, email.Sender.Name),
                Subject = email.Subject,
                PlainTextContent = email.PlainText,
                HtmlContent = email.HtmlContent ?? email.PlainText
            };

            foreach (var recipient in email.Recipients)
            {
                letter.AddTo(new EmailAddress(recipient));
            }

            try
            {
                return client.SendEmailAsync(letter);
            }
            catch (Exception ex)
            {
                throw new EmailServiceException(ex.Message);
            }
        }
    }
}
