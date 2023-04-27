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
using Project_ZLAGODA.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_ZLAGODA
{
    public partial class ManagerMainForm : Form, ShowForm
    {
        string[] tables = new string[] { "Працівники (за прізвищем)", "Касири (за прізвищем)", "Постійні клієнти (за прізвищем)", "Категорії (за назвою)", "Товари (за назвою)", "Товари у магазині (за кількістю)", "Чеки", "Товари у магазині (за назвою)" };
        SearchForm searchForm = null;
        public int employeeId { get; set; }
        public bool isManager { get; set; }
        public ManagerMainForm()
        {
            InitializeComponent();
            TableComboBox.Items.AddRange(tables);
            employeeId = 1;
        }

        public ManagerMainForm(int employeeId, bool isManager)
        {
            InitializeComponent();
            //TableComboBox.Items.AddRange(tables);
            //employeeId = "1";
            this.employeeId = employeeId;
            this.isManager = isManager;
            if (isManager)
            {
                string[] table = new string[] { tables[0], tables[1], tables[2], tables[3], tables[4], tables[5], tables[6] };
                TableComboBox.Items.AddRange(table);
            }
            else
            {
                string[] table = new string[] { tables[4], tables[7], tables[2], tables[6] };
                TableComboBox.Items.AddRange(table);
            }
            hideAll();
        }

        #region Show

        private void showAll()
        {
            AddBtn.Show();
            EditBtn.Show();
            DeleteBtn.Show();
            ShowProductsBtn.Show();
        }

        private void hideAll()
        {
            AddBtn.Hide();
            EditBtn.Hide();
            DeleteBtn.Hide();
            ShowProductsBtn.Hide();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            showAll();
            if (TableComboBox.Text.Equals(tables[0]))
            {
                if (isManager)
                {
                    ShowProductsBtn.Hide();
                }
                else
                {
                    hideAll();
                }
                ShowEmployees();
            }
            else if (TableComboBox.Text.Equals(tables[1]))
            {
                if (isManager)
                {
                    ShowProductsBtn.Hide();
                }
                else
                {
                    hideAll();
                }
                ShowEmployees();
            }
            else if (TableComboBox.Text.Equals(tables[2]))
            {

                ShowProductsBtn.Hide();
                ShowCustomers();
            }
            else if (TableComboBox.Text.Equals(tables[3]))
            {
                if (isManager)
                {
                    ShowProductsBtn.Hide();
                }
                else
                {
                    hideAll();
                }
                ShowCategories();
            }
            else if (TableComboBox.Text.Equals(tables[4]))
            {
                if (isManager)
                {
                    ShowProductsBtn.Hide();
                }
                else
                {
                    hideAll();
                }
                ShowProducts();
            }
            else if (TableComboBox.Text.Equals(tables[5]))
            {
                if (isManager)
                {
                    ShowProductsBtn.Hide();
                }
                else
                {
                    hideAll();
                }
                ShowStoreProducts();
            }
            else if (TableComboBox.Text.Equals(tables[6]))
            {
                if (isManager)
                {
                    AddBtn.Hide();
                    EditBtn.Hide();
                }
                else
                {
                    EditBtn.Hide();
                    DeleteBtn.Hide();
                }
                ShowSaleChecks();
            }
            else if (TableComboBox.Text.Equals(tables[7]))
            {
                if (isManager)
                {
                    ShowProductsBtn.Hide();
                }
                else
                {
                    hideAll();
                }
                ShowStoreProducts();
            }
        }

        public void ShowEmployees()
        {
            if (TableComboBox.Text.Equals(tables[0]))
            {
                ShowEployeesBySurname();
            }
            else if (TableComboBox.Text.Equals(tables[1]))
            {
                ShowCashiersBySurname();
            }
        }

        public void ShowCustomers()
        {
            if (TableComboBox.Text.Equals(tables[2]))
            {
                ShowCustomersBySurname();
            }
        }

        public void ShowCategories()
        {
            if (TableComboBox.Text.Equals(tables[3]))
            {
                ShowCategoriesByName();
            }
        }

        public void ShowProducts()
        {
            if (TableComboBox.Text.Equals(tables[4]))
            {
                ShowProductsByName();
            }
        }

        public void ShowStoreProducts()
        {
            ViewModel.UpdateProducts();
            if (TableComboBox.Text.Equals(tables[5]))
            {
                ShowStoreProductsByQuantity();
            }
            else if (TableComboBox.Text.Equals(tables[7]))
            {
                ShowStoreProductsByName();
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
            DataColumn[] columns = { new DataColumn("Id"), new DataColumn("Category"), new DataColumn("Name"), new DataColumn("Characteristics") };
            dataTable.Columns.AddRange(columns);
            List<ProductModel> products = DbRepository.GetProductsSorted();
            foreach (ProductModel product in products)
            {
                CategoryModel category = DbRepository.GetCategoryById(product.CategoryNumber);
                dataTable.Rows.Add(new Object[] { product.Id, category.CategoryName, product.ProductName, product.ProductCharacteristics });
            }
            //PersonList.ItemsSource = ViewModel.Persons;PersonList.Items.Refresh();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowStoreProductsByQuantity()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product name"), new DataColumn("Price"), new DataColumn("Type"), new DataColumn("Quantity"), new DataColumn("Expiry Date") };
            dataTable.Columns.AddRange(columns);
            List<StoreProductModel> products = DbRepository.GetStoreProductsSortedByQuantity();
            foreach (StoreProductModel product in products)
            {
                ProductModel p = DbRepository.GetProductById(product.ProductId);
                dataTable.Rows.Add(new Object[] { product.UPC, p.ProductName, product.Price, product.IsPromotion ? "Promotional" : "Ordiry", product.Quantity, product.ExpiryDate });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowStoreProductsByName()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product name"), new DataColumn("Price"), new DataColumn("Type"), new DataColumn("Quantity"), new DataColumn("Expiry Date") };
            dataTable.Columns.AddRange(columns);
            List<StoreProductModel> products = DbRepository.GetStoreProductsSortedByName();
            foreach (StoreProductModel product in products)
            {
                ProductModel p = DbRepository.GetProductById(product.ProductId);
                dataTable.Rows.Add(new Object[] { product.UPC, p.ProductName, product.Price, product.IsPromotion ? "Promotional" : "Ordiry", product.Quantity, product.ExpiryDate });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowSaleChecks()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Check number"), new DataColumn("Cashier"), new DataColumn("Card number"), new DataColumn("Print date"), new DataColumn("Total"), new DataColumn("VAT") };
            dataTable.Columns.AddRange(columns);
            List<SaleCheckModel> checks;
            if (isManager)
            {
                checks = DbRepository.GetSaleChecks();
            }
            else
            {
                checks = DbRepository.GetSaleChecksByEmployeeId(employeeId.ToString());
            }
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
            addCheck.setEmployee(this.employeeId);
            addCheck.Show();
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
            else if (TableComboBox.Text == tables[7])
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
                editEmployee.setPasswordHash(DbRepository.GetEmployeeById(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString())).PasswordHash);
                editEmployee.setSalt(DbRepository.GetEmployeeById(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString())).Salt);
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
                ProductModel model = DbRepository.GetProductById(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                editProduct.setMainForm(this);
                editProduct.setMode(Mode.Edit);
                editProduct.setId(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                editProduct.setCategoryId(model.CategoryNumber);
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
                StoreProductModel model = DbRepository.GetStoreProductById(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                editStoreProduct.setMainForm(this);
                editStoreProduct.setMode(Mode.Edit);
                editStoreProduct.setUPCTextBox(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                editStoreProduct.setProductId(model.ProductId);
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
            else if (TableComboBox.Text == tables[6])
            {
                DeleteSaleCheck();
            }
            else if (TableComboBox.Text == tables[7])
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

        private void DeleteSaleCheck()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                DbRepository.DeleteSaleCheck(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                ShowSaleChecks();
            }
        }

        #endregion

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (searchForm == null || searchForm.IsDisposed)
            {
                searchForm = new SearchForm(employeeId, isManager);
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
            EmployeeModel employee = DbRepository.GetEmployeeById(employeeId);
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
                    CheckInfoForm checkInfo = new CheckInfoForm(DbRepository.GetSaleCheckById(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));
                    checkInfo.Show();
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                new PrintResultForm(dataGridView1).Show();
            }
        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBtn_Click(sender, e);
        }

        private void buttonQuery1_Click(object sender, EventArgs e)
        {
            DbRepository.Query1();
        }

        private void buttonQuery2_Click(object sender, EventArgs e)
        {
            DbRepository.Query2();
        }
    }
}
