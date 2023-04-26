namespace Project_ZLAGODA
{
    partial class AddEditStoreProduct
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
            UPCLabel = new Label();
            UPCTextBox = new TextBox();
            ProductLabel = new Label();
            ProductComboBox = new ComboBox();
            PriceLabel = new Label();
            PriceTextBox = new TextBox();
            QuantityLabel = new Label();
            QuantityTextBox = new TextBox();
            TypeLabel = new Label();
            TypeComboBox = new ComboBox();
            ExpiryDateLabel = new Label();
            ExpiryDateTimePicker = new DateTimePicker();
            AddEditBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(UPCLabel);
            flowLayoutPanel1.Controls.Add(UPCTextBox);
            flowLayoutPanel1.Controls.Add(ProductLabel);
            flowLayoutPanel1.Controls.Add(ProductComboBox);
            flowLayoutPanel1.Controls.Add(PriceLabel);
            flowLayoutPanel1.Controls.Add(PriceTextBox);
            flowLayoutPanel1.Controls.Add(QuantityLabel);
            flowLayoutPanel1.Controls.Add(QuantityTextBox);
            flowLayoutPanel1.Controls.Add(TypeLabel);
            flowLayoutPanel1.Controls.Add(TypeComboBox);
            flowLayoutPanel1.Controls.Add(ExpiryDateLabel);
            flowLayoutPanel1.Controls.Add(ExpiryDateTimePicker);
            flowLayoutPanel1.Controls.Add(AddEditBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(89, 52);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(157, 355);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // UPCLabel
            // 
            UPCLabel.Anchor = AnchorStyles.None;
            UPCLabel.AutoSize = true;
            UPCLabel.Location = new Point(60, 0);
            UPCLabel.Name = "UPCLabel";
            UPCLabel.Size = new Size(36, 20);
            UPCLabel.TabIndex = 7;
            UPCLabel.Text = "UPC";
            // 
            // UPCTextBox
            // 
            UPCTextBox.Anchor = AnchorStyles.None;
            UPCTextBox.Location = new Point(6, 23);
            UPCTextBox.Name = "UPCTextBox";
            UPCTextBox.Size = new Size(145, 27);
            UPCTextBox.TabIndex = 9;
            // 
            // ProductLabel
            // 
            ProductLabel.Anchor = AnchorStyles.None;
            ProductLabel.AutoSize = true;
            ProductLabel.Location = new Point(48, 53);
            ProductLabel.Name = "ProductLabel";
            ProductLabel.Size = new Size(60, 20);
            ProductLabel.TabIndex = 0;
            ProductLabel.Text = "Product";
            // 
            // ProductComboBox
            // 
            ProductComboBox.Anchor = AnchorStyles.None;
            ProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.Location = new Point(3, 76);
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new Size(151, 28);
            ProductComboBox.TabIndex = 7;
            ProductComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.None;
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(58, 107);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(41, 20);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Price";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Anchor = AnchorStyles.None;
            PriceTextBox.Location = new Point(4, 130);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(149, 27);
            PriceTextBox.TabIndex = 10;
            // 
            // QuantityLabel
            // 
            QuantityLabel.Anchor = AnchorStyles.None;
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(46, 160);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(65, 20);
            QuantityLabel.TabIndex = 11;
            QuantityLabel.Text = "Quantity";
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Anchor = AnchorStyles.None;
            QuantityTextBox.Location = new Point(4, 183);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(149, 27);
            QuantityTextBox.TabIndex = 12;
            // 
            // TypeLabel
            // 
            TypeLabel.Anchor = AnchorStyles.None;
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(58, 213);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(40, 20);
            TypeLabel.TabIndex = 8;
            TypeLabel.Text = "Type";
            // 
            // TypeComboBox
            // 
            TypeComboBox.Anchor = AnchorStyles.None;
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Ordinary", "Promotional" });
            TypeComboBox.Location = new Point(3, 236);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(151, 28);
            TypeComboBox.TabIndex = 9;
            // 
            // ExpiryDateLabel
            // 
            ExpiryDateLabel.Anchor = AnchorStyles.None;
            ExpiryDateLabel.AutoSize = true;
            ExpiryDateLabel.Location = new Point(37, 267);
            ExpiryDateLabel.Name = "ExpiryDateLabel";
            ExpiryDateLabel.Size = new Size(83, 20);
            ExpiryDateLabel.TabIndex = 21;
            ExpiryDateLabel.Text = "Expiry date";
            // 
            // ExpiryDateTimePicker
            // 
            ExpiryDateTimePicker.Anchor = AnchorStyles.None;
            ExpiryDateTimePicker.Format = DateTimePickerFormat.Short;
            ExpiryDateTimePicker.Location = new Point(4, 290);
            ExpiryDateTimePicker.Name = "ExpiryDateTimePicker";
            ExpiryDateTimePicker.Size = new Size(148, 27);
            ExpiryDateTimePicker.TabIndex = 22;
            // 
            // AddEditBtn
            // 
            AddEditBtn.Anchor = AnchorStyles.None;
            AddEditBtn.Location = new Point(31, 323);
            AddEditBtn.Name = "AddEditBtn";
            AddEditBtn.Size = new Size(94, 29);
            AddEditBtn.TabIndex = 7;
            AddEditBtn.Text = "Add/Edit";
            AddEditBtn.UseVisualStyleBackColor = true;
            AddEditBtn.Click += AddEditBtn_Click;
            // 
            // AddEditStoreProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "AddEditStoreProduct";
            Text = "AddEditStoreProduct";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label ProductLabel;
        private ComboBox ProductComboBox;
        private Label UPCLabel;
        private TextBox UPCTextBox;
        private Label PriceLabel;
        private TextBox PriceTextBox;
        private Button AddEditBtn;
        private Label QuantityLabel;
        private TextBox QuantityTextBox;
        private Label TypeLabel;
        private ComboBox TypeComboBox;
        private Label ExpiryDateLabel;
        private DateTimePicker ExpiryDateTimePicker;
    }
}