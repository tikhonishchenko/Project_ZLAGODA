namespace Project_ZLAGODA
{
    partial class SearchForm
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
            QueryComboBox = new ComboBox();
            SecondNameLabel = new Label();
            SecondNameComboBox = new ComboBox();
            DiscountLabel = new Label();
            DiscountTextBox = new TextBox();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            UPCLabel = new Label();
            UPCTextBox = new TextBox();
            SellerLabel = new Label();
            SellerComboBox = new ComboBox();
            StartDateLabel = new Label();
            StartDateTimePicker = new DateTimePicker();
            EndDateLabel = new Label();
            EndDateTimePicker = new DateTimePicker();
            ShowBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(QueryComboBox);
            flowLayoutPanel1.Controls.Add(SecondNameLabel);
            flowLayoutPanel1.Controls.Add(SecondNameComboBox);
            flowLayoutPanel1.Controls.Add(DiscountLabel);
            flowLayoutPanel1.Controls.Add(DiscountTextBox);
            flowLayoutPanel1.Controls.Add(CategoryLabel);
            flowLayoutPanel1.Controls.Add(CategoryComboBox);
            flowLayoutPanel1.Controls.Add(UPCLabel);
            flowLayoutPanel1.Controls.Add(UPCTextBox);
            flowLayoutPanel1.Controls.Add(SellerLabel);
            flowLayoutPanel1.Controls.Add(SellerComboBox);
            flowLayoutPanel1.Controls.Add(StartDateLabel);
            flowLayoutPanel1.Controls.Add(StartDateTimePicker);
            flowLayoutPanel1.Controls.Add(EndDateLabel);
            flowLayoutPanel1.Controls.Add(EndDateTimePicker);
            flowLayoutPanel1.Controls.Add(ShowBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(215, 31);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(405, 443);
            flowLayoutPanel1.TabIndex = 7;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // QueryComboBox
            // 
            QueryComboBox.Anchor = AnchorStyles.None;
            QueryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            QueryComboBox.FormattingEnabled = true;
            QueryComboBox.Items.AddRange(new object[] { "телефон та адреса працівників за прізвищем", "постійні клієнти із певним відсотком (за прізвищем)", "товарів за категорією (за назвою)", "товар за UPC", "акційні товари (за кількістю)", "акційні товари (за назвою)", "не акційні товари (за кількістю)", "не акційні товари (за назвою)", "чеки за касиром, за період часу", "чеки за період часу", "сума проданих товарів за касиром, за період часу", "сума проданих товарів за період часу", "кількість проданого певного товару за період часу" });
            QueryComboBox.Location = new Point(3, 3);
            QueryComboBox.Name = "QueryComboBox";
            QueryComboBox.Size = new Size(399, 28);
            QueryComboBox.TabIndex = 7;
            QueryComboBox.SelectedIndexChanged += QueryComboBox_SelectedIndexChanged;
            // 
            // SecondNameLabel
            // 
            SecondNameLabel.Anchor = AnchorStyles.None;
            SecondNameLabel.AutoSize = true;
            SecondNameLabel.Location = new Point(153, 34);
            SecondNameLabel.Name = "SecondNameLabel";
            SecondNameLabel.Size = new Size(99, 20);
            SecondNameLabel.TabIndex = 10;
            SecondNameLabel.Text = "Second name";
            // 
            // SecondNameComboBox
            // 
            SecondNameComboBox.Anchor = AnchorStyles.None;
            SecondNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SecondNameComboBox.FormattingEnabled = true;
            SecondNameComboBox.Location = new Point(4, 57);
            SecondNameComboBox.Name = "SecondNameComboBox";
            SecondNameComboBox.Size = new Size(397, 28);
            SecondNameComboBox.TabIndex = 11;
            // 
            // DiscountLabel
            // 
            DiscountLabel.Anchor = AnchorStyles.None;
            DiscountLabel.AutoSize = true;
            DiscountLabel.Location = new Point(169, 88);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(67, 20);
            DiscountLabel.TabIndex = 14;
            DiscountLabel.Text = "Discount";
            // 
            // DiscountTextBox
            // 
            DiscountTextBox.Anchor = AnchorStyles.None;
            DiscountTextBox.Location = new Point(3, 111);
            DiscountTextBox.Name = "DiscountTextBox";
            DiscountTextBox.Size = new Size(398, 27);
            DiscountTextBox.TabIndex = 15;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Anchor = AnchorStyles.None;
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(168, 141);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(69, 20);
            CategoryLabel.TabIndex = 8;
            CategoryLabel.Text = "Category";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.None;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(3, 164);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(399, 28);
            CategoryComboBox.TabIndex = 9;
            // 
            // UPCLabel
            // 
            UPCLabel.Anchor = AnchorStyles.None;
            UPCLabel.AutoSize = true;
            UPCLabel.Location = new Point(184, 195);
            UPCLabel.Name = "UPCLabel";
            UPCLabel.Size = new Size(36, 20);
            UPCLabel.TabIndex = 10;
            UPCLabel.Text = "UPC";
            // 
            // UPCTextBox
            // 
            UPCTextBox.Anchor = AnchorStyles.None;
            UPCTextBox.Location = new Point(3, 218);
            UPCTextBox.Name = "UPCTextBox";
            UPCTextBox.Size = new Size(399, 27);
            UPCTextBox.TabIndex = 11;
            // 
            // SellerLabel
            // 
            SellerLabel.Anchor = AnchorStyles.None;
            SellerLabel.AutoSize = true;
            SellerLabel.Location = new Point(179, 248);
            SellerLabel.Name = "SellerLabel";
            SellerLabel.Size = new Size(46, 20);
            SellerLabel.TabIndex = 10;
            SellerLabel.Text = "Seller";
            // 
            // SellerComboBox
            // 
            SellerComboBox.Anchor = AnchorStyles.None;
            SellerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SellerComboBox.FormattingEnabled = true;
            SellerComboBox.Location = new Point(3, 271);
            SellerComboBox.Name = "SellerComboBox";
            SellerComboBox.Size = new Size(399, 28);
            SellerComboBox.TabIndex = 11;
            // 
            // StartDateLabel
            // 
            StartDateLabel.Anchor = AnchorStyles.None;
            StartDateLabel.AutoSize = true;
            StartDateLabel.Location = new Point(165, 302);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new Size(74, 20);
            StartDateLabel.TabIndex = 21;
            StartDateLabel.Text = "Start date";
            // 
            // StartDateTimePicker
            // 
            StartDateTimePicker.Anchor = AnchorStyles.None;
            StartDateTimePicker.Location = new Point(3, 325);
            StartDateTimePicker.Name = "StartDateTimePicker";
            StartDateTimePicker.Size = new Size(399, 27);
            StartDateTimePicker.TabIndex = 22;
            // 
            // EndDateLabel
            // 
            EndDateLabel.Anchor = AnchorStyles.None;
            EndDateLabel.AutoSize = true;
            EndDateLabel.Location = new Point(168, 355);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.Size = new Size(68, 20);
            EndDateLabel.TabIndex = 21;
            EndDateLabel.Text = "End date";
            // 
            // EndDateTimePicker
            // 
            EndDateTimePicker.Anchor = AnchorStyles.None;
            EndDateTimePicker.Location = new Point(3, 378);
            EndDateTimePicker.Name = "EndDateTimePicker";
            EndDateTimePicker.Size = new Size(399, 27);
            EndDateTimePicker.TabIndex = 22;
            // 
            // ShowBtn
            // 
            ShowBtn.Anchor = AnchorStyles.None;
            ShowBtn.Location = new Point(155, 411);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(94, 29);
            ShowBtn.TabIndex = 7;
            ShowBtn.Text = "Show";
            ShowBtn.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 497);
            Controls.Add(flowLayoutPanel1);
            Name = "SearchForm";
            Text = "SearchForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox QueryComboBox;
        private Button ShowBtn;
        private Label SecondNameLabel;
        private ComboBox SecondNameComboBox;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Label DiscountLabel;
        private TextBox DiscountTextBox;
        private Label UPCLabel;
        private TextBox UPCTextBox;
        private Label SellerLabel;
        private ComboBox SellerComboBox;
        private Label StartDateLabel;
        private DateTimePicker StartDateTimePicker;
        private Label EndDateLabel;
        private DateTimePicker EndDateTimePicker;
    }
}