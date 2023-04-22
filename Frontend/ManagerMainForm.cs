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
using Project_ZLAGODA.Frontend;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_ZLAGODA
{
    public partial class ManagerMainForm : Form, ShowForm
    {
        string[] tables = new string[] { "Працівники (за прізвищем)", "Касири (за прізвищем)", "Постійні клієнти (за прізвищем)", "Категорії (за назвою)", "Товари (за назвою)", "Товари у магазині (за кількістю)" };
        SearchForm searchForm = null;
        public string managerId { get; set; }
        public ManagerMainForm()
        {
            InitializeComponent();
            TableComboBox.Items.AddRange(tables);
            managerId = "1";
        }

        #region Show

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
                ShowCategoriesByName();
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

        public void ShowEployeesBySurname()
        {
        }

        public void ShowCashiersBySurname()
        {
        }

        public void ShowCustomersBySurname()
        {
        }

        public void ShowCategoriesByName()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Id"), new DataColumn("Name")};
            dataTable.Columns.AddRange(columns);
            List<CategoryModel> categories = DbRepository.GetCategoriesSorted();
            foreach (CategoryModel category in categories)
            {
                dataTable.Rows.Add(new Object[] { category.Id, category.CategoryName});
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowProductsByName()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Id"), new DataColumn("Category Id"), new DataColumn("Name"), new DataColumn("Characteristics") };
            dataTable.Columns.AddRange(columns);
            List<ProductModel> products = DbRepository.GetProductsSorted();
            foreach (ProductModel product in products)
            {
                dataTable.Rows.Add(new Object[] { product.Id, product.CategoryNumber, product.ProductName, product.ProductCharacteristics });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowStoreProductsByQuantity()
        {
        }

        #endregion


        #region Add
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TableComboBox.Text == tables[0])
            {
                AddEployee();
            }
            else if (TableComboBox.Text == tables[1])
            {
                AddCashier();
            }
            else if (TableComboBox.Text == tables[2])
            {
                AddCustomer();
            }
            else if (TableComboBox.Text == tables[3])
            {
                AddCategory();
            }
            else if (TableComboBox.Text == tables[4])
            {
                AddProduct();
            }
            else if (TableComboBox.Text == tables[5])
            {
                AddStoreProduct();
            }
        }

        private void AddEployee()
        {
            throw new NotImplementedException();
        }

        private void AddCashier()
        {
            throw new NotImplementedException();
        }

        private void AddCustomer()
        {
            throw new NotImplementedException();
        }

        private void AddCategory()
        {
            AddEditCategory addCategory = new AddEditCategory();
            addCategory.setMainForm(this);
            addCategory.setMode(Mode.Add);
            addCategory.Show();
        }
        private void AddProduct()
        {
            AddEditProduct addProduct = new AddEditProduct();
            addProduct.setMainForm(this);
            addProduct.setMode(Mode.Add);
            addProduct.Show();
        }

        private void AddStoreProduct()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Edit
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TableComboBox.Text == tables[0])
            {
                EditEployee();
            }
            else if (TableComboBox.Text == tables[1])
            {
                EditCashier();
            }
            else if (TableComboBox.Text == tables[2])
            {
                EditCustomer();
            }
            else if (TableComboBox.Text == tables[3])
            {
                EditCategory();
            }
            else if (TableComboBox.Text == tables[4])
            {
                EditProduct();
            }
            else if (TableComboBox.Text == tables[5])
            {
                EditStoreProduct();
            }
        }

        private void EditEployee()
        {
            throw new NotImplementedException();
        }

        private void EditCashier()
        {
            throw new NotImplementedException();
        }

        private void EditCustomer()
        {
            throw new NotImplementedException();
        }

        private void EditCategory()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                AddEditCategory editCategory = new AddEditCategory();
                editCategory.setMainForm(this);
                editCategory.setMode(Mode.Edit);
                editCategory.setId(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                editCategory.setNameTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][1].ToString());
                editCategory.Show();
            }
        }
        private void EditProduct()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                AddEditProduct editProduct = new AddEditProduct();
                editProduct.setMainForm(this);
                editProduct.setMode(Mode.Edit);
                editProduct.setId(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                editProduct.setCategoryId(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][1].ToString()));
                editProduct.setNameTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][2].ToString());
                editProduct.setCharacteristicsTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][3].ToString());
                editProduct.Show();
            }
        }

        private void EditStoreProduct()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (TableComboBox.Text == tables[0])
            {
                DeleteEployee();
            }
            else if (TableComboBox.Text == tables[1])
            {
                DeleteCashier();
            }
            else if (TableComboBox.Text == tables[2])
            {
                DeleteCustomer();
            }
            else if (TableComboBox.Text == tables[3])
            {
                DeleteCategory();
            }
            else if (TableComboBox.Text == tables[4])
            {
                DeleteProduct();
            }
            else if (TableComboBox.Text == tables[5])
            {
                DeleteStoreProduct();
            }
        }

        private void DeleteEployee()
        {
            throw new NotImplementedException();
        }

        private void DeleteCashier()
        {
            throw new NotImplementedException();
        }

        private void DeleteCustomer()
        {
            throw new NotImplementedException();
        }

        private void DeleteCategory()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                DbRepository.DeleteCategory(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                ShowCategoriesByName();
            }
        }
        private void DeleteProduct()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                DbRepository.DeleteProduct(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                ShowProductsByName();
            }
        }

        private void DeleteStoreProduct()
        {
            throw new NotImplementedException();
        }
        #endregion

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (searchForm == null || searchForm.IsDisposed)
            {
                searchForm = new SearchForm();
                searchForm.Show();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm form = new AuthorizationForm();
            form.ShowDialog();
            this.Close();
        }

        private void AboutMeBtn_Click(object sender, EventArgs e)
        {
            EmployeeModel employee = DbRepository.GetEmployeeById(managerId);
            if (employee == null)
            {
                MessageBox.Show("Unknown user", "Error");
                return;
            }
            MessageBox.Show("Id: " + employee.Id +
                "\nName: " + employee.Name +
                "\nSecond name: " + employee.Surname +
                "\nPatronymic: " + employee.Patronymic +
                "\nRole: " + employee.Role +
                "\nSalary: " + employee.Salary +
                "\nPhone: " + employee.Phone +
                "\nEmployment date: " + employee.DateOfEmployment +
                "\nBirth date: " + employee.DateOfBirth +
                "\nCity: " + employee.City +
                "\nAddress: " + employee.Street +
                "\nZip code: " + employee.Zip +
                "\nUsername: " + employee.Username, "Info");
        }
    }
}
