using Project_ZLAGODA.Backend.Database;
using Project_ZLAGODA.Backend.Models;
using Project_ZLAGODA.Frontend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ZLAGODA
{
    public partial class SearchForm : Form
    {
        List<EmployeeModel> employees;
        List<CustomerModel> customers;
        List<CategoryModel> categories;
        List<ProductModel> products;
        //ProductsByName,
        //CustomersBySurname,
        //SaleCheckByCashierToday,
        //SaleCheckByCheckNumber
        string[] tables = new string[]
        {
            "телефон та адреса працівників за прізвищем",
            "постійні клієнти із певним відсотком (за прізвищем)",
            "товарів за категорією (за назвою)",
            "товар за UPC",
            "акційні товари (за кількістю)",
            "акційні товари (за назвою)",
            "не акційні товари (за кількістю)",
            "не акційні товари (за назвою)",
            "чеки за касиром, за період часу",
            "чеки за період часу",
            "сума проданих товарів за касиром, за період часу",
            "сума проданих товарів за період часу",
            "кількість проданого певного товару за період часу",
            "товари у магазині за назвою",
            "клієнти за прізвищем",
            "чеки за період часу",
            "чеки за сьогодні",
            "чек за номером"
        };

        public int employeeId { get; set; }
        public bool isManager { get; set; }

        public SearchForm()
        {
            InitializeComponent();
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width / 2 - flowLayoutPanel1.Size.Width / 2, this.ClientSize.Height / 2 - flowLayoutPanel1.Size.Height / 2);
            hideAll();
            employeeId = 1;
            isManager = true;
        }
        public SearchForm(int employeeId, bool isManager)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.isManager = isManager;
            if (isManager)
            {
                string[] table = new string[] { tables[0], tables[1], tables[2], tables[3], tables[4], tables[5], tables[6], tables[7], tables[8], tables[9], tables[10], tables[11], tables[12] };
                QueryComboBox.Items.AddRange(table);
            }
            else
            {
                string[] table = new string[] { tables[13], tables[2], tables[14], tables[16], tables[15], tables[17], tables[3], tables[4], tables[5], tables[6], tables[7] };
                QueryComboBox.Items.AddRange(table);
            }
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width / 2 - flowLayoutPanel1.Size.Width / 2, this.ClientSize.Height / 2 - flowLayoutPanel1.Size.Height / 2);
            hideAll();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hideAll()
        {
            SecondNameLabel.Hide();
            SecondNameComboBox.Hide();
            DiscountLabel.Hide();
            DiscountTextBox.Hide();
            CategoryLabel.Hide();
            CategoryComboBox.Hide();
            ProductNameLabel.Hide();
            ProductNameComboBox.Hide();
            UPCLabel.Hide();
            UPCTextBox.Hide();
            CheckNumberLabel.Hide();
            CheckNumberTextBox.Hide();
            CashierLabel.Hide();
            CashierComboBox.Hide();
            StartDateLabel.Hide();
            StartDateTimePicker.Hide();
            EndDateLabel.Hide();
            EndDateTimePicker.Hide();
        }

        private void QueryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideAll();
            //SortedSet<string> employeeSurnames;
            if (QueryComboBox.Text.Equals(tables[0]))
            {
                employees = DbRepository.GetEmployeesSortedBySurname();
                SortedSet<string> employeeSurnames = new SortedSet<string>();
                foreach (EmployeeModel employee in employees)
                {
                    employeeSurnames.Add(employee.Surname);
                }
                SecondNameComboBox.Items.Clear();
                SecondNameComboBox.Items.AddRange(employeeSurnames.ToArray());
                if (employeeSurnames.Count() > 0)
                {
                    SecondNameComboBox.SelectedIndex = 0;
                }
                SecondNameLabel.Show();
                SecondNameComboBox.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[1]))
            {
                DiscountLabel.Show();
                DiscountTextBox.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[2]))
            {
                categories = DbRepository.GetCategoriesSorted();
                List<string> categoryNames = new List<string>();
                foreach (CategoryModel category in categories)
                {
                    categoryNames.Add(category.CategoryName);
                }
                CategoryComboBox.Items.Clear();
                CategoryComboBox.Items.AddRange(categoryNames.ToArray());
                if (categoryNames.Count() > 0)
                {
                    CategoryComboBox.SelectedIndex = 0;
                }
                CategoryLabel.Show();
                CategoryComboBox.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[3]))
            {
                UPCLabel.Show();
                UPCTextBox.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[4]))
            {
            }
            else if (QueryComboBox.Text.Equals(tables[5]))
            {
            }
            else if (QueryComboBox.Text.Equals(tables[6]))
            {
            }
            else if (QueryComboBox.Text.Equals(tables[7]))
            {
            }
            else if (QueryComboBox.Text.Equals(tables[8]))
            {
                employees = DbRepository.GetEmployeesSortedBySurname();
                List<string> employeeSurnames = new List<string>();
                foreach (EmployeeModel employee in employees)
                {
                    employeeSurnames.Add(employee.Surname + " " + employee.Name + " " + employee.Patronymic);
                }
                CashierComboBox.Items.Clear();
                CashierComboBox.Items.AddRange(employeeSurnames.ToArray());
                if (employeeSurnames.Count() > 0)
                {
                    CashierComboBox.SelectedIndex = 0;
                }
                CashierLabel.Show();
                CashierComboBox.Show();
                StartDateLabel.Show();
                StartDateTimePicker.Show();
                EndDateLabel.Show();
                EndDateTimePicker.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[9]))
            {
                StartDateLabel.Show();
                StartDateTimePicker.Show();
                EndDateLabel.Show();
                EndDateTimePicker.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[10]))
            {
                employees = DbRepository.GetEmployeesSortedBySurname();
                List<string> employeeSurnames = new List<string>();
                foreach (EmployeeModel employee in employees)
                {
                    employeeSurnames.Add(employee.Surname + " " + employee.Name + " " + employee.Patronymic);
                }
                CashierComboBox.Items.Clear();
                CashierComboBox.Items.AddRange(employeeSurnames.ToArray());
                if (employeeSurnames.Count() > 0)
                {
                    CashierComboBox.SelectedIndex = 0;
                }
                CashierLabel.Show();
                CashierComboBox.Show();
                StartDateLabel.Show();
                StartDateTimePicker.Show();
                EndDateLabel.Show();
                EndDateTimePicker.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[11]))
            {
                StartDateLabel.Show();
                StartDateTimePicker.Show();
                EndDateLabel.Show();
                EndDateTimePicker.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[12]))
            {
                products = DbRepository.GetProductsSorted();
                List<string> productNames = new List<string>();
                foreach (ProductModel product in products)
                {
                    productNames.Add(product.ProductName);
                }
                ProductNameComboBox.Items.Clear();
                ProductNameComboBox.Items.AddRange(productNames.ToArray());
                if (productNames.Count() > 0)
                {
                    ProductNameComboBox.SelectedIndex = 0;
                }
                ProductNameLabel.Show();
                ProductNameComboBox.Show();
                StartDateLabel.Show();
                StartDateTimePicker.Show();
                EndDateLabel.Show();
                EndDateTimePicker.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[13]))
            {
                products = DbRepository.GetProductsSorted();
                List<string> productNames = new List<string>();
                foreach (ProductModel product in products)
                {
                    productNames.Add(product.ProductName);
                }
                ProductNameComboBox.Items.Clear();
                ProductNameComboBox.Items.AddRange(productNames.ToArray());
                if (productNames.Count() > 0)
                {
                    ProductNameComboBox.SelectedIndex = 0;
                }
                ProductNameLabel.Show();
                ProductNameComboBox.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[14]))
            {
                customers = DbRepository.GetCustomersSorted();
                SortedSet<string> customerSurnames = new SortedSet<string>();
                foreach (CustomerModel customer in customers)
                {
                    customerSurnames.Add(customer.LastName);
                }
                SecondNameComboBox.Items.Clear();
                SecondNameComboBox.Items.AddRange(customerSurnames.ToArray());
                if (customerSurnames.Count() > 0)
                {
                    SecondNameComboBox.SelectedIndex = 0;
                }
                SecondNameLabel.Show();
                SecondNameComboBox.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[15]))
            {
                StartDateLabel.Show();
                StartDateTimePicker.Show();
                EndDateLabel.Show();
                EndDateTimePicker.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[16]))
            {
            }
            else if (QueryComboBox.Text.Equals(tables[17]))
            {
                CheckNumberLabel.Show();
                CheckNumberTextBox.Show();
            }
        }


        private void ShowBtn_Click(object sender, EventArgs e)
        {
            SearchResultForm result;
            if (QueryComboBox.Text.Equals(tables[0]))
            {
                result = new SearchResultForm(Query.PhoneAddressEmployeeBySurname);
                result.isManager = isManager;
                result.Surname = SecondNameComboBox.Text;
                result.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[1]))
            {
                result = new SearchResultForm(Query.CustomersByDiscountSortedSurname);
                result.isManager = isManager;
                result.discount = int.Parse(DiscountTextBox.Text);
                result.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[2]))
            {
                result = new SearchResultForm(Query.ProductByCategorySortedName);
                result.isManager = isManager;
                result.categotyId = categories[CategoryComboBox.SelectedIndex].Id;
                result.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[3]))
            {
                result = new SearchResultForm(Query.StoreProductByUPC);
                result.isManager = isManager;
                result.upc = UPCTextBox.Text;
                result.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[4]))
            {
                result = new SearchResultForm(Query.PromotionalStoreProductSortedQuantity);
                result.isManager = isManager;
                result.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[5]))
            {
                result = new SearchResultForm(Query.PromotionalStoreProductSortedName);
                result.isManager = isManager;
                result.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[6]))
            {
                result = new SearchResultForm(Query.OrdinaryStoreProductSortedQuantity);
                result.isManager = isManager;
                result.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[7]))
            {
                result = new SearchResultForm(Query.OrdinaryStoreProductSortedName);
                result.isManager = isManager;
                result.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[8]))
            {
                result = new SearchResultForm(Query.SaleCheckByCashierByPeriod);
                result.isManager = isManager;
                result.CashierId = employees[CashierComboBox.SelectedIndex].Id;
                result.startTime = StartDateTimePicker.Value;
                result.endTime = EndDateTimePicker.Value;
                result.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[9]))
            {
                if (isManager)
                {
                    result = new SearchResultForm(Query.SaleCheckByPeriod);
                    result.isManager = isManager;
                    result.startTime = StartDateTimePicker.Value;
                    result.endTime = EndDateTimePicker.Value;
                    result.Show();
                }
                else
                {
                    result = new SearchResultForm(Query.SaleCheckByCashierByPeriod);
                    result.isManager = isManager;
                    result.CashierId = employeeId;
                    result.startTime = StartDateTimePicker.Value;
                    result.endTime = EndDateTimePicker.Value;
                    result.Show();
                }
            }
            else if (QueryComboBox.Text.Equals(tables[10]))
            {
                MessageBox.Show("Total sum: " + DbRepository.GetSumOfSalesByEmployeeIdAndDates(employees[CashierComboBox.SelectedIndex].Id, StartDateTimePicker.Value, EndDateTimePicker.Value), "Info");
            }
            else if (QueryComboBox.Text.Equals(tables[11]))
            {
                MessageBox.Show("Total sum: " + DbRepository.GetSumOfSalesByDates(StartDateTimePicker.Value, EndDateTimePicker.Value), "Info");
            }
            else if (QueryComboBox.Text.Equals(tables[12]))
            {
                MessageBox.Show("Total quantity: " + DbRepository.GetQuantityOfSoldProductsByProductNameAndDates(ProductNameComboBox.Text, StartDateTimePicker.Value, EndDateTimePicker.Value), "Info");
            }
            //"товари у магазині за назвою",13
            //"клієнти за прізвищем",14
            //"чеки за період часу",15
            //"чеки за сьогодні",16
            //"чек за номером"17
            else if (QueryComboBox.Text.Equals(tables[13]))
            {
                result = new SearchResultForm(Query.ProductsByName);
                result.isManager = isManager;
                result.ProductName = ProductNameComboBox.Text;
                result.Show();
                //DbRepository.GetProductsByName
            }
            else if (QueryComboBox.Text.Equals(tables[14]))
            {
                result = new SearchResultForm(Query.CustomersBySurname);
                result.isManager = isManager;
                result.Surname = SecondNameComboBox.Text;
                result.Show();
                //DbRepository.GetCustomersBySurname();
            }
            else if (QueryComboBox.Text.Equals(tables[15]))
            {
                result = new SearchResultForm(Query.SaleCheckByCashierByPeriod);
                result.isManager = isManager;
                result.CashierId = employeeId;
                result.startTime = StartDateTimePicker.Value;
                result.endTime = EndDateTimePicker.Value;
                result.Show();
                //DbRepository.GetSale
            }
            else if (QueryComboBox.Text.Equals(tables[16]))
            {
                result = new SearchResultForm(Query.SaleCheckByCashierToday);
                result.isManager = isManager;
                result.CashierId = employeeId;
                result.Show();
            }
            else if (QueryComboBox.Text.Equals(tables[17]))
            {
                CheckInfoForm form = new CheckInfoForm(DbRepository.GetSaleCheckByCheckNumber(int.Parse(CheckNumberTextBox.Text)));
                form.Show();
            }
        }
    }
}
