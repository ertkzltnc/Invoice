namespace CodeFirst_Invoice
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbView = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.grbView = new System.Windows.Forms.GroupBox();
            this.dgvViewInvoice = new System.Windows.Forms.DataGridView();
            this.grbQuery = new System.Windows.Forms.GroupBox();
            this.btnGoEdit = new System.Windows.Forms.Button();
            this.cbInvoiceQuery = new System.Windows.Forms.ComboBox();
            this.dgvQueryList = new System.Windows.Forms.DataGridView();
            this.btnQuerySearch = new System.Windows.Forms.Button();
            this.cbCustomerQuery = new System.Windows.Forms.ComboBox();
            this.lblInvoiceQuery = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.btnInvoiceUpdateEdit = new System.Windows.Forms.Button();
            this.dtpPaymentDateEdit = new System.Windows.Forms.DateTimePicker();
            this.txtDeliverNoteEdit = new System.Windows.Forms.TextBox();
            this.lblPaymentDateEdit = new System.Windows.Forms.Label();
            this.lblDeliverNoteEdit = new System.Windows.Forms.Label();
            this.dgvInvoiceEdit = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.grbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewInvoice)).BeginInit();
            this.grbQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryList)).BeginInit();
            this.grbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbView,
            this.tsbQuery,
            this.tsbEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1040, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbView
            // 
            this.tsbView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbView.Image = ((System.Drawing.Image)(resources.GetObject("tsbView.Image")));
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(24, 24);
            this.tsbView.Text = "Invoice View";
            this.tsbView.Click += new System.EventHandler(this.tsbView_Click);
            // 
            // tsbQuery
            // 
            this.tsbQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuery.Image")));
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(24, 24);
            this.tsbQuery.Text = "Invoice Query";
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(24, 24);
            this.tsbEdit.Text = "Invoice Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // grbView
            // 
            this.grbView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbView.Controls.Add(this.dgvViewInvoice);
            this.grbView.Location = new System.Drawing.Point(74, 24);
            this.grbView.Margin = new System.Windows.Forms.Padding(2);
            this.grbView.Name = "grbView";
            this.grbView.Padding = new System.Windows.Forms.Padding(2);
            this.grbView.Size = new System.Drawing.Size(808, 433);
            this.grbView.TabIndex = 1;
            this.grbView.TabStop = false;
            this.grbView.Text = "Invoice View";
            this.grbView.Visible = false;
            // 
            // dgvViewInvoice
            // 
            this.dgvViewInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvViewInvoice.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewInvoice.Location = new System.Drawing.Point(32, 58);
            this.dgvViewInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.dgvViewInvoice.Name = "dgvViewInvoice";
            this.dgvViewInvoice.RowTemplate.Height = 24;
            this.dgvViewInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewInvoice.Size = new System.Drawing.Size(757, 354);
            this.dgvViewInvoice.TabIndex = 10;
            // 
            // grbQuery
            // 
            this.grbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbQuery.Controls.Add(this.btnGoEdit);
            this.grbQuery.Controls.Add(this.cbInvoiceQuery);
            this.grbQuery.Controls.Add(this.dgvQueryList);
            this.grbQuery.Controls.Add(this.btnQuerySearch);
            this.grbQuery.Controls.Add(this.cbCustomerQuery);
            this.grbQuery.Controls.Add(this.lblInvoiceQuery);
            this.grbQuery.Controls.Add(this.lblCustomer);
            this.grbQuery.Location = new System.Drawing.Point(31, 50);
            this.grbQuery.Margin = new System.Windows.Forms.Padding(2);
            this.grbQuery.Name = "grbQuery";
            this.grbQuery.Padding = new System.Windows.Forms.Padding(2);
            this.grbQuery.Size = new System.Drawing.Size(855, 419);
            this.grbQuery.TabIndex = 2;
            this.grbQuery.TabStop = false;
            this.grbQuery.Text = "Invoice Query";
            this.grbQuery.Visible = false;
            // 
            // btnGoEdit
            // 
            this.btnGoEdit.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_edit_48;
            this.btnGoEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoEdit.Location = new System.Drawing.Point(704, 365);
            this.btnGoEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoEdit.Name = "btnGoEdit";
            this.btnGoEdit.Size = new System.Drawing.Size(59, 50);
            this.btnGoEdit.TabIndex = 21;
            this.btnGoEdit.UseVisualStyleBackColor = true;
            this.btnGoEdit.Click += new System.EventHandler(this.btnGoEdit_Click);
            // 
            // cbInvoiceQuery
            // 
            this.cbInvoiceQuery.FormattingEnabled = true;
            this.cbInvoiceQuery.Location = new System.Drawing.Point(194, 48);
            this.cbInvoiceQuery.Margin = new System.Windows.Forms.Padding(2);
            this.cbInvoiceQuery.Name = "cbInvoiceQuery";
            this.cbInvoiceQuery.Size = new System.Drawing.Size(92, 21);
            this.cbInvoiceQuery.TabIndex = 20;
            // 
            // dgvQueryList
            // 
            this.dgvQueryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQueryList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvQueryList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQueryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryList.Location = new System.Drawing.Point(60, 189);
            this.dgvQueryList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQueryList.Name = "dgvQueryList";
            this.dgvQueryList.RowTemplate.Height = 24;
            this.dgvQueryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueryList.Size = new System.Drawing.Size(622, 225);
            this.dgvQueryList.TabIndex = 19;
            this.dgvQueryList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQueryList_CellClick);
            // 
            // btnQuerySearch
            // 
            this.btnQuerySearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuerySearch.BackgroundImage")));
            this.btnQuerySearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuerySearch.Location = new System.Drawing.Point(194, 83);
            this.btnQuerySearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuerySearch.Name = "btnQuerySearch";
            this.btnQuerySearch.Size = new System.Drawing.Size(59, 50);
            this.btnQuerySearch.TabIndex = 15;
            this.btnQuerySearch.UseVisualStyleBackColor = true;
            this.btnQuerySearch.Click += new System.EventHandler(this.btnQuerySearch_Click);
            // 
            // cbCustomerQuery
            // 
            this.cbCustomerQuery.FormattingEnabled = true;
            this.cbCustomerQuery.Location = new System.Drawing.Point(194, 15);
            this.cbCustomerQuery.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomerQuery.Name = "cbCustomerQuery";
            this.cbCustomerQuery.Size = new System.Drawing.Size(92, 21);
            this.cbCustomerQuery.TabIndex = 14;
            // 
            // lblInvoiceQuery
            // 
            this.lblInvoiceQuery.AutoSize = true;
            this.lblInvoiceQuery.Location = new System.Drawing.Point(100, 48);
            this.lblInvoiceQuery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceQuery.Name = "lblInvoiceQuery";
            this.lblInvoiceQuery.Size = new System.Drawing.Size(62, 13);
            this.lblInvoiceQuery.TabIndex = 13;
            this.lblInvoiceQuery.Text = "Invoice No:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(98, 15);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblCustomer.TabIndex = 12;
            this.lblCustomer.Text = "Customer:";
            // 
            // grbEdit
            // 
            this.grbEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEdit.Controls.Add(this.btnInvoiceUpdateEdit);
            this.grbEdit.Controls.Add(this.dtpPaymentDateEdit);
            this.grbEdit.Controls.Add(this.txtDeliverNoteEdit);
            this.grbEdit.Controls.Add(this.lblPaymentDateEdit);
            this.grbEdit.Controls.Add(this.lblDeliverNoteEdit);
            this.grbEdit.Controls.Add(this.dgvInvoiceEdit);
            this.grbEdit.Location = new System.Drawing.Point(91, 10);
            this.grbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.grbEdit.Name = "grbEdit";
            this.grbEdit.Padding = new System.Windows.Forms.Padding(2);
            this.grbEdit.Size = new System.Drawing.Size(922, 471);
            this.grbEdit.TabIndex = 2;
            this.grbEdit.TabStop = false;
            this.grbEdit.Text = "Invoice Edit";
            this.grbEdit.Visible = false;
            // 
            // btnInvoiceUpdateEdit
            // 
            this.btnInvoiceUpdateEdit.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_edit_48;
            this.btnInvoiceUpdateEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoiceUpdateEdit.Location = new System.Drawing.Point(142, 124);
            this.btnInvoiceUpdateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoiceUpdateEdit.Name = "btnInvoiceUpdateEdit";
            this.btnInvoiceUpdateEdit.Size = new System.Drawing.Size(69, 50);
            this.btnInvoiceUpdateEdit.TabIndex = 25;
            this.btnInvoiceUpdateEdit.UseVisualStyleBackColor = true;
            this.btnInvoiceUpdateEdit.Click += new System.EventHandler(this.btnInvoiceUpdateEdit_Click);
            // 
            // dtpPaymentDateEdit
            // 
            this.dtpPaymentDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDateEdit.Location = new System.Drawing.Point(142, 76);
            this.dtpPaymentDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPaymentDateEdit.Name = "dtpPaymentDateEdit";
            this.dtpPaymentDateEdit.Size = new System.Drawing.Size(152, 20);
            this.dtpPaymentDateEdit.TabIndex = 24;
            this.dtpPaymentDateEdit.Value = new System.DateTime(2019, 3, 6, 0, 0, 0, 0);
            // 
            // txtDeliverNoteEdit
            // 
            this.txtDeliverNoteEdit.Location = new System.Drawing.Point(142, 33);
            this.txtDeliverNoteEdit.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliverNoteEdit.Name = "txtDeliverNoteEdit";
            this.txtDeliverNoteEdit.Size = new System.Drawing.Size(152, 20);
            this.txtDeliverNoteEdit.TabIndex = 22;
            // 
            // lblPaymentDateEdit
            // 
            this.lblPaymentDateEdit.AutoSize = true;
            this.lblPaymentDateEdit.Location = new System.Drawing.Point(59, 81);
            this.lblPaymentDateEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentDateEdit.Name = "lblPaymentDateEdit";
            this.lblPaymentDateEdit.Size = new System.Drawing.Size(74, 13);
            this.lblPaymentDateEdit.TabIndex = 23;
            this.lblPaymentDateEdit.Text = "Payment Date";
            // 
            // lblDeliverNoteEdit
            // 
            this.lblDeliverNoteEdit.AutoSize = true;
            this.lblDeliverNoteEdit.Location = new System.Drawing.Point(59, 37);
            this.lblDeliverNoteEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliverNoteEdit.Name = "lblDeliverNoteEdit";
            this.lblDeliverNoteEdit.Size = new System.Drawing.Size(69, 13);
            this.lblDeliverNoteEdit.TabIndex = 21;
            this.lblDeliverNoteEdit.Text = "Deliver Note:";
            // 
            // dgvInvoiceEdit
            // 
            this.dgvInvoiceEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceEdit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInvoiceEdit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInvoiceEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceEdit.Location = new System.Drawing.Point(24, 229);
            this.dgvInvoiceEdit.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInvoiceEdit.Name = "dgvInvoiceEdit";
            this.dgvInvoiceEdit.RowTemplate.Height = 24;
            this.dgvInvoiceEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceEdit.Size = new System.Drawing.Size(755, 225);
            this.dgvInvoiceEdit.TabIndex = 20;
            this.dgvInvoiceEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceEdit_CellClick);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 532);
            this.Controls.Add(this.grbEdit);
            this.Controls.Add(this.grbView);
            this.Controls.Add(this.grbQuery);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Invoice(View/Query/Edit)";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewInvoice)).EndInit();
            this.grbQuery.ResumeLayout(false);
            this.grbQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryList)).EndInit();
            this.grbEdit.ResumeLayout(false);
            this.grbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.GroupBox grbView;
        private System.Windows.Forms.GroupBox grbQuery;
        private System.Windows.Forms.GroupBox grbEdit;
        private System.Windows.Forms.DataGridView dgvViewInvoice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvQueryList;
        private System.Windows.Forms.Button btnQuerySearch;
        private System.Windows.Forms.ComboBox cbCustomerQuery;
        private System.Windows.Forms.Label lblInvoiceQuery;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbInvoiceQuery;
        private System.Windows.Forms.DataGridView dgvInvoiceEdit;
        private System.Windows.Forms.Button btnGoEdit;
        private System.Windows.Forms.DateTimePicker dtpPaymentDateEdit;
        private System.Windows.Forms.TextBox txtDeliverNoteEdit;
        private System.Windows.Forms.Label lblPaymentDateEdit;
        private System.Windows.Forms.Label lblDeliverNoteEdit;
        private System.Windows.Forms.Button btnInvoiceUpdateEdit;
    }
}