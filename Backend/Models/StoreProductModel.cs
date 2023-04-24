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
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public bool IsPromotion { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }

        public StoreProductModel(string uPC, int productId, decimal price, int quantity,bool isPromotion,DateTime expiryDate)
        {
            UPC = uPC;
            ProductId = productId;
            Price = price;
            Quantity = quantity;
            IsPromotion = isPromotion;
            ExpiryDate = expiryDate;
        }

        public StoreProductModel()
        {
        }

        public override string ToString()
        {
            return $"UPC: {UPC}, ProductId: {ProductId}, Price: {Price}, Quantity: {Quantity}, IsPromotion: {IsPromotion}, ExpiryDate: {ExpiryDate}";
        }

    }
}
