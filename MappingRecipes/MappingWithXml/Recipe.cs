using NHibernate;
using NH4CookbookHelpers;
using NHibernate.Cfg;

using Eg.Core;
using NHibernate.Tool.hbm2ddl;

namespace MappingRecipes.MappingWithXml
{
    public class Recipe : BaseMappingRecipe
    {
        protected override void Configure(Configuration nhConfig)
        {
            nhConfig.AddAssembly(typeof(Product).Assembly);
        }

        protected override void AddInitialData(ISession session)
        {
            session.Save(new Product()
            {
                Name = "Car",
                Description = "一辆红色好车",
                UnitPrice = 300
            });
        }
    }
}
