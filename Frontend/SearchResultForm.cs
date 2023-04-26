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
using System.Transactions;
using System.Windows.Forms;

namespace Project_ZLAGODA.Frontend
{
    public partial class SearchResultForm : Form, ShowForm
    {
        Query query;
        public string Surname { get; set; }
        public string ProductName { get; set; }
        public int CashierId { get; set; }
        public int quantity { get; set; }
        public int discount { get; set; }
        public string upc { get; set; }
        public int categotyId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }

        public bool isManager { get; set; }
        public SearchResultForm()
        {
            InitializeComponent();
            isManager = true;
        }

        public SearchResultForm(Query query)
        {
            InitializeComponent();
            this.query = query;
        }

        public void Show()
        {
            base.Show();
            ShowProductsBtn.Hide();
            if (!isManager)
            {
                EditBtn.Hide();
                DeleteBtn.Hide();
            }
            switch (query)
            {
                case Query.PhoneAddressEmployeeBySurname:
                    ShowEmployees();
                    break;
                case Query.CustomersByDiscountSortedSurname:
                    ShowCustomers();
                    break;
                case Query.ProductByCategorySortedName:
                    ShowProducts();
                    break;
                case Query.StoreProductByUPC:
                    ShowStoreProducts();
                    break;
                case Query.PromotionalStoreProductSortedQuantity:
                    ShowStoreProducts();
                    break;
                case Query.PromotionalStoreProductSortedName:
                    ShowStoreProducts();
                    break;
                case Query.OrdinaryStoreProductSortedQuantity:
                    ShowStoreProducts();
                    break;
                case Query.OrdinaryStoreProductSortedName:
                    ShowStoreProducts();
                    break;
                case Query.SaleCheckByCashierByPeriod:
                    ShowSaleChecks();
                    ShowProductsBtn.Show();
                    break;
                case Query.SaleCheckByPeriod:
                    ShowSaleChecks();
                    ShowProductsBtn.Show();
                    break;
                case Query.ProductsByName:
                    ShowStoreProducts();
                    break;
                case Query.CustomersBySurname:
                    ShowCustomers();
                    break;
                case Query.SaleCheckByCashierToday:
                    ShowProductsBtn.Show();
                    ShowSaleChecks();
                    break;
                default:
                    break;
            }
        }

        #region Show

        public void ShowEmployees()
        {
            switch (query)
            {
                case Query.PhoneAddressEmployeeBySurname:
                    ShowPhoneAddressEmployeeBySurname();
                    break;
                default:
                    break;
            }
        }

        public void ShowPhoneAddressEmployeeBySurname()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Id"), new DataColumn("First name"), new DataColumn("Second name"), new DataColumn("Patronymic"), new DataColumn("Phone number"), new DataColumn("Address"), new DataColumn("City") };
            dataTable.Columns.AddRange(columns);
            List<EmployeeModel> employees = DbRepository.GetEmployeeDataBySurname(Surname);
            foreach (EmployeeModel employee in employees)
            {
                dataTable.Rows.Add(new Object[] { employee.Id, employee.Name, employee.Surname, employee.Patronymic, employee.Phone, employee.Street, employee.City });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowCustomers()
        {
            EditBtn.Show();
            DeleteBtn.Show();
            switch (query)
            {
                case Query.CustomersByDiscountSortedSurname:
                    ShowCustomersByDiscountSortedSurname();
                    break;
                case Query.CustomersBySurname:
                    ShowCustomersBySurname();
                    break;
                default:
                    break;
            }
        }

        public void ShowCustomersByDiscountSortedSurname()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Card number"), new DataColumn("First name"), new DataColumn("Second name"), new DataColumn("Patronymic"), new DataColumn("Phone number"), new DataColumn("Address"), new DataColumn("City"), new DataColumn("Zip code"), new DataColumn("Discount") };
            dataTable.Columns.AddRange(columns);
            List<CustomerModel> customers = DbRepository.GetCustomersWithPercentSortedBySurname(discount);
            foreach (CustomerModel customer in customers)
            {
                dataTable.Rows.Add(new Object[] { customer.CardNumber, customer.Name, customer.LastName, customer.Patronymic, customer.PhoneNumber, customer.Street, customer.City, customer.ZipCode, customer.Percent });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowCustomersBySurname()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Card number"), new DataColumn("First name"), new DataColumn("Second name"), new DataColumn("Patronymic"), new DataColumn("Phone number"), new DataColumn("Address"), new DataColumn("City"), new DataColumn("Zip code"), new DataColumn("Discount") };
            dataTable.Columns.AddRange(columns);
            List<CustomerModel> customers = DbRepository.GetCustomersBySurname(Surname);
            foreach (CustomerModel customer in customers)
            {
                dataTable.Rows.Add(new Object[] { customer.CardNumber, customer.Name, customer.LastName, customer.Patronymic, customer.PhoneNumber, customer.Street, customer.City, customer.ZipCode, customer.Percent });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowCategories() { }

        public void ShowProducts()
        {
            switch (query)
            {
                case Query.ProductByCategorySortedName:
                    ShowProductByCategorySortedName();
                    break;
                default:
                    break;
            }
        }

        public void ShowProductByCategorySortedName()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Id"), new DataColumn("Category"), new DataColumn("Name"), new DataColumn("Characteristics") };
            dataTable.Columns.AddRange(columns);
            List<ProductModel> products = DbRepository.GetProductsByCategory(DbRepository.GetCategoryById(categotyId).CategoryName);
            foreach (ProductModel product in products)
            {
                CategoryModel categoryModel = DbRepository.GetCategoryById(product.CategoryNumber);
                dataTable.Rows.Add(new Object[] { product.Id, categoryModel.CategoryName, product.ProductName, product.ProductCharacteristics });
            }
            //PersonList.ItemsSource = ViewModel.Persons;PersonList.Items.Refresh();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowStoreProducts()
        {
            switch (query)
            {
                case Query.StoreProductByUPC:
                    ShowStoreProductByUPC();
                    break;
                case Query.PromotionalStoreProductSortedQuantity:
                    ShowPromotionalStoreProductSortedQuantity();
                    break;
                case Query.PromotionalStoreProductSortedName:
                    ShowPromotionalStoreProductSortedName();
                    break;
                case Query.OrdinaryStoreProductSortedQuantity:
                    ShowOrdinaryStoreProductSortedQuantity();
                    break;
                case Query.OrdinaryStoreProductSortedName:
                    ShowOrdinaryStoreProductSortedName();
                    break;
                case Query.ProductsByName:
                    ShowStoreProductsByName();
                    break;
                default:
                    break;
            }
        }

        public void ShowStoreProductByUPC()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product"), new DataColumn("Price"), new DataColumn("Type"), new DataColumn("Quantity"), new DataColumn("Expiry Date") };
            dataTable.Columns.AddRange(columns);
            StoreProductModel product = DbRepository.GetStoreProductById(upc);
            if (product == null)
            {
                MessageBox.Show("No such product!", "Error");
                this.Close();
            }
            ProductModel p = DbRepository.GetProductById(product.ProductId);
            dataTable.Rows.Add(new Object[] { product.UPC, p.ProductName, product.Price, product.IsPromotion ? "Promotional" : "Ordiry", product.Quantity, product.ExpiryDate });
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowPromotionalStoreProductSortedQuantity()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product"), new DataColumn("Price"), new DataColumn("Type"), new DataColumn("Quantity"), new DataColumn("Expiry Date") };
            dataTable.Columns.AddRange(columns);
            List<StoreProductModel> products = DbRepository.GetStoreProductsDiscountSortedByQuantity();
            foreach (StoreProductModel product in products)
            {
                ProductModel p = DbRepository.GetProductById(product.ProductId);
                dataTable.Rows.Add(new Object[] { product.UPC, p.ProductName, product.Price, product.IsPromotion ? "Promotional" : "Ordiry", product.Quantity, product.ExpiryDate });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowPromotionalStoreProductSortedName()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product"), new DataColumn("Price"), new DataColumn("Type"), new DataColumn("Quantity"), new DataColumn("Expiry Date") };
            dataTable.Columns.AddRange(columns);
            List<StoreProductModel> products = DbRepository.GetStoreProductsDiscountSortedByName();
            foreach (StoreProductModel product in products)
            {
                ProductModel p = DbRepository.GetProductById(product.ProductId);
                dataTable.Rows.Add(new Object[] { product.UPC, p.ProductName, product.Price, product.IsPromotion ? "Promotional" : "Ordiry", product.Quantity, product.ExpiryDate });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowOrdinaryStoreProductSortedQuantity()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product"), new DataColumn("Price"), new DataColumn("Type"), new DataColumn("Quantity"), new DataColumn("Expiry Date") };
            dataTable.Columns.AddRange(columns);
            List<StoreProductModel> products = DbRepository.GetStoreProductsNotDiscountSortedByQuantity();
            foreach (StoreProductModel product in products)
            {
                ProductModel p = DbRepository.GetProductById(product.ProductId);
                dataTable.Rows.Add(new Object[] { product.UPC, p.ProductName, product.Price, product.IsPromotion ? "Promotional" : "Ordiry", product.Quantity, product.ExpiryDate });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowOrdinaryStoreProductSortedName()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product"), new DataColumn("Price"), new DataColumn("Type"), new DataColumn("Quantity"), new DataColumn("Expiry Date") };
            dataTable.Columns.AddRange(columns);
            List<StoreProductModel> products = DbRepository.GetStoreProductsNotDiscountSortedByName();
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
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product"), new DataColumn("Price"), new DataColumn("Type"), new DataColumn("Quantity"), new DataColumn("Expiry Date") };
            dataTable.Columns.AddRange(columns);
            List<StoreProductModel> products = DbRepository.GetStoreProductsByProductName(ProductName);
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
            switch (query)
            {
                case Query.SaleCheckByCashierByPeriod:
                    ShowSaleCheckByCashierByPeriod();
                    break;
                case Query.SaleCheckByPeriod:
                    ShowSaleCheckByPeriod();
                    break;
                case Query.SaleCheckByCashierToday:
                    ShowSaleCheckByCashierToday();
                    break;
                default:
                    break;
            }
        }

        private void ShowSaleCheckByCashierByPeriod()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Check number"), new DataColumn("Cashier"), new DataColumn("Card number"), new DataColumn("Print date"), new DataColumn("Total"), new DataColumn("VAT") };
            dataTable.Columns.AddRange(columns);
            List<SaleCheckModel> checks = DbRepository.GetSaleChecksByEmployeeIdAndDates(CashierId.ToString(), startTime, endTime);
            foreach (SaleCheckModel check in checks)
            {
                EmployeeModel employee = DbRepository.GetEmployeeById(check.EmployeeId);
                dataTable.Rows.Add(new Object[] { check.CheckNumber, employee.Surname + " " + employee.Name + " " + employee.Patronymic, check.CardNumber, check.PrintDate.ToString(), check.SumTotal, check.VAT });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void ShowSaleCheckByPeriod()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Check number"), new DataColumn("Cashier"), new DataColumn("Card number"), new DataColumn("Print date"), new DataColumn("Total"), new DataColumn("VAT") };
            dataTable.Columns.AddRange(columns);
            List<SaleCheckModel> checks = DbRepository.GetSaleChecksByDates(startTime, endTime);
            foreach (SaleCheckModel check in checks)
            {
                EmployeeModel employee = DbRepository.GetEmployeeById(check.EmployeeId);
                dataTable.Rows.Add(new Object[] { check.CheckNumber, employee.Surname + " " + employee.Name + " " + employee.Patronymic, check.CardNumber, check.PrintDate.ToString(), check.SumTotal, check.VAT });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void ShowSaleCheckByCashierToday()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Check number"), new DataColumn("Cashier"), new DataColumn("Card number"), new DataColumn("Print date"), new DataColumn("Total"), new DataColumn("VAT") };
            dataTable.Columns.AddRange(columns);
            List<SaleCheckModel> checks = DbRepository.GetSaleChecksByEmployeeIdToday(CashierId.ToString());
            foreach (SaleCheckModel check in checks)
            {
                EmployeeModel employee = DbRepository.GetEmployeeById(check.EmployeeId);
                dataTable.Rows.Add(new Object[] { check.CheckNumber, employee.Surname + " " + employee.Name + " " + employee.Patronymic, check.CardNumber, check.PrintDate.ToString(), check.SumTotal, check.VAT });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        #endregion



        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            switch (query)
            {
                case Query.PhoneAddressEmployeeBySurname:
                    EditEmployee();
                    break;
                case Query.CustomersByDiscountSortedSurname:
                    EditCustomer();
                    break;
                case Query.ProductByCategorySortedName:
                    EditProduct();
                    break;
                case Query.StoreProductByUPC:
                    EditStoreProduct();
                    break;
                case Query.PromotionalStoreProductSortedQuantity:
                    EditStoreProduct();
                    break;
                case Query.PromotionalStoreProductSortedName:
                    EditStoreProduct();
                    break;
                case Query.OrdinaryStoreProductSortedQuantity:
                    EditStoreProduct();
                    break;
                case Query.OrdinaryStoreProductSortedName:
                    EditStoreProduct();
                    break;
                case Query.SaleCheckByCashierByPeriod:
                    break;
                case Query.SaleCheckByPeriod:
                    break;
                case Query.ProductsByName:
                    EditStoreProduct();
                    break;
                case Query.CustomersBySurname:
                    EditCustomer();
                    break;
                case Query.SaleCheckByCashierToday:
                    break;
                default:
                    break;
            }
        }

        private void EditEmployee()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                EmployeeModel model = DbRepository.GetEmployeeById(int.Parse(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString()));
                AddEditEmployee editEmployee = new AddEditEmployee();
                editEmployee.setMainForm(this);
                editEmployee.setMode(Mode.Edit);
                editEmployee.setId(model.Id);
                editEmployee.setFirstNameTextBox(model.Name);
                editEmployee.setSecondNameTextBox(model.Surname);
                editEmployee.setPatronymicTextBox(model.Patronymic);
                editEmployee.setRoleComboBox(model.Role);
                editEmployee.setPhoneNumberTextBox(model.Phone);
                editEmployee.setSalaryTextBox(model.Salary.ToString());
                editEmployee.setEmploymentDateTextBox(model.DateOfEmployment);
                editEmployee.setBirthDateTextBox(model.DateOfBirth);
                editEmployee.setAddressTextBox(model.Street);
                editEmployee.setCityTextBox(model.City);
                editEmployee.setZipCodeTextBox(model.Zip);
                editEmployee.setUsernameTextBox(model.Username);
                editEmployee.setPasswordHash(model.PasswordHash);
                editEmployee.setSalt(model.Salt);
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            switch (query)
            {
                case Query.PhoneAddressEmployeeBySurname:
                    DeleteEmployee();
                    break;
                case Query.CustomersByDiscountSortedSurname:
                    DeleteCustomer();
                    break;
                case Query.ProductByCategorySortedName:
                    DeleteProduct();
                    break;
                case Query.StoreProductByUPC:
                    DeleteStoreProduct();
                    break;
                case Query.PromotionalStoreProductSortedQuantity:
                    DeleteStoreProduct();
                    break;
                case Query.PromotionalStoreProductSortedName:
                    DeleteStoreProduct();
                    break;
                case Query.OrdinaryStoreProductSortedQuantity:
                    DeleteStoreProduct();
                    break;
                case Query.OrdinaryStoreProductSortedName:
                    DeleteStoreProduct();
                    break;
                case Query.SaleCheckByCashierByPeriod:
                    break;
                case Query.SaleCheckByPeriod:
                    break;
                default:
                    break;
            }
        }

        private void DeleteEmployee()
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

        private void ShowProductsBtn_Click(object sender, EventArgs e)
        {
            //Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //DataTable dataTable = dataGridView1.DataSource as DataTable;
            //if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            //{
            //    CheckInfoForm checkInfo = new CheckInfoForm(DbRepository.GetSaleChecks()[dataGridView1.SelectedRows[0].Index]);
            //    checkInfo.Show();
            //}
        }
    }
}
