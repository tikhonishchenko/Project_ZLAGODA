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
    public partial class AddSaleCheckForm : Form
    {
        int CheckNumber = 0;
        EmployeeModel employee;
        ShowForm main;
        List<SaleModel> sales = new List<SaleModel>();

        public AddSaleCheckForm()
        {
            InitializeComponent();
            List<SaleCheckModel> checks = DbRepository.GetSaleChecks();
            for (int i = 0; i < checks.Count(); i++)
            {
                if (CheckNumber < checks[i].CheckNumber)
                {
                    CheckNumber = checks[i].CheckNumber;
                }
            }
            CheckNumber++;
            CheckNumberLabel.Text = "Check number: " + CheckNumber;
        }

        public void setEmployee(int employeeId)
        {
            this.employee = DbRepository.GetEmployeeById(employeeId);
            if (employee == null) return;
            CashierLabel.Text = "Cashier: " + employee.Surname + " " + employee.Name + " " + employee.Patronymic;
        }

        public void setMain(ShowForm main)
        {
            this.main = main;
        }

        public void ShowSales()
        {
            update();
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("UPC"), new DataColumn("Product"), new DataColumn("Quantity"), new DataColumn("Price") };
            dataTable.Columns.AddRange(columns);
            foreach (SaleModel sale in sales)
            {
                dataTable.Rows.Add(new Object[] { sale.UPC, "not realized", sale.ProductNumber, sale.Price });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void AddSale(string upc, int quantity, decimal price)
        {
            SaleModel sale = new SaleModel
            {
                UPC = upc,
                CheckNumber = this.CheckNumber,
                ProductNumber = quantity,
                Price = price * quantity
            };
            sales.Add(sale);
            ShowSales();
        }

        private void update()
        {
            decimal total = 0;
            foreach (SaleModel model in sales)
            {
                total += model.Price;
            }
            TotalLabel.Text = "Total: " + total;
            VATLabel.Text = "VAT: " + (total * 0.2M);
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddSaleForm addSale = new AddSaleForm();
            addSale.setMainForm(this);
            addSale.Show();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                sales.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ShowSales();
                //DbRepository.DeleteCustomer(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                //ShowCustomers();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (SaleModel m in sales)
            {
                total += m.Price;
            }
            SaleCheckModel model = new SaleCheckModel
            {
                CheckNumber = this.CheckNumber,
                EmployeeId = this.employee.Id,
                CardNumber = CardNumberTextBox.Text,
                PrintDate = DateTime.Now,
                SumTotal = total,
                VAT = total * 0.2M
            };
            DbRepository.AddSaleCheck(model);
            main.ShowSaleChecks();
            this.Close();
        }

        private void AddProductBtn_Click_1(object sender, EventArgs e)
        {
            AddSaleForm addSale = new AddSaleForm();
            addSale.setMainForm(this);
            addSale.Show();
        }

        private void DeleteProductBtn_Click_1(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (selectedRowCount == 1 && dataGridView1.SelectedRows[0].Index < dataTable.Rows.Count)
            {
                sales.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ShowSales();
                //DbRepository.DeleteCustomer(dataTable.Rows[dataGridView1.SelectedRows[0].Index][0].ToString());
                //ShowCustomers();
            }
        }
    }
}
