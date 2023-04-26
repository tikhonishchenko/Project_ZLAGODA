﻿using System;
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
        string[] tables = new string[] { "Працівники (за прізвищем)", "Касири (за прізвищем)", "Постійні клієнти (за прізвищем)", "Категорії (за назвою)", "Товари (за назвою)", "Товари у магазині (за кількістю)", "Чеки" };
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
                ShowEmployees();
            }
            else if (TableComboBox.Text == tables[1])
            {
                ShowEmployees();
            }
            else if (TableComboBox.Text == tables[2])
            {
                ShowCustomers();
            }
            else if (TableComboBox.Text == tables[3])
            {
                ShowCategories();
            }
            else if (TableComboBox.Text == tables[4])
            {
                ShowProducts();
            }
            else if (TableComboBox.Text == tables[5])
            {
                ShowStoreProducts();
            }
            else if (TableComboBox.Text.Equals(tables[6]))
            {
                ShowSaleChecks();
            }
        }

        public void ShowEmployees()
        {
            if (TableComboBox.Text == tables[0])
            {
                ShowEployeesBySurname();
            }
            else if (TableComboBox.Text == tables[1])
            {
                ShowCashiersBySurname();
            }
        }

        public void ShowCustomers()
        {
            if (TableComboBox.Text == tables[2])
            {
                ShowCustomersBySurname();
            }
        }

        public void ShowCategories()
        {
            if (TableComboBox.Text == tables[3])
            {
                ShowCategoriesByName();
            }
        }

        public void ShowProducts()
        {
            if (TableComboBox.Text == tables[4])
            {
                ShowProductsByName();
            }
        }

        public void ShowStoreProducts()
        {
            if (TableComboBox.Text == tables[5])
            {
                ShowStoreProductsByQuantity();
            }
        }

        public void ShowEployeesBySurname()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Id"), new DataColumn("First name"), new DataColumn("Second name"), new DataColumn("Patronymic"), new DataColumn("Role"), new DataColumn("Phone number"), new DataColumn("Salary"), new DataColumn("Employment date"), new DataColumn("Birth date"), new DataColumn("Address"), new DataColumn("City"), new DataColumn("Zip code"), new DataColumn("Username") };
            dataTable.Columns.AddRange(columns);
            List<EmployeeModel> employees = DbRepository.GetEmployeesSortedBySurname();
            foreach (EmployeeModel employee in employees)
            {
                dataTable.Rows.Add(new Object[] { employee.Id, employee.Name, employee.Surname, employee.Patronymic, employee.Role, employee.Phone, employee.Salary, employee.DateOfEmployment, employee.DateOfBirth, employee.Street, employee.City, employee.Zip, employee.Username });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowCashiersBySurname()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Id"), new DataColumn("First name"), new DataColumn("Second name"), new DataColumn("Patronymic"), new DataColumn("Role"), new DataColumn("Phone number"), new DataColumn("Salary"), new DataColumn("Employment date"), new DataColumn("Birth date"), new DataColumn("Address"), new DataColumn("City"), new DataColumn("Zip code"), new DataColumn("Username") };
            dataTable.Columns.AddRange(columns);
            List<EmployeeModel> employees = DbRepository.GetEmployeesCashiersSortedBySurname();
            foreach (EmployeeModel employee in employees)
            {
                dataTable.Rows.Add(new Object[] { employee.Id, employee.Name, employee.Surname, employee.Patronymic, employee.Role, employee.Phone, employee.Salary, employee.DateOfEmployment, employee.DateOfBirth, employee.Street, employee.City, employee.Zip, employee.Username });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowCustomersBySurname()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Card number"), new DataColumn("First name"), new DataColumn("Second name"), new DataColumn("Patronymic"), new DataColumn("Phone number"), new DataColumn("Address"), new DataColumn("City"), new DataColumn("Zip code"), new DataColumn("Discount") };
            dataTable.Columns.AddRange(columns);
            List<CustomerModel> customers = DbRepository.GetCustomersSorted();
            foreach (CustomerModel customer in customers)
            {
                dataTable.Rows.Add(new Object[] { customer.CardNumber, customer.Name, customer.LastName, customer.Patronymic, customer.PhoneNumber, customer.Street, customer.City, customer.ZipCode, customer.Percent });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowCategoriesByName()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Id"), new DataColumn("Name") };
            dataTable.Columns.AddRange(columns);
            List<CategoryModel> categories = DbRepository.GetCategoriesSorted();
            foreach (CategoryModel category in categories)
            {
                dataTable.Rows.Add(new Object[] { category.Id, category.CategoryName });
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
            //PersonList.ItemsSource = ViewModel.Persons;PersonList.Items.Refresh();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowStoreProductsByQuantity()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product Id"), new DataColumn("Price"), new DataColumn("Type"), new DataColumn("Quantity"), new DataColumn("Expiry Date") };
            dataTable.Columns.AddRange(columns);
            List<StoreProductModel> products = DbRepository.GetStoreProductsSortedByQuantity();
            foreach (StoreProductModel product in products)
            {
                dataTable.Rows.Add(new Object[] { product.UPC, product.ProductId, product.Price, product.IsPromotion ? "Promotional" : "Ordiry", product.Quantity, product.ExpiryDate });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowSaleChecks()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Check number"), new DataColumn("Cashier"), new DataColumn("Card number"), new DataColumn("Print date"), new DataColumn("Total"), new DataColumn("VAT") };
            dataTable.Columns.AddRange(columns);
            List<SaleCheckModel> checks = DbRepository.GetSaleChecks();
            foreach (SaleCheckModel check in checks)
            {
                EmployeeModel employee = DbRepository.GetEmployeeById(check.EmployeeId);
                dataTable.Rows.Add(new Object[] { check.CheckNumber, employee.Surname + " " + employee.Name + " " + employee.Patronymic, check.CardNumber, check.PrintDate.ToString(), check.SumTotal, check.VAT });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
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
            else if (TableComboBox.Text.Equals(tables[6]))
            {
                AddSaleChecks();
            }
        }

        private void AddEployee()
        {
            AddEditEmployee addEmployee = new AddEditEmployee();
            addEmployee.setMainForm(this);
            addEmployee.setMode(Mode.Add);
            addEmployee.Show();
        }

        private void AddCashier()
        {
            AddEditEmployee addEmployee = new AddEditEmployee();
            addEmployee.setMainForm(this);
            addEmployee.setMode(Mode.Add);
            addEmployee.setRoleComboBox("Cashier");
            addEmployee.Show();
        }

        private void AddCustomer()
        {
            AddEditCustomer addCustomer = new AddEditCustomer();
            addCustomer.setMainForm(this);
            addCustomer.setMode(Mode.Add);
            addCustomer.Show();
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
            AddEditStoreProduct addStoreProduct = new AddEditStoreProduct();
            addStoreProduct.setMainForm(this);
            addStoreProduct.setMode(Mode.Add);
            addStoreProduct.Show();
        }

        private void AddSaleChecks()
        {
            AddSaleCheckForm addCheck = new AddSaleCheckForm();
            addCheck.setEmployee(int.Parse(this.managerId));
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
                EditEployee();
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
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                AddEditEmployee editEmployee = new AddEditEmployee();
                editEmployee.setMainForm(this);
                editEmployee.setMode(Mode.Edit);
                editEmployee.setId(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                editEmployee.setFirstNameTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][1].ToString());
                editEmployee.setSecondNameTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][2].ToString());
                editEmployee.setPatronymicTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][3].ToString());
                editEmployee.setRoleComboBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][4].ToString());
                editEmployee.setPhoneNumberTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][5].ToString());
                editEmployee.setSalaryTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][6].ToString());
                editEmployee.setEmploymentDateTextBox(DateTime.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][7].ToString()));
                editEmployee.setBirthDateTextBox(DateTime.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][8].ToString()));
                editEmployee.setAddressTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][9].ToString());
                editEmployee.setCityTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][10].ToString());
                editEmployee.setZipCodeTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][11].ToString());
                editEmployee.setUsernameTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][12].ToString());
                editEmployee.setPasswordHash(DbRepository.GetEmployeeById(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()).PasswordHash);
                editEmployee.setSalt(DbRepository.GetEmployeeById(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()).Salt);
                editEmployee.Show();
            }
        }

        private void EditCustomer()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                AddEditCustomer editCustomer = new AddEditCustomer();
                editCustomer.setMainForm(this);
                editCustomer.setMode(Mode.Edit);
                editCustomer.setCardNumberTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                editCustomer.setFirstNameTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][1].ToString());
                editCustomer.setSecondNameTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][2].ToString());
                editCustomer.setPatronymicTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][3].ToString());
                editCustomer.setPhoneNumberTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][4].ToString());
                editCustomer.setAddressTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][5].ToString());
                editCustomer.setCityTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][6].ToString());
                editCustomer.setZipCodeTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][7].ToString());
                editCustomer.setDiscountTextBox(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][8].ToString()));
                editCustomer.Show();
            }
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
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                AddEditStoreProduct editStoreProduct = new AddEditStoreProduct();
                editStoreProduct.setMainForm(this);
                editStoreProduct.setMode(Mode.Edit);
                editStoreProduct.setUPCTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                editStoreProduct.setProductId(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][1].ToString()));
                editStoreProduct.setPriceTextBox(decimal.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][2].ToString()));
                editStoreProduct.setPromotional(dataTable.Rows[dataGridView1.SelectedRows[0].Index][3].ToString() == "Promotional" ? true : false);
                editStoreProduct.setQuantityTextBox(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][4].ToString()));
                editStoreProduct.setExpiryDate(DateTime.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][5].ToString()));
                editStoreProduct.Show();
            }
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
                DeleteEployee();
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
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                DbRepository.DeleteEmployee(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                ShowEmployees();
            }
        }

        private void DeleteCustomer()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                DbRepository.DeleteCustomer(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                ShowCustomers();
            }
        }

        private void DeleteCategory()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                DbRepository.DeleteCategory(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                ShowCategories();
            }
        }
        private void DeleteProduct()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                DbRepository.DeleteProduct(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                ShowProducts();
            }
        }

        private void DeleteStoreProduct()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                DbRepository.DeleteStoreProduct(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                ShowStoreProducts();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (TableComboBox.Text.Equals(tables[6]))
            {
                Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                DataTable dataTable = dataGridView1.DataSource as DataTable;
                if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
                {
                    CheckInfoForm checkInfo = new CheckInfoForm(DbRepository.GetSaleChecks()[dataGridView1.SelectedRows[0].Index]);
                    checkInfo.Show();
                }
            }
        }
    }
}