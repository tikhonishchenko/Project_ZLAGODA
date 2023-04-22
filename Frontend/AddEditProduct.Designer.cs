namespace Project_ZLAGODA
{
    partial class AddEditProduct
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
            CategoryLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CategoryComboBox = new ComboBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            CharacteristicsLabel = new Label();
            CharacteristicsTextBox = new TextBox();
            AddEditBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // CategoryLabel
            // 
            CategoryLabel.Anchor = AnchorStyles.None;
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(44, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(69, 20);
            CategoryLabel.TabIndex = 0;
            CategoryLabel.Text = "Category";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(CategoryLabel);
            flowLayoutPanel1.Controls.Add(CategoryComboBox);
            flowLayoutPanel1.Controls.Add(NameLabel);
            flowLayoutPanel1.Controls.Add(NameTextBox);
            flowLayoutPanel1.Controls.Add(CharacteristicsLabel);
            flowLayoutPanel1.Controls.Add(CharacteristicsTextBox);
            flowLayoutPanel1.Controls.Add(AddEditBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(101, 122);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(157, 195);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.None;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(3, 23);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 7;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.None;
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(54, 54);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 7;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.None;
            NameTextBox.Location = new Point(6, 77);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(145, 27);
            NameTextBox.TabIndex = 9;
            // 
            // CharacteristicsLabel
            // 
            CharacteristicsLabel.Anchor = AnchorStyles.None;
            CharacteristicsLabel.AutoSize = true;
            CharacteristicsLabel.Location = new Point(26, 107);
            CharacteristicsLabel.Name = "CharacteristicsLabel";
            CharacteristicsLabel.Size = new Size(104, 20);
            CharacteristicsLabel.TabIndex = 7;
            CharacteristicsLabel.Text = "Characteristics";
            // 
            // CharacteristicsTextBox
            // 
            CharacteristicsTextBox.Anchor = AnchorStyles.None;
            CharacteristicsTextBox.Location = new Point(4, 130);
            CharacteristicsTextBox.Name = "CharacteristicsTextBox";
            CharacteristicsTextBox.Size = new Size(149, 27);
            CharacteristicsTextBox.TabIndex = 10;
            // 
            // AddEditBtn
            // 
            AddEditBtn.Anchor = AnchorStyles.None;
            AddEditBtn.Location = new Point(31, 163);
            AddEditBtn.Name = "AddEditBtn";
            AddEditBtn.Size = new Size(94, 29);
            AddEditBtn.TabIndex = 7;
            AddEditBtn.Text = "Add/Edit";
            AddEditBtn.UseVisualStyleBackColor = true;
            AddEditBtn.Click += AddEditBtn_Click;
            // 
            // AddEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "AddEditProduct";
            Text = "AddEditProduct";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion
        private Label CategoryLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label NameLabel;
        private Label CharacteristicsLabel;
        private Button AddEditBtn;
        private ComboBox CategoryComboBox;
        private TextBox NameTextBox;
        private TextBox CharacteristicsTextBox;
    }
}