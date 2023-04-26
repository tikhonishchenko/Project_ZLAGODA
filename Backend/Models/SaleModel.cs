using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    public class SaleModel
    {
        [DisplayName("UPC")]
        public string UPC { get; set; }
        [DisplayName("Номер чека")]
        public int CheckNumber { get; set; }
        [DisplayName("Кількість")]
        public int ProductNumber { get; set; }
        [DisplayName("Ціна")]
        public decimal Price { get; set; }

        public SaleModel(string uPC, int checkNumber, int productNumber, decimal price)
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
            return $"{UPC} {CheckNumber} {Price}";
        }
    }
}
