using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst_Invoice.Context;
using CodeFirst_Invoice.Entity;

namespace CodeFirst_Invoice
{
    public partial class StartForm : Form
    {
        InvoiceContext db = DbSingleTone.GetInstance();
        public StartForm()
        {
            InitializeComponent();
        }
        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width + 20;
            this.Height = _childForm.Height + 67;



            bool status = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == _childForm.Name)
                {
                    status = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }

            if (status == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
                _childForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void countryDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CountyForm());
        }

        private void customerDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CustomerForm());
        }

        private void productDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new ProductForm());
        }

        private void cityDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CityForm());
        }

        private void ınvoiceViewQueryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new InvoiceForm());
        }

        private void createNewInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new NewInvoiceForm());
        }

        private void unitDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new UnitForm());
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Your Application Will Close ? ", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Environment.Exit(0);
            }
            //if (MessageBox.Show("Your Application Will Close ? ", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //{
            //    MessageBox.Show("Your transaction has been canceled.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Show();
            //}
            //else
            //{

            //    MessageBox.Show("Your transaction has been canceled.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //      this.Show(); 
               
                
            //}
        }
    }
}
