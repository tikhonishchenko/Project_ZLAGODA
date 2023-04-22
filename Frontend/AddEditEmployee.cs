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
        public AddEditEmployee()
        {
            InitializeComponent();
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width / 2 - flowLayoutPanel1.Size.Width / 2, this.ClientSize.Height / 2 - flowLayoutPanel1.Size.Height / 2);
            RoleComboBox.SelectedIndex = 0;
        }
    }
}
