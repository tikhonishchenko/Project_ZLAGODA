using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_ZLAGODA.Backend.Database;
using Project_ZLAGODA.Backend.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_ZLAGODA
{
    public partial class Form3 : Form
    {
        string[] tables = new string[] { "Працівники (за прізвищем)", "Касири (за прізвищем)", "Постійні клієнти (за прізвищем)", "Категорії (за назвою)", "Товари (за назвою)", "Товари у магазині (за кількістю)" };
        public Form3()
        {
            InitializeComponent();
            TableComboBox.Items.AddRange(tables);
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if (TableComboBox.Text == tables[0])
            {
                ShowEployeesBySurname();
            }
            else if (TableComboBox.Text == tables[1])
            {
                ShowCashiersBySurname();
            }
            else if (TableComboBox.Text == tables[2])
            {
                ShowCustomersBySurname();
            }
            else if (TableComboBox.Text == tables[3])
            {
                ShowCategoriesBySurname();
            }
            else if (TableComboBox.Text == tables[4])
            {
                ShowProductsByName();
            }
            else if (TableComboBox.Text == tables[5])
            {
                ShowStoreProductsByQuantity();
            }
        }

        private void ShowEployeesBySurname()
        {
        }

        private void ShowCashiersBySurname()
        {
        }

        private void ShowCustomersBySurname()
        {
        }

        private void ShowCategoriesBySurname()
        {


        }

        public void ShowProductsByName()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Id"), new DataColumn("Category Id"), new DataColumn("Name"), new DataColumn("Characteristics") };
            dataTable.Columns.AddRange(columns);
            List<ProductModel> products = DbRepository.GetProducts();
            foreach (ProductModel product in products)
            {
                dataTable.Rows.Add(new Object[] { product.Id, product.CategoryNumber, product.ProductName, product.ProductCharacteristics });
            }
            dataGridView1.DataSource = dataTable;
        }

        private void ShowStoreProductsByQuantity()
        {
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TableComboBox.Text == tables[4])
            {
                AddProduct addProduct = new AddProduct();
                addProduct.Text = "Add Product";
                addProduct.setMainForm(this);
                addProduct.Show();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TableComboBox.Text == tables[4])
            {
                Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                DataTable dataTable = dataGridView1.DataSource as DataTable;
                if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
                {
                    //System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    //for (int i = 0; i < selectedRowCount; i++)
                    //{
                    //    sb.Append("Row: ");
                    //    sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    //    sb.Append(Environment.NewLine);
                    //}

                    //sb.Append("Total: " + selectedRowCount.ToString());
                    //DataTable dataTable = dataGridView1.DataSource as DataTable;
                    //MessageBox.Show(sb.ToString(), "Selected Rows");
                    //dataTable.Rows[dataGridView1.SelectedRows[i].Index][0];

                    EditProduct editProduct = new EditProduct();
                    editProduct.Text = "Edit Product";
                    editProduct.setMainForm(this);
                    editProduct.setIdTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                    editProduct.setCategoryIdTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][1].ToString());
                    editProduct.setNameTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][2].ToString());
                    editProduct.setCharacteristicsTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][3].ToString());
                    editProduct.Show();

                    //addProduct.
                    //MessageBox.Show(dataTable.Rows[dataGridView1.SelectedRows[i].Index][0].ToString(), "Selected Rows");
                    //Console.WriteLine();
                    //dataTable.Rows[3].ToString;
                }
                //AddProduct addProduct = new AddProduct();
                //addProduct.Text = "Edit Product";
                //addProduct.setMainForm(this);
                //addProduct.Show();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (TableComboBox.Text == tables[4])
            {
                Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                DataTable dataTable = dataGridView1.DataSource as DataTable;
                if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
                {
                    DbRepository.DeleteProduct(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                    ShowProductsByName();
                }
            }
        }
    }
}
