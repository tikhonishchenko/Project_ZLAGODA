namespace Project_ZLAGODA
{
    partial class AddProduct
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
            IdLabel = new Label();
            AddBtn = new Button();
            IdTextBox = new TextBox();
            CategoryIdTextBox = new TextBox();
            label1 = new Label();
            NameTextBox = new TextBox();
            label2 = new Label();
            CharacteristicsTextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(352, 45);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(22, 20);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "Id";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(311, 292);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(302, 68);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 2;
            // 
            // CategoryIdTextBox
            // 
            CategoryIdTextBox.Location = new Point(302, 135);
            CategoryIdTextBox.Name = "CategoryIdTextBox";
            CategoryIdTextBox.Size = new Size(125, 27);
            CategoryIdTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 112);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 3;
            label1.Text = "Category Id";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(302, 199);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 176);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // CharacteristicsTextBox
            // 
            CharacteristicsTextBox.Location = new Point(302, 259);
            CharacteristicsTextBox.Name = "CharacteristicsTextBox";
            CharacteristicsTextBox.Size = new Size(125, 27);
            CharacteristicsTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 236);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 7;
            label3.Text = "Characteristics";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CharacteristicsTextBox);
            Controls.Add(label3);
            Controls.Add(NameTextBox);
            Controls.Add(label2);
            Controls.Add(CategoryIdTextBox);
            Controls.Add(label1);
            Controls.Add(IdTextBox);
            Controls.Add(AddBtn);
            Controls.Add(IdLabel);
            Name = "AddProduct";
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdLabel;
        private Button AddBtn;
        private TextBox IdTextBox;
        private TextBox CategoryIdTextBox;
        private Label label1;
        private TextBox NameTextBox;
        private Label label2;
        private TextBox CharacteristicsTextBox;
        private Label label3;
    }
}