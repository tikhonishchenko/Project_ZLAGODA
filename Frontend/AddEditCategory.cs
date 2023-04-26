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

namespace Project_ZLAGODA
{
    public partial class AddEditCategory : Form
    {

        ShowForm main = null;
        Mode mode = Mode.Add;
        int Id = 0;
        public AddEditCategory()
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
                this.Text = "Add product";
                AddEditBtn.Text = "Add";
            }
            else if (mode == Mode.Edit)
            {
                this.Text = "Edit product";
                AddEditBtn.Text = "Edit";
            }
        }

        public void setId(int Id)
        {
            this.Id = Id;
        }

        public void setNameTextBox(string name)
        {
            this.NameTextBox.Text = name;
        }

        private void AddEditBtn_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Add)
            {
                List<CategoryModel> categories = DbRepository.GetCategories();
                CategoryModel model = new CategoryModel
                {
                    Id = categories.Count() == 0 ? 0 : categories[categories.Count() - 1].Id + 1,
                    CategoryName = NameTextBox.Text
                };
                DbRepository.AddCategory(model);
                main.ShowCategories();
                this.Close();
            }
            else if (mode == Mode.Edit)
            {
                CategoryModel model = new CategoryModel
                {
                    Id = this.Id,
                    CategoryName = NameTextBox.Text
                };
                DbRepository.UpdateCategory(model);
                main.ShowCategories();
                this.Close();
            }
        }
    }
}
