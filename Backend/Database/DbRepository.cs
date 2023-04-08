using Project_ZLAGODA.Backend.Models;
using Project_ZLAGODA.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_ZLAGODA.Backend.Database
{
    internal static class DbRepository
    {
        private static string connectionString = "Data Source=../../../MainDatabase.db;Version=3;";
        #region Employee
        public static List<EmployeeModel> GetEmployees()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Employee", connection);
                var reader = command.ExecuteReader();
                var employees = new List<EmployeeModel>();
                while (reader.Read())
                {
                    employees.Add(new EmployeeModel
                    {
                        Id = Int32.Parse(reader["id_employee"].ToString()),
                        Surname = reader["empl_surname"].ToString(),
                        Name = reader["empl_name"].ToString(),
                        Patronymic = reader["empl_patronymic"].ToString(),
                        Username = reader["username"].ToString(),
                        PasswordHash = (byte[])reader["password_hash"],
                        Salt = (byte[])reader["password_salt"],
                        Role = reader["empl_role"].ToString(),
                        Phone = reader["phone_number"].ToString(),
                        Salary = Decimal.Parse(reader["salary"].ToString()),
                        DateOfEmployment = DateTime.Parse(reader["date_of_start"].ToString()),
                        DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                        City = reader["city"].ToString(),
                        Street = reader["street"].ToString(),
                        Zip = reader["zip_code"].ToString()
                    });
                }
                return employees;

            }
        }

        /// <summary>
        /// Отримати інформацію про усіх працівників, відсортованих за прізвищем;
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeModel> GetEmployeesSortedBySurname()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Employee ORDER BY empl_surname", connection);
                var reader = command.ExecuteReader();
                var employees = new List<EmployeeModel>();
                while (reader.Read())
                {
                    employees.Add(new EmployeeModel
                    {
                        Id = Int32.Parse(reader["id_employee"].ToString()),
                        Surname = reader["empl_surname"].ToString(),
                        Name = reader["empl_name"].ToString(),
                        Patronymic = reader["empl_patronymic"].ToString(),
                        Username = reader["username"].ToString(),
                        PasswordHash = (byte[])reader["password_hash"],
                        Salt = (byte[])reader["password_salt"],
                        Role = reader["empl_role"].ToString(),
                        Phone = reader["phone_number"].ToString(),
                        Salary = Decimal.Parse(reader["salary"].ToString()),
                        DateOfEmployment = DateTime.Parse(reader["date_of_start"].ToString()),
                        DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                        City = reader["city"].ToString(),
                        Street = reader["street"].ToString(),
                        Zip = reader["zip_code"].ToString()
                    });
                }
                return employees;

            }
        }

        /// <summary>
        /// Отримати інформацію про усіх працівників, що займають посаду касира, відсортованих за прізвищем;
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeModel> GetEmployeesCashiersSortedBySurname()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Employee WHERE empl_role = 'Cashier' ORDER BY empl_surname", connection);
                var reader = command.ExecuteReader();
                var employees = new List<EmployeeModel>();
                while (reader.Read())
                {
                    employees.Add(new EmployeeModel
                    {
                        Id = Int32.Parse(reader["id_employee"].ToString()),
                        Surname = reader["empl_surname"].ToString(),
                        Name = reader["empl_name"].ToString(),
                        Patronymic = reader["empl_patronymic"].ToString(),
                        Username = reader["username"].ToString(),
                        PasswordHash = (byte[])reader["password_hash"],
                        Salt = (byte[])reader["password_salt"],
                        Role = reader["empl_role"].ToString(),
                        Phone = reader["phone_number"].ToString(),
                        Salary = Decimal.Parse(reader["salary"].ToString()),
                        DateOfEmployment = DateTime.Parse(reader["date_of_start"].ToString()),
                        DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                        City = reader["city"].ToString(),
                        Street = reader["street"].ToString(),
                        Zip = reader["zip_code"].ToString()
                    });
                }
                return employees;

            }
        }
        /// <summary>
        /// Повертає юзера за логіном і паролем
        /// </summary>
        /// <param name="username">логін</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        public static EmployeeModel GetEmployee(string username, string password)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Employee WHERE username = @username", connection);
                command.Parameters.AddWithValue("@username", username);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var salt = (byte[])reader["password_salt"];
                    var passwordHash = (byte[])reader["password_hash"];
                    var computedHash = ViewModel.ComputePasswordHash(password, salt);
                    if (computedHash.SequenceEqual(passwordHash))
                    {
                        return new EmployeeModel
                        {
                            Id = Int32.Parse(reader["id_employee"].ToString()),
                            Surname = reader["empl_surname"].ToString(),
                            Name = reader["empl_name"].ToString(),
                            Patronymic = reader["empl_patronymic"].ToString(),
                            Username = reader["username"].ToString(),
                            PasswordHash = (byte[])reader["password_hash"],
                            Salt = (byte[])reader["password_salt"],
                            Role = reader["empl_role"].ToString(),
                            Phone = reader["phone_number"].ToString(),
                            Salary = Decimal.Parse(reader["salary"].ToString()),
                            DateOfEmployment = DateTime.Parse(reader["date_of_start"].ToString()),
                            DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                            City = reader["city"].ToString(),
                            Street = reader["street"].ToString(),
                            Zip = reader["zip_code"].ToString()
                        };
                    }
                }
                return null;

            }
        }

        /// <summary>
        /// За прізвищем працівника знайти його телефон та адресу;
        /// </summary>
        /// <param name="surname"></param>
        /// <returns></returns>
        public static EmployeeModel GetEmployeeDataBySurname(string surname)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT phone_number, city, street, zip_code FROM Employee WHERE empl_surname = @surname", connection);
                command.Parameters.AddWithValue("@surname", surname);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {                    
                        return new EmployeeModel
                        {
                            Phone = reader["phone_number"].ToString(),
                            City = reader["city"].ToString(),
                            Street = reader["street"].ToString(),
                            Zip = reader["zip_code"].ToString()
                        };
                    
                }
                return null;

            }
        }

        /// <summary>
        /// Отримати працівника по id.
        /// </summary>
        /// <param name="idEmployee"></param>
        /// <returns></returns>
        public static EmployeeModel GetEmployeeById(string idEmployee)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Employee WHERE id_employee = @idEmployee", connection);
                command.Parameters.AddWithValue("@idEmployee", idEmployee);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {                   
                        return new EmployeeModel
                        {
                            Id = Int32.Parse(reader["id_employee"].ToString()),
                            Surname = reader["empl_surname"].ToString(),
                            Name = reader["empl_name"].ToString(),
                            Patronymic = reader["empl_patronymic"].ToString(),
                            Username = reader["username"].ToString(),
                            PasswordHash = (byte[])reader["password_hash"],
                            Salt = (byte[])reader["password_salt"],
                            Role = reader["empl_role"].ToString(),
                            Phone = reader["phone_number"].ToString(),
                            Salary = Decimal.Parse(reader["salary"].ToString()),
                            DateOfEmployment = DateTime.Parse(reader["date_of_start"].ToString()),
                            DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                            City = reader["city"].ToString(),
                            Street = reader["street"].ToString(),
                            Zip = reader["zip_code"].ToString()
                        };
                    
                }
                return null;

            }
        }
        public static void AddEmployee(EmployeeModel employee)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("INSERT INTO Employee (empl_surname, empl_name, empl_patronymic, username, password_hash, password_salt, empl_role, phone_number, salary, date_of_start, date_of_birth, city, street, zip_code) VALUES (@empl_surname, @empl_name, @empl_patronymic, @username, @password_hash, @password_salt, @empl_role, @phone_number, @salary, @date_of_start, @date_of_birth, @city, @street, @zip_code)", connection);
                command.Parameters.AddWithValue("@empl_surname", employee.Surname);
                command.Parameters.AddWithValue("@empl_name", employee.Name);
                command.Parameters.AddWithValue("@empl_patronymic", employee.Patronymic);
                command.Parameters.AddWithValue("@username", employee.Username);
                command.Parameters.AddWithValue("@password_hash", employee.PasswordHash);
                command.Parameters.AddWithValue("@password_salt", employee.Salt);
                command.Parameters.AddWithValue("@empl_role", employee.Role);
                command.Parameters.AddWithValue("@phone_number", employee.Phone);
                command.Parameters.AddWithValue("@salary", employee.Salary);
                command.Parameters.AddWithValue("@date_of_start", employee.DateOfEmployment);
                command.Parameters.AddWithValue("@date_of_birth", employee.DateOfBirth);
                command.Parameters.AddWithValue("@city", employee.City);
                command.Parameters.AddWithValue("@street", employee.Street);
                command.Parameters.AddWithValue("@zip_code", employee.Zip);
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateEmployee(EmployeeModel employee)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("UPDATE Employee SET empl_surname = @empl_surname, empl_name = @empl_name, empl_patronymic = @empl_patronymic, username = @username, password_hash = @password_hash, password_salt = @password_salt, empl_role = @empl_role, phone_number = @phone_number, salary = @salary, date_of_start = @date_of_start, date_of_birth = @date_of_birth, city = @city, street = @street, zip_code = @zip_code WHERE id_employee = @id_employee", connection);
                command.Parameters.AddWithValue("@id_employee", employee.Id);
                command.Parameters.AddWithValue("@empl_surname", employee.Surname);
                command.Parameters.AddWithValue("@empl_name", employee.Name);
                command.Parameters.AddWithValue("@empl_patronymic", employee.Patronymic);
                command.Parameters.AddWithValue("@username", employee.Username);
                command.Parameters.AddWithValue("@password_hash", employee.PasswordHash);
                command.Parameters.AddWithValue("@password_salt", employee.Salt);
                command.Parameters.AddWithValue("@empl_role", employee.Role);
                command.Parameters.AddWithValue("@phone_number", employee.Phone);
                command.Parameters.AddWithValue("@salary", employee.Salary);
                command.Parameters.AddWithValue("@date_of_start", employee.DateOfEmployment);
                command.Parameters.AddWithValue("@date_of_birth", employee.DateOfBirth);
                command.Parameters.AddWithValue("@city", employee.City);
                command.Parameters.AddWithValue("@street", employee.Street);
                command.Parameters.AddWithValue("@zip_code", employee.Zip);
                command.ExecuteNonQuery();
            }
        }
        public static void DeleteEmployee(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("DELETE FROM Employee WHERE id_employee = @id_employee", connection);
                command.Parameters.AddWithValue("@id_employee", id);
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Product
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
        /// <summary>
        /// Отримати інформацію про усі товари
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Отримати інформацію про усі товари, відсортовані за назвою;
        /// </summary>
        /// <returns></returns>
        public static List<ProductModel> GetProductsSorted()
        {
            List<ProductModel> products = new List<ProductModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Product ORDER BY product_name", connection);
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
        #endregion

        #region Category

        public static List<CategoryModel> GetCategories()
        {
            List<CategoryModel> categories = new List<CategoryModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Category", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["category_number"].ToString());
                    string categoryName = reader["category_name"].ToString();;
                    categories.Add(new CategoryModel(id, categoryName));
                }
            }
            return categories;
        }

        /// <summary>
        ///  Отримати інформацію про усі категорії, відсортовані за назвою;
        /// </summary>
        /// <returns></returns>
        public static List<CategoryModel> GetCategoriesSorted()
        {
            List<CategoryModel> categories = new List<CategoryModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Category ORDER BY category_name", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["category_number"].ToString());
                    string categoryName = reader["category_name"].ToString(); ;
                    categories.Add(new CategoryModel(id, categoryName));
                }
            }
            return categories;
        }

        public static bool AddCategory(CategoryModel category)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("INSERT INTO Category (category_number, category_name) VALUES (@Id, @CategoryName)", connection);
                command.Parameters.AddWithValue("@Id", category.Id);
                command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
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

        public static bool UpdateCategory(CategoryModel category)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("UPDATE Category SET category_name = @CategoryName WHERE category_number = @Id", connection);
                command.Parameters.AddWithValue("@Id", category.Id);
                command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
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

        public static bool DeleteCategory(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("DELETE FROM Category WHERE category_number = @Id", connection);
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
        #endregion

        #region Store Product

        public static List<StoreProductModel> GetStoreProducts()
        {
            List<StoreProductModel> storeProducts = new List<StoreProductModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM StoreProduct", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["CheckNumber"].ToString();
                    string UPC_prom = reader["UPC_prom"].ToString();
                    int id_product = Int32.Parse(reader["id_product"].ToString());
                    int selling_price = Int32.Parse(reader["selling_price"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));

                    storeProducts.Add(new StoreProductModel(UPC, UPC_prom, id_product, selling_price, promotional_product));
                }
            }

            return storeProducts;
        }
        /// <summary>
        /// Отримати інформацію про усі товари у магазині, відсортовані за кількістю;
        /// </summary>
        /// <returns></returns>
        public static List<StoreProductModel> GetStoreProductsSortedByQuantity()
        {
            List<StoreProductModel> storeProducts = new List<StoreProductModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Store_Product sp JOIN Product p on p.id_product = sp.id_product ORDER BY sp.products_number", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["CheckNumber"].ToString();
                    string UPC_prom = reader["UPC_prom"].ToString();
                    int id_product = Int32.Parse(reader["id_product"].ToString());
                    int selling_price = Int32.Parse(reader["selling_price"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));

                    storeProducts.Add(new StoreProductModel(UPC, UPC_prom, id_product, selling_price, promotional_product));
                }
            }

            return storeProducts;
        }
        /// <summary>
        /// Отримати інформацію про усі акційні товари у магазині, відсортовані за назвою;
        /// </summary>
        /// <returns></returns>
        public static List<StoreProductModel> GetStoreProductsDiscountSortedByName()
        {
            List<StoreProductModel> storeProducts = new List<StoreProductModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Store_Product sp JOIN Product p on p.id_product = sp.id_product WHERE sp.promotional_product = true ORDER BY p.product_name", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["CheckNumber"].ToString();
                    string UPC_prom = reader["UPC_prom"].ToString();
                    int id_product = Int32.Parse(reader["id_product"].ToString());
                    int selling_price = Int32.Parse(reader["selling_price"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));

                    storeProducts.Add(new StoreProductModel(UPC, UPC_prom, id_product, selling_price, promotional_product));
                }
            }

            return storeProducts;
        }
        /// <summary>
        /// Отримати інформацію про усі акційні товари у магазині, відсортовані за кількістю;
        /// </summary>
        /// <returns></returns>
        public static List<StoreProductModel> GetStoreProductsDiscountSortedByQuantity()
        {
            List<StoreProductModel> storeProducts = new List<StoreProductModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Store_Product sp JOIN Product p on p.id_product = sp.id_product WHERE sp.promotional_product = true ORDER BY sp.products_number", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["CheckNumber"].ToString();
                    string UPC_prom = reader["UPC_prom"].ToString();
                    int id_product = Int32.Parse(reader["id_product"].ToString());
                    int selling_price = Int32.Parse(reader["selling_price"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));

                    storeProducts.Add(new StoreProductModel(UPC, UPC_prom, id_product, selling_price, promotional_product));
                }
            }

            return storeProducts;
        }
        /// <summary>
        /// Отримати інформацію про усі не акційні товари, відсортовані за назвою;
        /// </summary>
        /// <returns></returns>
        public static List<StoreProductModel> GetStoreProductsNotDiscountSortedByName()
        {
            List<StoreProductModel> storeProducts = new List<StoreProductModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Store_Product sp JOIN Product p on p.id_product = sp.id_product WHERE sp.promotional_product = false ORDER BY p.product_name", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["CheckNumber"].ToString();
                    string UPC_prom = reader["UPC_prom"].ToString();
                    int id_product = Int32.Parse(reader["id_product"].ToString());
                    int selling_price = Int32.Parse(reader["selling_price"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));

                    storeProducts.Add(new StoreProductModel(UPC, UPC_prom, id_product, selling_price, promotional_product));
                }
            }

            return storeProducts;
        }
        /// <summary>
        /// Отримати інформацію про усі не акційні товари, відсортовані за кількістю;
        /// </summary>
        /// <returns></returns>
        public static List<StoreProductModel> GetStoreProductsNotDiscountSortedByQuantity()
        {
            List<StoreProductModel> storeProducts = new List<StoreProductModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Store_Product sp JOIN Product p on p.id_product = sp.id_product WHERE sp.promotional_product = false ORDER BY sp.products_number", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["CheckNumber"].ToString();
                    string UPC_prom = reader["UPC_prom"].ToString();
                    int id_product = Int32.Parse(reader["id_product"].ToString());
                    int selling_price = Int32.Parse(reader["selling_price"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));

                    storeProducts.Add(new StoreProductModel(UPC, UPC_prom, id_product, selling_price, promotional_product));
                }
            }

            return storeProducts;
        }
        public static List<ProductModel> GetStoreProductsSorted()
        {
            List<ProductModel> products = new List<ProductModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Store_Product sp JOIN Product p on p.id_product = sp.id_product ORDER BY p.product_name", connection);
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
        public static List<StoreProductModel> GetStoreProductsToDate(DateTime date)
        {
            List<StoreProductModel> storeProducts = new List<StoreProductModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Store_Product WHERE expiry_date < @date", connection);
                command.Parameters.AddWithValue("@date", date);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    string UPC_prom = reader["UPC_prom"].ToString();
                    int id_product = Int32.Parse(reader["id_product"].ToString());
                    int selling_price = Int32.Parse(reader["selling_price"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));

                    storeProducts.Add(new StoreProductModel(UPC, UPC_prom, id_product, selling_price, promotional_product));
                }
            }

            return storeProducts;
        }
        public static bool AddStoreProduct(StoreProductModel storeProduct)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("INSERT INTO Store_Product (CheckNumber, UPC_prom, id_product, selling_price, promotional_product) VALUES (@CheckNumber, @UPC_prom, @Id, @SellingPrice, @PromotionalProduct)", connection);
                command.Parameters.AddWithValue("@CheckNumber", storeProduct.UPC);
                command.Parameters.AddWithValue("@UPC_prom", storeProduct.UPC_Prom);
                command.Parameters.AddWithValue("@Id", storeProduct.ProductId);
                command.Parameters.AddWithValue("@SellingPrice", storeProduct.Price);
                command.Parameters.AddWithValue("@PromotionalProduct", storeProduct.IsPromotion);
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

        public static bool UpdateStoreProduct(StoreProductModel storeProduct)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("UPDATE Store_Product SET UPC_prom = @UPC_prom, selling_price = @SellingPrice, promotional_product = @PromotionalProduct WHERE CheckNumber = @CheckNumber", connection);
                command.Parameters.AddWithValue("@CheckNumber", storeProduct.UPC);
                command.Parameters.AddWithValue("@UPC_prom", storeProduct.UPC_Prom);
                command.Parameters.AddWithValue("@SellingPrice", storeProduct.Price);
                command.Parameters.AddWithValue("@PromotionalProduct", storeProduct.IsPromotion);
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

        public static bool DeleteStoreProduct(string UPC)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("DELETE FROM Store_Product WHERE CheckNumber = @CheckNumber", connection);
                command.Parameters.AddWithValue("@CheckNumber", UPC);
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
        #endregion

        #region Customer

        public static List<CustomerModel> GetCustomers()
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Customer_Card", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string card_number = reader["card_number"].ToString();
                    string cust_surname = reader["cust_surname"].ToString();
                    string cust_name = reader["cust_name"].ToString();
                    string cust_patronymic = reader["cust_patronymic"].ToString();
                    string phone_number = reader["phone_number"].ToString();
                    string city = reader["city"].ToString();
                    string street = reader["street"].ToString();
                    string zip_code = reader["zip_code"].ToString();
                    int percent = Int32.Parse(reader["percent"].ToString());

                    customers.Add(new CustomerModel(card_number, cust_name, cust_surname, cust_patronymic, phone_number, street, city, zip_code, percent));
                }
            }

            return customers;
        }
        /// <summary>
        /// Отримати інформацію про усіх постійних клієнтів, відсортованих за прізвищем;
        /// </summary>
        /// <returns></returns>
        public static List<CustomerModel> GetCustomersSorted()
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Customer_Card ORDER BY cust_surname", connection);
    SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string card_number = reader["card_number"].ToString();
    string cust_surname = reader["cust_surname"].ToString();
    string cust_name = reader["cust_name"].ToString();
    string cust_patronymic = reader["cust_patronymic"].ToString();
    string phone_number = reader["phone_number"].ToString();
    string city = reader["city"].ToString();
    string street = reader["street"].ToString();
    string zip_code = reader["zip_code"].ToString();
    int percent = Int32.Parse(reader["percent"].ToString());

    customers.Add(new CustomerModel(card_number, cust_name, cust_surname, cust_patronymic, phone_number, street, city, zip_code, percent));
                }
            }

            return customers;
        }
        /// <summary>
        ///  Отримати інформацію про усіх постійних клієнтів, що мають карту клієнта із певним відсотком, посортованих за прізвищем;
        /// </summary>
        /// <param name="percent"></param>
        /// <returns></returns>
        public static List<CustomerModel> GetCustomersWithPercentSortedBySurname(int percentSearch)
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Customer_Card WHERE percent = @percent ORDER BY cust_surname", connection);
                command.Parameters.AddWithValue("@percent", percentSearch);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string card_number = reader["card_number"].ToString();
                    string cust_surname = reader["cust_surname"].ToString();
                    string cust_name = reader["cust_name"].ToString();
                    string cust_patronymic = reader["cust_patronymic"].ToString();
                    string phone_number = reader["phone_number"].ToString();
                    string city = reader["city"].ToString();
                    string street = reader["street"].ToString();
                    string zip_code = reader["zip_code"].ToString();
                    int percent = Int32.Parse(reader["percent"].ToString());

                    customers.Add(new CustomerModel(card_number, cust_name, cust_surname, cust_patronymic, phone_number, street, city, zip_code, percent));
                }
            }

            return customers;
        }
        public static bool AddCustomer(CustomerModel customer)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("INSERT INTO Customer_Card (card_number, cust_surname, cust_name, cust_patronymic, phone_number, city, street, zip_code, percent) VALUES (@CardNumber, @Surname, @Name, @Patronymic, @PhoneNumber, @City, @Street, @ZipCode, @Percent)", connection);
                command.Parameters.AddWithValue("@CardNumber", customer.CardNumber);
                command.Parameters.AddWithValue("@Surname", customer.LastName);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Patronymic", customer.Patronymic);
                command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                command.Parameters.AddWithValue("@City", customer.City);
                command.Parameters.AddWithValue("@Street", customer.Street);
                command.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
                command.Parameters.AddWithValue("@Percent", customer.Percent);
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

        public static bool UpdateCustomer(CustomerModel customer)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("UPDATE Customer_Card SET cust_surname = @Surname, cust_name = @Name, cust_patronymic = @Patronymic, phone_number = @PhoneNumber, city = @City, street = @Street, zip_code = @ZipCode, percent = @Percent WHERE card_number = @CardNumber", connection);
                command.Parameters.AddWithValue("@CardNumber", customer.CardNumber);
                command.Parameters.AddWithValue("@Surname", customer.LastName);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Patronymic", customer.Patronymic);
                command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                command.Parameters.AddWithValue("@City", customer.City);
                command.Parameters.AddWithValue("@Street", customer.Street);
                command.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
                command.Parameters.AddWithValue("@Percent", customer.Percent);
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

        public static bool DeleteCustomer(string cardNumber)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("DELETE FROM Customer_Card WHERE card_number = @CardNumber", connection);
                command.Parameters.AddWithValue("@CardNumber", cardNumber);
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
        #endregion

        #region Sale

        public static List<SaleModel> GetSales()
        {
            List<SaleModel> sales = new List<SaleModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Sale", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["CheckNumber"].ToString();
                    string check_number = reader["check_number"].ToString();
                    int product_number = Int32.Parse(reader["product_number"].ToString());
                    decimal selling_price = Decimal.Parse(reader["selling_price"].ToString());

                    sales.Add(new SaleModel(UPC, check_number, product_number, selling_price));
                }
            }

            return sales;
        }

        public static bool AddSale(SaleModel sale)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("INSERT INTO Sale (CheckNumber, check_number, product_number, selling_price) VALUES (@CheckNumber, @CheckNumber, @ProductNumber, @SellingPrice)", connection);
                command.Parameters.AddWithValue("@CheckNumber", sale.UPC);
                command.Parameters.AddWithValue("@CheckNumber", sale.CheckNumber);
                command.Parameters.AddWithValue("@ProductNumber", sale.ProductNumber);
                command.Parameters.AddWithValue("@SellingPrice", sale.Price);
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

        public static bool UpdateSale(SaleModel sale)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("UPDATE Sale SET CheckNumber = @CheckNumber, check_number = @CheckNumber, product_number = @ProductNumber, selling_price = @SellingPrice WHERE CheckNumber = @CheckNumber", connection);
                command.Parameters.AddWithValue("@CheckNumber", sale.UPC);
                command.Parameters.AddWithValue("@CheckNumber", sale.CheckNumber);
                command.Parameters.AddWithValue("@ProductNumber", sale.ProductNumber);
                command.Parameters.AddWithValue("@SellingPrice", sale.Price);
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

        public static bool DeleteSale(string UPC)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("DELETE FROM Sale WHERE CheckNumber = @CheckNumber", connection);
                command.Parameters.AddWithValue("@CheckNumber", UPC);
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

        #endregion

        #region Sale Check

        public static List<SaleCheckModel> GetSaleChecks()
        {
            List<SaleCheckModel> saleChecks = new List<SaleCheckModel>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Sales_Check", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string check_number = reader["check_number"].ToString();
                    string id_employee = reader["id_employee"].ToString();
                    string card_number = reader["card_number"].ToString();
                    DateTime print_date = DateTime.Parse(reader["print_date"].ToString());
                    decimal sum_total = Decimal.Parse(reader["sum_total"].ToString());
                    decimal vat = Decimal.Parse(reader["vat"].ToString());

                    saleChecks.Add(new SaleCheckModel(check_number, id_employee, card_number, print_date, sum_total, vat));
                }
            }

            return saleChecks;
        }

        public static bool AddSaleCheck(SaleCheckModel saleCheck)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("INSERT INTO Sales_Check (check_number, id_employee, card_number, print_date, sum_total, vat) VALUES (@CheckNumber, @IdEmployee, @CardNumber, @PrintDate, @SumTotal, @Vat)", connection);
                command.Parameters.AddWithValue("@CheckNumber", saleCheck.CheckNumber);
                command.Parameters.AddWithValue("@IdEmployee", saleCheck.EmployeeId);
                command.Parameters.AddWithValue("@CardNumber", saleCheck.CardNumber);
                command.Parameters.AddWithValue("@PrintDate", saleCheck.PrintDate);
                command.Parameters.AddWithValue("@SumTotal", saleCheck.SumTotal);
                command.Parameters.AddWithValue("@Vat", saleCheck.VAT);
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

        public static bool UpdateSaleCheck(SaleCheckModel saleCheck)
        {
            
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("UPDATE Sales_Check SET id_employee = @IdEmployee, card_number = @CardNumber, print_date = @PrintDate, sum_total = @SumTotal, vat = @Vat WHERE check_number = @CheckNumber", connection);
                    command.Parameters.AddWithValue("@IdEmployee", saleCheck.EmployeeId);
                    command.Parameters.AddWithValue("@CardNumber", saleCheck.CardNumber);
                    command.Parameters.AddWithValue("@PrintDate", saleCheck.PrintDate);
                    command.Parameters.AddWithValue("@SumTotal", saleCheck.SumTotal);
                    command.Parameters.AddWithValue("@Vat", saleCheck.VAT);
                    command.Parameters.AddWithValue("@CheckNumber", saleCheck.CheckNumber);
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
        
        public static bool DeleteSaleCheck(string checkNumber)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("DELETE FROM Sales_Check WHERE check_number = @CheckNumber", connection);
                command.Parameters.AddWithValue("@CheckNumber", checkNumber);
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

        #endregion

    }
}
