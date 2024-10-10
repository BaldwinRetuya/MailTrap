using MailKit.Net.Smtp;
using MimeKit;

namespace PhonesDL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("FromMyNotes", "do-not-reply@frommynotes.com"));
            message.To.Add(new MailboxAddress("Baldwin Retuya", "baldwinretuya@gmail.com"));
            message.Subject = "Thanks for Subscribing!";

            message.Body = new TextPart("html")
            {
                Text = "<h1>Hi, User!</h1>" +
                "<p>Thank you for subscribing to frommynotes newsletter.</p>" +
                "<p><strong>Welcome!</strong></p>"
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                    client.Authenticate("2c0ef11d8831d9", "e0041f0559923c");

                    client.Send(message);
                    Console.WriteLine("Email sent successfully through Mailtrap.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }
    }
}