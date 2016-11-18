using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendMail.Controller;

namespace TestMailManager
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMailerController.SendMail();
        }
    }
}
