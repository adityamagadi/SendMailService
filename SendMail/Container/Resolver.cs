using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using SendMail.Interfaces;

namespace SendMail.Container
{
    public class Resolver: NinjectModule
    {
        public override void Load()
        {
            Bind<ISendMailManager>().To<SendMail.MailManager>();
        }
    }
}
