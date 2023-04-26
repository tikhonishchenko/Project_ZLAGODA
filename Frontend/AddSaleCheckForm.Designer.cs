namespace Project_ZLAGODA.Frontend
{
    partial class AddSaleCheckForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            CheckNumberLabel = new Label();
            CashierLabel = new Label();
            CardNumberLabel = new Label();
            CardNumberTextBox = new TextBox();
            TotalLabel = new Label();
            VATLabel = new Label();
            dataGridView1 = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            AddProductBtn = new Button();
            DeleteProductBtn = new Button();
            AddBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(CheckNumberLabel);
            flowLayoutPanel1.Controls.Add(CashierLabel);
            flowLayoutPanel1.Controls.Add(CardNumberLabel);
            flowLayoutPanel1.Controls.Add(CardNumberTextBox);
            flowLayoutPanel1.Controls.Add(TotalLabel);
            flowLayoutPanel1.Controls.Add(VATLabel);
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(AddBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(38, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(805, 538);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // CheckNumberLabel
            // 
            CheckNumberLabel.Anchor = AnchorStyles.None;
            CheckNumberLabel.AutoSize = true;
            CheckNumberLabel.Location = new Point(351, 0);
            CheckNumberLabel.Name = "CheckNumberLabel";
            CheckNumberLabel.Size = new Size(103, 20);
            CheckNumberLabel.TabIndex = 9;
            CheckNumberLabel.Text = "Check number";
            // 
            // CashierLabel
            // 
            CashierLabel.Anchor = AnchorStyles.None;
            CashierLabel.AutoSize = true;
            CashierLabel.Location = new Point(374, 20);
            CashierLabel.Name = "CashierLabel";
            CashierLabel.Size = new Size(57, 20);
            CashierLabel.TabIndex = 10;
            CashierLabel.Text = "Cashier";
            // 
            // CardNumberLabel
            // 
            CardNumberLabel.Anchor = AnchorStyles.None;
            CardNumberLabel.AutoSize = true;
            CardNumberLabel.Location = new Point(355, 40);
            CardNumberLabel.Name = "CardNumberLabel";
            CardNumberLabel.Size = new Size(95, 20);
            CardNumberLabel.TabIndex = 12;
            CardNumberLabel.Text = "Card number";
            // 
            // CardNumberTextBox
            // 
            CardNumberTextBox.Anchor = AnchorStyles.None;
            CardNumberTextBox.Location = new Point(305, 63);
            CardNumberTextBox.MaxLength = 16;
            CardNumberTextBox.Name = "CardNumberTextBox";
            CardNumberTextBox.Size = new Size(195, 27);
            CardNumberTextBox.TabIndex = 13;
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.None;
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(381, 93);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(42, 20);
            TotalLabel.TabIndex = 15;
            TotalLabel.Text = "Total";
            // 
            // VATLabel
            // 
            VATLabel.Anchor = AnchorStyles.None;
            VATLabel.AutoSize = true;
            VATLabel.Location = new Point(385, 113);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(34, 20);
            VATLabel.TabIndex = 14;
            VATLabel.Text = "VAT";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(799, 318);
            dataGridView1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.None;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(AddProductBtn);
            flowLayoutPanel2.Controls.Add(DeleteProductBtn);
            flowLayoutPanel2.Location = new Point(272, 460);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(260, 35);
            flowLayoutPanel2.TabIndex = 16;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(3, 3);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(121, 29);
            AddProductBtn.TabIndex = 0;
            AddProductBtn.Text = "Add product";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click_1;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.Location = new Point(130, 3);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(127, 29);
            DeleteProductBtn.TabIndex = 1;
            DeleteProductBtn.Text = "Delete product";
            DeleteProductBtn.UseVisualStyleBackColor = true;
            DeleteProductBtn.Click += DeleteProductBtn_Click_1;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.None;
            AddBtn.Location = new Point(355, 501);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 34);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AddSaleCheckForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 609);
            Controls.Add(flowLayoutPanel1);
            Name = "AddSaleCheckForm";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label CheckNumberLabel;
        private Label CashierLabel;
        private Label CardNumberLabel;
        private TextBox CardNumberTextBox;
        private Label TotalLabel;
        private Label VATLabel;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button AddProductBtn;
        private Button DeleteProductBtn;
        private Button AddBtn;
    }
}