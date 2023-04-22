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
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
