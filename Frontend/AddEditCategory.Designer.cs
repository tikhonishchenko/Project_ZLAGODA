namespace Project_ZLAGODA
{
    partial class AddEditCategory
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
            NameLabel = new Label();
            NameTextBox = new TextBox();
            AddEditBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(NameLabel);
            flowLayoutPanel1.Controls.Add(NameTextBox);
            flowLayoutPanel1.Controls.Add(AddEditBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(58, 31);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(151, 88);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.None;
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(51, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 7;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.None;
            NameTextBox.Location = new Point(3, 23);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(145, 27);
            NameTextBox.TabIndex = 9;
            // 
            // AddEditBtn
            // 
            AddEditBtn.Anchor = AnchorStyles.None;
            AddEditBtn.Location = new Point(28, 56);
            AddEditBtn.Name = "AddEditBtn";
            AddEditBtn.Size = new Size(94, 29);
            AddEditBtn.TabIndex = 7;
            AddEditBtn.Text = "Add/Edit";
            AddEditBtn.UseVisualStyleBackColor = true;
            AddEditBtn.Click += AddEditBtn_Click;
            // 
            // AddEditCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 170);
            Controls.Add(flowLayoutPanel1);
            Name = "AddEditCategory";
            Text = "AddEditCategory";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button AddEditBtn;
    }
}