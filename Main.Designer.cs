
namespace Trang_Granville
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchPart = new System.Windows.Forms.Button();
            this.searchProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addPart = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.searchPartValue = new System.Windows.Forms.TextBox();
            this.searchProductValue = new System.Windows.Forms.TextBox();
            this.DataGridViewPart = new System.Windows.Forms.DataGridView();
            this.DataGridViewProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // searchPart
            // 
            this.searchPart.Location = new System.Drawing.Point(270, 58);
            this.searchPart.Name = "searchPart";
            this.searchPart.Size = new System.Drawing.Size(75, 23);
            this.searchPart.TabIndex = 1;
            this.searchPart.Text = "Search";
            this.searchPart.UseVisualStyleBackColor = true;
            this.searchPart.Click += new System.EventHandler(this.searchPart_Click);
            // 
            // searchProduct
            // 
            this.searchProduct.Location = new System.Drawing.Point(909, 60);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(75, 23);
            this.searchProduct.TabIndex = 2;
            this.searchProduct.Text = "Search";
            this.searchProduct.UseVisualStyleBackColor = true;
            this.searchProduct.Click += new System.EventHandler(this.searchProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(717, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products";
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(347, 474);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(75, 23);
            this.addPart.TabIndex = 5;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(454, 474);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(75, 23);
            this.modifyPart.TabIndex = 6;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(561, 474);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 23);
            this.deletePart.TabIndex = 7;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(983, 474);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 8;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(1091, 474);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(75, 23);
            this.modifyProduct.TabIndex = 9;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(1195, 474);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.deleteProduct.TabIndex = 10;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1195, 521);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // searchPartValue
            // 
            this.searchPartValue.Location = new System.Drawing.Point(363, 60);
            this.searchPartValue.Name = "searchPartValue";
            this.searchPartValue.Size = new System.Drawing.Size(273, 20);
            this.searchPartValue.TabIndex = 12;
            // 
            // searchProductValue
            // 
            this.searchProductValue.Location = new System.Drawing.Point(1007, 62);
            this.searchProductValue.Name = "searchProductValue";
            this.searchProductValue.Size = new System.Drawing.Size(263, 20);
            this.searchProductValue.TabIndex = 13;
            // 
            // DataGridViewPart
            // 
            this.DataGridViewPart.AllowUserToAddRows = false;
            this.DataGridViewPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPart.Location = new System.Drawing.Point(36, 100);
            this.DataGridViewPart.Name = "DataGridViewPart";
            this.DataGridViewPart.RowHeadersVisible = false;
            this.DataGridViewPart.Size = new System.Drawing.Size(600, 354);
            this.DataGridViewPart.TabIndex = 14;
            this.DataGridViewPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPart_CellClick_1);
            // 
            // DataGridViewProduct
            // 
            this.DataGridViewProduct.AllowUserToAddRows = false;
            this.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProduct.Location = new System.Drawing.Point(683, 100);
            this.DataGridViewProduct.Name = "DataGridViewProduct";
            this.DataGridViewProduct.RowHeadersVisible = false;
            this.DataGridViewProduct.Size = new System.Drawing.Size(587, 354);
            this.DataGridViewProduct.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 556);
            this.Controls.Add(this.DataGridViewProduct);
            this.Controls.Add(this.DataGridViewPart);
            this.Controls.Add(this.searchProductValue);
            this.Controls.Add(this.searchPartValue);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.modifyPart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.searchPart);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchPart;
        private System.Windows.Forms.Button searchProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox searchPartValue;
        private System.Windows.Forms.TextBox searchProductValue;
        private System.Windows.Forms.DataGridView DataGridViewPart;
        private System.Windows.Forms.DataGridView DataGridViewProduct;
    }
}