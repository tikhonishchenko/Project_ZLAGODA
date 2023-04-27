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
    public partial class DataGridForm : Form
    {
        public DataGridForm()
        {
            InitializeComponent();          
        }

        public DataGridForm(List<string> category_name, List<decimal> average_price)
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Назва категорії";
            dataGridView1.Columns[1].Name = "Середня ціна";
            for (int i = 0; i < category_name.Count; i++)
            {
                dataGridView1.Rows.Add(category_name[i], average_price[i]);
            }
        }

        public DataGridForm(List<string> product_name, List<int> total_quantity, List<decimal> total_value)
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Назва товару";
            dataGridView1.Columns[1].Name = "Загальна кількість";
            dataGridView1.Columns[2].Name = "Загальна вартість";
            for (int i = 0; i < product_name.Count; i++)
            {
                dataGridView1.Rows.Add(product_name[i], total_quantity[i], total_value[i]);
            }
        }
    }
}
