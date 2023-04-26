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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_ZLAGODA
{
    public partial class AddEditProduct : Form
    {

        ShowForm main = null;
        Mode mode = Mode.Add;
        int Id = 0;
        List<CategoryModel> categories;
        public AddEditProduct()
        {
            InitializeComponent();
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width / 2 - flowLayoutPanel1.Size.Width / 2, this.ClientSize.Height / 2 - flowLayoutPanel1.Size.Height / 2);
            //CategoryComboBox.SelectedIndex = 0;
            categories = DbRepository.GetCategoriesSorted();
            List<string> categoryNames = new List<string>();
            foreach (CategoryModel category in categories)
            {
                categoryNames.Add(category.CategoryName);
            }
            CategoryComboBox.Items.AddRange(categoryNames.ToArray());
            if (categoryNames.Count() > 0)
            {
                CategoryComboBox.SelectedIndex = 0;
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
                this.Text = "Add product";
                AddEditBtn.Text = "Add";
            }
            else if (mode == Mode.Edit)
            {
                this.Text = "Edit product";
                AddEditBtn.Text = "Edit";
            }
        }

        public void setId(int Id)
        {
            this.Id = Id;
        }

        public void setNameTextBox(string name)
        {
            this.NameTextBox.Text = name;
        }

        public void setCharacteristicsTextBox(string characteristics)
        {
            this.CharacteristicsTextBox.Text = characteristics;
        }

        public void setCategoryId(int Id)
        {
            int n = 0;
            foreach (CategoryModel category in categories)
            {
                if (category.Id == Id)
                {
                    break;
                }
                n++;
            }
            if (categories.Count() > 0)
            {
                CategoryComboBox.SelectedIndex = n;
            }
        }

        private void AddEditBtn_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Add)
            {
                List<ProductModel> products = DbRepository.GetProducts();
                ProductModel model = new ProductModel {
                    Id = products[products.Count()-1].Id + 1,
                    CategoryNumber = categories[CategoryComboBox.SelectedIndex].Id,
                    ProductName = NameTextBox.Text,
                    ProductCharacteristics = CharacteristicsTextBox.Text
                };
                DbRepository.AddProduct(model);
                main.ShowProducts();
                this.Close();
            }
            else if (mode == Mode.Edit)
            {
                ProductModel productModel = new ProductModel
                {
                    Id = this.Id,
                    CategoryNumber = categories[CategoryComboBox.SelectedIndex].Id,
                    ProductName = NameTextBox.Text,
                    ProductCharacteristics = CharacteristicsTextBox.Text
                };
                DbRepository.UpdateProduct(productModel);
                main.ShowProducts();
                this.Close();
            }
        }
    }
}
