using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    public class SaleModel
    {
        public string UPC { get; set; }
        public int CheckNumber { get; set; }
        public int ProductNumber { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public SaleModel(string uPC, int checkNumber, int productNumber, int quantity, decimal price)
        {
            UPC = uPC;
            CheckNumber = checkNumber;
            ProductNumber = productNumber;
            Quantity = quantity;
            Price = price;
        }

        public SaleModel()
        {
        }

        public override string ToString()
        {
            return $"{UPC} {CheckNumber} {Quantity} {Price}";
        }
    }
}
