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
            SellerLabel.Hide();
            SellerComboBox.Hide();
            StartDateLabel.Hide();
            StartDateTimePicker.Hide();
            EndDateLabel.Hide();
            EndDateTimePicker.Hide();
        }

        private void QueryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideAll();
            switch (QueryComboBox.SelectedIndex)
            {
                case 0:
                    SecondNameLabel.Show();
                    SecondNameComboBox.Show();
                    break;
                case 1:
                    DiscountLabel.Show();
                    DiscountTextBox.Show();
                    break;
                case 2:
                    CategoryComboBox.Show();
                    CategoryLabel.Show();
                    break;
                case 3:
                    UPCLabel.Show();
                    UPCTextBox.Show();
                    break;
                case 8:
                    SellerLabel.Show();
                    SellerComboBox.Show();
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
                    SellerLabel.Show();
                    SellerComboBox.Show();
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
