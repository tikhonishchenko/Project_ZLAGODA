namespace Project_ZLAGODA.Frontend
{
    partial class AddSaleForm
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
            QuantityLabel = new Label();
            QuantityTextBox = new TextBox();
            AddBtn = new Button();
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
            flowLayoutPanel1.Controls.Add(QuantityLabel);
            flowLayoutPanel1.Controls.Add(QuantityTextBox);
            flowLayoutPanel1.Controls.Add(AddBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(87, 95);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(155, 141);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // UPCLabel
            // 
            UPCLabel.Anchor = AnchorStyles.None;
            UPCLabel.AutoSize = true;
            UPCLabel.Location = new Point(59, 0);
            UPCLabel.Name = "UPCLabel";
            UPCLabel.Size = new Size(36, 20);
            UPCLabel.TabIndex = 7;
            UPCLabel.Text = "UPC";
            // 
            // UPCTextBox
            // 
            UPCTextBox.Anchor = AnchorStyles.None;
            UPCTextBox.Location = new Point(5, 23);
            UPCTextBox.Name = "UPCTextBox";
            UPCTextBox.Size = new Size(145, 27);
            UPCTextBox.TabIndex = 9;
            // 
            // QuantityLabel
            // 
            QuantityLabel.Anchor = AnchorStyles.None;
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(45, 53);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(65, 20);
            QuantityLabel.TabIndex = 7;
            QuantityLabel.Text = "Quantity";
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Anchor = AnchorStyles.None;
            QuantityTextBox.Location = new Point(3, 76);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(149, 27);
            QuantityTextBox.TabIndex = 10;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.None;
            AddBtn.Location = new Point(30, 109);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AddSaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 326);
            Controls.Add(flowLayoutPanel1);
            Name = "AddSaleForm";
            Text = "AddSaleForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label UPCLabel;
        private TextBox UPCTextBox;
        private Label QuantityLabel;
        private TextBox QuantityTextBox;
        private Button AddBtn;
    }
}