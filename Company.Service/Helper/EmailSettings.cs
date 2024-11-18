using System.Net.Mail;
using System.Net;

namespace Company.Service.Helper
{
    public static class EmailSettings
    {
        public static void SendEmail(Email input)
        {
            var Client = new SmtpClient("smtp.gmail.com", 587);
            Client.EnableSsl = true;

            Client.Credentials = new NetworkCredential("", "");

            Client.Send("", input.To, input.Subject, input.Body);

        }
    }
}
