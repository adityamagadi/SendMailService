using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace SendMail.Interfaces
{
    public interface ISendMailManager
    {
        SmtpClient createStmpClient();
        void sendMail();
        MailMessage composeMailMessage(string toAddress, string fromAddress);
    }
}
