namespace Project_ZLAGODA
{
    partial class ManagerMainForm
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
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ShowProductsBtn = new Button();
            SearchBtn = new Button();
            AboutMeBtn = new Button();
            PrintBtn = new Button();
            ExitBtn = new Button();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // TableComboBox
            // 
            TableComboBox.Dock = DockStyle.Fill;
            TableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TableComboBox.FormattingEnabled = true;
            TableComboBox.Location = new Point(0, 0);
            TableComboBox.Margin = new Padding(5);
            TableComboBox.Name = "TableComboBox";
            TableComboBox.Size = new Size(675, 40);
            TableComboBox.TabIndex = 0;
            TableComboBox.SelectedIndexChanged += TableComboBox_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1032, 738);
            dataGridView1.TabIndex = 1;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(5, 5);
            AddBtn.Margin = new Padding(5);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(223, 46);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(5, 61);
            EditBtn.Margin = new Padding(5);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(223, 46);
            EditBtn.TabIndex = 3;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(5, 173);
            DeleteBtn.Margin = new Padding(5);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(223, 46);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ShowBtn
            // 
            ShowBtn.Dock = DockStyle.Fill;
            ShowBtn.Location = new Point(0, 0);
            ShowBtn.Margin = new Padding(5);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(341, 45);
            ShowBtn.TabIndex = 5;
            ShowBtn.Text = "Show";
            ShowBtn.UseVisualStyleBackColor = true;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(TableComboBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ShowBtn);
            splitContainer1.Size = new Size(1032, 45);
            splitContainer1.SplitterDistance = 675;
            splitContainer1.SplitterWidth = 16;
            splitContainer1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(AddBtn);
            flowLayoutPanel1.Controls.Add(EditBtn);
            flowLayoutPanel1.Controls.Add(ShowProductsBtn);
            flowLayoutPanel1.Controls.Add(DeleteBtn);
            flowLayoutPanel1.Controls.Add(SearchBtn);
            flowLayoutPanel1.Controls.Add(AboutMeBtn);
            flowLayoutPanel1.Controls.Add(PrintBtn);
            flowLayoutPanel1.Controls.Add(ExitBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(143, 784);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // ShowProductsBtn
            // 
            ShowProductsBtn.Location = new Point(5, 117);
            ShowProductsBtn.Margin = new Padding(5);
            ShowProductsBtn.Name = "ShowProductsBtn";
            ShowProductsBtn.Size = new Size(223, 46);
            ShowProductsBtn.TabIndex = 9;
            ShowProductsBtn.Text = "Show products";
            ShowProductsBtn.UseVisualStyleBackColor = true;
            ShowProductsBtn.Click += button1_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(5, 229);
            SearchBtn.Margin = new Padding(5);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(223, 46);
            SearchBtn.TabIndex = 8;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // AboutMeBtn
            // 
            AboutMeBtn.Location = new Point(5, 285);
            AboutMeBtn.Margin = new Padding(5);
            AboutMeBtn.Name = "AboutMeBtn";
            AboutMeBtn.Size = new Size(223, 46);
            AboutMeBtn.TabIndex = 6;
            AboutMeBtn.Text = "About me";
            AboutMeBtn.UseVisualStyleBackColor = true;
            AboutMeBtn.Click += AboutMeBtn_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.Location = new Point(5, 341);
            PrintBtn.Margin = new Padding(5);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(223, 46);
            PrintBtn.TabIndex = 7;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(5, 397);
            ExitBtn.Margin = new Padding(5);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(223, 46);
            ExitBtn.TabIndex = 5;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(5);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dataGridView1);
            splitContainer2.Size = new Size(1032, 784);
            splitContainer2.SplitterDistance = 30;
            splitContainer2.SplitterWidth = 16;
            splitContainer2.TabIndex = 8;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel1;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(5);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer2);
            splitContainer3.Size = new Size(1191, 784);
            splitContainer3.SplitterDistance = 143;
            splitContainer3.SplitterWidth = 16;
            splitContainer3.TabIndex = 9;
            // 
            // ManagerMainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 784);
            Controls.Add(splitContainer3);
            Margin = new Padding(5);
            Name = "ManagerMainForm";
            Text = "ZLAGODA";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox TableComboBox;
        private DataGridView dataGridView1;
        private Button AddBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button ShowBtn;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Button SearchBtn;
        private Button AboutMeBtn;
        private Button PrintBtn;
        private Button ExitBtn;
        private Button ShowProductsBtn;
    }
}