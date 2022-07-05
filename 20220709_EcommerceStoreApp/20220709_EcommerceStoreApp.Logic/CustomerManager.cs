using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace _20220709_EcommerceStoreApp.Logic
{
    public class CustomerManager
    {
        //string ConnectionString = "Server=QADIR\\SQLEXPRESS;Database=EcommerceStore;Trusted_Connection=True;";
        string ConnectionString = ConfigurationManager.ConnectionStrings["EcommerceStoreDB"].ConnectionString;

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string sql = "SELECT * FROM Customers";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Id = reader.GetInt32(0);
                customer.Name = reader.GetString(1);
                customer.Email = reader.GetString(2);
                customer.Phone = reader.GetString(3);
                customer.Address = reader.GetString(4);
                customer.Balance = reader.GetInt32(5);
                customers.Add(customer);
            }
            connection.Close();
            return customers;
        }

        public void InsertCustomer(Customer customer)
        {
            //INSERT INTO Customers
            //VALUES('Kamran Qadir', 'qadir1234@mail.com', '0321-1231234', 'House # 123, Street # 321, Islamabad, Pakistan', 0);
            string sql = "INSERT INTO Customers VALUES (@Name, @Email, @Phone, @Address, @Balance)";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@Email", customer.Email);
            cmd.Parameters.AddWithValue("@Phone", customer.Phone);
            cmd.Parameters.AddWithValue("@Address", customer.Address);
            cmd.Parameters.AddWithValue("@Balance", customer.Balance);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteCustomer(int CustomerId)
        {
            string sql = "DELETE FROM Customers WHERE Id = " + CustomerId;
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
