namespace CodeFirst_Invoice
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supportTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoiceTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoiceViewQueryEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportTablesToolStripMenuItem,
            this.ınvoiceTransactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // supportTablesToolStripMenuItem
            // 
            this.supportTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerDefinitionsToolStripMenuItem,
            this.unitDefinitionsToolStripMenuItem,
            this.productDefinitionsToolStripMenuItem,
            this.cityDefinitionsToolStripMenuItem,
            this.countryDefinitionsToolStripMenuItem});
            this.supportTablesToolStripMenuItem.Name = "supportTablesToolStripMenuItem";
            this.supportTablesToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.supportTablesToolStripMenuItem.Text = "Support Tables";
            // 
            // customerDefinitionsToolStripMenuItem
            // 
            this.customerDefinitionsToolStripMenuItem.Image = global::CodeFirst_Invoice.Properties.Resources.icons8_customer_64;
            this.customerDefinitionsToolStripMenuItem.Name = "customerDefinitionsToolStripMenuItem";
            this.customerDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.customerDefinitionsToolStripMenuItem.Text = "Customer Definitions";
            this.customerDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.customerDefinitionsToolStripMenuItem_Click);
            // 
            // unitDefinitionsToolStripMenuItem
            // 
            this.unitDefinitionsToolStripMenuItem.Image = global::CodeFirst_Invoice.Properties.Resources.icons8_unit_50;
            this.unitDefinitionsToolStripMenuItem.Name = "unitDefinitionsToolStripMenuItem";
            this.unitDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.unitDefinitionsToolStripMenuItem.Text = "Unit Definitions";
            this.unitDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.unitDefinitionsToolStripMenuItem_Click);
            // 
            // productDefinitionsToolStripMenuItem
            // 
            this.productDefinitionsToolStripMenuItem.Image = global::CodeFirst_Invoice.Properties.Resources.icons8_box_64;
            this.productDefinitionsToolStripMenuItem.Name = "productDefinitionsToolStripMenuItem";
            this.productDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.productDefinitionsToolStripMenuItem.Text = "Product Definitions";
            this.productDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.productDefinitionsToolStripMenuItem_Click);
            // 
            // cityDefinitionsToolStripMenuItem
            // 
            this.cityDefinitionsToolStripMenuItem.Image = global::CodeFirst_Invoice.Properties.Resources.icons8_city_filled_50;
            this.cityDefinitionsToolStripMenuItem.Name = "cityDefinitionsToolStripMenuItem";
            this.cityDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.cityDefinitionsToolStripMenuItem.Text = "City Definitions";
            this.cityDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.cityDefinitionsToolStripMenuItem_Click);
            // 
            // countryDefinitionsToolStripMenuItem
            // 
            this.countryDefinitionsToolStripMenuItem.Image = global::CodeFirst_Invoice.Properties.Resources.icons8_country_50;
            this.countryDefinitionsToolStripMenuItem.Name = "countryDefinitionsToolStripMenuItem";
            this.countryDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.countryDefinitionsToolStripMenuItem.Text = "County Definitions";
            this.countryDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.countryDefinitionsToolStripMenuItem_Click);
            // 
            // ınvoiceTransactionsToolStripMenuItem
            // 
            this.ınvoiceTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınvoiceViewQueryEditToolStripMenuItem,
            this.createNewInvoiceToolStripMenuItem});
            this.ınvoiceTransactionsToolStripMenuItem.Name = "ınvoiceTransactionsToolStripMenuItem";
            this.ınvoiceTransactionsToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.ınvoiceTransactionsToolStripMenuItem.Text = "Invoice Transactions";
            // 
            // ınvoiceViewQueryEditToolStripMenuItem
            // 
            this.ınvoiceViewQueryEditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ınvoiceViewQueryEditToolStripMenuItem.Image")));
            this.ınvoiceViewQueryEditToolStripMenuItem.Name = "ınvoiceViewQueryEditToolStripMenuItem";
            this.ınvoiceViewQueryEditToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.ınvoiceViewQueryEditToolStripMenuItem.Text = "Invoice View/Query/Edit";
            this.ınvoiceViewQueryEditToolStripMenuItem.Click += new System.EventHandler(this.ınvoiceViewQueryEditToolStripMenuItem_Click);
            // 
            // createNewInvoiceToolStripMenuItem
            // 
            this.createNewInvoiceToolStripMenuItem.Image = global::CodeFirst_Invoice.Properties.Resources.icons8_invoice_512;
            this.createNewInvoiceToolStripMenuItem.Name = "createNewInvoiceToolStripMenuItem";
            this.createNewInvoiceToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.createNewInvoiceToolStripMenuItem.Text = "Create New Invoice";
            this.createNewInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createNewInvoiceToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.Text = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supportTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoiceTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoiceViewQueryEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewInvoiceToolStripMenuItem;
    }
}

