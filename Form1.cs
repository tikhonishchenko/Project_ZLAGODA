using Project_ZLAGODA.Backend.Database;
using Project_ZLAGODA.Backend.Models;

namespace Project_ZLAGODA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetProductsBtn_Click(object sender, EventArgs e)
        {
            List<ProductModel> products = DbRepository.GetProducts();
            ProductsTextBox.Text = "";

            foreach (ProductModel product in products)
            {
                ProductsTextBox.Text += product.ToString() + Environment.NewLine;
            }
        }

        private void AddSamplesBtn_Click(object sender, EventArgs e)
        {
            DbRepository.AddSampleProducts();
            List<ProductModel> products = DbRepository.GetProducts();
            ProductsTextBox.Text = "";
            foreach (ProductModel product in products)
            {
                ProductsTextBox.Text += product.ToString() + Environment.NewLine;
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            ProductModel productModel = new ProductModel
            {
                Id = int.Parse(idTextBox.Text),
                CategoryNumber = int.Parse(CatTextBox.Text),
                ProductName = NameTextBox.Text,
                ProductCharacteristics = DescTextBox.Text
            };

            DbRepository.AddProduct(productModel);
        }



        private void UpdateProductsBtn_Click(object sender, EventArgs e)
        {
            ProductModel productModel = new ProductModel
            {
                Id = int.Parse(idTextBox.Text),
                CategoryNumber = int.Parse(CatTextBox.Text),
                ProductName = NameTextBox.Text,
                ProductCharacteristics = DescTextBox.Text
            };

            DbRepository.UpdateProduct(productModel);
        }

        private void DeleteProductsBtn_Click(object sender, EventArgs e)
        {
            DbRepository.DeleteProduct(int.Parse(idTextBox.Text));

        }
    }
}