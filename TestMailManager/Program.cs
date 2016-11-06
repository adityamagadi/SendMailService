using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendMail;

namespace TestMailManager
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMail.MailManager.sendMail("adityamagadi@gmail.com");
        }
    }
}
