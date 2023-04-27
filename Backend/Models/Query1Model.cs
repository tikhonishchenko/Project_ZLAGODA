using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    public class Query1Model
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Product")]
        public string ProductName { get; set; }
        [DisplayName("Category")]
        public string CategoryName { get; set; }
        [DisplayName("Characteristics")]
        public string ProductCharacteristics { get; set; }

        public Query1Model(int id, string productName, string categoryName, string productCharacteristics)
        {
            Id = id;
            ProductName = productName;
            CategoryName = categoryName;
            ProductCharacteristics = productCharacteristics;
        }

        public Query1Model()
        {
        }

        public override string ToString()
        {
            return $"{Id} {ProductName} {CategoryName} {ProductCharacteristics}";
        }
    }
}
