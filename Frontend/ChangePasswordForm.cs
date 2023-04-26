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

namespace Project_ZLAGODA.Frontend
{
    public partial class ChangePasswordForm : Form
    {
        AddEditEmployee addEditEmployee;
        public ChangePasswordForm()
        {
            InitializeComponent();
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width / 2 - flowLayoutPanel1.Size.Width / 2, this.ClientSize.Height / 2 - flowLayoutPanel1.Size.Height / 2);
        }

        public void setAddEditEmployee(AddEditEmployee a)
        {
            addEditEmployee = a;
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            if (!PasswordTextBox.Text.Equals(RepeatPasswordTextBox.Text))
            {
                MessageBox.Show("Passwords are not equal!", "Error");
                return;
            }
            byte[] hash1 = null;
            byte[] salt1 = null;
            ViewModel.CreatePasswordHash(PasswordTextBox.Text, out hash1, out salt1);
            addEditEmployee.setPasswordHash(hash1);
            addEditEmployee.setSalt(salt1);
            this.Close();
        }
    }
}
