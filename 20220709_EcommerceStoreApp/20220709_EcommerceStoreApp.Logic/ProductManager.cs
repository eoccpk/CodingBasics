using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace _20220709_EcommerceStoreApp.Logic
{
    public class ProductManager
    {
        //string ConnectionString = "Server=QADIR\\SQLEXPRESS;Database=EcommerceStore;Trusted_Connection=True;";
        string ConnectionString = ConfigurationManager.ConnectionStrings["EcommerceStoreDB"].ConnectionString;

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            string sql = "SELECT * FROM Products";
            
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = reader.GetInt32(0);
                product.Code = reader.GetString(1);
                product.Name = reader.GetString(2);
                product.Category = reader.GetString(3);
                product.UnitPrice = reader.GetInt32(4);
                product.StockQuantity = reader.GetString(5);
                product.Rating = reader.GetInt32(6);
                product.Seller = reader.GetString(7);
                product.Image = reader.GetString(8);
                products.Add(product);
            }
            connection.Close();
            return products;
        }

        public void InsertProduct(Product product)
        {
            //INSERT INTO Products
            //VALUES('P1', 'Samsung A20', 'Mobiles', 40000, 4, 9, 'The Mobile Shop', 'img_samsung_a20.jpg');
            string sql = "INSERT INTO Products VALUES (@Code, @Name, @Category,@UnitPrice, @StockQuantity, @Rating, @Seller, @Image)";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Code", product.Code);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
            cmd.Parameters.AddWithValue("@Rating", product.Rating);
            cmd.Parameters.AddWithValue("@Seller", product.Seller);
            cmd.Parameters.AddWithValue("@Image", product.Image);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteProduct(int ProductId)
        {
            string sql = "DELETE FROM Products WHERE Id = " + ProductId;
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
