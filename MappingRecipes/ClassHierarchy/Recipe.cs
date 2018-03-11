﻿using Eg.Core;
using NH4CookbookHelpers;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingRecipes.ClassHierarchy
{
    public class Recipe : BaseMappingRecipe
    {
        protected override void Configure(Configuration cfg)
        {
            cfg.AddAssembly(typeof(Product).Assembly);
        }

        protected override void AddInitialData(ISession session)
        {
            session.Save(new Book
            {
                Name = "NHibernate Cookbook",
                ISBN = "12334"
            });
            session.Save(new Movie
            {
                Name = "Intouchables",
                Director = "Olivier Nakache"
            });
        }
        public override void RunQueries(ISession session)
        {
            session.CreateQuery("from Product").List<Product>();
        }
    }
}
