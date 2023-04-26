namespace Project_ZLAGODA.Frontend
{
    partial class ChangePasswordForm
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
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            RepeatPasswordLabel = new Label();
            RepeatPasswordTextBox = new TextBox();
            ChangePasswordBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(PasswordLabel);
            flowLayoutPanel1.Controls.Add(PasswordTextBox);
            flowLayoutPanel1.Controls.Add(RepeatPasswordLabel);
            flowLayoutPanel1.Controls.Add(RepeatPasswordTextBox);
            flowLayoutPanel1.Controls.Add(ChangePasswordBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(140, 18);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(151, 141);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.None;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(40, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 16;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.None;
            PasswordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(3, 23);
            PasswordTextBox.MaxLength = 16;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(145, 27);
            PasswordTextBox.TabIndex = 17;
            // 
            // RepeatPasswordLabel
            // 
            RepeatPasswordLabel.Anchor = AnchorStyles.None;
            RepeatPasswordLabel.AutoSize = true;
            RepeatPasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RepeatPasswordLabel.Location = new Point(14, 53);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(123, 20);
            RepeatPasswordLabel.TabIndex = 18;
            RepeatPasswordLabel.Text = "Repeat password";
            // 
            // RepeatPasswordTextBox
            // 
            RepeatPasswordTextBox.Anchor = AnchorStyles.None;
            RepeatPasswordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RepeatPasswordTextBox.Location = new Point(3, 76);
            RepeatPasswordTextBox.MaxLength = 16;
            RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            RepeatPasswordTextBox.PasswordChar = '*';
            RepeatPasswordTextBox.Size = new Size(145, 27);
            RepeatPasswordTextBox.TabIndex = 19;
            // 
            // ChangePasswordBtn
            // 
            ChangePasswordBtn.Anchor = AnchorStyles.None;
            ChangePasswordBtn.Location = new Point(7, 109);
            ChangePasswordBtn.Name = "ChangePasswordBtn";
            ChangePasswordBtn.Size = new Size(136, 29);
            ChangePasswordBtn.TabIndex = 15;
            ChangePasswordBtn.Text = "Change password";
            ChangePasswordBtn.UseVisualStyleBackColor = true;
            ChangePasswordBtn.Click += ChangePasswordBtn_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 171);
            Controls.Add(flowLayoutPanel1);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label RepeatPasswordLabel;
        private TextBox RepeatPasswordTextBox;
        private Button ChangePasswordBtn;
    }
}