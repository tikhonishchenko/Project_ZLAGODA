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
    public partial class AddEditStoreProduct : Form
    {
        public AddEditStoreProduct()
        {
            InitializeComponent();
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width / 2 - flowLayoutPanel1.Size.Width / 2, this.ClientSize.Height / 2 - flowLayoutPanel1.Size.Height / 2);
            TypeComboBox.SelectedIndex = 0;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
