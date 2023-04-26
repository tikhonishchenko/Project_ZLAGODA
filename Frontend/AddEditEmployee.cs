using Project_ZLAGODA.Backend.Database;
using Project_ZLAGODA.Backend.Models;
using Project_ZLAGODA.Frontend;
using Project_ZLAGODA.ViewModels;
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
    public partial class AddEditEmployee : Form
    {
        ShowForm main = null;
        Mode mode = Mode.Add;
        int Id = 0;
        byte[] PasswordHash;
        byte[] Salt;

        public AddEditEmployee()
        {
            InitializeComponent();
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width / 2 - flowLayoutPanel1.Size.Width / 2, this.ClientSize.Height / 2 - flowLayoutPanel1.Size.Height / 2);
            RoleComboBox.SelectedIndex = 0;
        }

        public void setMainForm(ShowForm main)
        {
            this.main = main;
        }

        public void setMode(Mode mode)
        {
            this.mode = mode;
            if (mode == Mode.Add)
            {
                ChangePasswordBtn.Hide();
                this.Text = "Add employee";
                AddEditBtn.Text = "Add";
            }
            else if (mode == Mode.Edit)
            {
                PasswordLabel.Hide();
                PasswordTextBox.Hide();
                RepeatPasswordLabel.Hide();
                RepeatPasswordTextBox.Hide();
                this.Text = "Edit employee";
                AddEditBtn.Text = "Edit";
            }
        }

        public void setId(int Id)
        {
            this.Id = Id;
        }

        public void setFirstNameTextBox(string name)
        {
            this.FirstNameTextBox.Text = name;
        }

        public void setSecondNameTextBox(string name)
        {
            this.SecondNameTextBox.Text = name;
        }

        public void setPatronymicTextBox(string name)
        {
            this.PatronymicTextBox.Text = name;
        }

        public void setRoleComboBox(string role)
        {
            if (role == "Manager")
            {
                RoleComboBox.SelectedIndex = 0;
            }
            else if (role == "Cashier")
            {
                RoleComboBox.SelectedIndex = 1;
            }
        }

        public void setPhoneNumberTextBox(string number)
        {
            this.PhoneNumberTextBox.Text = number;
        }

        public void setSalaryTextBox(string salary)
        {
            this.SalaryTextBox.Text = salary;
        }

        public void setEmploymentDateTextBox(DateTime employmentDate)
        {
            EmploymentDateTimePicker.Value = employmentDate;
        }

        public void setBirthDateTextBox(DateTime birthDate)
        {
            BirthDateTimePicker.Value = birthDate;
        }

        public void setAddressTextBox(string address)
        {
            this.AddressTextBox.Text = address;
        }

        public void setCityTextBox(string city)
        {
            this.CityTextBox.Text = city;
        }

        public void setZipCodeTextBox(string code)
        {
            this.ZipCodeTextBox.Text = code;
        }

        public void setUsernameTextBox(string username)
        {
            this.UsernameTextbox.Text = username;
        }

        public void setPasswordHash(byte[] PasswordHash)
        {
            this.PasswordHash = PasswordHash;
        }

        public void setSalt(byte[] Salt)
        {
            this.Salt = Salt;
        }

        private void AddEditBtn_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Add)
            {
                //List<StoreProductModel> storeProducts = DbRepository.GetStoreProducts();
                if (!PasswordTextBox.Text.Equals(RepeatPasswordTextBox.Text))
                {
                    MessageBox.Show("Passwords are not equal!", "Error");
                    return;
                }
                byte[] hash1 = null;
                byte[] salt1 = null;
                ViewModel.CreatePasswordHash(PasswordTextBox.Text, out hash1, out salt1);
                List<EmployeeModel> employees = DbRepository.GetEmployees();
                foreach (EmployeeModel employee in employees)
                {
                    if (employee.Id > Id)
                    {
                        Id = employee.Id;
                    }
                }
                Id++;
                //MessageBox.Show(Id.ToString(), "Error");
                EmployeeModel model = new EmployeeModel
                {
                    Id = this.Id,
                    Name = FirstNameTextBox.Text,
                    Surname = SecondNameTextBox.Text,
                    Patronymic = PatronymicTextBox.Text,
                    Role = RoleComboBox.Text,
                    Phone = PhoneNumberTextBox.Text,
                    Salary = decimal.Parse(SalaryTextBox.Text),
                    DateOfEmployment = EmploymentDateTimePicker.Value,
                    DateOfBirth = BirthDateTimePicker.Value,
                    City = CityTextBox.Text,
                    Street = AddressTextBox.Text,
                    Zip = ZipCodeTextBox.Text,
                    PasswordHash = hash1,
                    Username = UsernameTextbox.Text,
                    Salt = salt1,
                };
                DbRepository.AddEmployee(model);
                main.ShowEmployees();
                this.Close();
            }
            else if (mode == Mode.Edit)
            {
                //MessageBox.Show(ProductComboBox.SelectedIndex + " " + products[ProductComboBox.SelectedIndex].Id, "Error");
                EmployeeModel model = new EmployeeModel
                {
                    Id = this.Id,
                    Name = FirstNameTextBox.Text,
                    Surname = SecondNameTextBox.Text,
                    Patronymic = PatronymicTextBox.Text,
                    Role = RoleComboBox.Text,
                    Phone = PhoneNumberTextBox.Text,
                    Salary = decimal.Parse(SalaryTextBox.Text),
                    DateOfEmployment = EmploymentDateTimePicker.Value,
                    DateOfBirth = BirthDateTimePicker.Value,
                    City = CityTextBox.Text,
                    Street = AddressTextBox.Text,
                    Zip = ZipCodeTextBox.Text,
                    PasswordHash = this.PasswordHash,
                    Username = UsernameTextbox.Text,
                    Salt = this.Salt,
                };
                DbRepository.UpdateEmployee(model);
                main.ShowEmployees();
                this.Close();
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();
            form.setAddEditEmployee(this);
            form.ShowDialog();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void RepeatPasswordLabel_Click(object sender, EventArgs e)
        {
        }

        private void RepeatPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
