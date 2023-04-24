using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    internal class SaleModel
    {
        [DisplayName("UPC")]
        public string UPC { get; set; }
        [DisplayName("Номер чека")]
        public int CheckNumber { get; set; }
        [DisplayName("Номер товару")]
        public int ProductNumber { get; set; }
        [DisplayName("Кількість")]
        public int Quantity { get; set; }
        [DisplayName("Ціна")]
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
