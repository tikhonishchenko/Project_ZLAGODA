namespace Project_ZLAGODA
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableComboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            AddBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            ShowBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TableComboBox
            // 
            TableComboBox.FormattingEnabled = true;
            TableComboBox.Location = new Point(263, 12);
            TableComboBox.Name = "TableComboBox";
            TableComboBox.Size = new Size(363, 28);
            TableComboBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(263, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(525, 401);
            dataGridView1.TabIndex = 1;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(20, 13);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(123, 29);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(21, 51);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(122, 29);
            EditBtn.TabIndex = 3;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(24, 91);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(119, 29);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ShowBtn
            // 
            ShowBtn.Location = new Point(651, 11);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(94, 29);
            ShowBtn.TabIndex = 5;
            ShowBtn.Text = "Show";
            ShowBtn.UseVisualStyleBackColor = true;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Controls.Add(TableComboBox);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox TableComboBox;
        private DataGridView dataGridView1;
        private Button AddBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button ShowBtn;
    }
}