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

namespace Project_ZLAGODA.Frontend
{
    public partial class Query1Form : Form
    {
        public Query1Form()
        {
            InitializeComponent();
            List<ProductModel> models = DbRepository.GetProductsSorted();
            List<string> strings = new List<string>();
            foreach (ProductModel model in models)
            {
                strings.Add(model.ProductName);
            }
            ProductNameComboBox.Items.Clear();
            ProductNameComboBox.Items.AddRange(strings.ToArray());
        }

        private void ProductNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            List<Query1Model> models = DbRepository.ShevchenkoQuery1(ProductNameComboBox.Text);
            QueryResultForm form = new QueryResultForm(models);
            form.Show();
        }
    }
}
