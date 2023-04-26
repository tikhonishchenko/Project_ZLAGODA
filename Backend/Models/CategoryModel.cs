using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    internal class CategoryModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Назва категорії")]
        public string CategoryName { get; set; }

        public CategoryModel(int id, string categoryName)
        {
            Id = id;
            CategoryName = categoryName;
        }

        public CategoryModel()
        {
        }

        public override string ToString()
        {
            return $"{Id} {CategoryName}";
        }
    }
}
