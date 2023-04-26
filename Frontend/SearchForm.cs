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

namespace Project_ZLAGODA
{
    public partial class SearchForm : Form
    {
        List<EmployeeModel> employees;
        List<CategoryModel> categories;

        public SearchForm()
        {
            InitializeComponent();
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
            UPCLabel.Hide();
            UPCTextBox.Hide();
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
            List<string> employeeSurnames;
            switch (QueryComboBox.SelectedIndex)
            {
                case 0:
                    employees = DbRepository.GetEmployeesSortedBySurname();
                    employeeSurnames = new List<string>();
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
                    break;
                case 1:
                    DiscountLabel.Show();
                    DiscountTextBox.Show();
                    break;
                case 2:
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
                    break;
                case 3:
                    UPCLabel.Show();
                    UPCTextBox.Show();
                    break;
                case 8:
                    employees = DbRepository.GetEmployeesSortedBySurname();
                    employeeSurnames = new List<string>();
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
                    break;
                case 9:
                    StartDateLabel.Show();
                    StartDateTimePicker.Show();
                    EndDateLabel.Show();
                    EndDateTimePicker.Show();
                    break;
                case 10:
                    employees = DbRepository.GetEmployeesSortedBySurname();
                    employeeSurnames = new List<string>();
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
                    break;
                case 11:
                    StartDateLabel.Show();
                    StartDateTimePicker.Show();
                    EndDateLabel.Show();
                    EndDateTimePicker.Show();
                    break;
                case 12:
                    UPCLabel.Show();
                    UPCTextBox.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
