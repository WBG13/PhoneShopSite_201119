using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhoneShopSite_201119.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Name ="x", Price = 30000, Producer = "x"});

            context.Phones.Add(new Phone() { Name = "y", Price = 50000, Producer = "y" });

            context.Phones.Add(new Phone() { Name = "z", Price = 60000, Producer = "z" });

            base.Seed(context);
        }
    }
}