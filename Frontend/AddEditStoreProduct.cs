using Project_ZLAGODA.Backend.Database;
using Project_ZLAGODA.Backend.Models;
using Project_ZLAGODA.Frontend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ZLAGODA
{
    public partial class AddEditStoreProduct : Form
    {

        ShowForm main = null;
        Mode mode = Mode.Add;
        List<ProductModel> products;
        public AddEditStoreProduct()
        {
            InitializeComponent();
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width / 2 - flowLayoutPanel1.Size.Width / 2, this.ClientSize.Height / 2 - flowLayoutPanel1.Size.Height / 2);
            TypeComboBox.SelectedIndex = 0;
            products = DbRepository.GetProductsSorted();
            List<string> productNames = new List<string>();
            foreach (ProductModel product in products)
            {
                productNames.Add(product.ProductName);
            }
            ProductComboBox.Items.AddRange(productNames.ToArray());
            if (productNames.Count() > 0)
            {
                ProductComboBox.SelectedIndex = 0;
            }
        }

        public void setMainForm(ShowForm main)
        {
            this.main = main;
        }

        public void setMode(Mode mode)
        {
            this.mode = mode;
            if (mode == Mode.Add)
            {
                this.Text = "Add store product";
                AddEditBtn.Text = "Add";
            }
            else if (mode == Mode.Edit)
            {
                UPCLabel.Hide();
                UPCTextBox.Hide();
                this.Text = "Edit product";
                AddEditBtn.Text = "Edit";
            }
        }

        public void setUPCTextBox(string upc)
        {
            this.UPCTextBox.Text = upc;
        }

        public void setPriceTextBox(decimal price)
        {
            this.PriceTextBox.Text = price.ToString();
        }

        public void setQuantityTextBox(int quantity)
        {
            this.QuantityTextBox.Text = quantity.ToString();
        }

        public void setProductId(int Id)
        {
            int n = 0;
            foreach (ProductModel product in products)
            {
                if (product.Id == Id)
                {
                    break;
                }
                n++;
            }
            if (products.Count() > 0)
            {
                ProductComboBox.SelectedIndex = n;
            }
        }

        public void setPromotional(bool isPromotional)
        {
            if (isPromotional)
            {
                TypeComboBox.SelectedIndex = 1;
            }
            else
            {
                TypeComboBox.SelectedIndex = 0;
            }
        }

        public void setExpiryDate(DateTime expiryDate)
        {
            ExpiryDateTimePicker.Value = expiryDate;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(PriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Price is incorrect!", "Error");
                return;
            }
            try
            {
                int.Parse(QuantityTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Quantity is incorrect!", "Error");
                return;
            }
            if (mode == Mode.Add)
            {
                //List<StoreProductModel> storeProducts = DbRepository.GetStoreProducts();
                StoreProductModel model = new StoreProductModel
                {
                    UPC = UPCTextBox.Text,
                    ProductId = products[ProductComboBox.SelectedIndex].Id,
                    Price = decimal.Parse(PriceTextBox.Text),
                    IsPromotion = TypeComboBox.SelectedIndex == 1 ? true : false,
                    Quantity = int.Parse(QuantityTextBox.Text),
                    ExpiryDate = ExpiryDateTimePicker.Value
                };
                DbRepository.AddStoreProduct(model);
                main.ShowStoreProducts();
                this.Close();
            }
            else if (mode == Mode.Edit)
            {
                //MessageBox.Show(ProductComboBox.SelectedIndex + " " + products[ProductComboBox.SelectedIndex].Id, "Error");
                StoreProductModel model = new StoreProductModel
                {
                    UPC = UPCTextBox.Text,
                    ProductId = products[ProductComboBox.SelectedIndex].Id,
                    Price = decimal.Parse(PriceTextBox.Text),
                    IsPromotion = TypeComboBox.SelectedIndex == 1 ? true : false,
                    Quantity = int.Parse(QuantityTextBox.Text),
                    ExpiryDate = ExpiryDateTimePicker.Value
                };
                //MessageBox.Show(model.ProductId.ToString(), "Error");
                DbRepository.UpdateStoreProduct(model);
                main.ShowStoreProducts();
                this.Close();
            }
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

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in PriceTextBox.Text)
            {
                if (!(a >= '0' && a <= '9' || a == '.' || a == ','))
                {
                    PriceTextBox.Text = PriceTextBox.Text.Remove(PriceTextBox.Text.Length - 1);
                    PriceTextBox.SelectionStart = PriceTextBox.Text.Length;
                    PriceTextBox.SelectionLength = 0;
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
