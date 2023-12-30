using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eg.Core
{
    public class Entity
    {
        public virtual Guid Id { get; protected set; }
    }

    public class Product : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal UnitPrice { get; set; }
    }

    public class Book : Product
    {
        public virtual string ISBN { get; set; }
        public virtual string Author { get; set; }
    }

    public class Movie : Product
    {
        public virtual string Director { get; set; }
    }

    public class Address
    {
        public virtual Guid Id { get; protected set; }
        public virtual string Lines { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string ZipCode { get; set; }
    }

    public class Customer: Entity
    {
        public virtual string Name { get; set; }
        public virtual Address BillingAddress { get; set; }
        public virtual Address ShippingAddress { get; set; }
    }
}
