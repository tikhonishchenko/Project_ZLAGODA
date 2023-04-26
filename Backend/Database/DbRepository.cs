using Microsoft.Data.Sqlite;
using Project_ZLAGODA.Backend.Models;
using Project_ZLAGODA.ViewModels;
using System.Diagnostics;

namespace Project_ZLAGODA.Backend.Database
{
    internal static class DbRepository
    {
        private static readonly string connectionString = "Data Source=../../../MainDatabase.db;";
        #region Employee
        public static List<EmployeeModel> GetEmployees()
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("SELECT * FROM Employee", connection);
            SqliteDataReader reader = command.ExecuteReader();
            List<EmployeeModel> employees = new();
            while (reader.Read())
            {
                employees.Add(new EmployeeModel
                {
                    Id = int.Parse(reader["id_employee"].ToString()),
                    Surname = reader["empl_surname"].ToString(),
                    Name = reader["empl_name"].ToString(),
                    Patronymic = reader["empl_patronymic"].ToString(),
                    Username = reader["username"].ToString(),
                    PasswordHash = (byte[])reader["password_hash"],
                    Salt = (byte[])reader["password_salt"],
                    Role = reader["empl_role"].ToString(),
                    Phone = reader["phone_number"].ToString(),
                    Salary = decimal.Parse(reader["salary"].ToString()),
                    DateOfEmployment = DateTime.Parse(reader["date_of_start"].ToString()),
                    DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                    City = reader["city"].ToString(),
                    Street = reader["street"].ToString(),
                    Zip = reader["zip_code"].ToString()
                });
            }
            return employees;
        }

        /// <summary>
        /// Отримати інформацію про усіх працівників, відсортованих за прізвищем;
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeModel> GetEmployeesSortedBySurname()
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("SELECT * FROM Employee ORDER BY empl_surname", connection);
            SqliteDataReader reader = command.ExecuteReader();
            List<EmployeeModel> employees = new();
            while (reader.Read())
            {
                employees.Add(new EmployeeModel
                {
                    Id = int.Parse(reader["id_employee"].ToString()),
                    Surname = reader["empl_surname"].ToString(),
                    Name = reader["empl_name"].ToString(),
                    Patronymic = reader["empl_patronymic"].ToString(),
                    Username = reader["username"].ToString(),
                    PasswordHash = (byte[])reader["password_hash"],
                    Salt = (byte[])reader["password_salt"],
                    Role = reader["empl_role"].ToString(),
                    Phone = reader["phone_number"].ToString(),
                    Salary = decimal.Parse(reader["salary"].ToString()),
                    DateOfEmployment = DateTime.Parse(reader["date_of_start"].ToString()),
                    DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                    City = reader["city"].ToString(),
                    Street = reader["street"].ToString(),
                    Zip = reader["zip_code"].ToString()
                });
            }

            return employees;
        }

        /// <summary>
        /// Отримати інформацію про усіх працівників, що займають посаду касира, відсортованих за прізвищем;
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeModel> GetEmployeesCashiersSortedBySurname()
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("SELECT * FROM Employee WHERE empl_role = 'Cashier' ORDER BY empl_surname", connection);
            SqliteDataReader reader = command.ExecuteReader();
            List<EmployeeModel> employees = new();
            while (reader.Read())
            {
                employees.Add(new EmployeeModel
                {
                    Id = int.Parse(reader["id_employee"].ToString()),
                    Surname = reader["empl_surname"].ToString(),
                    Name = reader["empl_name"].ToString(),
                    Patronymic = reader["empl_patronymic"].ToString(),
                    Username = reader["username"].ToString(),
                    PasswordHash = (byte[])reader["password_hash"],
                    Salt = (byte[])reader["password_salt"],
                    Role = reader["empl_role"].ToString(),
                    Phone = reader["phone_number"].ToString(),
                    Salary = decimal.Parse(reader["salary"].ToString()),
                    DateOfEmployment = DateTime.Parse(reader["date_of_start"].ToString()),
                    DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                    City = reader["city"].ToString(),
                    Street = reader["street"].ToString(),
                    Zip = reader["zip_code"].ToString()
                });
            }
            return employees;
        }
        /// <summary>
        /// Повертає юзера за логіном і паролем
        /// </summary>
        /// <param name="username">логін</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        public static EmployeeModel? GetEmployee(string username, string password)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            using SqliteCommand command = new("SELECT * FROM Employee WHERE username = @username", connection);
            _ = command.Parameters.AddWithValue("@username", username);
            using SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                byte[] salt = (byte[])reader["password_salt"];
                byte[] passwordHash = (byte[])reader["password_hash"];
                byte[] computedHash = ViewModel.ComputePasswordHash(password, salt);
                if (computedHash.SequenceEqual(passwordHash))
                {
                    return new EmployeeModel
                    {
                        Id = int.Parse(reader["id_employee"].ToString()),
                        Surname = reader["empl_surname"].ToString(),
                        Name = reader["empl_name"].ToString(),
                        Patronymic = reader["empl_patronymic"].ToString(),
                        Username = reader["username"].ToString(),
                        PasswordHash = (byte[])reader["password_hash"],
                        Salt = (byte[])reader["password_salt"],
                        Role = reader["empl_role"].ToString(),
                        Phone = reader["phone_number"].ToString(),
                        Salary = decimal.Parse(reader["salary"].ToString()),
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


        /// <summary>
        /// За прізвищем працівника знайти його телефон та адресу;
        /// </summary>
        /// <param name="surname"></param>
        /// <returns></returns>
        public static List<EmployeeModel> GetEmployeeDataBySurname(string surname)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("SELECT * FROM Employee WHERE empl_surname = @surname", connection);
            _ = command.Parameters.AddWithValue("@surname", surname);
            SqliteDataReader reader = command.ExecuteReader();
            List<EmployeeModel> employees = new();
            while (reader.Read())
            {
                employees.Add(new EmployeeModel
                {
                    Id = int.Parse(reader["id_employee"].ToString()),
                    Surname = reader["empl_surname"].ToString(),
                    Name = reader["empl_name"].ToString(),
                    Patronymic = reader["empl_patronymic"].ToString(),
                    Username = reader["username"].ToString(),
                    PasswordHash = (byte[])reader["password_hash"],
                    Salt = (byte[])reader["password_salt"],
                    Role = reader["empl_role"].ToString(),
                    Phone = reader["phone_number"].ToString(),
                    Salary = decimal.Parse(reader["salary"].ToString()),
                    DateOfEmployment = DateTime.Parse(reader["date_of_start"].ToString()),
                    DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                    City = reader["city"].ToString(),
                    Street = reader["street"].ToString(),
                    Zip = reader["zip_code"].ToString()
                });
            }
            return employees;
        }

        /// <summary>
        /// Отримати працівника по id.
        /// </summary>
        /// <param name="idEmployee"></param>
        /// <returns></returns>
        public static EmployeeModel? GetEmployeeById(int idEmployee)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("SELECT * FROM Employee WHERE id_employee = @idEmployee", connection);
            _ = command.Parameters.AddWithValue("@idEmployee", idEmployee);
            SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return new EmployeeModel
                {
                    Id = int.Parse(reader["id_employee"].ToString()),
                    Surname = reader["empl_surname"].ToString(),
                    Name = reader["empl_name"].ToString(),
                    Patronymic = reader["empl_patronymic"].ToString(),
                    Username = reader["username"].ToString(),
                    PasswordHash = (byte[])reader["password_hash"],
                    Salt = (byte[])reader["password_salt"],
                    Role = reader["empl_role"].ToString(),
                    Phone = reader["phone_number"].ToString(),
                    Salary = decimal.Parse(reader["salary"].ToString()),
                    DateOfEmployment = DateTime.Parse(reader["date_of_start"].ToString()),
                    DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                    City = reader["city"].ToString(),
                    Street = reader["street"].ToString(),
                    Zip = reader["zip_code"].ToString()
                };

            }
            return null;
        }
        public static void AddEmployee(EmployeeModel employee)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("INSERT INTO Employee (empl_surname, empl_name, empl_patronymic, username, password_hash, password_salt, empl_role, phone_number, salary, date_of_start, date_of_birth, city, street, zip_code) VALUES (@empl_surname, @empl_name, @empl_patronymic, @username, @password_hash, @password_salt, @empl_role, @phone_number, @salary, @date_of_start, @date_of_birth, @city, @street, @zip_code)", connection);
            _ = command.Parameters.AddWithValue("@empl_surname", employee.Surname);
            _ = command.Parameters.AddWithValue("@empl_name", employee.Name);
            _ = command.Parameters.AddWithValue("@empl_patronymic", employee.Patronymic);
            _ = command.Parameters.AddWithValue("@username", employee.Username);
            _ = command.Parameters.AddWithValue("@password_hash", employee.PasswordHash);
            _ = command.Parameters.AddWithValue("@password_salt", employee.Salt);
            _ = command.Parameters.AddWithValue("@empl_role", employee.Role);
            _ = command.Parameters.AddWithValue("@phone_number", employee.Phone);
            _ = command.Parameters.AddWithValue("@salary", employee.Salary);
            _ = command.Parameters.AddWithValue("@date_of_start", employee.DateOfEmployment);
            _ = command.Parameters.AddWithValue("@date_of_birth", employee.DateOfBirth);
            _ = command.Parameters.AddWithValue("@city", employee.City);
            _ = command.Parameters.AddWithValue("@street", employee.Street);
            _ = command.Parameters.AddWithValue("@zip_code", employee.Zip);
            _ = command.ExecuteNonQuery();
        }
        public static void UpdateEmployee(EmployeeModel employee)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("UPDATE Employee SET empl_surname = @empl_surname, empl_name = @empl_name, empl_patronymic = @empl_patronymic, username = @username, password_hash = @password_hash, password_salt = @password_salt, empl_role = @empl_role, phone_number = @phone_number, salary = @salary, date_of_start = @date_of_start, date_of_birth = @date_of_birth, city = @city, street = @street, zip_code = @zip_code WHERE id_employee = @id_employee", connection);
            _ = command.Parameters.AddWithValue("@id_employee", employee.Id);
            _ = command.Parameters.AddWithValue("@empl_surname", employee.Surname);
            _ = command.Parameters.AddWithValue("@empl_name", employee.Name);
            _ = command.Parameters.AddWithValue("@empl_patronymic", employee.Patronymic);
            _ = command.Parameters.AddWithValue("@username", employee.Username);
            _ = command.Parameters.AddWithValue("@password_hash", employee.PasswordHash);
            _ = command.Parameters.AddWithValue("@password_salt", employee.Salt);
            _ = command.Parameters.AddWithValue("@empl_role", employee.Role);
            _ = command.Parameters.AddWithValue("@phone_number", employee.Phone);
            _ = command.Parameters.AddWithValue("@salary", employee.Salary);
            _ = command.Parameters.AddWithValue("@date_of_start", employee.DateOfEmployment);
            _ = command.Parameters.AddWithValue("@date_of_birth", employee.DateOfBirth);
            _ = command.Parameters.AddWithValue("@city", employee.City);
            _ = command.Parameters.AddWithValue("@street", employee.Street);
            _ = command.Parameters.AddWithValue("@zip_code", employee.Zip);
            _ = command.ExecuteNonQuery();
        }
        public static void DeleteEmployee(int id)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("DELETE FROM Employee WHERE id_employee = @id_employee", connection);
            _ = command.Parameters.AddWithValue("@id_employee", id);
            _ = command.ExecuteNonQuery();
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
                _ = AddProduct(new ProductModel(id, id, "Product " + id, "Product Description " + id));
            }
        }
        /// <summary>
        /// Отримати інформацію про усі товари
        /// </summary>
        /// <returns></returns>
        public static List<ProductModel> GetProducts()
        {
            List<ProductModel> products = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Product", connection);
                SqliteDataReader reader = command.ExecuteReader();
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

        public static ProductModel GetProductById(int id)
        {
            ProductModel product = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Product WHERE id_product = @id_product", connection);
                _ = command.Parameters.AddWithValue("@id_product", id);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int categoryNumber = int.Parse(reader["category_number"].ToString());
                    string productName = reader["product_name"].ToString();
                    string productCharacteristics = reader["characteristics"].ToString();
                    product = new ProductModel(id, categoryNumber, productName, productCharacteristics);
                }
            }
            return product;
        }

        /// <summary>
        /// Отримати інформацію про усі товари, відсортовані за назвою;
        /// </summary>
        /// <returns></returns>
        public static List<ProductModel> GetProductsSorted()
        {
            List<ProductModel> products = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Product ORDER BY product_name", connection);
                SqliteDataReader reader = command.ExecuteReader();
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
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("INSERT INTO Product (id_product, category_number, product_name, characteristics) VALUES (@Id, @CategoryNumber, @ProductName, @ProductCharacteristics)", connection);
            _ = command.Parameters.AddWithValue("@Id", product.Id);
            _ = command.Parameters.AddWithValue("@CategoryNumber", product.CategoryNumber);
            _ = command.Parameters.AddWithValue("@ProductName", product.ProductName);
            _ = command.Parameters.AddWithValue("@ProductCharacteristics", product.ProductCharacteristics);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        public static bool UpdateProduct(ProductModel product)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("UPDATE Product SET category_number = @CategoryNumber, product_name = @ProductName, characteristics = @ProductCharacteristics WHERE id_product = @Id", connection);
            _ = command.Parameters.AddWithValue("@Id", product.Id);
            _ = command.Parameters.AddWithValue("@CategoryNumber", product.CategoryNumber);
            _ = command.Parameters.AddWithValue("@ProductName", product.ProductName);
            _ = command.Parameters.AddWithValue("@ProductCharacteristics", product.ProductCharacteristics);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        public static bool DeleteProduct(int id)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("DELETE FROM Product WHERE id_product = @Id", connection);
            _ = command.Parameters.AddWithValue("@Id", id);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        //get sorted products by category
        public static List<ProductModel> GetProductsByCategory(string categoryName)
        {
            List<ProductModel> products = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Product WHERE category_number = (SELECT category_number FROM Category WHERE category_name = @categoryName)", connection);
                _ = command.Parameters.AddWithValue("@categoryName", categoryName);
                SqliteDataReader reader = command.ExecuteReader();
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

        //get products by name in lowercase and if it contains search string
        public static List<ProductModel> GetProductsByName(string productName)
        {
            List<ProductModel> products = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Product WHERE lower(product_name) LIKE @productName", connection);
                _ = command.Parameters.AddWithValue("@productName", "%" + productName.ToLower() + "%");
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id_product"].ToString());
                    int categoryNumber = int.Parse(reader["category_number"].ToString());
                    string ProductName = reader["product_name"].ToString();
                    string productCharacteristics = reader["characteristics"].ToString();
                    products.Add(new ProductModel(id, categoryNumber, ProductName, productCharacteristics));
                }
            }
            return products;
        }
        #endregion

        #region Category

        public static List<CategoryModel> GetCategories()
        {
            List<CategoryModel> categories = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Category", connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["category_number"].ToString());
                    string categoryName = reader["category_name"].ToString(); ;
                    categories.Add(new CategoryModel(id, categoryName));
                }
            }
            return categories;
        }

        public static CategoryModel GetCategoryById(int id)
        {
            CategoryModel category = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Category WHERE category_number = @Id", connection);
                _ = command.Parameters.AddWithValue("@Id", id);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int categoryId = int.Parse(reader["category_number"].ToString());
                    string categoryName = reader["category_name"].ToString(); ;
                    category = new CategoryModel(categoryId, categoryName);
                }
            }
            return category;
        }

        /// <summary>
        ///  Отримати інформацію про усі категорії, відсортовані за назвою;
        /// </summary>
        /// <returns></returns>
        public static List<CategoryModel> GetCategoriesSorted()
        {
            List<CategoryModel> categories = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Category ORDER BY category_name", connection);
                SqliteDataReader reader = command.ExecuteReader();
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
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("INSERT INTO Category (category_number, category_name) VALUES (@Id, @CategoryName)", connection);
            _ = command.Parameters.AddWithValue("@Id", category.Id);
            _ = command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        public static bool UpdateCategory(CategoryModel category)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("UPDATE Category SET category_name = @CategoryName WHERE category_number = @Id", connection);
            _ = command.Parameters.AddWithValue("@Id", category.Id);
            _ = command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        public static bool DeleteCategory(int id)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("DELETE FROM Category WHERE category_number = @Id", connection);
            _ = command.Parameters.AddWithValue("@Id", id);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }
        #endregion

        #region Store Product

        public static List<StoreProductModel> GetStoreProducts()
        {
            List<StoreProductModel> storeProducts = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Store_Product", connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    int id_product = int.Parse(reader["id_product"].ToString());
                    int selling_price = int.Parse(reader["selling_price"].ToString());
                    int quantity = int.Parse(reader["products_number"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));
                    DateTime date = DateTime.Parse(reader["expiry_date"].ToString());

                    storeProducts.Add(new StoreProductModel(UPC, id_product, selling_price, quantity, promotional_product, date));
                }
            }

            return storeProducts;
        }
        public static StoreProductModel GetStoreProductById(string uPC)
        {
            StoreProductModel storeProduct = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Store_Product WHERE UPC = @UPC", connection);
                _ = command.Parameters.AddWithValue("@UPC", uPC);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    int id_product = int.Parse(reader["id_product"].ToString());
                    int selling_price = int.Parse(reader["selling_price"].ToString());
                    int quantity = int.Parse(reader["products_number"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));
                    DateTime date = DateTime.Parse(reader["expiry_date"].ToString());
                    storeProduct = new StoreProductModel(UPC, id_product, selling_price, quantity, promotional_product, date);
                }
            }
            return storeProduct;
        }
        //get store products by product name 
        public static List<StoreProductModel> GetStoreProductsByProductName(string productName)
        {
            List<StoreProductModel> storeProducts = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Store_Product WHERE id_product = (SELECT product_number FROM Product WHERE product_name = @ProductName)", connection);
                _ = command.Parameters.AddWithValue("@ProductName", productName);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    int id_product = int.Parse(reader["id_product"].ToString());
                    int selling_price = int.Parse(reader["selling_price"].ToString());
                    int quantity = int.Parse(reader["products_number"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));
                    DateTime date = DateTime.Parse(reader["expiry_date"].ToString());
                    storeProducts.Add(new StoreProductModel(UPC, id_product, selling_price, quantity, promotional_product, date));
                }
            }
            return storeProducts;
        }
        public static decimal GetStoreProductPrice(string UPC)
        {
            decimal price = 0;
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT selling_price FROM Store_Product WHERE UPC = @UPC", connection);
                _ = command.Parameters.AddWithValue("@UPC", UPC);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    price = decimal.Parse(reader["selling_price"].ToString());
                }
            }
            return price;
        }
        public static int GetStoreProductProductId(string UPC)
        {
            int productId = 0;
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT id_product FROM Store_Product WHERE UPC = @UPC", connection);
                _ = command.Parameters.AddWithValue("@UPC", UPC);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productId = int.Parse(reader["id_product"].ToString());
                }
            }
            return productId;
        }
        public static int GetStoreProductQuantity(string UPC)
        {
            int quantity = 0;
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT products_number FROM Store_Product WHERE UPC = @UPC", connection);
                _ = command.Parameters.AddWithValue("@UPC", UPC);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    quantity = int.Parse(reader["products_number"].ToString());
                }
            }
            return quantity;
        }
        public static void SellStoreProduct(string UPC, int quantity)
        {
            StoreProductModel storeProduct = GetStoreProductById(UPC);
            storeProduct.Quantity -= quantity;
            if (storeProduct.Quantity < 0)
            {
                throw new Exception("В магазині немає достатньо цього продукту.");
            }

            if (storeProduct.Quantity >= 0)
            {
                _ = UpdateStoreProduct(storeProduct);
            }
        }
        /// <summary>
        /// Отримати інформацію про усі товари у магазині, відсортовані за кількістю;
        /// </summary>
        /// <returns></returns>
        public static List<StoreProductModel> GetStoreProductsSortedByQuantity()
        {
            List<StoreProductModel> storeProducts = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Store_Product sp ORDER BY sp.products_number", connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    int id_product = int.Parse(reader["id_product"].ToString());
                    int selling_price = int.Parse(reader["selling_price"].ToString());
                    int quantity = int.Parse(reader["products_number"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));
                    DateTime date = DateTime.Parse(reader["expiry_date"].ToString());

                    storeProducts.Add(new StoreProductModel(UPC,id_product, selling_price, quantity, promotional_product, date));
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
            List<StoreProductModel> storeProducts = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Store_Product sp JOIN Product p on p.id_product = sp.id_product WHERE sp.promotional_product = true ORDER BY p.product_name", connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    int id_product = int.Parse(reader["id_product"].ToString());
                    int selling_price = int.Parse(reader["selling_price"].ToString());
                    int quantity = int.Parse(reader["products_number"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));
                    DateTime date = DateTime.Parse(reader["expiry_date"].ToString());

                    storeProducts.Add(new StoreProductModel(UPC, id_product, selling_price, quantity, promotional_product, date));
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
            List<StoreProductModel> storeProducts = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Store_Product sp WHERE sp.promotional_product = true ORDER BY sp.products_number", connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    int id_product = int.Parse(reader["id_product"].ToString());
                    int selling_price = int.Parse(reader["selling_price"].ToString());
                    int quantity = int.Parse(reader["products_number"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));
                    DateTime date = DateTime.Parse(reader["expiry_date"].ToString());

                    storeProducts.Add(new StoreProductModel(UPC,  id_product, selling_price, quantity, promotional_product, date));
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
            List<StoreProductModel> storeProducts = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Store_Product sp JOIN Product p on p.id_product = sp.id_product WHERE sp.promotional_product = false ORDER BY p.product_name", connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    int id_product = int.Parse(reader["id_product"].ToString());
                    int selling_price = int.Parse(reader["selling_price"].ToString());
                    int quantity = int.Parse(reader["products_number"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));
                    DateTime date = DateTime.Parse(reader["expiry_date"].ToString());

                    storeProducts.Add(new StoreProductModel(UPC, id_product, selling_price, quantity, promotional_product, date));
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
            List<StoreProductModel> storeProducts = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Store_Product sp WHERE sp.promotional_product = false ORDER BY sp.products_number", connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    int id_product = int.Parse(reader["id_product"].ToString());
                    int selling_price = int.Parse(reader["selling_price"].ToString());
                    int quantity = int.Parse(reader["products_number"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));
                    DateTime date = DateTime.Parse(reader["expiry_date"].ToString());

                    storeProducts.Add(new StoreProductModel(UPC, id_product, selling_price, quantity, promotional_product, date));
                }
            }

            return storeProducts;
        }
        public static List<StoreProductModel> GetStoreProductsToDate(DateTime date)
        {
            List<StoreProductModel> storeProducts = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Store_Product WHERE expiry_date < @date", connection);
                _ = command.Parameters.AddWithValue("@date", date);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    int id_product = int.Parse(reader["id_product"].ToString());
                    int selling_price = int.Parse(reader["selling_price"].ToString());
                    int quantity = int.Parse(reader["products_number"].ToString());
                    bool promotional_product = reader.GetBoolean(reader.GetOrdinal("promotional_product"));
                    DateTime expiryDate = DateTime.Parse(reader["expiry_date"].ToString());

                    storeProducts.Add(new StoreProductModel(UPC, id_product, selling_price, quantity, promotional_product, expiryDate));
                }
            }

            return storeProducts;
        }
        public static bool AddStoreProduct(StoreProductModel storeProduct)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("INSERT INTO Store_Product (UPC,  id_product, selling_price, promotional_product, products_number, expiry_date) VALUES (@UPC,  @Id, @SellingPrice, @PromotionalProduct, @Quantity, @ExpiryDate)", connection);
            _ = command.Parameters.AddWithValue("@UPC", storeProduct.UPC);
            _ = command.Parameters.AddWithValue("@Id", storeProduct.ProductId);
            _ = command.Parameters.AddWithValue("@SellingPrice", storeProduct.Price);
            _ = command.Parameters.AddWithValue("@PromotionalProduct", storeProduct.IsPromotion);
            _ = command.Parameters.AddWithValue("@Quantity", storeProduct.Quantity);
            _ = command.Parameters.AddWithValue("@ExpiryDate", storeProduct.ExpiryDate);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        public static bool UpdateStoreProduct(StoreProductModel storeProduct)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("UPDATE Store_Product SET selling_price = @SellingPrice, promotional_product = @PromotionalProduct, products_number = @Quantity, id_product = @productId, expiry_date = @ExpiryDate WHERE UPC = @UPC", connection);
            _ = command.Parameters.AddWithValue("@UPC", storeProduct.UPC);
            _ = command.Parameters.AddWithValue("@SellingPrice", storeProduct.Price);
            _ = command.Parameters.AddWithValue("@PromotionalProduct", storeProduct.IsPromotion);
            _ = command.Parameters.AddWithValue("@Quantity", storeProduct.Quantity);
            _ = command.Parameters.AddWithValue("@productId", storeProduct.ProductId);
            _ = command.Parameters.AddWithValue("@ExpiryDate", storeProduct.ExpiryDate);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        public static bool DeleteStoreProduct(string UPC)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("DELETE FROM Store_Product WHERE UPC = @UPC", connection);
            _ = command.Parameters.AddWithValue("@UPC", UPC);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }
        #endregion

        #region Customer

        public static List<CustomerModel> GetCustomers()
        {
            List<CustomerModel> customers = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Customer_Card", connection);
                SqliteDataReader reader = command.ExecuteReader();
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
                    int percent = int.Parse(reader["percent"].ToString());

                    customers.Add(new CustomerModel(card_number, cust_name, cust_surname, cust_patronymic, phone_number, street, city, zip_code, percent));
                }
            }

            return customers;
        }

        public static CustomerModel GetCustomerById(int id)
        {
            CustomerModel customer = new CustomerModel();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Customer_Card WHERE id = @id", connection);
                _ = command.Parameters.AddWithValue("@id", id);
                SqliteDataReader reader = command.ExecuteReader();
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
                    int percent = int.Parse(reader["percent"].ToString());
                    customer = new CustomerModel(card_number, cust_name, cust_surname, cust_patronymic, phone_number, street, city, zip_code, percent);
                }
            }
            return customer;
        }
        /// <summary>
        /// Отримати інформацію про усіх постійних клієнтів, відсортованих за прізвищем;
        /// </summary>
        /// <returns></returns>
        public static List<CustomerModel> GetCustomersSorted()
        {
            List<CustomerModel> customers = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Customer_Card ORDER BY cust_surname", connection);
                SqliteDataReader reader = command.ExecuteReader();
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
                    int percent = int.Parse(reader["percent"].ToString());

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
            List<CustomerModel> customers = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Customer_Card WHERE percent = @percent ORDER BY cust_surname", connection);
                _ = command.Parameters.AddWithValue("@percent", percentSearch);
                SqliteDataReader reader = command.ExecuteReader();
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
                    int percent = int.Parse(reader["percent"].ToString());

                    customers.Add(new CustomerModel(card_number, cust_name, cust_surname, cust_patronymic, phone_number, street, city, zip_code, percent));
                }
            }

            return customers;
        }
        public static bool AddCustomer(CustomerModel customer)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("INSERT INTO Customer_Card (card_number, cust_surname, cust_name, cust_patronymic, phone_number, city, street, zip_code, percent) VALUES (@CardNumber, @Surname, @Name, @Patronymic, @PhoneNumber, @City, @Street, @ZipCode, @Percent)", connection);
            _ = command.Parameters.AddWithValue("@CardNumber", customer.CardNumber);
            _ = command.Parameters.AddWithValue("@Surname", customer.LastName);
            _ = command.Parameters.AddWithValue("@Name", customer.Name);
            _ = command.Parameters.AddWithValue("@Patronymic", customer.Patronymic);
            _ = command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
            _ = command.Parameters.AddWithValue("@City", customer.City);
            _ = command.Parameters.AddWithValue("@Street", customer.Street);
            _ = command.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
            _ = command.Parameters.AddWithValue("@Percent", customer.Percent);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        public static bool UpdateCustomer(CustomerModel customer)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("UPDATE Customer_Card SET cust_surname = @Surname, cust_name = @Name, cust_patronymic = @Patronymic, phone_number = @PhoneNumber, city = @City, street = @Street, zip_code = @ZipCode, percent = @Percent WHERE card_number = @CardNumber", connection);
            _ = command.Parameters.AddWithValue("@CardNumber", customer.CardNumber);
            _ = command.Parameters.AddWithValue("@Surname", customer.LastName);
            _ = command.Parameters.AddWithValue("@Name", customer.Name);
            _ = command.Parameters.AddWithValue("@Patronymic", customer.Patronymic);
            _ = command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
            _ = command.Parameters.AddWithValue("@City", customer.City);
            _ = command.Parameters.AddWithValue("@Street", customer.Street);
            _ = command.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
            _ = command.Parameters.AddWithValue("@Percent", customer.Percent);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        public static bool DeleteCustomer(string cardNumber)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("DELETE FROM Customer_Card WHERE card_number = @CardNumber", connection);
            _ = command.Parameters.AddWithValue("@CardNumber", cardNumber);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }
        //get customers where surname contains search string
        public static List<CustomerModel> GetCustomersBySurname(string surnameSearch)
        {
            List<CustomerModel> customers = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Customer_Card WHERE cust_surname LIKE @Surname", connection);
                _ = command.Parameters.AddWithValue("@Surname", "%" + surnameSearch + "%");
                SqliteDataReader reader = command.ExecuteReader();
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
                    int percent = int.Parse(reader["percent"].ToString());
                    customers.Add(new CustomerModel(card_number, cust_name, cust_surname, cust_patronymic, phone_number, street, city, zip_code, percent));
                }
            }
            return customers;
        }
        #endregion

        #region Sale

        public static List<SaleModel> GetSalesBySaleCheckId(int saleCheckId)
        {
            List<SaleModel> sales = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Sale WHERE check_number = @CheckNumber", connection);
                _ = command.Parameters.AddWithValue("@CheckNumber", saleCheckId);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string UPC = reader["UPC"].ToString();
                    int check_number = int.Parse(reader["check_number"].ToString());
                    int product_number = int.Parse(reader["product_number"].ToString());
                    //int quantity = int.Parse(reader["quantity"].ToString());
                    decimal selling_price = decimal.Parse(reader["selling_price"].ToString());
                    sales.Add(new SaleModel(UPC, check_number, product_number, selling_price));
                }
            }
            return sales;
        }
        private static void AddSales(SaleCheckModel saleCheck)
        {
            foreach (SaleModel sale in saleCheck.CheckItems)
            {
                if (sale.CheckNumber != saleCheck.CheckNumber)
                {
                    sale.CheckNumber = saleCheck.CheckNumber;
                }

                _ = AddSale(sale);
            }
        }

        private static int GetLastSaleCheckId()
        {
            int lastSaleCheckId = 0;
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT MAX(check_number) FROM Sales_Check", connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lastSaleCheckId = int.Parse(reader["MAX(check_number)"].ToString());
                }
            }
            return lastSaleCheckId;
        }

        public static bool AddSale(SaleModel sale)
        {

            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("INSERT INTO Sale (UPC, check_number, product_number, selling_price) VALUES (@UPC, @CheckNumber, @ProductNumber,  @SellingPrice)", connection);
            _ = command.Parameters.AddWithValue("@UPC", sale.UPC);
            _ = command.Parameters.AddWithValue("@CheckNumber", sale.CheckNumber);
            _ = command.Parameters.AddWithValue("@ProductNumber", sale.ProductNumber);
            _ = command.Parameters.AddWithValue("@SellingPrice", sale.Price);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                SellStoreProduct(sale.UPC, sale.ProductNumber);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteSale(string checkNumber)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("DELETE FROM Sale WHERE check_number = @CheckNumber", connection);
            _ = command.Parameters.AddWithValue("@CheckNumber", checkNumber);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        #endregion

        #region Sale Check

        public static List<SaleCheckModel> GetSaleChecks()
        {
            List<SaleCheckModel> saleChecks = new();

            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Sales_Check", connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int check_number = int.Parse(reader["check_number"].ToString());
                    int id_employee = int.Parse(reader["id_employee"].ToString());
                    string card_number = reader["card_number"].ToString();
                    DateTime print_date = DateTime.Parse(reader["print_date"].ToString());
                    decimal sum_total = decimal.Parse(reader["sum_total"].ToString());
                    decimal vat = decimal.Parse(reader["vat"].ToString());
                    List<SaleModel> sales = GetSalesBySaleCheckId(check_number);
                    saleChecks.Add(new SaleCheckModel(check_number, id_employee, card_number, print_date, sum_total, vat, sales));
                }
            }

            return saleChecks;
        }

        public static SaleCheckModel GetSaleCheckById(int checkNumber)
        {
            SaleCheckModel saleCheck = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Sales_Check WHERE check_number = @CheckNumber", connection);
                _ = command.Parameters.AddWithValue("@CheckNumber", checkNumber);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id_employee = int.Parse(reader["id_employee"].ToString());
                    string card_number = reader["card_number"].ToString();
                    DateTime print_date = DateTime.Parse(reader["print_date"].ToString());
                    decimal sum_total = decimal.Parse(reader["sum_total"].ToString());
                    decimal vat = decimal.Parse(reader["vat"].ToString());
                    List<SaleModel> sales = GetSalesBySaleCheckId(checkNumber);
                    saleCheck = new SaleCheckModel(checkNumber, id_employee, card_number, print_date, sum_total, vat, sales);
                }
            }
            return saleCheck;
        }

        public static bool AddSaleCheck(SaleCheckModel saleCheck)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("INSERT INTO Sales_Check (id_employee, card_number, print_date, sum_total, vat) VALUES (@IdEmployee, @CardNumber, @PrintDate, @SumTotal, @VAT)", connection);
            _ = command.Parameters.AddWithValue("@IdEmployee", saleCheck.EmployeeId);
            _ = command.Parameters.AddWithValue("@CardNumber", saleCheck.CardNumber);
            _ = command.Parameters.AddWithValue("@PrintDate", saleCheck.PrintDate);
            _ = command.Parameters.AddWithValue("@SumTotal", saleCheck.SumTotal);
            _ = command.Parameters.AddWithValue("@VAT", saleCheck.VAT);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                AddSales(saleCheck);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteSaleCheck(string checkNumber)
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();
            SqliteCommand command = new("DELETE FROM Sales_Check WHERE check_number = @CheckNumber", connection);
            _ = command.Parameters.AddWithValue("@CheckNumber", checkNumber);
            _ = DeleteSale(checkNumber);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        //get all sale checks with sales by employee id and 2 dates
        public static List<SaleCheckModel> GetSaleChecksByEmployeeIdAndDates(string employeeId, DateTime startDate, DateTime endDate)
        {
            List<SaleCheckModel> saleChecks = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Sales_Check WHERE id_employee = @IdEmployee AND print_date BETWEEN @StartDate AND @EndDate", connection);
                _ = command.Parameters.AddWithValue("@IdEmployee", employeeId);
                _ = command.Parameters.AddWithValue("@StartDate", startDate);
                _ = command.Parameters.AddWithValue("@EndDate", endDate);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int check_number = int.Parse(reader["check_number"].ToString());
                    int id_employee = int.Parse(reader["id_employee"].ToString());
                    string card_number = reader["card_number"].ToString();
                    DateTime print_date = DateTime.Parse(reader["print_date"].ToString());
                    decimal sum_total = decimal.Parse(reader["sum_total"].ToString());
                    decimal vat = decimal.Parse(reader["vat"].ToString());
                    List<SaleModel> sales = GetSalesBySaleCheckId(check_number);
                    saleChecks.Add(new SaleCheckModel(check_number, id_employee, card_number, print_date, sum_total, vat, sales));
                }
            }
            return saleChecks;
        }

        //get all sale checks with sales by 2 dates
        public static List<SaleCheckModel> GetSaleChecksByDates(DateTime startDate, DateTime endDate)
        {
            List<SaleCheckModel> saleChecks = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Sales_Check WHERE print_date BETWEEN @StartDate AND @EndDate", connection);
                _ = command.Parameters.AddWithValue("@StartDate", startDate);
                _ = command.Parameters.AddWithValue("@EndDate", endDate);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int check_number = int.Parse(reader["check_number"].ToString());
                    int id_employee = int.Parse(reader["id_employee"].ToString());
                    string card_number = reader["card_number"].ToString();
                    DateTime print_date = DateTime.Parse(reader["print_date"].ToString());
                    decimal sum_total = decimal.Parse(reader["sum_total"].ToString());
                    decimal vat = decimal.Parse(reader["vat"].ToString());
                    List<SaleModel> sales = GetSalesBySaleCheckId(check_number);
                    saleChecks.Add(new SaleCheckModel(check_number, id_employee, card_number, print_date, sum_total, vat, sales));
                }
            }
            return saleChecks;
        }

        //get sum of all sales by employee id and 2 dates
        public static decimal GetSumOfSalesByEmployeeIdAndDates(string employeeId, DateTime startDate, DateTime endDate)
        {
            decimal sum = 0;
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT sum(sum_total) FROM Sales_Check WHERE id_employee = @IdEmployee AND print_date BETWEEN @StartDate AND @EndDate", connection);
                _ = command.Parameters.AddWithValue("@IdEmployee", employeeId);
                _ = command.Parameters.AddWithValue("@StartDate", startDate);
                _ = command.Parameters.AddWithValue("@EndDate", endDate);
                SqliteDataReader reader = command.ExecuteReader();
                try { 
                    sum = decimal.Parse(reader["sum(sum_total)"].ToString());
                }
                catch (Exception e)
                {
                    sum = 0;
                }
            }
            return sum;
        }

        //get sum of all sales by 2 dates
        public static decimal GetSumOfSalesByDates(DateTime startDate, DateTime endDate)
        {
            decimal sum = 0;
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT sum(sum_total) FROM Sales_Check WHERE print_date BETWEEN @StartDate AND @EndDate", connection);
                _ = command.Parameters.AddWithValue("@StartDate", startDate);
                _ = command.Parameters.AddWithValue("@EndDate", endDate);
                SqliteDataReader reader = command.ExecuteReader();
                sum = decimal.Parse(reader["sum(sum_total)"].ToString());
            }
            return sum;
        }

        //count quantity of all sold products by product name
        public static int GetQuantityOfSoldProductsByProductName(string productName)
        {
            int quantity = 0;
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT sum(product_number) FROM Sale as s JOIN Store_Product as sp on sp.UPC = s.UPC JOIN Product as p on p.id_product = sp.id_product WHERE p.product_name = @ProductName", connection);
                _ = command.Parameters.AddWithValue("@ProductName", productName);
                SqliteDataReader reader = command.ExecuteReader();
                try
                {
                    quantity = int.Parse(reader["sum(quantity)"].ToString());
                }
                catch (Exception e)
                {
                    quantity = 0;
                }
            }
            return quantity;
        }

        //count quantity of all sold products by product name and 2 dates
        public static int GetQuantityOfSoldProductsByProductNameAndDates(string productName, DateTime startDate, DateTime endDate)
        {
            int quantity = 0;
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT sum(quantity) FROM Sale JOIN Product as p on p.id_product = product_number JOIN Sales_Check as sc on sc.check_number = sale_check_number WHERE p.product_name = @ProductName AND sc.print_date BETWEEN @StartDate AND @EndDate", connection);
                _ = command.Parameters.AddWithValue("@ProductName", productName);
                _ = command.Parameters.AddWithValue("@StartDate", startDate);
                _ = command.Parameters.AddWithValue("@EndDate", endDate);
                SqliteDataReader reader = command.ExecuteReader();
                try
                {
                    quantity = int.Parse(reader["sum(quantity)"].ToString());
                }
                catch (Exception e)
                {
                    quantity = 0;
                }
            }
            return quantity;
        }

        //get checks by employee id today
        public static List<SaleCheckModel> GetSaleChecksByEmployeeIdToday(string employeeId)
        {
            List<SaleCheckModel> saleChecks = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Sales_Check WHERE id_employee = @IdEmployee AND print_date BETWEEN @StartDate AND @EndDate", connection);
                _ = command.Parameters.AddWithValue("@IdEmployee", employeeId);
                _ = command.Parameters.AddWithValue("@StartDate", DateTime.Today);
                _ = command.Parameters.AddWithValue("@EndDate", DateTime.Today.AddDays(1));
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int check_number = int.Parse(reader["check_number"].ToString());
                    int id_employee = int.Parse(reader["id_employee"].ToString());
                    string card_number = reader["card_number"].ToString();
                    DateTime print_date = DateTime.Parse(reader["print_date"].ToString());
                    decimal sum_total = decimal.Parse(reader["sum_total"].ToString());
                    decimal vat = decimal.Parse(reader["vat"].ToString());
                    List<SaleModel> sales = GetSalesBySaleCheckId(check_number);
                    saleChecks.Add(new SaleCheckModel(check_number, id_employee, card_number, print_date, sum_total, vat, sales));
                }
            }
            return saleChecks;
        }

        //get check by check number
        public static SaleCheckModel GetSaleCheckByCheckNumber(int checkNumber)
        {
            SaleCheckModel saleCheck = new();
            using (SqliteConnection connection = new(connectionString))
            {
                connection.Open();
                SqliteCommand command = new("SELECT * FROM Sales_Check WHERE check_number = @CheckNumber", connection);
                _ = command.Parameters.AddWithValue("@CheckNumber", checkNumber);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int check_number = int.Parse(reader["check_number"].ToString());
                    int id_employee = int.Parse(reader["id_employee"].ToString());
                    string card_number = reader["card_number"].ToString();
                    DateTime print_date = DateTime.Parse(reader["print_date"].ToString());
                    decimal sum_total = decimal.Parse(reader["sum_total"].ToString());
                    decimal vat = decimal.Parse(reader["vat"].ToString());
                    List<SaleModel> sales = GetSalesBySaleCheckId(check_number);
                    saleCheck = new SaleCheckModel(check_number, id_employee, card_number, print_date, sum_total, vat, sales);
                }
            }
            return saleCheck;
        }

        #endregion
    }
}
