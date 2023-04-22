namespace Project_ZLAGODA
{
    partial class AuthorizationForm
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
            LoginBtn = new Button();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameTextbox = new TextBox();
            PasswordTextbox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.None;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.Location = new Point(14, 139);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(164, 52);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Log in";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = AnchorStyles.None;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(46, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(99, 28);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            UsernameLabel.Click += UsernameLabel_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.None;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(49, 68);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(93, 28);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Anchor = AnchorStyles.None;
            UsernameTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTextbox.Location = new Point(3, 31);
            UsernameTextbox.MaxLength = 16;
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(186, 34);
            UsernameTextbox.TabIndex = 3;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Anchor = AnchorStyles.None;
            PasswordTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextbox.Location = new Point(3, 99);
            PasswordTextbox.MaxLength = 16;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.PasswordChar = '*';
            PasswordTextbox.Size = new Size(185, 34);
            PasswordTextbox.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(UsernameLabel);
            flowLayoutPanel1.Controls.Add(UsernameTextbox);
            flowLayoutPanel1.Controls.Add(PasswordLabel);
            flowLayoutPanel1.Controls.Add(PasswordTextbox);
            flowLayoutPanel1.Controls.Add(LoginBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(312, 109);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(192, 194);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authorization";
            Load += Form2_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox UsernameTextbox;
        private TextBox PasswordTextbox;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}