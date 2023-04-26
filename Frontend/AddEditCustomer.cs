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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                try
                {
                    int.Parse(DiscountTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Discount is incorrect!", "Error");
                    return;
                }
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
                try
                {
                    int.Parse(DiscountTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Discount is incorrect!", "Error");
                    return;
                }
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

        private void CardNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in CardNumberTextBox.Text)
            {
                if (!(a >= '0' && a <= '9'))
                {
                    CardNumberTextBox.Text = CardNumberTextBox.Text.Remove(CardNumberTextBox.Text.Length - 1);
                    CardNumberTextBox.SelectionStart = CardNumberTextBox.Text.Length;
                    CardNumberTextBox.SelectionLength = 0;
                    return;
                }
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in PhoneNumberTextBox.Text)
            {
                if (!(a >= '0' && a <= '9' || a == '+' || a == '-'))
                {
                    PhoneNumberTextBox.Text = PhoneNumberTextBox.Text.Remove(PhoneNumberTextBox.Text.Length - 1);
                    PhoneNumberTextBox.SelectionStart = PhoneNumberTextBox.Text.Length;
                    PhoneNumberTextBox.SelectionLength = 0;
                    return;
                }
            }
        }

        private void ZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in ZipCodeTextBox.Text)
            {
                if (!(a >= '0' && a <= '9'))
                {
                    ZipCodeTextBox.Text = ZipCodeTextBox.Text.Remove(ZipCodeTextBox.Text.Length - 1);
                    ZipCodeTextBox.SelectionStart = ZipCodeTextBox.Text.Length;
                    ZipCodeTextBox.SelectionLength = 0;
                    return;
                }
            }
        }
    }
}
