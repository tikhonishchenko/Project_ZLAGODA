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
            this.ProductsTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.CatTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.UpdateProductsBtn = new System.Windows.Forms.Button();
            this.DeleteProductsBtn = new System.Windows.Forms.Button();
            this.GetProductsBtn = new System.Windows.Forms.Button();
            this.AddSamplesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductsTextBox
            // 
            this.ProductsTextBox.Location = new System.Drawing.Point(1253, 12);
            this.ProductsTextBox.Multiline = true;
            this.ProductsTextBox.Name = "ProductsTextBox";
            this.ProductsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductsTextBox.Size = new System.Drawing.Size(644, 865);
            this.ProductsTextBox.TabIndex = 0;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(124, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 39);
            this.idTextBox.TabIndex = 1;
            // 
            // CatTextBox
            // 
            this.CatTextBox.Location = new System.Drawing.Point(124, 57);
            this.CatTextBox.Name = "CatTextBox";
            this.CatTextBox.Size = new System.Drawing.Size(200, 39);
            this.CatTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(124, 102);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 39);
            this.NameTextBox.TabIndex = 3;
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(124, 147);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(200, 39);
            this.DescTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cat_num";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Desc";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(10, 206);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(314, 46);
            this.AddProductBtn.TabIndex = 9;
            this.AddProductBtn.Text = "Add";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // UpdateProductsBtn
            // 
            this.UpdateProductsBtn.Location = new System.Drawing.Point(10, 258);
            this.UpdateProductsBtn.Name = "UpdateProductsBtn";
            this.UpdateProductsBtn.Size = new System.Drawing.Size(314, 46);
            this.UpdateProductsBtn.TabIndex = 10;
            this.UpdateProductsBtn.Text = "Update";
            this.UpdateProductsBtn.UseVisualStyleBackColor = true;
            this.UpdateProductsBtn.Click += new System.EventHandler(this.UpdateProductsBtn_Click);
            // 
            // DeleteProductsBtn
            // 
            this.DeleteProductsBtn.Location = new System.Drawing.Point(10, 310);
            this.DeleteProductsBtn.Name = "DeleteProductsBtn";
            this.DeleteProductsBtn.Size = new System.Drawing.Size(314, 46);
            this.DeleteProductsBtn.TabIndex = 11;
            this.DeleteProductsBtn.Text = "Delete";
            this.DeleteProductsBtn.UseVisualStyleBackColor = true;
            this.DeleteProductsBtn.Click += new System.EventHandler(this.DeleteProductsBtn_Click);
            // 
            // GetProductsBtn
            // 
            this.GetProductsBtn.Location = new System.Drawing.Point(1253, 883);
            this.GetProductsBtn.Name = "GetProductsBtn";
            this.GetProductsBtn.Size = new System.Drawing.Size(644, 72);
            this.GetProductsBtn.TabIndex = 12;
            this.GetProductsBtn.Text = "get products";
            this.GetProductsBtn.UseVisualStyleBackColor = true;
            this.GetProductsBtn.Click += new System.EventHandler(this.GetProductsBtn_Click);
            // 
            // AddSamplesBtn
            // 
            this.AddSamplesBtn.Location = new System.Drawing.Point(341, 12);
            this.AddSamplesBtn.Name = "AddSamplesBtn";
            this.AddSamplesBtn.Size = new System.Drawing.Size(150, 92);
            this.AddSamplesBtn.TabIndex = 13;
            this.AddSamplesBtn.Text = "Add sample products";
            this.AddSamplesBtn.UseVisualStyleBackColor = true;
            this.AddSamplesBtn.Click += new System.EventHandler(this.AddSamplesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 967);
            this.Controls.Add(this.AddSamplesBtn);
            this.Controls.Add(this.GetProductsBtn);
            this.Controls.Add(this.DeleteProductsBtn);
            this.Controls.Add(this.UpdateProductsBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CatTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.ProductsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}