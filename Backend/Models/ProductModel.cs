using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    internal class ProductModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Категорія")]
        public int CategoryNumber { get; set; }
        [DisplayName("Назва товару")]
        public string ProductName { get; set; }
        [DisplayName("Характеристики")]
        public string ProductCharacteristics { get; set; }

        public ProductModel(int id, int categoryNumber, string productName, string productCharacteristics)
        {
            Id = id;
            CategoryNumber = categoryNumber;
            ProductName = productName;
            ProductCharacteristics = productCharacteristics;
        }

        public ProductModel()
        {
        }

        public override string ToString()
        {
            return $"{Id} {CategoryNumber} {ProductName} {ProductCharacteristics}";
        }

    }
}
