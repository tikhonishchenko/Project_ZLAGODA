namespace Project_ZLAGODA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProductsTextBox = new TextBox();
            idTextBox = new TextBox();
            CatTextBox = new TextBox();
            NameTextBox = new TextBox();
            DescTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddProductBtn = new Button();
            UpdateProductsBtn = new Button();
            DeleteProductsBtn = new Button();
            GetProductsBtn = new Button();
            AddSamplesBtn = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            BtnGetProductsSorted = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // ProductsTextBox
            // 
            ProductsTextBox.Location = new Point(1253, 12);
            ProductsTextBox.Multiline = true;
            ProductsTextBox.Name = "ProductsTextBox";
            ProductsTextBox.ScrollBars = ScrollBars.Vertical;
            ProductsTextBox.Size = new Size(644, 865);
            ProductsTextBox.TabIndex = 0;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(124, 12);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(200, 39);
            idTextBox.TabIndex = 1;
            // 
            // CatTextBox
            // 
            CatTextBox.Location = new Point(124, 57);
            CatTextBox.Name = "CatTextBox";
            CatTextBox.Size = new Size(200, 39);
            CatTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(124, 102);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(200, 39);
            NameTextBox.TabIndex = 3;
            // 
            // DescTextBox
            // 
            DescTextBox.Location = new Point(124, 147);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(200, 39);
            DescTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(34, 32);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 6;
            label2.Text = "Cat_num";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 102);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 147);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 8;
            label4.Text = "Desc";
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(10, 206);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(314, 46);
            AddProductBtn.TabIndex = 9;
            AddProductBtn.Text = "Add";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // UpdateProductsBtn
            // 
            UpdateProductsBtn.Location = new Point(10, 258);
            UpdateProductsBtn.Name = "UpdateProductsBtn";
            UpdateProductsBtn.Size = new Size(314, 46);
            UpdateProductsBtn.TabIndex = 10;
            UpdateProductsBtn.Text = "Update";
            UpdateProductsBtn.UseVisualStyleBackColor = true;
            UpdateProductsBtn.Click += UpdateProductsBtn_Click;
            // 
            // DeleteProductsBtn
            // 
            DeleteProductsBtn.Location = new Point(10, 310);
            DeleteProductsBtn.Name = "DeleteProductsBtn";
            DeleteProductsBtn.Size = new Size(314, 46);
            DeleteProductsBtn.TabIndex = 11;
            DeleteProductsBtn.Text = "Delete";
            DeleteProductsBtn.UseVisualStyleBackColor = true;
            DeleteProductsBtn.Click += DeleteProductsBtn_Click;
            // 
            // GetProductsBtn
            // 
            GetProductsBtn.Location = new Point(1253, 883);
            GetProductsBtn.Name = "GetProductsBtn";
            GetProductsBtn.Size = new Size(335, 72);
            GetProductsBtn.TabIndex = 12;
            GetProductsBtn.Text = "get products";
            GetProductsBtn.UseVisualStyleBackColor = true;
            GetProductsBtn.Click += GetProductsBtn_Click;
            // 
            // AddSamplesBtn
            // 
            AddSamplesBtn.Location = new Point(341, 12);
            AddSamplesBtn.Name = "AddSamplesBtn";
            AddSamplesBtn.Size = new Size(150, 92);
            AddSamplesBtn.TabIndex = 13;
            AddSamplesBtn.Text = "Add sample products";
            AddSamplesBtn.UseVisualStyleBackColor = true;
            AddSamplesBtn.Click += AddSamplesBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 592);
            button1.Name = "button1";
            button1.Size = new Size(314, 46);
            button1.TabIndex = 14;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 511);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 39);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 556);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 39);
            textBox2.TabIndex = 16;
            // 
            // BtnGetProductsSorted
            // 
            BtnGetProductsSorted.Location = new Point(1594, 883);
            BtnGetProductsSorted.Name = "BtnGetProductsSorted";
            BtnGetProductsSorted.Size = new Size(303, 72);
            BtnGetProductsSorted.TabIndex = 17;
            BtnGetProductsSorted.Text = "get products sorted";
            BtnGetProductsSorted.UseVisualStyleBackColor = true;
            BtnGetProductsSorted.Click += BtnGetProductsSorted_Click;
            // 
            // button2
            // 
            button2.Location = new Point(10, 896);
            button2.Name = "button2";
            button2.Size = new Size(314, 46);
            button2.TabIndex = 18;
            button2.Text = "Test";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(556, 617);
            button3.Name = "button3";
            button3.Size = new Size(314, 46);
            button3.TabIndex = 19;
            button3.Text = "Add Sale to check";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(556, 669);
            button4.Name = "button4";
            button4.Size = new Size(314, 46);
            button4.TabIndex = 20;
            button4.Text = "Generate check and insert";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 556);
            label6.Name = "label6";
            label6.Size = new Size(106, 32);
            label6.TabIndex = 27;
            label6.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(457, 511);
            label8.Name = "label8";
            label8.Size = new Size(195, 32);
            label8.TabIndex = 25;
            label8.Text = "UPCStoreProduct";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(658, 556);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 23;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(658, 511);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 39);
            textBox6.TabIndex = 21;
            // 
            // button5
            // 
            button5.Location = new Point(10, 644);
            button5.Name = "button5";
            button5.Size = new Size(314, 46);
            button5.TabIndex = 28;
            button5.Text = "Login Default Cashier";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1909, 967);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(textBox6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(BtnGetProductsSorted);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(AddSamplesBtn);
            Controls.Add(GetProductsBtn);
            Controls.Add(DeleteProductsBtn);
            Controls.Add(UpdateProductsBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(CatTextBox);
            Controls.Add(idTextBox);
            Controls.Add(ProductsTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProductsTextBox;
        private TextBox idTextBox;
        private TextBox CatTextBox;
        private TextBox NameTextBox;
        private TextBox DescTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AddProductBtn;
        private Button UpdateProductsBtn;
        private Button DeleteProductsBtn;
        private Button GetProductsBtn;
        private Button AddSamplesBtn;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button BtnGetProductsSorted;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label6;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox6;
        private Button button5;
    }
}