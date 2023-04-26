﻿using Project_ZLAGODA.Backend.Database;
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

namespace Project_ZLAGODA.Frontend
{
    public partial class SearchResultForm : Form, ShowForm
    {
        Query query;
        public int CashierId { get; set; }
        public int quantity { get; set; }
        public int discount { get; set; }
        public string upc { get; set; }
        public int categotyId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public SearchResultForm()
        {
            InitializeComponent();
        }

        public SearchResultForm(Query query)
        {
            InitializeComponent();
            this.query = query;
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
                    break;
                case Query.SaleCheckByPeriod:
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
            List<EmployeeModel> employees = DbRepository.GetEmployeesSortedBySurname();
            foreach (EmployeeModel employee in employees)
            {
                dataTable.Rows.Add(new Object[] { employee.Id, employee.Name, employee.Surname, employee.Patronymic, employee.Phone, employee.Street, employee.City });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ShowCustomers()
        {
            switch (query)
            {
                case Query.CustomersByDiscountSortedSurname:
                    ShowCustomersByDiscountSortedSurname();
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
            List<CustomerModel> customers = DbRepository.GetCustomersSorted();
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
                default:
                    break;
            }
        }

        public void ShowStoreProductByUPC()
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

        public void ShowPromotionalStoreProductSortedQuantity()
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

        public void ShowPromotionalStoreProductSortedName()
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

        public void ShowOrdinaryStoreProductSortedQuantity()
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

        public void ShowOrdinaryStoreProductSortedName()
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
                EmployeeModel model = DbRepository.GetEmployeeById(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                AddEditEmployee editEmployee = new AddEditEmployee();
                editEmployee.setMainForm(this);
                editEmployee.setMode(Mode.Edit);
                editEmployee.setId(int.Parse(model.Id));
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
    }
}