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
    public partial class QueryResultForm : Form
    {
        public QueryResultForm()
        {
            InitializeComponent();
        }

        public QueryResultForm(List<Query2Model> models)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = models;
        }

        public QueryResultForm(List<Query1Model> models)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = models;
        }
    }
}
