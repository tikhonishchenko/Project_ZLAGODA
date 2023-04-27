namespace Project_ZLAGODA.Frontend
{
    partial class Query1Form
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
            ProductNameLabel = new Label();
            ProductNameComboBox = new ComboBox();
            ShowBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(ProductNameLabel);
            flowLayoutPanel1.Controls.Add(ProductNameComboBox);
            flowLayoutPanel1.Controls.Add(ShowBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(40, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(405, 89);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.Anchor = AnchorStyles.None;
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(152, 0);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(101, 20);
            ProductNameLabel.TabIndex = 10;
            ProductNameLabel.Text = "Product name";
            ProductNameLabel.Click += ProductNameLabel_Click;
            // 
            // ProductNameComboBox
            // 
            ProductNameComboBox.Anchor = AnchorStyles.None;
            ProductNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductNameComboBox.FormattingEnabled = true;
            ProductNameComboBox.Location = new Point(3, 23);
            ProductNameComboBox.Name = "ProductNameComboBox";
            ProductNameComboBox.Size = new Size(399, 28);
            ProductNameComboBox.TabIndex = 11;
            // 
            // ShowBtn
            // 
            ShowBtn.Anchor = AnchorStyles.None;
            ShowBtn.Location = new Point(155, 57);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(94, 29);
            ShowBtn.TabIndex = 7;
            ShowBtn.Text = "Show";
            ShowBtn.UseVisualStyleBackColor = true;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // Query1Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 196);
            Controls.Add(flowLayoutPanel1);
            Name = "Query1Form";
            Text = "Query1Form";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label ProductNameLabel;
        private ComboBox ProductNameComboBox;
        private Button ShowBtn;
    }
}