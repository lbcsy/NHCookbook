using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace ConfigByFNH
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbConfig = MsSqlConfiguration.MsSql2008
                .ConnectionString(connStr => connStr.FromConnectionStringWithKey("db"))
                .AdoNetBatchSize(100);
            var nhConfig = Fluently.Configure().Database(dbConfig).BuildConfiguration();
            var sessionFactory = nhConfig.BuildSessionFactory();
            Console.WriteLine("NHibernate configured fluently!");
            Console.ReadKey();
        }
    }
}
