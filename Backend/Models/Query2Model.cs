using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    public class Query2Model
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Category")]
        public string CategoryName { get; set; }
        [DisplayName("Store products quantity")]
        public int StoreProductsQuantity { get; set; }

        public Query2Model(int id, string categoryName, int storeProductsQuantity)
        {
            Id = id;
            CategoryName = categoryName;
            StoreProductsQuantity = storeProductsQuantity;
        }

        public Query2Model()
        {
        }

        public override string ToString()
        {
            return $"{Id} {CategoryName} {StoreProductsQuantity}";
        }
    }
}
