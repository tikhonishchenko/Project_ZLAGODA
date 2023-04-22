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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_ZLAGODA
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width / 2 - flowLayoutPanel1.Size.Width / 2, this.ClientSize.Height / 2 - flowLayoutPanel1.Size.Height / 2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Unknown username or password!", "Error");
            EmployeeModel model = DbRepository.GetEmployee(UsernameTextbox.Text, PasswordTextbox.Text);//"kovalchuk_olena", "12345"
            if (model == null)
            {
                MessageBox.Show("Unknown username or password!", "Error");
                return;
            }
            if (model.Role == "Manager")
            {
                this.Hide();
                ManagerMainForm form = new ManagerMainForm();
                form.managerId = model.Id;
                form.ShowDialog();
                this.Close();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
