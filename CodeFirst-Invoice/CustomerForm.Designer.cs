namespace CodeFirst_Invoice
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.grbCustomer = new System.Windows.Forms.GroupBox();
            this.cbCustomerCity = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.cbCustomerCounty = new System.Windows.Forms.ComboBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnCustomerMultipleDelete = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerCounty = new System.Windows.Forms.Label();
            this.grbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCustomer
            // 
            this.grbCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.grbCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbCustomer.Controls.Add(this.cbCustomerCity);
            this.grbCustomer.Controls.Add(this.lblAddress);
            this.grbCustomer.Controls.Add(this.lblCustomerCity);
            this.grbCustomer.Controls.Add(this.txtCustomerAddress);
            this.grbCustomer.Controls.Add(this.cbCustomerCounty);
            this.grbCustomer.Controls.Add(this.lblCounty);
            this.grbCustomer.Controls.Add(this.dgvCustomer);
            this.grbCustomer.Controls.Add(this.btnCustomerMultipleDelete);
            this.grbCustomer.Controls.Add(this.btnCustomerUpdate);
            this.grbCustomer.Controls.Add(this.btnCustomerDelete);
            this.grbCustomer.Controls.Add(this.btnCustomerAdd);
            this.grbCustomer.Controls.Add(this.txtCustomerName);
            this.grbCustomer.Controls.Add(this.lblCustomerCounty);
            this.grbCustomer.Location = new System.Drawing.Point(122, 50);
            this.grbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.grbCustomer.Name = "grbCustomer";
            this.grbCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.grbCustomer.Size = new System.Drawing.Size(704, 493);
            this.grbCustomer.TabIndex = 3;
            this.grbCustomer.TabStop = false;
            this.grbCustomer.Text = "Customer Operations";
            // 
            // cbCustomerCity
            // 
            this.cbCustomerCity.FormattingEnabled = true;
            this.cbCustomerCity.Location = new System.Drawing.Point(128, 73);
            this.cbCustomerCity.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomerCity.Name = "cbCustomerCity";
            this.cbCustomerCity.Size = new System.Drawing.Size(120, 21);
            this.cbCustomerCity.TabIndex = 12;
            this.cbCustomerCity.TextChanged += new System.EventHandler(this.cbCustomerCity_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(28, 148);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address:";
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Location = new System.Drawing.Point(28, 73);
            this.lblCustomerCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(74, 13);
            this.lblCustomerCity.TabIndex = 10;
            this.lblCustomerCity.Text = "Customer City:";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(128, 148);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(120, 20);
            this.txtCustomerAddress.TabIndex = 4;
            // 
            // cbCustomerCounty
            // 
            this.cbCustomerCounty.FormattingEnabled = true;
            this.cbCustomerCounty.Location = new System.Drawing.Point(128, 110);
            this.cbCustomerCounty.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomerCounty.Name = "cbCustomerCounty";
            this.cbCustomerCounty.Size = new System.Drawing.Size(120, 21);
            this.cbCustomerCounty.TabIndex = 3;
            this.cbCustomerCounty.TextChanged += new System.EventHandler(this.cbCustomerCounty_TextChanged);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(28, 37);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(85, 13);
            this.lblCounty.TabIndex = 7;
            this.lblCounty.Text = "Customer Name:";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(-14, 268);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(685, 225);
            this.dgvCustomer.TabIndex = 9;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // btnCustomerMultipleDelete
            // 
            this.btnCustomerMultipleDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_view_40;
            this.btnCustomerMultipleDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomerMultipleDelete.Location = new System.Drawing.Point(340, 202);
            this.btnCustomerMultipleDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerMultipleDelete.Name = "btnCustomerMultipleDelete";
            this.btnCustomerMultipleDelete.Size = new System.Drawing.Size(63, 50);
            this.btnCustomerMultipleDelete.TabIndex = 8;
            this.btnCustomerMultipleDelete.UseVisualStyleBackColor = true;
            this.btnCustomerMultipleDelete.Click += new System.EventHandler(this.btnCustomerMultipleDelete_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_edit_48;
            this.btnCustomerUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(267, 202);
            this.btnCustomerUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(69, 50);
            this.btnCustomerUpdate.TabIndex = 7;
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_48;
            this.btnCustomerDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomerDelete.Location = new System.Drawing.Point(192, 202);
            this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(70, 50);
            this.btnCustomerDelete.TabIndex = 6;
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_plus_48;
            this.btnCustomerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomerAdd.Location = new System.Drawing.Point(128, 202);
            this.btnCustomerAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(59, 50);
            this.btnCustomerAdd.TabIndex = 5;
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(128, 37);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(120, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerCounty
            // 
            this.lblCustomerCounty.AutoSize = true;
            this.lblCustomerCounty.Location = new System.Drawing.Point(28, 110);
            this.lblCustomerCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerCounty.Name = "lblCustomerCounty";
            this.lblCustomerCounty.Size = new System.Drawing.Size(90, 13);
            this.lblCustomerCounty.TabIndex = 0;
            this.lblCustomerCounty.Text = "Customer County:";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 592);
            this.Controls.Add(this.grbCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.grbCustomer.ResumeLayout(false);
            this.grbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCustomer;
        private System.Windows.Forms.ComboBox cbCustomerCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.ComboBox cbCustomerCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnCustomerMultipleDelete;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerCounty;
    }
}