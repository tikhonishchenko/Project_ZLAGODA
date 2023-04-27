using Project_ZLAGODA.Backend.Database;
using Project_ZLAGODA.Backend.Models;
using System.Data;

namespace Project_ZLAGODA.Frontend
{
    public partial class CheckInfoForm : Form
    {
        public CheckInfoForm()
        {
            InitializeComponent();
        }

        public CheckInfoForm(SaleCheckModel check)
        {
            InitializeComponent();
            CheckNumberLabel.Text = "Check number: " + check.CheckNumber;
            EmployeeModel employee = DbRepository.GetEmployeeById(check.EmployeeId);
            CashierLabel.Text = "Cashier: " + employee.Surname + " " + employee.Name + " " + employee.Patronymic;
            CardNumberLabel.Text = "Card number: " + check.CardNumber;
            PrintDateLabel.Text = "Print date: " + check.PrintDate.ToString();
            TotalLabel.Text = "Total: " + check.SumTotal;
            VATLabel.Text = "VAT: " + check.VAT;
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product"), new DataColumn("Quantity"), new DataColumn("Price") };
            dataTable.Columns.AddRange(columns);
            foreach (SaleModel sale in check.CheckItems)
            {
                ProductModel productModel = DbRepository.GetProductById(DbRepository.GetStoreProductById(sale.UPC).ProductId);
                dataTable.Rows.Add(new Object[] { sale.UPC, productModel.ProductName, sale.ProductNumber, sale.Price });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textHeader = CheckNumberLabel.Text + "\n" +
                CashierLabel.Text + "\n" +
                CardNumberLabel.Text + "\n" +
                PrintDateLabel.Text + "\n" +
                TotalLabel.Text + "\n" +
                VATLabel.Text + "\n\n\n";
            new PrintResultForm(dataGridView1, textHeader).Show();
        }
    }
}
