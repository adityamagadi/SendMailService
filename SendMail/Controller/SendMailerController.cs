using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Reflection;
using SendMail.Interfaces;

namespace SendMail.Controller
{
    public static class SendMailerController
    {
        public static void SendMail()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var mailHandler = kernel.Get<ISendMailManager>();
            mailHandler.sendMail();
        }

    }
}
