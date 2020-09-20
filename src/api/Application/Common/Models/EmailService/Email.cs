namespace Application.Common.Models.EmailService
{
    public class Email
    {
        public Sender Sender { get; set; }

        public string[] Recipients { get; set; }

        public string Subject { get; set; }

        public string PlainText { get; set; }

        public string HtmlContent { get; set; }
    }
}
