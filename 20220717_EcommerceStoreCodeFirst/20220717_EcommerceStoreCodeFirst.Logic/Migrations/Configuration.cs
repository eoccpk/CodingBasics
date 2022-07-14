namespace _20220717_EcommerceStoreCodeFirst.Logic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_20220717_EcommerceStoreCodeFirst.Logic.EcommerceStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_20220717_EcommerceStoreCodeFirst.Logic.EcommerceStoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var customer = new Customer()
            {
                Name = "Kamran",
                Email = "email@mail.com",
                Phone = "123",
                Address = "Good Address",
                Balance = 200,
            };
            context.Customers.AddOrUpdate(customer);
            context.SaveChanges();
        }
    }
}
