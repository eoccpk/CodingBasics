using System;

namespace _20220717_EcommerceStoreCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logic.EcommerceStoreDbContext dbContext = new Logic.EcommerceStoreDbContext();
            var allCustomers = dbContext.Customers;
            foreach (var customer in allCustomers)
            {
                Console.WriteLine("Customer Name : " + customer.Name);
                Console.WriteLine("Customer Email : " + customer.Email);
                Console.WriteLine("Customer Phone : " + customer.Phone);
                Console.WriteLine("Customer Addresss : " + customer.Address);
            }

            Console.ReadKey();
        }
    }
}
