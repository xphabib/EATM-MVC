using EatmMVC.Models;

namespace EatmMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EatmMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EatmMVC.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Accounts.AddOrUpdate(
                p => p.Id,
                new Account {Id = 1, CardNumber = 1, PinNumber = 123, Balance = 500},
                new Account {Id = 2, CardNumber = 2, PinNumber = 234, Balance = 1500},
                new Account {Id = 3, CardNumber = 3, PinNumber = 567, Balance = 1800}
            );
            context.SaveChanges();
        }
    }
}
