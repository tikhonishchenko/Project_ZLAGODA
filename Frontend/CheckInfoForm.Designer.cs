namespace Project_ZLAGODA.Frontend
{
    partial class CheckInfoForm
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
            PrintDateLabel = new Label();
            TotalLabel = new Label();
            VATLabel = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            flowLayoutPanel1.Controls.Add(PrintDateLabel);
            flowLayoutPanel1.Controls.Add(TotalLabel);
            flowLayoutPanel1.Controls.Add(VATLabel);
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(42, 46);
            flowLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1308, 848);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // CheckNumberLabel
            // 
            CheckNumberLabel.Anchor = AnchorStyles.None;
            CheckNumberLabel.AutoSize = true;
            CheckNumberLabel.Location = new Point(569, 0);
            CheckNumberLabel.Margin = new Padding(5, 0, 5, 0);
            CheckNumberLabel.Name = "CheckNumberLabel";
            CheckNumberLabel.Size = new Size(170, 32);
            CheckNumberLabel.TabIndex = 9;
            CheckNumberLabel.Text = "Check number";
            // 
            // CashierLabel
            // 
            CashierLabel.Anchor = AnchorStyles.None;
            CashierLabel.AutoSize = true;
            CashierLabel.Location = new Point(608, 32);
            CashierLabel.Margin = new Padding(5, 0, 5, 0);
            CashierLabel.Name = "CashierLabel";
            CashierLabel.Size = new Size(92, 32);
            CashierLabel.TabIndex = 10;
            CashierLabel.Text = "Cashier";
            // 
            // CardNumberLabel
            // 
            CardNumberLabel.Anchor = AnchorStyles.None;
            CardNumberLabel.AutoSize = true;
            CardNumberLabel.Location = new Point(577, 64);
            CardNumberLabel.Margin = new Padding(5, 0, 5, 0);
            CardNumberLabel.Name = "CardNumberLabel";
            CardNumberLabel.Size = new Size(154, 32);
            CardNumberLabel.TabIndex = 12;
            CardNumberLabel.Text = "Card number";
            // 
            // PrintDateLabel
            // 
            PrintDateLabel.Anchor = AnchorStyles.None;
            PrintDateLabel.AutoSize = true;
            PrintDateLabel.Location = new Point(595, 96);
            PrintDateLabel.Margin = new Padding(5, 0, 5, 0);
            PrintDateLabel.Name = "PrintDateLabel";
            PrintDateLabel.Size = new Size(117, 32);
            PrintDateLabel.TabIndex = 7;
            PrintDateLabel.Text = "Print date";
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.None;
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(621, 128);
            TotalLabel.Margin = new Padding(5, 0, 5, 0);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(65, 32);
            TotalLabel.TabIndex = 15;
            TotalLabel.Text = "Total";
            // 
            // VATLabel
            // 
            VATLabel.Anchor = AnchorStyles.None;
            VATLabel.AutoSize = true;
            VATLabel.Location = new Point(627, 160);
            VATLabel.Margin = new Padding(5, 0, 5, 0);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(54, 32);
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
            dataGridView1.Location = new Point(5, 197);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1298, 646);
            dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(611, 902);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 12;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CheckInfoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 960);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "CheckInfoForm";
            Text = "CheckInfoForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label CheckNumberLabel;
        private Label CashierLabel;
        private Label CardNumberLabel;
        private Label PrintDateLabel;
        private Label TotalLabel;
        private Label VATLabel;
        private DataGridView dataGridView1;
        private Button button1;
    }
}