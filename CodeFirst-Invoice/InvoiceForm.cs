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

namespace CodeFirst_Invoice
{
    public partial class InvoiceForm : Form
    {
        InvoiceContext db = DbSingleTone.GetInstance();
        int customerID, invoiceID;
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            grbView.Visible = true;
            grbEdit.Visible = false;
            grbQuery.Visible = false;
            InvoiceFill();
        }
        public void InvoiceFill()
        {
            List<MyEntityInvoice> invoiceDatails = db.InvoiceDetails
                      .Select(x => new MyEntityInvoice
                      {
                          InvoiceNo = x.InvoiceID,
                          CustomerNo = x.invoiceHeader.CustomerID,
                          CustomerNAme = x.invoiceHeader.customer.CompanyName,
                          ProdıuıctName = x.product.ProductName,
                          Quantity = x.Quantity,
                          UnitPrice = x.product.UnitPrice,
                          VatAmount = x.VATAmount,
                          AmountWithVat = x.AmountWithVAT,
                          InvoiceDate = x.invoiceHeader.InvoiceDate,
                          PaymentDate = x.invoiceHeader.PaymentDate,
                          Descirtion = x.Description



                      }).ToList();
            dgvViewInvoice.DataSource = invoiceDatails;



        }
        public void GetCustomer()
        {
            List<Customer> customerList = db.Customers.ToList();
            cbCustomerQuery.DisplayMember = "CompanyName";
            cbCustomerQuery.ValueMember = "CustomerID";
            cbCustomerQuery.DataSource = customerList;

            cbCustomerQuery.Text = "";

        }
        public void GetInvoice()
        {
            List<InvoiceHeader> invoiceHeaders = db.InvoiceHeaders.ToList();
            cbInvoiceQuery.DisplayMember = "InvoiceNumarasi";
           
            cbInvoiceQuery.DataSource = invoiceHeaders;

            cbInvoiceQuery.Text = "";

        }
        private void tsbQuery_Click(object sender, EventArgs e)
        {
            grbView.Visible = false;
            grbEdit.Visible = false;
            grbQuery.Visible = true;
            GetCustomer();
            GetInvoice();
        }
        public void InvoiceFillQuery()
        {
            if (cbInvoiceQuery.Text!="" && cbCustomerQuery.Text=="")
            {
                int invoiceID = Convert.ToInt32(cbInvoiceQuery.Text);
                List<MyEntityInvoice> invoiceDatails = db.InvoiceDetails.Where(x=>x.InvoiceID == invoiceID)
                     .Select(x => new MyEntityInvoice
                     {
                         InvoiceNo = x.InvoiceID,
                         CustomerNo = x.invoiceHeader.CustomerID,
                         CustomerNAme = x.invoiceHeader.customer.CompanyName,
                         ProdıuıctName = x.product.ProductName,
                         Quantity = x.Quantity,
                         UnitPrice = x.product.UnitPrice,
                         VatAmount = x.VATAmount,
                         AmountWithVat = x.AmountWithVAT,
                         InvoiceDate = x.invoiceHeader.InvoiceDate,
                         PaymentDate = x.invoiceHeader.PaymentDate,
                         Descirtion = x.Description



                     }).ToList();
                dgvQueryList.DataSource = invoiceDatails;
            }
            else if (cbInvoiceQuery.Text == "" && cbCustomerQuery.Text != "")
            {
                int customerID = Convert.ToInt32(cbCustomerQuery.SelectedValue);
                List<MyEntityInvoice> invoiceDatails = db.InvoiceDetails.Where(x => x.invoiceHeader.CustomerID ==customerID)
                    .Select(x => new MyEntityInvoice
                    {
                        InvoiceNo = x.InvoiceID,
                        CustomerNo=x.invoiceHeader.CustomerID,
                        CustomerNAme = x.invoiceHeader.customer.CompanyName,
                        ProdıuıctName = x.product.ProductName,
                        Quantity = x.Quantity,
                        UnitPrice = x.product.UnitPrice,
                        VatAmount = x.VATAmount,
                        AmountWithVat = x.AmountWithVAT,
                        InvoiceDate = x.invoiceHeader.InvoiceDate,
                        PaymentDate = x.invoiceHeader.PaymentDate,
                        Descirtion = x.Description



                    }).ToList();
                dgvQueryList.DataSource = invoiceDatails;
            }
            else if (cbInvoiceQuery.Text != "" && cbCustomerQuery.Text != "")
            {

                int invoiceID = Convert.ToInt32(cbInvoiceQuery.Text);
                int custmerID = Convert.ToInt32(cbCustomerQuery.SelectedValue);
                List<MyEntityInvoice> invoiceDatails = db.InvoiceDetails.Where(x => x.invoiceHeader.CustomerID == customerID && x.InvoiceID == invoiceID)
                    .Select(x => new MyEntityInvoice
                    {
                        InvoiceNo = x.InvoiceID,
                        CustomerNo = x.invoiceHeader.CustomerID,
                        CustomerNAme = x.invoiceHeader.customer.CompanyName,
                        ProdıuıctName = x.product.ProductName,
                        Quantity = x.Quantity,
                        UnitPrice = x.product.UnitPrice,
                        VatAmount = x.VATAmount,
                        AmountWithVat = x.AmountWithVAT,
                        InvoiceDate = x.invoiceHeader.InvoiceDate,
                        PaymentDate = x.invoiceHeader.PaymentDate,
                        Descirtion = x.Description


                    }).ToList();
                dgvQueryList.DataSource = invoiceDatails;

            }
          



        }
        public void InvoiceFillEdit()
        {
            List<MyEntityEdit> invoiceDatails = db.InvoiceDetails.Where(x => x.InvoiceID == invoiceID)
                    .Select(x => new MyEntityEdit
                    {
                        InvoiceNo = x.InvoiceID,
                        PaymentDate = x.invoiceHeader.PaymentDate,
                        DeliveryNote = x.invoiceHeader.DeliveryNote



                    }).ToList();
            dgvInvoiceEdit.DataSource = invoiceDatails;
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            grbView.Visible = false;
            
            grbQuery.Visible = false;
            InvoiceFillEdit();
        }

        private void btnQuerySearch_Click(object sender, EventArgs e)
        {
            InvoiceFillQuery();
            cbInvoiceQuery.Text = "";
            cbCustomerQuery.Text = "";
        }

        private void btnGoEdit_Click(object sender, EventArgs e)
        {

            if (dgvQueryList.SelectedRows.Count == 1)
            {
                grbEdit.Visible = true;
                tsbEdit.PerformClick();


            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void dgvQueryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                invoiceID = Convert.ToInt32(dgvQueryList.Rows[dgvQueryList.CurrentRow.Index].Cells[0].Value.ToString());
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

            }
        }

        private void dgvInvoiceEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            
              
                InvoiceHeader invoiceHeader = db.InvoiceHeaders.Find(invoiceID);
                txtDeliverNoteEdit.Text = invoiceHeader.DeliveryNote;
                dtpPaymentDateEdit.Text = invoiceHeader.PaymentDate.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

            }
        }

        private void btnInvoiceUpdateEdit_Click(object sender, EventArgs e)
        {
            InvoiceHeader invoiceHeader = db.InvoiceHeaders.Find(invoiceID, customerID);
            invoiceHeader.DeliveryNote = txtDeliverNoteEdit.Text;
            invoiceHeader.PaymentDate = dtpPaymentDateEdit.Value;
            txtDeliverNoteEdit.Text = "";
            dtpPaymentDateEdit.Text = "";
            db.SaveChanges();
            InvoiceFillEdit();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            tsbView.PerformClick();
        }
    }
}
