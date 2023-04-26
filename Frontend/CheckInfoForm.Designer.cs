﻿namespace Project_ZLAGODA.Frontend
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
            PrintBtn = new Button();
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
            flowLayoutPanel1.Controls.Add(PrintBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(23, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(831, 558);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // CheckNumberLabel
            // 
            CheckNumberLabel.Anchor = AnchorStyles.None;
            CheckNumberLabel.AutoSize = true;
            CheckNumberLabel.Location = new Point(364, 0);
            CheckNumberLabel.Name = "CheckNumberLabel";
            CheckNumberLabel.Size = new Size(103, 20);
            CheckNumberLabel.TabIndex = 9;
            CheckNumberLabel.Text = "Check number";
            // 
            // CashierLabel
            // 
            CashierLabel.Anchor = AnchorStyles.None;
            CashierLabel.AutoSize = true;
            CashierLabel.Location = new Point(387, 20);
            CashierLabel.Name = "CashierLabel";
            CashierLabel.Size = new Size(57, 20);
            CashierLabel.TabIndex = 10;
            CashierLabel.Text = "Cashier";
            // 
            // CardNumberLabel
            // 
            CardNumberLabel.Anchor = AnchorStyles.None;
            CardNumberLabel.AutoSize = true;
            CardNumberLabel.Location = new Point(368, 40);
            CardNumberLabel.Name = "CardNumberLabel";
            CardNumberLabel.Size = new Size(95, 20);
            CardNumberLabel.TabIndex = 12;
            CardNumberLabel.Text = "Card number";
            // 
            // PrintDateLabel
            // 
            PrintDateLabel.Anchor = AnchorStyles.None;
            PrintDateLabel.AutoSize = true;
            PrintDateLabel.Location = new Point(379, 60);
            PrintDateLabel.Name = "PrintDateLabel";
            PrintDateLabel.Size = new Size(73, 20);
            PrintDateLabel.TabIndex = 7;
            PrintDateLabel.Text = "Print date";
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.None;
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(394, 80);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(42, 20);
            TotalLabel.TabIndex = 15;
            TotalLabel.Text = "Total";
            // 
            // VATLabel
            // 
            VATLabel.Anchor = AnchorStyles.None;
            VATLabel.AutoSize = true;
            VATLabel.Location = new Point(398, 100);
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
            dataGridView1.Location = new Point(3, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(825, 397);
            dataGridView1.TabIndex = 9;
            // 
            // PrintBtn
            // 
            PrintBtn.Anchor = AnchorStyles.None;
            PrintBtn.Location = new Point(347, 526);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(137, 29);
            PrintBtn.TabIndex = 12;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = true;
            // 
            // CheckInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 600);
            Controls.Add(flowLayoutPanel1);
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
        private Button PrintBtn;
    }
}