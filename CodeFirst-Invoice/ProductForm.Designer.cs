namespace CodeFirst_Invoice
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.grbProduct = new System.Windows.Forms.GroupBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnProductMultipleDelete = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.grbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProduct
            // 
            this.grbProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbProduct.BackColor = System.Drawing.SystemColors.Control;
            this.grbProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbProduct.Controls.Add(this.lblUnitPrice);
            this.grbProduct.Controls.Add(this.lblProductCode);
            this.grbProduct.Controls.Add(this.txtUnitPrice);
            this.grbProduct.Controls.Add(this.txtProductCode);
            this.grbProduct.Controls.Add(this.cbUnit);
            this.grbProduct.Controls.Add(this.lblCounty);
            this.grbProduct.Controls.Add(this.dgvProduct);
            this.grbProduct.Controls.Add(this.btnProductMultipleDelete);
            this.grbProduct.Controls.Add(this.btnProductUpdate);
            this.grbProduct.Controls.Add(this.btnProductDelete);
            this.grbProduct.Controls.Add(this.btnProductAdd);
            this.grbProduct.Controls.Add(this.txtProductName);
            this.grbProduct.Controls.Add(this.lblUnitName);
            this.grbProduct.Location = new System.Drawing.Point(114, 84);
            this.grbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.grbProduct.Name = "grbProduct";
            this.grbProduct.Padding = new System.Windows.Forms.Padding(2);
            this.grbProduct.Size = new System.Drawing.Size(704, 493);
            this.grbProduct.TabIndex = 2;
            this.grbProduct.TabStop = false;
            this.grbProduct.Text = "Product Operations";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(50, 150);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(59, 13);
            this.lblUnitPrice.TabIndex = 11;
            this.lblUnitPrice.Text = "Unit Price :";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(50, 73);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(75, 13);
            this.lblProductCode.TabIndex = 10;
            this.lblProductCode.Text = "Product Code:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(128, 148);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(120, 20);
            this.txtUnitPrice.TabIndex = 4;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(127, 71);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(120, 20);
            this.txtProductCode.TabIndex = 2;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(128, 110);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(120, 21);
            this.cbUnit.TabIndex = 3;
            this.cbUnit.TextChanged += new System.EventHandler(this.cbUnit_TextChanged);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(50, 37);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(78, 13);
            this.lblCounty.TabIndex = 7;
            this.lblCounty.Text = "Product Name:";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(-14, 268);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(685, 225);
            this.dgvProduct.TabIndex = 9;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // btnProductMultipleDelete
            // 
            this.btnProductMultipleDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_view_40;
            this.btnProductMultipleDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductMultipleDelete.Location = new System.Drawing.Point(340, 202);
            this.btnProductMultipleDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductMultipleDelete.Name = "btnProductMultipleDelete";
            this.btnProductMultipleDelete.Size = new System.Drawing.Size(63, 50);
            this.btnProductMultipleDelete.TabIndex = 8;
            this.btnProductMultipleDelete.UseVisualStyleBackColor = true;
            this.btnProductMultipleDelete.Click += new System.EventHandler(this.btnProductMultipleDelete_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_edit_48;
            this.btnProductUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductUpdate.Location = new System.Drawing.Point(267, 202);
            this.btnProductUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(69, 50);
            this.btnProductUpdate.TabIndex = 7;
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_48;
            this.btnProductDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductDelete.Location = new System.Drawing.Point(192, 202);
            this.btnProductDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(70, 50);
            this.btnProductDelete.TabIndex = 6;
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_plus_48;
            this.btnProductAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductAdd.Location = new System.Drawing.Point(128, 202);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(59, 50);
            this.btnProductAdd.TabIndex = 5;
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(128, 37);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(120, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(50, 110);
            this.lblUnitName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(60, 13);
            this.lblUnitName.TabIndex = 0;
            this.lblUnitName.Text = "Unit Name:";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 599);
            this.Controls.Add(this.grbProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.grbProduct.ResumeLayout(false);
            this.grbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProduct;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnProductMultipleDelete;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblUnitName;
    }
}