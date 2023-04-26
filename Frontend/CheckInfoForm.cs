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
using System.Windows.Forms;

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
                dataTable.Rows.Add(new Object[] { sale.UPC, "not realized", sale.ProductNumber, sale.Price });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }
    }
}
