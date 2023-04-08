using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    internal class StoreProductModel
    {
        public string UPC { get; set; }
        public string UPC_Prom { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public bool IsPromotion { get; set; }
        public DateTime ExpiryDate { get; set; }

        public StoreProductModel(string uPC, string uPC_Prom, int productId, decimal price, bool isPromotion)
        {
            UPC = uPC;
            UPC_Prom = uPC_Prom;
            ProductId = productId;
            Price = price;
            IsPromotion = isPromotion;
        }

        public StoreProductModel()
        {
        }

        public override string ToString()
        {
            return $"{UPC} {UPC_Prom} {ProductId} {Price} {IsPromotion}";
        }

    }
}
