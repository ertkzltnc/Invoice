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
    public partial class ProductForm : Form
    {

        InvoiceContext db = DbSingleTone.GetInstance();
        int productID, unitID;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetUnit();
            ProductFill();
        }
        public void GetUnit()
        {
            List<Unit> unitList = db.Units.ToList();

            cbUnit.DisplayMember = "UnitName";
            cbUnit.ValueMember = "UnitID";
            cbUnit.DataSource = unitList;
            cbUnit.Text = "";
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text != "" && cbUnit.Text != "")
                {
                    Product product = new Product();
                    product.ProductName = txtProductName.Text;
                    product.ProductCode = Convert.ToInt32(txtProductCode.Text);
                    product.UnitID = Convert.ToInt32(cbUnit.SelectedValue);
                    product.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
                    db.Products.Add(product);
                    db.SaveChanges();
                    ProductFill();
                    txtUnitPrice.Text = "";
                    txtProductName.Text = "";
                    txtProductCode.Text = "";
                    cbUnit.Text = "";

                }
                else
                {
                    MessageBox.Show("Please fill in all fields");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }

        }

        private void cbUnit_TextChanged(object sender, EventArgs e)
        {
            unitID = Convert.ToInt32(cbUnit.SelectedValue);
            ProductFill();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                productID = Convert.ToInt32(dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value.ToString());

                Product product = db.Products.Find(productID);
                txtProductName.Text = product.ProductName;
                txtProductCode.Text = product.ProductCode.ToString();
                txtUnitPrice.Text = product.UnitPrice.ToString();
                cbUnit.Text = product.unit.UnitName;
                



            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

            }
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvProduct.SelectedRows.Count == 1)
                    {
                        Product product = db.Products.Find(productID);
                        db.Products.Remove(product);
                        db.SaveChanges();
                        ProductFill();
                        txtUnitPrice.Text = "";
                        txtProductName.Text = "";
                        txtProductCode.Text = "";
                        cbUnit.Text = "";


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

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = db.Products.Find(productID);
                product.ProductName = txtProductName.Text;
                product.ProductCode = Convert.ToInt32(txtProductCode.Text);
                product.UnitID = Convert.ToInt32(cbUnit.SelectedValue);
                product.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
                db.SaveChanges();
                ProductFill();
                txtUnitPrice.Text = "";
                txtProductName.Text = "";
                txtProductCode.Text = "";
                cbUnit.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }

        private void btnProductMultipleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvProduct.SelectedRows.Count > 1)
                    {
                        foreach (DataGridViewRow drow in dgvProduct.SelectedRows)
                        {
                            productID = Convert.ToInt32(drow.Cells[0].Value);
                            Product product = db.Products.Find(productID);
                            db.Products.Remove(product);
                            db.SaveChanges();
                            ProductFill();

                        }
                        txtUnitPrice.Text = "";
                        txtProductName.Text = "";
                        txtProductCode.Text = "";
                        cbUnit.Text = "";

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

        public void ProductFill()
        {
            if (cbUnit.Text != "")
            {
                List<MyEntityProduct> product = db.Products.Where(x => x.UnitID == unitID).Select(x => new MyEntityProduct
                {
                    ID = x.ProductID,
                    ProductName=x.ProductName,
                    Code=x.ProductCode,
                    Unit = x.unit.UnitName
                }).ToList();
                dgvProduct.DataSource = product;
            }
            else
            {
                List<MyEntityProduct> product = db.Products.Where(x => x.UnitID == unitID).Select(x => new MyEntityProduct
                {
                    ID = x.ProductID,
                    ProductName = x.ProductName,
                    Code = x.ProductCode,
                    Unit = x.unit.UnitName
                }).ToList();
                dgvProduct.DataSource = product;
            }
        }

    }
}
