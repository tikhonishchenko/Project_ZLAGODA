using Microsoft.VisualBasic.Logging;
using Project_ZLAGODA.Backend.Database;
using Project_ZLAGODA.Backend.Models;
using Project_ZLAGODA.ViewModels;

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
            /*List<ProductModel> products = DbRepository.GetProducts();
            ProductsTextBox.Text = "";
            //DbRepository.GetEmployee("kovalenko_mariia", "12345");
            foreach (ProductModel product in products)
            {
                ProductsTextBox.Text += product.ToString() + Environment.NewLine;
            }
            */
            ViewModels.ViewModel.ResetPromotion();
            List<StoreProductModel> storeProducts = DbRepository.GetStoreProducts();
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
                ViewModel.currentEmployee = employee;
            }
            else
            {
                MessageBox.Show("Wrong login or password");
            }
        }

        private void BtnGetProductsSorted_Click(object sender, EventArgs e)
        {
            ViewModels.ViewModel.UpdateProducts();
            List<StoreProductModel> storeProducts = DbRepository.GetStoreProducts();
            ProductsTextBox.Text = "";
            foreach (StoreProductModel storeProduct in storeProducts)
            {
                ProductsTextBox.Text += storeProduct.ToString() + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewModel.TestRepository();
        }

        private void button3_Click(object sender, EventArgs e)

        {
            string UPC = textBox6.Text;
            int quantity = int.Parse(textBox4.Text);
            if (ViewModel.SaleIsLegal(UPC, quantity))
            {
                ViewModel.AddItem(new SaleModel
                {
                    UPC = UPC,
                    CheckNumber = 0,
                    ProductNumber = DbRepository.GetStoreProductProductId(UPC),
                    Quantity = quantity,
                    Price = DbRepository.GetStoreProductPrice(UPC)
                });
            }
            else
            {
                MessageBox.Show("Not enough products in store");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewModel.GenerateCheck();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeModel employee = DbRepository.GetEmployee("kovalchuk_olena", "12345");
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
                ViewModel.currentEmployee = employee;
            }
            else
            {
                MessageBox.Show("Wrong login or password");
            }
        }
    }
}