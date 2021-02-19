namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.tbxAddProductUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxAddProductStock = new System.Windows.Forms.TextBox();
            this.tbxAddProductQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.cbxAddCategoryId = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.cbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductStock = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProductDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(13, 161);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(775, 150);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(13, 13);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(775, 62);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(13, 81);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(775, 74);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Ara";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 20);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(7, 33);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(98, 17);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(264, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(98, 30);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(264, 20);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAddProduct);
            this.gbxProductAdd.Controls.Add(this.cbxAddCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductStock);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductName);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblAddProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(13, 318);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(295, 236);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(10, 20);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(48, 13);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Ürün Adı";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(10, 46);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Kategori";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(10, 71);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(10, 96);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(59, 13);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adedi";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(10, 120);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(98, 17);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(179, 20);
            this.tbxAddProductName.TabIndex = 5;
            // 
            // tbxAddProductUnitPrice
            // 
            this.tbxAddProductUnitPrice.Location = new System.Drawing.Point(98, 68);
            this.tbxAddProductUnitPrice.Name = "tbxAddProductUnitPrice";
            this.tbxAddProductUnitPrice.Size = new System.Drawing.Size(179, 20);
            this.tbxAddProductUnitPrice.TabIndex = 6;
            // 
            // tbxAddProductStock
            // 
            this.tbxAddProductStock.Location = new System.Drawing.Point(98, 93);
            this.tbxAddProductStock.Name = "tbxAddProductStock";
            this.tbxAddProductStock.Size = new System.Drawing.Size(179, 20);
            this.tbxAddProductStock.TabIndex = 7;
            // 
            // tbxAddProductQuantityPerUnit
            // 
            this.tbxAddProductQuantityPerUnit.Location = new System.Drawing.Point(98, 117);
            this.tbxAddProductQuantityPerUnit.Name = "tbxAddProductQuantityPerUnit";
            this.tbxAddProductQuantityPerUnit.Size = new System.Drawing.Size(179, 20);
            this.tbxAddProductQuantityPerUnit.TabIndex = 8;
            // 
            // cbxAddCategoryId
            // 
            this.cbxAddCategoryId.FormattingEnabled = true;
            this.cbxAddCategoryId.Location = new System.Drawing.Point(98, 43);
            this.cbxAddCategoryId.Name = "cbxAddCategoryId";
            this.cbxAddCategoryId.Size = new System.Drawing.Size(179, 21);
            this.cbxAddCategoryId.TabIndex = 9;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(98, 144);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(179, 23);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateProduct);
            this.groupBox1.Controls.Add(this.cbxUpdateCategoryId);
            this.groupBox1.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.groupBox1.Controls.Add(this.tbxUpdateProductStock);
            this.groupBox1.Controls.Add(this.tbxUpdateProductUnitPrice);
            this.groupBox1.Controls.Add(this.tbxUpdateProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(314, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 236);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(98, 144);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(179, 23);
            this.btnUpdateProduct.TabIndex = 10;
            this.btnUpdateProduct.Text = "Güncelle";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // cbxUpdateCategoryId
            // 
            this.cbxUpdateCategoryId.FormattingEnabled = true;
            this.cbxUpdateCategoryId.Location = new System.Drawing.Point(98, 43);
            this.cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            this.cbxUpdateCategoryId.Size = new System.Drawing.Size(179, 21);
            this.cbxUpdateCategoryId.TabIndex = 9;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(98, 117);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(179, 20);
            this.tbxUpdateQuantityPerUnit.TabIndex = 8;
            // 
            // tbxUpdateProductStock
            // 
            this.tbxUpdateProductStock.Location = new System.Drawing.Point(98, 93);
            this.tbxUpdateProductStock.Name = "tbxUpdateProductStock";
            this.tbxUpdateProductStock.Size = new System.Drawing.Size(179, 20);
            this.tbxUpdateProductStock.TabIndex = 7;
            // 
            // tbxUpdateProductUnitPrice
            // 
            this.tbxUpdateProductUnitPrice.Location = new System.Drawing.Point(98, 68);
            this.tbxUpdateProductUnitPrice.Name = "tbxUpdateProductUnitPrice";
            this.tbxUpdateProductUnitPrice.Size = new System.Drawing.Size(179, 20);
            this.tbxUpdateProductUnitPrice.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(98, 17);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(179, 20);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Adı";
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(615, 333);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(179, 23);
            this.btnProductDelete.TabIndex = 11;
            this.btnProductDelete.Text = "Sil";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbxAddCategoryId;
        private System.Windows.Forms.TextBox tbxAddProductQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxAddProductStock;
        private System.Windows.Forms.TextBox tbxAddProductUnitPrice;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryId;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateProductStock;
        private System.Windows.Forms.TextBox tbxUpdateProductUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProductDelete;
    }
}

