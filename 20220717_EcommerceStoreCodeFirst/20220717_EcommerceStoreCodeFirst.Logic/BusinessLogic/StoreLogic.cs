using System;
using System.Data.Entity;
using System.Linq;
namespace _20220717_EcommerceStoreCodeFirst.Logic.BusinessLogic
{
    public class StoreLogic
    {
        EcommerceStoreDbContext db = new EcommerceStoreDbContext();

        /// <summary>
        /// Add New Customer
        /// </summary>
        /// <param name="customer"></param>
        public void AddNewCustomer()
        {
            Customer customer = new Customer();
            customer.Name = "Kamran Qadir";
            customer.Email = "test@test.com";
            customer.Phone = "123";
            customer.Address = "Good Address";
            customer.Balance = 200;
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        /// <summary>
        /// Get Customer
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int CustomerId)
        {
            //return db.Customers.Find(CustomerId);
            return db.Customers.SingleOrDefault(x => x.Id == CustomerId);

            // LINQ Query Syntax
            //var customer = (from c in db.Customers
            //                select c).SingleOrDefault();
            //return customer;
        }

        /// <summary>
        /// Update Product
        /// </summary>
        public void UpdateProduct()
        {
            int productId = 1;
            var product = db.Products.FirstOrDefault(x => x.Id == productId);
            product.StockQuantity = "100";
            db.SaveChanges();
        }

        /// <summary>
        /// Delete Products
        /// </summary>
        public void DeleteProducts()
        {
            // Delete Product By Id
            int productId = 1;
            var product = db.Products.FirstOrDefault(x => x.Id == productId);
            db.Products.Remove(product);
            db.SaveChanges();

            //DeleteZeroRatingProducts
            var productsWithZeroRating = db.Products.Where(x => x.Rating == 0).ToList();
            db.Products.RemoveRange(productsWithZeroRating);
            db.SaveChanges();
        }

        /// <summary>
        /// GetStockEmptyProducts
        /// </summary>
        public void GetStockEmptyProducts()
        {
            var stockEmptyProducts = db.Products
                .Where(x => x.StockQuantity == "0")
                .Select(x => x.Name)
                .ToList();
        }

        /// <summary>
        /// Process Orders
        /// </summary>
        public void ProcessOrders()
        {
            // Todays Orders
            var todaysOrders = db.Orders.Where(x => x.OrderTime.Date == DateTime.Now).ToList();

            // Orders that are not yet dispatched
            var tobeDispatchedOrders = db.Orders.Where(x => !x.IsDispatched).ToList();

            // Orders that's Bill is not yet Paid
            db.Orders.Include(x => x.Bill).Where(x => !x.Bill.IsPaid);
        }

        /// <summary>
        /// Count
        /// </summary>
        public void CountOrder()
        {
            var kamransOrders = db.Orders.Count(x => x.Customer.Name.Contains("kamran"));

        }

        /// <summary>
        /// Sum
        /// </summary>
        public void SumTodaysOrdersBillAmount()
        {
            db.Bills.Where(x => x.Order.OrderTime.Date == DateTime.Now).Sum(x => x.Amount);
        }

        /// <summary>
        /// Join
        /// </summary>
        public void CustomerNamesWithOrderCount()
        {
            // Selecting from Customers
            var CustomerNameWithOrderCount = db.Customers.Select(x => new
            {
                CustomerName = x.Name,
                OrdersCount = x.Orders.Count()
            });
        }

        /// <summary>
        /// Join using LINQ Query Syntax
        /// </summary>
        public void CustomerOrdersData()
        {
            var CustomerOrderData = from c in db.Customers
                                              join o in db.Orders
                                              on c.Id equals o.CustomerId
                                              select new
                                              {
                                                  c.Name,
                                                  c.Phone,
                                                  c.Email,
                                                  o.OrderTime,
                                                  o.OrderProducts.Count
                                              };
        }
    }
}
