using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;
using NHibernate.Cfg;

namespace ConfigByAppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();
            Console.WriteLine("NHibernate configured by App.config!");
            Console.ReadKey();
        }
    }
}
