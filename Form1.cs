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
            /*
            List<ProductModel> products = DbRepository.GetProducts();
            ProductsTextBox.Text = "";
            //DbRepository.GetEmployee("kovalenko_mariia", "12345");
            foreach (ProductModel product in products)
            {
                ProductsTextBox.Text += product.ToString() + Environment.NewLine;
            }
            */
            List<StoreProductModel> storeProducts = DbRepository.GetStoreProductsToDate(new DateTime(2023,4,20));
            ProductsTextBox.Text = "";
            foreach (StoreProductModel storeProduct in storeProducts)
            {
                ProductsTextBox.Text += storeProduct.ToString() + Environment.NewLine;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            EmployeeModel employee = DbRepository.GetEmployee(login, password);
            if (employee != null)
            {
                if (employee.Role == "Manager")
                {
                    MessageBox.Show("Manager");
                }
                else if (employee.Role == "Cashier")
                {
                    MessageBox.Show("Cashier");
                }               
            }
            else
            {
                MessageBox.Show("Wrong login or password");
            }
        }

        private void BtnGetProductsSorted_Click(object sender, EventArgs e)
        {
            ProductsTextBox.Text = "";
            foreach(ProductModel product in DbRepository.GetProductsSorted())
            {
                ProductsTextBox.Text += product.ToString() + Environment.NewLine;
            }
        }
    }
}