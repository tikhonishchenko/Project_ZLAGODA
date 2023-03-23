using Project_ZLAGODA.Backend.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Database
{
    internal static class DbRepository
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ZlagodaDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static void AddSampleProducts()
        {
            //find biggest id from products table
            int idMax = 0;
            if (GetProducts().Count != 0)
            {
                idMax = GetProducts().Max(x => x.Id);
            }
            for (int i = 1; i <= 5; i++)
            {
                int id = idMax + i;
                AddProduct(new ProductModel(id, id, "Product " + id, "Product Description " + id));
            }
        }
        
        public static List<ProductModel> GetProducts()
        {
            List<ProductModel> products = new List<ProductModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProductModel product = new ProductModel();
                    product.Id = (int)reader["Id"];
                    product.CategoryNumber = (int)reader["CategoryNumber"];
                    product.ProductName = (string)reader["ProductName"];
                    product.ProductCharacteristics = (string)reader["ProductCharacteristics"];
                    products.Add(product);
                }
            }

            return products;
        }

        public static bool AddProduct(ProductModel product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Products (Id, CategoryNumber, ProductName, ProductCharacteristics) VALUES (@Id, @CategoryNumber, @ProductName, @ProductCharacteristics)", connection);
                command.Parameters.AddWithValue("@Id", product.Id);
                command.Parameters.AddWithValue("@CategoryNumber", product.CategoryNumber);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@ProductCharacteristics", product.ProductCharacteristics);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool UpdateProduct(ProductModel product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Products SET CategoryNumber = @CategoryNumber, ProductName = @ProductName, ProductCharacteristics = @ProductCharacteristics WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", product.Id);
                command.Parameters.AddWithValue("@CategoryNumber", product.CategoryNumber);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@ProductCharacteristics", product.ProductCharacteristics);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool DeleteProduct(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
