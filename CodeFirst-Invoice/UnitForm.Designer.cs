namespace CodeFirst_Invoice
{
    partial class UnitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitForm));
            this.grbUnit = new System.Windows.Forms.GroupBox();
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.btnUnitMultipleDelete = new System.Windows.Forms.Button();
            this.btnUnitUpdate = new System.Windows.Forms.Button();
            this.btnUnitDelete = new System.Windows.Forms.Button();
            this.btnUnitAdd = new System.Windows.Forms.Button();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.grbUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUnit
            // 
            this.grbUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbUnit.BackColor = System.Drawing.SystemColors.Control;
            this.grbUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbUnit.Controls.Add(this.dgvUnit);
            this.grbUnit.Controls.Add(this.btnUnitMultipleDelete);
            this.grbUnit.Controls.Add(this.btnUnitUpdate);
            this.grbUnit.Controls.Add(this.btnUnitDelete);
            this.grbUnit.Controls.Add(this.btnUnitAdd);
            this.grbUnit.Controls.Add(this.txtUnitName);
            this.grbUnit.Controls.Add(this.lblUnitName);
            this.grbUnit.Location = new System.Drawing.Point(200, 82);
            this.grbUnit.Name = "grbUnit";
            this.grbUnit.Size = new System.Drawing.Size(938, 529);
            this.grbUnit.TabIndex = 1;
            this.grbUnit.TabStop = false;
            this.grbUnit.Text = "Unit Operations";
            // 
            // dgvUnit
            // 
            this.dgvUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUnit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Location = new System.Drawing.Point(6, 232);
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.RowTemplate.Height = 24;
            this.dgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnit.Size = new System.Drawing.Size(913, 277);
            this.dgvUnit.TabIndex = 6;
            this.dgvUnit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellClick);
            // 
            // btnUnitMultipleDelete
            // 
            this.btnUnitMultipleDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_view_40;
            this.btnUnitMultipleDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnitMultipleDelete.Location = new System.Drawing.Point(445, 99);
            this.btnUnitMultipleDelete.Name = "btnUnitMultipleDelete";
            this.btnUnitMultipleDelete.Size = new System.Drawing.Size(84, 61);
            this.btnUnitMultipleDelete.TabIndex = 5;
            this.btnUnitMultipleDelete.UseVisualStyleBackColor = true;
            this.btnUnitMultipleDelete.Click += new System.EventHandler(this.btnUnitMultipleDelete_Click);
            // 
            // btnUnitUpdate
            // 
            this.btnUnitUpdate.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_edit_48;
            this.btnUnitUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnitUpdate.Location = new System.Drawing.Point(347, 99);
            this.btnUnitUpdate.Name = "btnUnitUpdate";
            this.btnUnitUpdate.Size = new System.Drawing.Size(92, 61);
            this.btnUnitUpdate.TabIndex = 4;
            this.btnUnitUpdate.UseVisualStyleBackColor = true;
            this.btnUnitUpdate.Click += new System.EventHandler(this.btnUnitUpdate_Click);
            // 
            // btnUnitDelete
            // 
            this.btnUnitDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_48;
            this.btnUnitDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnitDelete.Location = new System.Drawing.Point(247, 99);
            this.btnUnitDelete.Name = "btnUnitDelete";
            this.btnUnitDelete.Size = new System.Drawing.Size(94, 61);
            this.btnUnitDelete.TabIndex = 3;
            this.btnUnitDelete.UseVisualStyleBackColor = true;
            this.btnUnitDelete.Click += new System.EventHandler(this.btnUnitDelete_Click);
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_plus_48;
            this.btnUnitAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnitAdd.Location = new System.Drawing.Point(143, 99);
            this.btnUnitAdd.Name = "btnUnitAdd";
            this.btnUnitAdd.Size = new System.Drawing.Size(79, 61);
            this.btnUnitAdd.TabIndex = 2;
            this.btnUnitAdd.UseVisualStyleBackColor = true;
            this.btnUnitAdd.Click += new System.EventHandler(this.btnUnitAdd_Click);
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(171, 45);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(159, 22);
            this.txtUnitName.TabIndex = 1;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(65, 50);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(78, 17);
            this.lblUnitName.TabIndex = 0;
            this.lblUnitName.Text = "Unit Name:";
            // 
            // UnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 693);
            this.Controls.Add(this.grbUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Unit";
            this.Load += new System.EventHandler(this.UnitForm_Load);
            this.grbUnit.ResumeLayout(false);
            this.grbUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUnit;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.Button btnUnitMultipleDelete;
        private System.Windows.Forms.Button btnUnitUpdate;
        private System.Windows.Forms.Button btnUnitDelete;
        private System.Windows.Forms.Button btnUnitAdd;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label lblUnitName;
    }
}