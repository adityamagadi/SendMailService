using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using SendMail.Interfaces;

namespace SendMail
{
    public class MailManager : ISendMailManager
    {
        private SmtpClient _client;
        public void sendMail()
        {
            _client = createStmpClient();
            _client.Send(composeMailMessage("",""));
        }

        public MailMessage composeMailMessage(string toAddress, string fromAddress)
        {
            MailMessage message = new MailMessage(fromAddress, toAddress);
            message.Subject = "test";
            message.Body = "this is a test body";
            return message;
        }

        public SmtpClient createStmpClient()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            client.Credentials = new System.Net.NetworkCredential("adityamagadi@gmail.com", "");
            return client;
        }
    }

}
