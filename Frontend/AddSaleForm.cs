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
            try
            {
                int.Parse(QuantityTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Quantity is incorrect!", "Error");
                return;
            }
            StoreProductModel model = DbRepository.GetStoreProductById(UPCTextBox.Text);
            if (model.UPC == null)
            {
                MessageBox.Show("No such UPC!", "Error");
                return;
            }
            if (model.Quantity < int.Parse(QuantityTextBox.Text))
            {
                MessageBox.Show("Quantity is too big!", "Error");
                return;
            }
            main.AddSale(model.UPC, int.Parse(QuantityTextBox.Text), model.Price);
            this.Close();
        }

        private void UPCTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in UPCTextBox.Text)
            {
                if (!(a >= '0' && a <= '9'))
                {
                    UPCTextBox.Text = UPCTextBox.Text.Remove(UPCTextBox.Text.Length - 1);
                    UPCTextBox.SelectionStart = UPCTextBox.Text.Length;
                    UPCTextBox.SelectionLength = 0;
                    return;
                }
            }
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in QuantityTextBox.Text)
            {
                if (!(a >= '0' && a <= '9'))
                {
                    QuantityTextBox.Text = QuantityTextBox.Text.Remove(QuantityTextBox.Text.Length - 1);
                    QuantityTextBox.SelectionStart = QuantityTextBox.Text.Length;
                    QuantityTextBox.SelectionLength = 0;
                    return;
                }
            }
        }
    }
}
