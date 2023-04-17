using Project_ZLAGODA.Backend.Database;
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
    }
}
