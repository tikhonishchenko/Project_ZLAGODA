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
    public partial class AddEditCustomer : Form
    {
        ShowForm main = null;
        Mode mode = Mode.Add;
        public AddEditCustomer()
        {
            InitializeComponent();
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width / 2 - flowLayoutPanel1.Size.Width / 2, this.ClientSize.Height / 2 - flowLayoutPanel1.Size.Height / 2);
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
                this.Text = "Add customer";
                AddEditBtn.Text = "Add";
            }
            else if (mode == Mode.Edit)
            {
                CardNumberLabel.Hide();
                CardNumberTextBox.Hide();
                this.Text = "Edit customer";
                AddEditBtn.Text = "Edit";
            }
        }

        public void setCardNumberTextBox(string number)
        {
            this.CardNumberTextBox.Text = number;
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

        public void setPhoneNumberTextBox(string number)
        {
            this.PhoneNumberTextBox.Text = number;
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

        public void setDiscountTextBox(int discount)
        {
            this.DiscountTextBox.Text = discount.ToString();
        }

        private void AddEditBtn_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Add)
            {
                //List<StoreProductModel> storeProducts = DbRepository.GetStoreProducts();
                CustomerModel model = new CustomerModel
                {
                    CardNumber = CardNumberTextBox.Text,
                    Name = FirstNameTextBox.Text,
                    LastName = SecondNameTextBox.Text,
                    Patronymic = PatronymicTextBox.Text,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    Street = AddressTextBox.Text,
                    City = CityTextBox.Text,
                    ZipCode = ZipCodeTextBox.Text,
                    Percent = int.Parse(DiscountTextBox.Text)
                };
                DbRepository.AddCustomer(model);
                main.ShowCustomers();
                this.Close();
            }
            else if (mode == Mode.Edit)
            {
                //MessageBox.Show(ProductComboBox.SelectedIndex + " " + products[ProductComboBox.SelectedIndex].Id, "Error");
                CustomerModel model = new CustomerModel
                {
                    CardNumber = CardNumberTextBox.Text,
                    Name = FirstNameTextBox.Text,
                    LastName = SecondNameTextBox.Text,
                    Patronymic = PatronymicTextBox.Text,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    Street = AddressTextBox.Text,
                    City = CityTextBox.Text,
                    ZipCode = ZipCodeTextBox.Text,
                    Percent = int.Parse(DiscountTextBox.Text)
                };
                DbRepository.UpdateCustomer(model);
                main.ShowCustomers();
                this.Close();
            }
        }
    }
}
