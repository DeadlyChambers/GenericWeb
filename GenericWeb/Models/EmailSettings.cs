namespace GenericWeb.Models
{
    public class EmailSettings
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Subject { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public string EmailRequestMessage { get; set; }
    }
}