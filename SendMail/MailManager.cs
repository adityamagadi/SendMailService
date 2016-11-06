using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SendMail
{
    public static class MailManager
    {
        public static void sendMail(string toAddress)
        {
            MailMessage message = new MailMessage("adityamagadi@gmail.com", toAddress);
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            client.Credentials = new System.Net.NetworkCredential("adityamagadi@gmail.com", "Bullet35091#");
            message.Subject = "test";
            message.Body = "this is a test body";
            client.Send(message);
        }
    }
}
