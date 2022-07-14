using _20220717_EcommerceStoreCodeFirst.Logic.Migrations;
using System.Data.Entity;

namespace _20220717_EcommerceStoreCodeFirst.Logic
{
    public class EcommerceStoreDbContext : DbContext 
    {
        public EcommerceStoreDbContext() : base("EcommerceStoreDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EcommerceStoreDbContext, Configuration>());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
