using System;
using Eg.Core;
using NH4CookbookHelpers;
using NHibernate;
using NHibernate.Cfg;

namespace MappingRecipes.Components
{
    public class Recipe : BaseMappingRecipe
    {
        protected override void Configure(Configuration cfg)
        {
            cfg.AddAssembly(typeof(Customer).Assembly);
        }
        protected override void AddInitialData(ISession session)
        {
            session.Save(new Customer
            {
                Name = "Max Weinberg",
                BillingAddress = new Address
                {
                    Lines = "E Street 1",
                    City = "Belmar",
                    State = "New Jersey",
                    ZipCode = "123"
                },
                ShippingAddress = new Address
                {
                    Lines = "Home street",
                    City = "Newark",
                    State = "New Jersey",
                    ZipCode = "123"
                }
            });
        }
        public override void RunQueries(ISession session)
        {
            var customer = session.QueryOver<Customer>()
            .SingleOrDefault();
            Console.WriteLine(
            "Customer {0} has a billing address in {1}",
            customer.Name, customer.BillingAddress.City);
        }
    }
}


