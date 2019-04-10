namespace CodeFirst_Invoice
{
    partial class NewInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewInvoiceForm));
            this.grbHedaer = new System.Windows.Forms.GroupBox();
            this.btnInvoiceHeaderMultipleDelete = new System.Windows.Forms.Button();
            this.btnInvoiceUpdate = new System.Windows.Forms.Button();
            this.btnInvoiceDelete = new System.Windows.Forms.Button();
            this.btnInvoiceHeader = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtDeliverNote = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblDeliverNote = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Label();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.grbInvoiceHeaderList = new System.Windows.Forms.GroupBox();
            this.dgvInvoiceHeader = new System.Windows.Forms.DataGridView();
            this.btnGoDetails = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInvoiceHeader = new System.Windows.Forms.ToolStripButton();
            this.tsbInvoiceDetails = new System.Windows.Forms.ToolStripButton();
            this.grbInvoiceDetails = new System.Windows.Forms.GroupBox();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnInvoiceDetailsMultipleDelete = new System.Windows.Forms.Button();
            this.btnİnvoiceDetailsUpdate = new System.Windows.Forms.Button();
            this.btnInvoiceDetailsDelete = new System.Windows.Forms.Button();
            this.btnInvoiceDateilsAdd = new System.Windows.Forms.Button();
            this.dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.txtDesricpiton = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lblInvoiceDescription = new System.Windows.Forms.Label();
            this.lblInvoiceAmountWithVat = new System.Windows.Forms.Label();
            this.lblUnitPriceVatAmount = new System.Windows.Forms.Label();
            this.lblInvoiceUnitPrice = new System.Windows.Forms.Label();
            this.lblInvoiceQuanty = new System.Windows.Forms.Label();
            this.lblInvoiceProduct = new System.Windows.Forms.Label();
            this.grbHedaer.SuspendLayout();
            this.grbInvoiceHeaderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceHeader)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grbInvoiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHedaer
            // 
            this.grbHedaer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbHedaer.Controls.Add(this.btnInvoiceHeaderMultipleDelete);
            this.grbHedaer.Controls.Add(this.btnInvoiceUpdate);
            this.grbHedaer.Controls.Add(this.btnInvoiceDelete);
            this.grbHedaer.Controls.Add(this.btnInvoiceHeader);
            this.grbHedaer.Controls.Add(this.cbCustomer);
            this.grbHedaer.Controls.Add(this.dtpPaymentDate);
            this.grbHedaer.Controls.Add(this.dtpInvoiceDate);
            this.grbHedaer.Controls.Add(this.txtDeliverNote);
            this.grbHedaer.Controls.Add(this.txtInvoiceNo);
            this.grbHedaer.Controls.Add(this.lblPaymentDate);
            this.grbHedaer.Controls.Add(this.lblDeliverNote);
            this.grbHedaer.Controls.Add(this.lblInvoiceDate);
            this.grbHedaer.Controls.Add(this.Customer);
            this.grbHedaer.Controls.Add(this.lblInvoiceID);
            this.grbHedaer.Location = new System.Drawing.Point(111, 34);
            this.grbHedaer.Margin = new System.Windows.Forms.Padding(2);
            this.grbHedaer.Name = "grbHedaer";
            this.grbHedaer.Padding = new System.Windows.Forms.Padding(2);
            this.grbHedaer.Size = new System.Drawing.Size(779, 480);
            this.grbHedaer.TabIndex = 0;
            this.grbHedaer.TabStop = false;
            this.grbHedaer.Text = "New Invoice Header";
            this.grbHedaer.Visible = false;
            // 
            // btnInvoiceHeaderMultipleDelete
            // 
            this.btnInvoiceHeaderMultipleDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_view_40;
            this.btnInvoiceHeaderMultipleDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoiceHeaderMultipleDelete.Location = new System.Drawing.Point(335, 223);
            this.btnInvoiceHeaderMultipleDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoiceHeaderMultipleDelete.Name = "btnInvoiceHeaderMultipleDelete";
            this.btnInvoiceHeaderMultipleDelete.Size = new System.Drawing.Size(63, 50);
            this.btnInvoiceHeaderMultipleDelete.TabIndex = 9;
            this.btnInvoiceHeaderMultipleDelete.UseVisualStyleBackColor = true;
            this.btnInvoiceHeaderMultipleDelete.Click += new System.EventHandler(this.btnInvoiceHeaderMultipleDelete_Click);
            // 
            // btnInvoiceUpdate
            // 
            this.btnInvoiceUpdate.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_edit_48;
            this.btnInvoiceUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoiceUpdate.Location = new System.Drawing.Point(262, 223);
            this.btnInvoiceUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoiceUpdate.Name = "btnInvoiceUpdate";
            this.btnInvoiceUpdate.Size = new System.Drawing.Size(69, 50);
            this.btnInvoiceUpdate.TabIndex = 8;
            this.btnInvoiceUpdate.UseVisualStyleBackColor = true;
            this.btnInvoiceUpdate.Click += new System.EventHandler(this.btnInvoiceUpdate_Click);
            // 
            // btnInvoiceDelete
            // 
            this.btnInvoiceDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_48;
            this.btnInvoiceDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoiceDelete.Location = new System.Drawing.Point(187, 223);
            this.btnInvoiceDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoiceDelete.Name = "btnInvoiceDelete";
            this.btnInvoiceDelete.Size = new System.Drawing.Size(70, 50);
            this.btnInvoiceDelete.TabIndex = 7;
            this.btnInvoiceDelete.UseVisualStyleBackColor = true;
            this.btnInvoiceDelete.Click += new System.EventHandler(this.btnInvoiceDelete_Click);
            // 
            // btnInvoiceHeader
            // 
            this.btnInvoiceHeader.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_plus_48;
            this.btnInvoiceHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoiceHeader.Location = new System.Drawing.Point(109, 223);
            this.btnInvoiceHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoiceHeader.Name = "btnInvoiceHeader";
            this.btnInvoiceHeader.Size = new System.Drawing.Size(59, 50);
            this.btnInvoiceHeader.TabIndex = 6;
            this.btnInvoiceHeader.UseVisualStyleBackColor = true;
            this.btnInvoiceHeader.Click += new System.EventHandler(this.btnInvoiceHeader_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(109, 24);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(152, 21);
            this.cbCustomer.TabIndex = 1;
            this.cbCustomer.TextChanged += new System.EventHandler(this.cbCustomer_TextChanged);
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(109, 183);
            this.dtpPaymentDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(152, 20);
            this.dtpPaymentDate.TabIndex = 5;
            this.dtpPaymentDate.Value = new System.DateTime(2019, 3, 6, 0, 0, 0, 0);
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(109, 106);
            this.dtpInvoiceDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(152, 20);
            this.dtpInvoiceDate.TabIndex = 3;
            // 
            // txtDeliverNote
            // 
            this.txtDeliverNote.Location = new System.Drawing.Point(109, 140);
            this.txtDeliverNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliverNote.Name = "txtDeliverNote";
            this.txtDeliverNote.Size = new System.Drawing.Size(152, 20);
            this.txtDeliverNote.TabIndex = 4;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(109, 63);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(152, 20);
            this.txtInvoiceNo.TabIndex = 2;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(26, 188);
            this.lblPaymentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(74, 13);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // lblDeliverNote
            // 
            this.lblDeliverNote.AutoSize = true;
            this.lblDeliverNote.Location = new System.Drawing.Point(26, 144);
            this.lblDeliverNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliverNote.Name = "lblDeliverNote";
            this.lblDeliverNote.Size = new System.Drawing.Size(69, 13);
            this.lblDeliverNote.TabIndex = 3;
            this.lblDeliverNote.Text = "Deliver Note:";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(26, 106);
            this.lblInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(65, 13);
            this.lblInvoiceDate.TabIndex = 2;
            this.lblInvoiceDate.Text = "InvoiceDate";
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(22, 24);
            this.Customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(57, 13);
            this.Customer.TabIndex = 1;
            this.Customer.Text = "Customer :";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(28, 67);
            this.lblInvoiceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(62, 13);
            this.lblInvoiceID.TabIndex = 0;
            this.lblInvoiceID.Text = "Invoice No:";
            // 
            // grbInvoiceHeaderList
            // 
            this.grbInvoiceHeaderList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grbInvoiceHeaderList.Controls.Add(this.dgvInvoiceHeader);
            this.grbInvoiceHeaderList.Controls.Add(this.btnGoDetails);
            this.grbInvoiceHeaderList.Location = new System.Drawing.Point(58, 338);
            this.grbInvoiceHeaderList.Margin = new System.Windows.Forms.Padding(2);
            this.grbInvoiceHeaderList.Name = "grbInvoiceHeaderList";
            this.grbInvoiceHeaderList.Padding = new System.Windows.Forms.Padding(2);
            this.grbInvoiceHeaderList.Size = new System.Drawing.Size(940, 287);
            this.grbInvoiceHeaderList.TabIndex = 1;
            this.grbInvoiceHeaderList.TabStop = false;
            this.grbInvoiceHeaderList.Text = "Invoice Header List";
            this.grbInvoiceHeaderList.Visible = false;
            // 
            // dgvInvoiceHeader
            // 
            this.dgvInvoiceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoiceHeader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceHeader.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInvoiceHeader.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInvoiceHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceHeader.Location = new System.Drawing.Point(34, 35);
            this.dgvInvoiceHeader.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInvoiceHeader.Name = "dgvInvoiceHeader";
            this.dgvInvoiceHeader.RowTemplate.Height = 24;
            this.dgvInvoiceHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceHeader.Size = new System.Drawing.Size(685, 225);
            this.dgvInvoiceHeader.TabIndex = 9;
            this.dgvInvoiceHeader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceHeader_CellClick_1);
            // 
            // btnGoDetails
            // 
            this.btnGoDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoDetails.BackgroundImage")));
            this.btnGoDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoDetails.Location = new System.Drawing.Point(779, 119);
            this.btnGoDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoDetails.Name = "btnGoDetails";
            this.btnGoDetails.Size = new System.Drawing.Size(59, 50);
            this.btnGoDetails.TabIndex = 8;
            this.btnGoDetails.UseVisualStyleBackColor = true;
            this.btnGoDetails.Click += new System.EventHandler(this.btnGoDetails_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInvoiceHeader,
            this.tsbInvoiceDetails});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1040, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbInvoiceHeader
            // 
            this.tsbInvoiceHeader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInvoiceHeader.Image = global::CodeFirst_Invoice.Properties.Resources.icons8_invoice_512;
            this.tsbInvoiceHeader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInvoiceHeader.Name = "tsbInvoiceHeader";
            this.tsbInvoiceHeader.Size = new System.Drawing.Size(24, 24);
            this.tsbInvoiceHeader.Text = "New Header";
            this.tsbInvoiceHeader.Click += new System.EventHandler(this.tsbInvoiceHeader_Click);
            // 
            // tsbInvoiceDetails
            // 
            this.tsbInvoiceDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInvoiceDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsbInvoiceDetails.Image")));
            this.tsbInvoiceDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInvoiceDetails.Name = "tsbInvoiceDetails";
            this.tsbInvoiceDetails.Size = new System.Drawing.Size(24, 24);
            this.tsbInvoiceDetails.Text = "Add Invoice Details";
            this.tsbInvoiceDetails.Click += new System.EventHandler(this.tsbInvoiceDetails_Click);
            // 
            // grbInvoiceDetails
            // 
            this.grbInvoiceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbInvoiceDetails.Controls.Add(this.btnSaveInvoice);
            this.grbInvoiceDetails.Controls.Add(this.btnInvoiceDetailsMultipleDelete);
            this.grbInvoiceDetails.Controls.Add(this.btnİnvoiceDetailsUpdate);
            this.grbInvoiceDetails.Controls.Add(this.btnInvoiceDetailsDelete);
            this.grbInvoiceDetails.Controls.Add(this.btnInvoiceDateilsAdd);
            this.grbInvoiceDetails.Controls.Add(this.dgvInvoiceDetails);
            this.grbInvoiceDetails.Controls.Add(this.txtDesricpiton);
            this.grbInvoiceDetails.Controls.Add(this.txtQuantity);
            this.grbInvoiceDetails.Controls.Add(this.cbProduct);
            this.grbInvoiceDetails.Controls.Add(this.lblInvoiceDescription);
            this.grbInvoiceDetails.Controls.Add(this.lblInvoiceAmountWithVat);
            this.grbInvoiceDetails.Controls.Add(this.lblUnitPriceVatAmount);
            this.grbInvoiceDetails.Controls.Add(this.lblInvoiceUnitPrice);
            this.grbInvoiceDetails.Controls.Add(this.lblInvoiceQuanty);
            this.grbInvoiceDetails.Controls.Add(this.lblInvoiceProduct);
            this.grbInvoiceDetails.Location = new System.Drawing.Point(62, 113);
            this.grbInvoiceDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grbInvoiceDetails.Name = "grbInvoiceDetails";
            this.grbInvoiceDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grbInvoiceDetails.Size = new System.Drawing.Size(824, 416);
            this.grbInvoiceDetails.TabIndex = 3;
            this.grbInvoiceDetails.TabStop = false;
            this.grbInvoiceDetails.Text = "Add Invoice Details";
            this.grbInvoiceDetails.Visible = false;
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveInvoice.BackgroundImage")));
            this.btnSaveInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveInvoice.Location = new System.Drawing.Point(597, 334);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(76, 60);
            this.btnSaveInvoice.TabIndex = 14;
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // btnInvoiceDetailsMultipleDelete
            // 
            this.btnInvoiceDetailsMultipleDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_view_40;
            this.btnInvoiceDetailsMultipleDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoiceDetailsMultipleDelete.Location = new System.Drawing.Point(323, 183);
            this.btnInvoiceDetailsMultipleDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoiceDetailsMultipleDelete.Name = "btnInvoiceDetailsMultipleDelete";
            this.btnInvoiceDetailsMultipleDelete.Size = new System.Drawing.Size(63, 50);
            this.btnInvoiceDetailsMultipleDelete.TabIndex = 13;
            this.btnInvoiceDetailsMultipleDelete.UseVisualStyleBackColor = true;
            this.btnInvoiceDetailsMultipleDelete.Click += new System.EventHandler(this.btnInvoiceDetailsMultipleDelete_Click);
            // 
            // btnİnvoiceDetailsUpdate
            // 
            this.btnİnvoiceDetailsUpdate.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_edit_48;
            this.btnİnvoiceDetailsUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnİnvoiceDetailsUpdate.Location = new System.Drawing.Point(235, 183);
            this.btnİnvoiceDetailsUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnİnvoiceDetailsUpdate.Name = "btnİnvoiceDetailsUpdate";
            this.btnİnvoiceDetailsUpdate.Size = new System.Drawing.Size(69, 50);
            this.btnİnvoiceDetailsUpdate.TabIndex = 12;
            this.btnİnvoiceDetailsUpdate.UseVisualStyleBackColor = true;
            this.btnİnvoiceDetailsUpdate.Click += new System.EventHandler(this.btnİnvoiceDetailsUpdate_Click);
            // 
            // btnInvoiceDetailsDelete
            // 
            this.btnInvoiceDetailsDelete.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_delete_48;
            this.btnInvoiceDetailsDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoiceDetailsDelete.Location = new System.Drawing.Point(148, 183);
            this.btnInvoiceDetailsDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoiceDetailsDelete.Name = "btnInvoiceDetailsDelete";
            this.btnInvoiceDetailsDelete.Size = new System.Drawing.Size(70, 50);
            this.btnInvoiceDetailsDelete.TabIndex = 11;
            this.btnInvoiceDetailsDelete.UseVisualStyleBackColor = true;
            this.btnInvoiceDetailsDelete.Click += new System.EventHandler(this.btnInvoiceDetailsDelete_Click);
            // 
            // btnInvoiceDateilsAdd
            // 
            this.btnInvoiceDateilsAdd.BackgroundImage = global::CodeFirst_Invoice.Properties.Resources.icons8_plus_48;
            this.btnInvoiceDateilsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoiceDateilsAdd.Location = new System.Drawing.Point(60, 183);
            this.btnInvoiceDateilsAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoiceDateilsAdd.Name = "btnInvoiceDateilsAdd";
            this.btnInvoiceDateilsAdd.Size = new System.Drawing.Size(59, 50);
            this.btnInvoiceDateilsAdd.TabIndex = 10;
            this.btnInvoiceDateilsAdd.UseVisualStyleBackColor = true;
            this.btnInvoiceDateilsAdd.Click += new System.EventHandler(this.btnInvoiceDateilsAdd_Click);
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInvoiceDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(15, 258);
            this.dgvInvoiceDetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.RowTemplate.Height = 24;
            this.dgvInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(544, 225);
            this.dgvInvoiceDetails.TabIndex = 9;
            this.dgvInvoiceDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceDetails_CellClick);
            // 
            // txtDesricpiton
            // 
            this.txtDesricpiton.Location = new System.Drawing.Point(69, 83);
            this.txtDesricpiton.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesricpiton.Name = "txtDesricpiton";
            this.txtDesricpiton.Size = new System.Drawing.Size(92, 20);
            this.txtDesricpiton.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(69, 54);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(92, 20);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged_1);
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(69, 26);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(92, 21);
            this.cbProduct.TabIndex = 6;
            this.cbProduct.TextChanged += new System.EventHandler(this.cbProduct_TextChanged);
            // 
            // lblInvoiceDescription
            // 
            this.lblInvoiceDescription.AutoSize = true;
            this.lblInvoiceDescription.Location = new System.Drawing.Point(5, 87);
            this.lblInvoiceDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceDescription.Name = "lblInvoiceDescription";
            this.lblInvoiceDescription.Size = new System.Drawing.Size(63, 13);
            this.lblInvoiceDescription.TabIndex = 5;
            this.lblInvoiceDescription.Text = "Description:";
            // 
            // lblInvoiceAmountWithVat
            // 
            this.lblInvoiceAmountWithVat.AutoSize = true;
            this.lblInvoiceAmountWithVat.Location = new System.Drawing.Point(5, 151);
            this.lblInvoiceAmountWithVat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceAmountWithVat.Name = "lblInvoiceAmountWithVat";
            this.lblInvoiceAmountWithVat.Size = new System.Drawing.Size(11, 13);
            this.lblInvoiceAmountWithVat.TabIndex = 4;
            this.lblInvoiceAmountWithVat.Text = "*";
            // 
            // lblUnitPriceVatAmount
            // 
            this.lblUnitPriceVatAmount.AutoSize = true;
            this.lblUnitPriceVatAmount.Location = new System.Drawing.Point(4, 135);
            this.lblUnitPriceVatAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitPriceVatAmount.Name = "lblUnitPriceVatAmount";
            this.lblUnitPriceVatAmount.Size = new System.Drawing.Size(11, 13);
            this.lblUnitPriceVatAmount.TabIndex = 3;
            this.lblUnitPriceVatAmount.Text = "*";
            // 
            // lblInvoiceUnitPrice
            // 
            this.lblInvoiceUnitPrice.AutoSize = true;
            this.lblInvoiceUnitPrice.Location = new System.Drawing.Point(4, 117);
            this.lblInvoiceUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceUnitPrice.Name = "lblInvoiceUnitPrice";
            this.lblInvoiceUnitPrice.Size = new System.Drawing.Size(11, 13);
            this.lblInvoiceUnitPrice.TabIndex = 2;
            this.lblInvoiceUnitPrice.Text = "*";
            // 
            // lblInvoiceQuanty
            // 
            this.lblInvoiceQuanty.AutoSize = true;
            this.lblInvoiceQuanty.Location = new System.Drawing.Point(4, 56);
            this.lblInvoiceQuanty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceQuanty.Name = "lblInvoiceQuanty";
            this.lblInvoiceQuanty.Size = new System.Drawing.Size(48, 13);
            this.lblInvoiceQuanty.TabIndex = 1;
            this.lblInvoiceQuanty.Text = "Qyantity:";
            // 
            // lblInvoiceProduct
            // 
            this.lblInvoiceProduct.AutoSize = true;
            this.lblInvoiceProduct.Location = new System.Drawing.Point(5, 26);
            this.lblInvoiceProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceProduct.Name = "lblInvoiceProduct";
            this.lblInvoiceProduct.Size = new System.Drawing.Size(47, 13);
            this.lblInvoiceProduct.TabIndex = 0;
            this.lblInvoiceProduct.Text = "Product:";
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 595);
            this.Controls.Add(this.grbInvoiceDetails);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grbInvoiceHeaderList);
            this.Controls.Add(this.grbHedaer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewInvoice";
            this.Load += new System.EventHandler(this.NewInvoiceForm_Load);
            this.grbHedaer.ResumeLayout(false);
            this.grbHedaer.PerformLayout();
            this.grbInvoiceHeaderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceHeader)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbInvoiceDetails.ResumeLayout(false);
            this.grbInvoiceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHedaer;
        private System.Windows.Forms.GroupBox grbInvoiceHeaderList;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblDeliverNote;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.TextBox txtDeliverNote;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button btnInvoiceHeaderMultipleDelete;
        private System.Windows.Forms.Button btnInvoiceUpdate;
        private System.Windows.Forms.Button btnInvoiceDelete;
        private System.Windows.Forms.Button btnInvoiceHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbInvoiceHeader;
        private System.Windows.Forms.ToolStripButton tsbInvoiceDetails;
        private System.Windows.Forms.GroupBox grbInvoiceDetails;
        private System.Windows.Forms.Label lblInvoiceDescription;
        private System.Windows.Forms.Label lblInvoiceAmountWithVat;
        private System.Windows.Forms.Label lblUnitPriceVatAmount;
        private System.Windows.Forms.Label lblInvoiceUnitPrice;
        private System.Windows.Forms.Label lblInvoiceQuanty;
        private System.Windows.Forms.Label lblInvoiceProduct;
        private System.Windows.Forms.Button btnInvoiceDetailsMultipleDelete;
        private System.Windows.Forms.Button btnİnvoiceDetailsUpdate;
        private System.Windows.Forms.Button btnInvoiceDetailsDelete;
        private System.Windows.Forms.Button btnInvoiceDateilsAdd;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.TextBox txtDesricpiton;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Button btnGoDetails;
        private System.Windows.Forms.DataGridView dgvInvoiceHeader;
        private System.Windows.Forms.Button btnSaveInvoice;
    }
}