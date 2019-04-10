namespace CodeFirst_Invoice
{
    partial class CityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityForm));
            this.grbCity = new System.Windows.Forms.GroupBox();
            this.dgvCity = new System.Windows.Forms.DataGridView();
            this.btnCityMultipleDelete = new System.Windows.Forms.Button();
            this.btnCityUpdate = new System.Windows.Forms.Button();
            this.btnCityDelete = new System.Windows.Forms.Button();
            this.btnCityAdd = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.lblCityName = new System.Windows.Forms.Label();
            this.grbCity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCity
            // 
            this.grbCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbCity.BackColor = System.Drawing.SystemColors.Control;
            this.grbCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbCity.Controls.Add(this.dgvCity);
            this.grbCity.Controls.Add(this.btnCityMultipleDelete);
            this.grbCity.Controls.Add(this.btnCityUpdate);
            this.grbCity.Controls.Add(this.btnCityDelete);
            this.grbCity.Controls.Add(this.btnCityAdd);
            this.grbCity.Controls.Add(this.txtCityName);
            this.grbCity.Controls.Add(this.lblCityName);
            this.grbCity.Location = new System.Drawing.Point(127, 34);
            this.grbCity.Name = "grbCity";
            this.grbCity.Size = new System.Drawing.Size(938, 529);
            this.grbCity.TabIndex = 0;
            this.grbCity.TabStop = false;
            this.grbCity.Text = "City Operations";
            // 
            // dgvCity
            // 
            this.dgvCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCity.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Location = new System.Drawing.Point(6, 232);
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.RowTemplate.Height = 24;
            this.dgvCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCity.Size = new System.Drawing.Size(913, 277);
            this.dgvCity.TabIndex = 6;
            this.dgvCity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCity_CellClick);
            // 
            // btnCityMultipleDelete
            // 
            this.btnCityMultipleDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_view_40;
            this.btnCityMultipleDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCityMultipleDelete.Location = new System.Drawing.Point(445, 99);
            this.btnCityMultipleDelete.Name = "btnCityMultipleDelete";
            this.btnCityMultipleDelete.Size = new System.Drawing.Size(84, 61);
            this.btnCityMultipleDelete.TabIndex = 5;
            this.btnCityMultipleDelete.UseVisualStyleBackColor = true;
            this.btnCityMultipleDelete.Click += new System.EventHandler(this.btnCityMultipleDelete_Click);
            // 
            // btnCityUpdate
            // 
            this.btnCityUpdate.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_edit_48;
            this.btnCityUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCityUpdate.Location = new System.Drawing.Point(347, 99);
            this.btnCityUpdate.Name = "btnCityUpdate";
            this.btnCityUpdate.Size = new System.Drawing.Size(92, 61);
            this.btnCityUpdate.TabIndex = 4;
            this.btnCityUpdate.UseVisualStyleBackColor = true;
            this.btnCityUpdate.Click += new System.EventHandler(this.btnCityUpdate_Click);
            // 
            // btnCityDelete
            // 
            this.btnCityDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_48;
            this.btnCityDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCityDelete.Location = new System.Drawing.Point(247, 99);
            this.btnCityDelete.Name = "btnCityDelete";
            this.btnCityDelete.Size = new System.Drawing.Size(94, 61);
            this.btnCityDelete.TabIndex = 3;
            this.btnCityDelete.UseVisualStyleBackColor = true;
            this.btnCityDelete.Click += new System.EventHandler(this.btnCityDelete_Click);
            // 
            // btnCityAdd
            // 
            this.btnCityAdd.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_plus_48;
            this.btnCityAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCityAdd.Location = new System.Drawing.Point(143, 99);
            this.btnCityAdd.Name = "btnCityAdd";
            this.btnCityAdd.Size = new System.Drawing.Size(79, 61);
            this.btnCityAdd.TabIndex = 2;
            this.btnCityAdd.UseVisualStyleBackColor = true;
            this.btnCityAdd.Click += new System.EventHandler(this.btnCityAdd_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(171, 45);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(159, 22);
            this.txtCityName.TabIndex = 1;
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(65, 50);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(76, 17);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "City Name:";
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 588);
            this.Controls.Add(this.grbCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "City";
            this.Load += new System.EventHandler(this.CityForm_Load);
            this.grbCity.ResumeLayout(false);
            this.grbCity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCity;
        private System.Windows.Forms.DataGridView dgvCity;
        private System.Windows.Forms.Button btnCityMultipleDelete;
        private System.Windows.Forms.Button btnCityUpdate;
        private System.Windows.Forms.Button btnCityDelete;
        private System.Windows.Forms.Button btnCityAdd;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label lblCityName;
    }
}