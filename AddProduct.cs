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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_ZLAGODA
{
    public partial class AddProduct : Form
    {
        Form3 main;
        public AddProduct()
        {
            InitializeComponent();
            this.main = null;
        }

        public void setMainForm(Form3 main)
        {
            this.main = main;
        }

        public void setIdTextBox(string id)
        {
            this.IdTextBox.Text = id;
        }

        public void setCategoryIdTextBox(string id)
        {
            this.CategoryIdTextBox.Text = id;
        }

        public void setNameTextBox(string name)
        {
            this.NameTextBox.Text = name;
        }

        public void setCharacteristicsTextBox(string characteristics)
        {
            this.CharacteristicsTextBox.Text = characteristics;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ProductModel productModel = new ProductModel
            {
                Id = int.Parse(IdTextBox.Text),
                CategoryNumber = int.Parse(CategoryIdTextBox.Text),
                ProductName = NameTextBox.Text,
                ProductCharacteristics = CharacteristicsTextBox.Text
            };
            DbRepository.AddProduct(productModel);
            main.ShowProductsByName();
            this.Close();
        }
    }
}
