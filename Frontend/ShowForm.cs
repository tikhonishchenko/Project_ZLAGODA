using Project_ZLAGODA.Backend.Database;
using Project_ZLAGODA.Backend.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ZLAGODA.Frontend
{
    public interface ShowForm
    {
        public void ShowEmployees();

        public void ShowCustomers();

        public void ShowCategories();

        public void ShowProducts();

        public void ShowStoreProducts();
    }
}
