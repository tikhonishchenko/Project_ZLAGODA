using Project_ZLAGODA.Backend.Database;
using Project_ZLAGODA.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.ViewModels
{
    internal static class ViewModel
    {
        public static EmployeeModel currentEmployee = new EmployeeModel();
        public static SaleCheckModel currentCheck = new SaleCheckModel();
        public static byte[] ComputePasswordHash(string password, byte[] salt)
        {
            using (var hmac = new HMACSHA512(salt))
            {
                return hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public static void UpdateProducts()
        {
            var date = DateTime.Now.AddDays(3.0);
            var products = DbRepository.GetStoreProductsToDate(date);
            foreach(var product in products)
            {
                if (product.IsPromotion || product.Quantity < 5)
                {
                    continue;
                }
                product.IsPromotion = true;
                product.Price *= 0.8m;
                DbRepository.UpdateStoreProduct(product);
            }
        }

        public static void ResetPromotion()
        {
            var date = DateTime.Now.AddDays(3.0);
            var products = DbRepository.GetStoreProductsToDate(date);
            foreach (var product in products)
            {
                product.IsPromotion = false;
                DbRepository.UpdateStoreProduct(product);
            }
        }

        public static void TestRepository()
        {
            //test every method in dbrepository
            /*
            var result = DbRepository.GetEmployees();
            result = DbRepository.GetEmployeesSortedBySurname();
            result = DbRepository.GetEmployeesCashiersSortedBySurname();
            var resultS = DbRepository.GetEmployee("kovalchuk_olena","12345");
            resultS = DbRepository.GetEmployee("kovalchuk_vasyl", "12345");
            resultS = DbRepository.GetEmployee("kovalchuk_olena", "1234567");
            resultS = DbRepository.GetEmployeeDataBySurname("Біленький");
            resultS = DbRepository.GetEmployeeDataBySurname("Білий");
            var resultT = DbRepository.GetEmployeeById("3");
            resultS = DbRepository.GetEmployeeById("10");
            DbRepository.AddEmployee(new EmployeeModel(10, "Тест", "ТестП", "ТестПо", "Cashier", "+380991234567", 1000.69M, DateTime.Now, new DateTime(2000, 1, 1), "Київ", "Хрещатик", "00001", "12345", "test"));
            resultT.City = "Тест";
            DbRepository.UpdateEmployee(resultT);
            DbRepository.DeleteEmployee(4);
            result = DbRepository.GetEmployees();
            */
            /*
            var resultP = DbRepository.GetProducts();
            resultP = DbRepository.GetProductsSorted();
            DbRepository.AddProduct(new ProductModel(69, 2, "Тест", "тЕСТоПИС"));
            DbRepository.UpdateProduct(new ProductModel(10, 2, "Яловичина2", "вага 2кг"));
            DbRepository.DeleteProduct(9);
            resultP = DbRepository.GetProducts();
            */

            /*
            var result = DbRepository.GetCategories();
            result = DbRepository.GetCategoriesSorted();
            DbRepository.AddCategory(new CategoryModel(69, "Тест"));
            DbRepository.UpdateCategory(new CategoryModel(3, "мясо"));
            DbRepository.DeleteCategory(2);
            result = DbRepository.GetCategories();
            */
            /*
            var result = DbRepository.GetStoreProducts();
            result = DbRepository.GetStoreProductsSortedByQuantity();
            result = DbRepository.GetStoreProductsDiscountSortedByName();
            result = DbRepository.GetStoreProductsDiscountSortedByQuantity();
            result = DbRepository.GetStoreProductsNotDiscountSortedByName();
            result = DbRepository.GetStoreProductsNotDiscountSortedByQuantity();
            result = DbRepository.GetStoreProductsToDate(new DateTime(2023,4,20));
            DbRepository.AddStoreProduct(new StoreProductModel("000000000069", null, 69, 69.69M, 69, false, new DateTime(2023, 4, 25)));
            DbRepository.UpdateStoreProduct(new StoreProductModel("000000000010", null, 10, 169.69M, 420, false, new DateTime(2023, 4, 25)));
            DbRepository.DeleteStoreProduct("000000000009");
            */

            
        }

        internal static void AddItem(SaleModel saleModel)
        {
            if(currentCheck.CheckItems.Any(x=>x.UPC==saleModel.UPC))
            {
                var item = currentCheck.CheckItems.Where(x => x.UPC == saleModel.UPC).FirstOrDefault();
                item.ProductNumber += saleModel.ProductNumber;
            }
            else
                currentCheck.CheckItems.Add(saleModel);
        }

        internal static void GenerateCheck()
        {
            currentCheck.EmployeeId = currentEmployee.Id;
            currentCheck.SumTotal = currentCheck.CheckItems.Sum(x => x.Price*x.ProductNumber);
            currentCheck.PrintDate = DateTime.Now;
            currentCheck.VAT = currentCheck.SumTotal * 0.2M;
            DbRepository.AddSaleCheck(currentCheck);
            currentCheck = new SaleCheckModel();
        }

        internal static bool SaleIsLegal(string uPC, int quantity)
        {
            int quantityInStore = DbRepository.GetStoreProductQuantity(uPC);
            //check if there is duplicate objects in current check and merge them into one
            

            if (currentCheck.CheckItems.Any(x => x.UPC == uPC))
                quantityInStore -= currentCheck.CheckItems.Where(x => x.UPC == uPC).Sum(x => x.ProductNumber);
            if (quantityInStore >= quantity)           
                return true;         
            else
                return false;
            
        }
    }
}
