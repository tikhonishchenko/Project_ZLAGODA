using Project_ZLAGODA.Backend.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Database
{
    internal static class DbRepository
    {
        private static string connectionString = "Data Source=../../../MainDatabase.db;Version=3;";

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

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Product", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id_product"].ToString());
                    int categoryNumber = int.Parse(reader["category_number"].ToString());
                    string productName = reader["product_name"].ToString();
                    string productCharacteristics = reader["characteristics"].ToString();
                    products.Add(new ProductModel(id, categoryNumber, productName, productCharacteristics));
                }
            }

            return products;
        }

        public static bool AddProduct(ProductModel product)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("INSERT INTO Product (id_product, category_number, product_name, characteristics) VALUES (@Id, @CategoryNumber, @ProductName, @ProductCharacteristics)", connection);
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
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("UPDATE Product SET category_number = @CategoryNumber, product_name = @ProductName, characteristics = @ProductCharacteristics WHERE id_product = @Id", connection);
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
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("DELETE FROM Product WHERE id_product = @Id", connection);
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
