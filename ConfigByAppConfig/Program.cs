using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;

using Eg.Core;

namespace ConfigByAppConfig
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();
            Console.WriteLine("NHibernate configured by App.config!");

            //var foo = new NeedLog();
            //foo.DoSomething();

            var mapper = new ConventionModelMapper();
            nhConfig.AddMapping(mapper.CompileMappingFor(new[] { typeof(TestClass) }));
            var schemaExport = new SchemaExport(nhConfig);
            schemaExport.Create(false, true);
            Console.WriteLine("已创建表!");

            //schemaExport.SetOutputFile("db.sql").Execute(false, false, false);
            //Console.WriteLine("生成了SQL文件：{0}", Path.GetFullPath("db.sql"));

            Console.ReadKey();
        }
    }
}
