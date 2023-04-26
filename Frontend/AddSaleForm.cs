using Project_ZLAGODA.Backend.Database;
using Project_ZLAGODA.Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ZLAGODA.Frontend
{
    public partial class AddSaleForm : Form
    {
        AddSaleCheckForm main;

        public AddSaleForm()
        {
            InitializeComponent();
        }

        public void setMainForm(AddSaleCheckForm main)
        {
            this.main = main;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            StoreProductModel model = DbRepository.GetStoreProduct(UPCTextBox.Text);
            main.AddSale(model.UPC, int.Parse(QuantityTextBox.Text), model.Price);
        }
    }
}
