namespace CodeFirst_Invoice
{
    partial class CountyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountyForm));
            this.grbCounty = new System.Windows.Forms.GroupBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.dgvCounty = new System.Windows.Forms.DataGridView();
            this.btnCountyMultipleDelete = new System.Windows.Forms.Button();
            this.btnCountyUpdate = new System.Windows.Forms.Button();
            this.btnCountyDelete = new System.Windows.Forms.Button();
            this.btnCountyAdd = new System.Windows.Forms.Button();
            this.txtCountyName = new System.Windows.Forms.TextBox();
            this.lblCityName = new System.Windows.Forms.Label();
            this.grbCounty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounty)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCounty
            // 
            this.grbCounty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbCounty.BackColor = System.Drawing.SystemColors.Control;
            this.grbCounty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbCounty.Controls.Add(this.cbCity);
            this.grbCounty.Controls.Add(this.lblCounty);
            this.grbCounty.Controls.Add(this.dgvCounty);
            this.grbCounty.Controls.Add(this.btnCountyMultipleDelete);
            this.grbCounty.Controls.Add(this.btnCountyUpdate);
            this.grbCounty.Controls.Add(this.btnCountyDelete);
            this.grbCounty.Controls.Add(this.btnCountyAdd);
            this.grbCounty.Controls.Add(this.txtCountyName);
            this.grbCounty.Controls.Add(this.lblCityName);
            this.grbCounty.Location = new System.Drawing.Point(110, 75);
            this.grbCounty.Margin = new System.Windows.Forms.Padding(2);
            this.grbCounty.Name = "grbCounty";
            this.grbCounty.Padding = new System.Windows.Forms.Padding(2);
            this.grbCounty.Size = new System.Drawing.Size(704, 430);
            this.grbCounty.TabIndex = 1;
            this.grbCounty.TabStop = false;
            this.grbCounty.Text = "County Operations";
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(128, 72);
            this.cbCity.Margin = new System.Windows.Forms.Padding(2);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(120, 21);
            this.cbCity.TabIndex = 2;
            this.cbCity.TextChanged += new System.EventHandler(this.cbCity_TextChanged);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(50, 37);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(74, 13);
            this.lblCounty.TabIndex = 7;
            this.lblCounty.Text = "County Name:";
            // 
            // dgvCounty
            // 
            this.dgvCounty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCounty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCounty.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCounty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCounty.Location = new System.Drawing.Point(4, 188);
            this.dgvCounty.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCounty.Name = "dgvCounty";
            this.dgvCounty.RowTemplate.Height = 24;
            this.dgvCounty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCounty.Size = new System.Drawing.Size(685, 225);
            this.dgvCounty.TabIndex = 6;
            this.dgvCounty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCounty_CellClick);
            // 
            // btnCountyMultipleDelete
            // 
            this.btnCountyMultipleDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_view_40;
            this.btnCountyMultipleDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCountyMultipleDelete.Location = new System.Drawing.Point(343, 112);
            this.btnCountyMultipleDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCountyMultipleDelete.Name = "btnCountyMultipleDelete";
            this.btnCountyMultipleDelete.Size = new System.Drawing.Size(63, 50);
            this.btnCountyMultipleDelete.TabIndex = 6;
            this.btnCountyMultipleDelete.UseVisualStyleBackColor = true;
            this.btnCountyMultipleDelete.Click += new System.EventHandler(this.btnCountyMultipleDelete_Click);
            // 
            // btnCountyUpdate
            // 
            this.btnCountyUpdate.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_edit_48;
            this.btnCountyUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCountyUpdate.Location = new System.Drawing.Point(260, 112);
            this.btnCountyUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCountyUpdate.Name = "btnCountyUpdate";
            this.btnCountyUpdate.Size = new System.Drawing.Size(69, 50);
            this.btnCountyUpdate.TabIndex = 5;
            this.btnCountyUpdate.UseVisualStyleBackColor = true;
            this.btnCountyUpdate.Click += new System.EventHandler(this.btnCountyUpdate_Click);
            // 
            // btnCountyDelete
            // 
            this.btnCountyDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_48;
            this.btnCountyDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCountyDelete.Location = new System.Drawing.Point(177, 112);
            this.btnCountyDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCountyDelete.Name = "btnCountyDelete";
            this.btnCountyDelete.Size = new System.Drawing.Size(70, 50);
            this.btnCountyDelete.TabIndex = 4;
            this.btnCountyDelete.UseVisualStyleBackColor = true;
            this.btnCountyDelete.Click += new System.EventHandler(this.btnCountyDelete_Click);
            // 
            // btnCountyAdd
            // 
            this.btnCountyAdd.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_plus_48;
            this.btnCountyAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCountyAdd.Location = new System.Drawing.Point(104, 112);
            this.btnCountyAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCountyAdd.Name = "btnCountyAdd";
            this.btnCountyAdd.Size = new System.Drawing.Size(59, 50);
            this.btnCountyAdd.TabIndex = 3;
            this.btnCountyAdd.UseVisualStyleBackColor = true;
            this.btnCountyAdd.Click += new System.EventHandler(this.btnCountyAdd_Click);
            // 
            // txtCountyName
            // 
            this.txtCountyName.Location = new System.Drawing.Point(128, 37);
            this.txtCountyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountyName.Name = "txtCountyName";
            this.txtCountyName.Size = new System.Drawing.Size(120, 20);
            this.txtCountyName.TabIndex = 1;
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(47, 79);
            this.lblCityName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(58, 13);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "City Name:";
            // 
            // CountyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 587);
            this.Controls.Add(this.grbCounty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CountyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "County";
            this.Load += new System.EventHandler(this.CountyForm_Load);
            this.grbCounty.ResumeLayout(false);
            this.grbCounty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCounty;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.DataGridView dgvCounty;
        private System.Windows.Forms.Button btnCountyMultipleDelete;
        private System.Windows.Forms.Button btnCountyUpdate;
        private System.Windows.Forms.Button btnCountyDelete;
        private System.Windows.Forms.Button btnCountyAdd;
        private System.Windows.Forms.TextBox txtCountyName;
        private System.Windows.Forms.Label lblCityName;
    }
}