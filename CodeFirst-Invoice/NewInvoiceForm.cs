using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst_Invoice.Entity;
using CodeFirst_Invoice.Context;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace CodeFirst_Invoice
{
    // Id degeri dısardan girilme islemine bakılacak 
    public partial class NewInvoiceForm : Form
    {
        InvoiceContext db = DbSingleTone.GetInstance();
        int customerID, invoiceID, productID;
        public NewInvoiceForm()
        {
            InitializeComponent();
        }

        private void NewInvoiceForm_Load(object sender, EventArgs e)
        {
            tsbInvoiceHeader.PerformClick();
         
        }
        public void GetCustomer()
        {
            List<Customer> customerList = db.Customers.ToList();
            cbCustomer.DisplayMember = "CompanyName";
            cbCustomer.ValueMember ="CustomerID";
            cbCustomer.DataSource = customerList;
          
            cbCustomer.Text = "";
           
        }
        public void GetProduct()
        {
            List<Product> productList = db.Products.ToList();
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";
            cbProduct.DataSource = productList;

            cbProduct.Text = "";
        }

        private void cbCustomer_TextChanged(object sender, EventArgs e)
        {
            customerID = Convert.ToInt32(cbCustomer.SelectedValue);
            InvoiceHeaderFill();
        }

        private void btnInvoiceHeader_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceNo.Text != "" && cbCustomer.Text != "")
                {
                    
                    InvoiceHeader invoiceHeader = new InvoiceHeader();
                    invoiceHeader.CustomerID = Convert.ToInt32(cbCustomer.SelectedValue);
                    invoiceHeader.InvoiceID = Convert.ToInt32(txtInvoiceNo.Text);
                    invoiceHeader.InvoiceDate = dtpInvoiceDate.Value.Date;
                    invoiceHeader.PaymentDate = dtpPaymentDate.Value;
                    invoiceHeader.DeliveryNote = txtDeliverNote.Text;
                    invoiceHeader.TotalAmount = 0;
                    db.InvoiceHeaders.Add(invoiceHeader);
                    db.SaveChanges();
                    InvoiceHeaderFill();
                  
                    txtDeliverNote.Text = "";
                    txtInvoiceNo.Text = "";
                    cbCustomer.Text = "";
                    dtpInvoiceDate.Text = "";
                    dtpPaymentDate.Text = "";
                    invoiceID = invoiceHeader.InvoiceID;
                    btnGoDetails.PerformClick();


                }
                else
                {
                    MessageBox.Show("Please fill in all fields");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(" ",ex.Message);
            }
        }

        private void btnInvoiceDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvInvoiceHeader.SelectedRows.Count == 1)
                    {
                        InvoiceHeader invoiceHeader = db.InvoiceHeaders.Find(invoiceID);
                        db.InvoiceHeaders.Remove(invoiceHeader);
                        db.SaveChanges();
                        InvoiceHeaderFill();
                        txtDeliverNote.Text = "";
                        txtInvoiceNo.Text = "";
                        cbCustomer.Text = "";
                        dtpInvoiceDate.Text = "";
                        dtpPaymentDate.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Multiple Delete");
                    }

                }
                else
                {

                    MessageBox.Show("Your transaction has been canceled.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }

       

        private void btnInvoiceUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                InvoiceHeader invoiceHeader = db.InvoiceHeaders.Find(invoiceID);
                invoiceHeader.CustomerID = Convert.ToInt32(cbCustomer.SelectedValue);
                invoiceHeader.InvoiceID = Convert.ToInt32(txtInvoiceNo.Text);
                invoiceHeader.InvoiceDate = dtpInvoiceDate.Value;
                invoiceHeader.PaymentDate = dtpPaymentDate.Value;
                invoiceHeader.DeliveryNote = txtDeliverNote.Text;
                db.SaveChanges();
                InvoiceHeaderFill();
                txtDeliverNote.Text = "";
                txtInvoiceNo.Text = "";
                cbCustomer.Text = "";
                dtpInvoiceDate.Text = "";
                dtpPaymentDate.Text = "";


            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }

        private void btnInvoiceHeaderMultipleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvInvoiceHeader.SelectedRows.Count > 1)
                    {
                        foreach (DataGridViewRow drow in dgvInvoiceHeader.SelectedRows)
                        {
                            invoiceID = Convert.ToInt32(dgvInvoiceHeader.Rows[dgvInvoiceHeader.CurrentRow.Index].Cells[0].Value.ToString());
                            InvoiceHeader invoiceHeader = db.InvoiceHeaders.Find(invoiceID);
                            db.InvoiceHeaders.Remove(invoiceHeader);
                            db.SaveChanges();
                            InvoiceHeaderFill();
                            txtDeliverNote.Text = "";
                            txtInvoiceNo.Text = "";
                            cbCustomer.Text = "";
                            dtpInvoiceDate.Text = "";
                            dtpPaymentDate.Text = "";
                        }
                        InvoiceHeaderFill();
                        txtDeliverNote.Text = "";
                        txtInvoiceNo.Text = "";
                        cbCustomer.Text = "";
                        dtpInvoiceDate.Text = "";
                        dtpPaymentDate.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("Delete");
                    }

                }
                else
                {

                    MessageBox.Show("Your transaction has been canceled.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }
        
        private void tsbInvoiceHeader_Click(object sender, EventArgs e)
        {
            grbHedaer.Visible = true;
            grbInvoiceHeaderList.Visible = true;
            grbInvoiceDetails.Visible = false;
          
            
            GetCustomer();
            InvoiceHeaderFill();
        }

        private void tsbInvoiceDetails_Click(object sender, EventArgs e)
        {
          
            grbHedaer.Visible = false;
            grbInvoiceHeaderList.Visible = false;
        
            GetProduct();
            InvoiceDetailsFill();
        }

        private void cbProduct_TextChanged(object sender, EventArgs e)
        {
            
            productID = Convert.ToInt32(cbProduct.SelectedValue);
            Product product = db.Products.Find(productID);
            lblInvoiceUnitPrice.Text ="Unit Price: "+ product.UnitPrice.ToString();
            lblUnitPriceVatAmount.Text ="Vat Amount: %18";
            InvoiceDetailsFill();

          
        }

     

        private void btnGoDetails_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceHeader.SelectedRows.Count <= 1)
            {
                grbInvoiceDetails.Visible = true;
                tsbInvoiceDetails.PerformClick();
                InvoiceDetailsFill();
                txtQuantity.Text = "";
                cbProduct.Text = "";
                txtDesricpiton.Text = "";
                lblUnitPriceVatAmount.Text = "";
                lblInvoiceAmountWithVat.Text = "";
                lblUnitPriceVatAmount.Text = "";
               
            }
            else
            {
                MessageBox.Show("error");
            }

            
        }

        private void btnInvoiceDateilsAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtQuantity.Text != "" && cbProduct.Text != "")
                {
                    Product product = db.Products.Find(productID);
                    InvoiceDetails invoiceDetails = new InvoiceDetails();
                    invoiceDetails.InvoiceID = invoiceID;
                    invoiceDetails.ProductID = productID;
                    invoiceDetails.Quantity = Convert.ToInt32(txtQuantity.Text);
                    invoiceDetails.UnitPrice = product.UnitPrice * invoiceDetails.Quantity;
                    invoiceDetails.VATAmount = 1.18;
                    invoiceDetails.AmountWithVAT = invoiceDetails.UnitPrice * invoiceDetails.VATAmount;
                    invoiceDetails.Description = txtDesricpiton.Text;
                    db.InvoiceDetails.Add(invoiceDetails);
                    db.SaveChanges();
                    InvoiceDetailsFill();
                    cbProduct.Text = "";
                    txtQuantity.Text = "";
                    txtDesricpiton.Text = "";
                    lblUnitPriceVatAmount.Text = "";
                    lblInvoiceAmountWithVat.Text = "";
                    lblUnitPriceVatAmount.Text = "";
                    Total();



                }
                else
                {
                    MessageBox.Show("Please fill in all fields");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(" ", ex.Message);
            }
        }

        private void btnInvoiceDetailsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvInvoiceDetails.SelectedRows.Count == 1)
                    {
                        InvoiceDetails invoiceDtails = db.InvoiceDetails.Find(invoiceID, productID);
                        db.InvoiceDetails.Remove(invoiceDtails);
                        db.SaveChanges();
                        InvoiceDetailsFill();
                        cbProduct.Text = "";
                        txtQuantity.Text = "";
                        txtDesricpiton.Text = "";
                        lblUnitPriceVatAmount.Text = "";
                        lblInvoiceAmountWithVat.Text = "";
                        lblUnitPriceVatAmount.Text = "";
                        Total();
                    }
                    else
                    {
                        MessageBox.Show("Multiple Delete");
                    }

                }
                else
                {

                    MessageBox.Show("Your transaction has been canceled.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }

        private void dgvInvoiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                productID = Convert.ToInt32(dgvInvoiceDetails.Rows[dgvInvoiceDetails.CurrentRow.Index].Cells[1].Value.ToString());
                InvoiceDetails invoiceDetails = db.InvoiceDetails.Find(invoiceID, productID);
                cbProduct.Text = invoiceDetails.product.ProductName;
                txtDesricpiton.Text = invoiceDetails.Description;
                txtQuantity.Text = invoiceDetails.Quantity.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

            }
        }
        public void Total()
        {
            double total = 0;
            for (int i = 0; i < dgvInvoiceDetails.Rows.Count; i++)
            {
                total += Convert.ToInt32(dgvInvoiceDetails.Rows[i].Cells[5].Value);
            }
            InvoiceHeader invoiceHeader = db.InvoiceHeaders.Find(invoiceID);
            invoiceHeader.TotalAmount = Convert.ToDecimal(total);
            db.SaveChanges();
           
        }

        private void btnİnvoiceDetailsUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                productID = Convert.ToInt32(dgvInvoiceDetails.Rows[dgvInvoiceDetails.CurrentRow.Index].Cells[1].Value.ToString());
                Product product = db.Products.Find(productID);
                InvoiceDetails invoiceDetails = db.InvoiceDetails.Find(invoiceID, productID);
                invoiceDetails.InvoiceID = invoiceID;
                invoiceDetails.ProductID = productID;
                invoiceDetails.Quantity = Convert.ToInt32(txtQuantity.Text);
                invoiceDetails.UnitPrice = product.UnitPrice * invoiceDetails.Quantity;
                invoiceDetails.VATAmount = 1.18;
                invoiceDetails.AmountWithVAT = invoiceDetails.UnitPrice * invoiceDetails.Quantity * invoiceDetails.VATAmount;
                invoiceDetails.Description = txtDesricpiton.Text;
                db.SaveChanges();
                InvoiceDetailsFill();
                cbProduct.Text = "";
                txtQuantity.Text = "";
                txtDesricpiton.Text = "";
                lblUnitPriceVatAmount.Text = "";
                lblInvoiceAmountWithVat.Text = "";
                lblUnitPriceVatAmount.Text = "";
                Total();
            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }

        private void btnInvoiceDetailsMultipleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvInvoiceDetails.SelectedRows.Count > 1)
                    {
                        foreach (DataGridViewRow drow in dgvInvoiceDetails.SelectedRows)
                        {
                            productID= Convert.ToInt32(dgvInvoiceDetails.Rows[dgvInvoiceHeader.CurrentRow.Index].Cells[1].Value.ToString());
                            InvoiceDetails invoiceDtails = db.InvoiceDetails.Find(invoiceID, productID);
                            db.InvoiceDetails.Remove(invoiceDtails);
                            db.SaveChanges();
                          
                        }
                        InvoiceDetailsFill();
                        cbProduct.Text = "";
                        txtQuantity.Text = "";
                        txtDesricpiton.Text = "";
                        lblUnitPriceVatAmount.Text = "";
                        lblInvoiceAmountWithVat.Text = "";
                        lblUnitPriceVatAmount.Text = "";
                        Total();


                    }
                    else
                    {
                        MessageBox.Show("Delete");
                    }

                }
                else
                {

                    MessageBox.Show("Your transaction has been canceled.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }

       

        private void dgvInvoiceHeader_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                invoiceID = Convert.ToInt32(dgvInvoiceHeader.Rows[dgvInvoiceHeader.CurrentRow.Index].Cells[0].Value.ToString());

                InvoiceHeader invoiceHeader = db.InvoiceHeaders.Find(invoiceID);
                txtDeliverNote.Text = invoiceHeader.DeliveryNote;
                txtInvoiceNo.Text = invoiceHeader.InvoiceID.ToString();
                cbCustomer.Text = invoiceHeader.customer.CompanyName;
                dtpInvoiceDate.Text = invoiceHeader.InvoiceDate.ToString();
                dtpPaymentDate.Text = invoiceHeader.PaymentDate.ToString();
                if (dgvInvoiceHeader.SelectedRows.Count == 1)
                {
                    btnGoDetails.Enabled = true;

                }
                else
                {
                    btnGoDetails.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

            }
        }

        private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        {
            if (cbProduct.Text != "" && txtQuantity.Text!=" ")
            {
                productID = Convert.ToInt32(cbProduct.SelectedValue);
                Product product = db.Products.Find(productID);
                double unitPrice = (Convert.ToDouble(product.UnitPrice));
                lblInvoiceAmountWithVat.Text = ((Convert.ToInt32(txtQuantity.Text)) * unitPrice * (1.18)).ToString();
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            int a = dgvInvoiceDetails.Rows.Count;
            if (a == 0)
            {
                InvoiceHeader invoiceHeader = db.InvoiceHeaders.Find(invoiceID);

                db.InvoiceHeaders.Remove(invoiceHeader);
                db.SaveChanges();
                MessageBox.Show("Bos silindi");
                tsbInvoiceHeader.PerformClick();
            }
            else
            {
                MessageBox.Show("Kayıt basarılı");
                tsbInvoiceHeader.PerformClick();
            }
        }
       
        public void InvoiceHeaderFill()
        {
            if (cbCustomer.Text != "")
            {
                DateTime today = DateTime.Now.Date;
                List<MyEntityInvoiceHeader> invoiceHeader = db.InvoiceHeaders.Where(x => x.CustomerID==customerID && x.InvoiceDate == today)
                .Select(x => new MyEntityInvoiceHeader
                {
                    invoiceNo=x.InvoiceID,
                    Customer=x.customer.CompanyName,
                    Total=x.TotalAmount,
                    InvoiceDate=x.InvoiceDate,
                    PaymentDate=x.PaymentDate,
                    DeliveryNote=x.DeliveryNote
                    
                    
                }).ToList();
                dgvInvoiceHeader.DataSource = invoiceHeader;
            }
            //else
            //{
            //    DateTime today = DateTime.Now;
            //    List<MyEntityInvoiceHeader> invoiceHeader = db.InvoiceHeaders.Where(x => x.InvoiceDate == today)
            //        .Select(x => new MyEntityInvoiceHeader
            //    {
            //        invoiceNo = x.InvoiceID,
            //        Customer = x.customer.CompanyName,
            //        Total = x.TotalAmount,
            //        InvoiceDate = x.InvoiceDate,
            //        PaymentDate = x.PaymentDate,
            //        DeliveryNote = x.DeliveryNote


            //    }).ToList();
            //    dgvInvoiceHeader.DataSource = invoiceHeader;

            //}
        }
      
        public void InvoiceDetailsFill()
        {
            if (cbProduct.Text!="")
            {
                List<MyEntityInvoiceDetails> invoiceDatails = db.InvoiceDetails.Where(x => x.InvoiceID== invoiceID )
                    .Select(x => new MyEntityInvoiceDetails
                {
                    InvoiceNo = x.InvoiceID,
                    ProductNo = x.ProductID,
                    Quantity = x.Quantity,
                    UnitPrice = x.product.UnitPrice,
                    VatAmount = x.VATAmount,
                    AmountWithVat = x.AmountWithVAT,
                    Descirtion = x.Description



                }).ToList();
                dgvInvoiceDetails.DataSource = invoiceDatails;
                
              
              
            }
         
        }
    }
}
