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
        [DisplayName("First Name")]
        public int Id { get; set; }
        public int CategoryNumber { get; set; }
        public string ProductName { get; set; }
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
