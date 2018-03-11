using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using NH4CookbookHelpers;
using NHibernate.Cfg;
using NHibernate.Dialect;

namespace MappingRecipes
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 用代码配置
            //RecipeLoader.DefaultConfiguration = () => new Configuration().DataBaseIntegration(db =>
            //{
            //    db.Dialect<MsSql2008Dialect>();
            //    db.ConnectionString = @"Server=.\SqlExpress;Database=NHCookbook;Trusted_Connection=True;";
            //});

            RecipeLoader.DefaultConfiguration = () => new Configuration().Configure();

            Application.Run(new WindowsFormsRunner());
        }
    }
}
