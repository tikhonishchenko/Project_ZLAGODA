namespace Project_ZLAGODA
{
    partial class AddEditCustomer
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
            CardNumberLabel = new Label();
            CardNumberTextBox = new TextBox();
            NameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameLabel = new Label();
            SecondNameTextBox = new TextBox();
            PatronymicLabel = new Label();
            PatronymicTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            AddressLabel = new Label();
            AddressTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            ZipCodeLabel = new Label();
            ZipCodeTextBox = new TextBox();
            DiscountLabel = new Label();
            DiscountTextBox = new NumericUpDown();
            AddEditBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiscountTextBox).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(CardNumberLabel);
            flowLayoutPanel1.Controls.Add(CardNumberTextBox);
            flowLayoutPanel1.Controls.Add(NameLabel);
            flowLayoutPanel1.Controls.Add(FirstNameTextBox);
            flowLayoutPanel1.Controls.Add(LastNameLabel);
            flowLayoutPanel1.Controls.Add(SecondNameTextBox);
            flowLayoutPanel1.Controls.Add(PatronymicLabel);
            flowLayoutPanel1.Controls.Add(PatronymicTextBox);
            flowLayoutPanel1.Controls.Add(PhoneNumberLabel);
            flowLayoutPanel1.Controls.Add(PhoneNumberTextBox);
            flowLayoutPanel1.Controls.Add(AddressLabel);
            flowLayoutPanel1.Controls.Add(AddressTextBox);
            flowLayoutPanel1.Controls.Add(CityLabel);
            flowLayoutPanel1.Controls.Add(CityTextBox);
            flowLayoutPanel1.Controls.Add(ZipCodeLabel);
            flowLayoutPanel1.Controls.Add(ZipCodeTextBox);
            flowLayoutPanel1.Controls.Add(DiscountLabel);
            flowLayoutPanel1.Controls.Add(DiscountTextBox);
            flowLayoutPanel1.Controls.Add(AddEditBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(173, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(156, 512);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // CardNumberLabel
            // 
            CardNumberLabel.Anchor = AnchorStyles.None;
            CardNumberLabel.AutoSize = true;
            CardNumberLabel.Location = new Point(30, 0);
            CardNumberLabel.Name = "CardNumberLabel";
            CardNumberLabel.Size = new Size(95, 20);
            CardNumberLabel.TabIndex = 10;
            CardNumberLabel.Text = "Card number";
            // 
            // CardNumberTextBox
            // 
            CardNumberTextBox.Anchor = AnchorStyles.None;
            CardNumberTextBox.Location = new Point(5, 23);
            CardNumberTextBox.MaxLength = 13;
            CardNumberTextBox.Name = "CardNumberTextBox";
            CardNumberTextBox.Size = new Size(145, 27);
            CardNumberTextBox.TabIndex = 11;
            CardNumberTextBox.TextChanged += CardNumberTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.None;
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(39, 53);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(77, 20);
            NameLabel.TabIndex = 7;
            NameLabel.Text = "First name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Anchor = AnchorStyles.None;
            FirstNameTextBox.Location = new Point(5, 76);
            FirstNameTextBox.MaxLength = 50;
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(145, 27);
            FirstNameTextBox.TabIndex = 9;
            // 
            // LastNameLabel
            // 
            LastNameLabel.Anchor = AnchorStyles.None;
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(40, 106);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(76, 20);
            LastNameLabel.TabIndex = 10;
            LastNameLabel.Text = "Last name";
            // 
            // SecondNameTextBox
            // 
            SecondNameTextBox.Anchor = AnchorStyles.None;
            SecondNameTextBox.Location = new Point(5, 129);
            SecondNameTextBox.MaxLength = 50;
            SecondNameTextBox.Name = "SecondNameTextBox";
            SecondNameTextBox.Size = new Size(145, 27);
            SecondNameTextBox.TabIndex = 11;
            // 
            // PatronymicLabel
            // 
            PatronymicLabel.Anchor = AnchorStyles.None;
            PatronymicLabel.AutoSize = true;
            PatronymicLabel.Location = new Point(37, 159);
            PatronymicLabel.Name = "PatronymicLabel";
            PatronymicLabel.Size = new Size(82, 20);
            PatronymicLabel.TabIndex = 10;
            PatronymicLabel.Text = "Patronymic";
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Anchor = AnchorStyles.None;
            PatronymicTextBox.Location = new Point(5, 182);
            PatronymicTextBox.MaxLength = 50;
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(145, 27);
            PatronymicTextBox.TabIndex = 11;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.Anchor = AnchorStyles.None;
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(25, 212);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(105, 20);
            PhoneNumberLabel.TabIndex = 12;
            PhoneNumberLabel.Text = "Phone number";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Anchor = AnchorStyles.None;
            PhoneNumberTextBox.Location = new Point(5, 235);
            PhoneNumberTextBox.MaxLength = 13;
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(145, 27);
            PhoneNumberTextBox.TabIndex = 13;
            PhoneNumberTextBox.TextChanged += PhoneNumberTextBox_TextChanged;
            // 
            // AddressLabel
            // 
            AddressLabel.Anchor = AnchorStyles.None;
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(47, 265);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(62, 20);
            AddressLabel.TabIndex = 18;
            AddressLabel.Text = "Address";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.None;
            AddressTextBox.Location = new Point(5, 288);
            AddressTextBox.MaxLength = 50;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(145, 27);
            AddressTextBox.TabIndex = 19;
            // 
            // CityLabel
            // 
            CityLabel.Anchor = AnchorStyles.None;
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(61, 318);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 16;
            CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.None;
            CityTextBox.Location = new Point(5, 341);
            CityTextBox.MaxLength = 50;
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(145, 27);
            CityTextBox.TabIndex = 17;
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.Anchor = AnchorStyles.None;
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(44, 371);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(68, 20);
            ZipCodeLabel.TabIndex = 14;
            ZipCodeLabel.Text = "Zip code";
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.Anchor = AnchorStyles.None;
            ZipCodeTextBox.Location = new Point(5, 394);
            ZipCodeTextBox.MaxLength = 9;
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(145, 27);
            ZipCodeTextBox.TabIndex = 15;
            ZipCodeTextBox.TextChanged += ZipCodeTextBox_TextChanged;
            // 
            // DiscountLabel
            // 
            DiscountLabel.Anchor = AnchorStyles.None;
            DiscountLabel.AutoSize = true;
            DiscountLabel.Location = new Point(44, 424);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(67, 20);
            DiscountLabel.TabIndex = 12;
            DiscountLabel.Text = "Discount";
            // 
            // DiscountTextBox
            // 
            DiscountTextBox.Location = new Point(3, 447);
            DiscountTextBox.Name = "DiscountTextBox";
            DiscountTextBox.Size = new Size(150, 27);
            DiscountTextBox.TabIndex = 8;
            // 
            // AddEditBtn
            // 
            AddEditBtn.Anchor = AnchorStyles.None;
            AddEditBtn.Location = new Point(31, 480);
            AddEditBtn.Name = "AddEditBtn";
            AddEditBtn.Size = new Size(94, 29);
            AddEditBtn.TabIndex = 7;
            AddEditBtn.Text = "Add/Edit";
            AddEditBtn.UseVisualStyleBackColor = true;
            AddEditBtn.Click += AddEditBtn_Click;
            // 
            // AddEditCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 527);
            Controls.Add(flowLayoutPanel1);
            Name = "AddEditCustomer";
            Text = "AddEditCustomer";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiscountTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label CardNumberLabel;
        private TextBox CardNumberTextBox;
        private Label NameLabel;
        private TextBox FirstNameTextBox;
        private Label LastNameLabel;
        private TextBox SecondNameTextBox;
        private Label PatronymicLabel;
        private TextBox PatronymicTextBox;
        private Label AddressLabel;
        private TextBox AddressTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private Label ZipCodeLabel;
        private TextBox ZipCodeTextBox;
        private Label DiscountLabel;
        private Button AddEditBtn;
        private Label PhoneNumberLabel;
        private TextBox PhoneNumberTextBox;
        private NumericUpDown DiscountTextBox;
    }
}