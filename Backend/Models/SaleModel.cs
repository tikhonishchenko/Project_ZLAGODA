using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    internal class SaleModel
    {
        public string UPC { get; set; }
        public string CheckNumber { get; set; }
        public int ProductNumber { get; set; }
        public decimal Price { get; set; }

        public SaleModel(string uPC, string checkNumber, int productNumber, decimal price)
        {
            UPC = uPC;
            CheckNumber = checkNumber;
            ProductNumber = productNumber;
            Price = price;
        }

        public SaleModel()
        {
        }

        public override string ToString()
        {
            return $"{UPC} {CheckNumber} {ProductNumber} {Price}";
        }
    }
}
