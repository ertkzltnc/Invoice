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
    
    public partial class CustomerForm : Form
    {
        InvoiceContext db = DbSingleTone.GetInstance();
        int customerID, cityID, countyID;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetCity();
            GetCounty();
            CustomerFill();
        }
        public void GetCity()
        {
            List<City> cityList = db.Citys.ToList();

            cbCustomerCity.DisplayMember = "Description";
            cbCustomerCity.ValueMember = "CityID";
            cbCustomerCity.DataSource = cityList;
            cbCustomerCity.Text = "";
        }

        private void cbCustomerCity_TextChanged(object sender, EventArgs e)
        {
            cityID = Convert.ToInt32(cbCustomerCity.SelectedValue);
            GetCounty();
        }

        private void cbCustomerCounty_TextChanged(object sender, EventArgs e)
        {
            countyID = Convert.ToInt32(cbCustomerCounty.SelectedValue);
            CustomerFill();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                customerID = Convert.ToInt32(dgvCustomer.Rows[dgvCustomer.CurrentRow.Index].Cells[0].Value.ToString());

                Customer customer = db.Customers.Find(customerID);
                txtCustomerName.Text = customer.CompanyName;
                txtCustomerAddress.Text = customer.Address;
                cbCustomerCity.Text = customer.county.city.Description;
                cbCustomerCounty.Text = customer.county.Description;
            }

            catch (Exception ex)
            {
                MessageBox.Show("error");

            }
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCustomerCounty.Text != "" && txtCustomerName.Text != "")
                {
                    Customer customer = new Customer();
                    customer.CompanyName = txtCustomerName.Text;
                    customer.Address = txtCustomerAddress.Text;
                    customer.CountyID = Convert.ToInt32(cbCustomerCounty.SelectedValue);
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    txtCustomerAddress.Text = "";
                    txtCustomerName.Text = "";
                    cbCustomerCounty.Text = "";
                    cbCustomerCity.Text = "";

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

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvCustomer.SelectedRows.Count == 1)
                    {
                        Customer customer = db.Customers.Find(customerID);
                        db.Customers.Remove(customer);
                        db.SaveChanges();
                        CustomerFill();
                        txtCustomerAddress.Text = "";
                        txtCustomerName.Text = "";
                        cbCustomerCounty.Text = "";
                        cbCustomerCity.Text = "";

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

        private void btnCustomerMultipleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvCustomer.SelectedRows.Count > 1)
                    {
                        foreach (DataGridViewRow drow in dgvCustomer.SelectedRows)
                        {
                            customerID = Convert.ToInt32(drow.Cells[0].Value);
                            Customer customer = db.Customers.Find(customerID);
                            db.Customers.Remove(customer);
                            db.SaveChanges();


                        }
                        CustomerFill();
                        txtCustomerAddress.Text = "";
                        txtCustomerName.Text = "";
                        cbCustomerCounty.Text = "";
                        cbCustomerCity.Text = "";

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

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = db.Customers.Find(customerID);
                customer.CompanyName = txtCustomerName.Text;
                customer.Address = txtCustomerAddress.Text;
                customer.CountyID = Convert.ToInt32(cbCustomerCounty.SelectedValue);
                db.SaveChanges();
                txtCustomerAddress.Text = "";
                txtCustomerName.Text = "";
                cbCustomerCounty.Text = "";
                cbCustomerCity.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }

        public void GetCounty()
        {
            if (cbCustomerCity.Text!="")
            {
               
                List<County> countyList = db.Countys.Where(x => x.CityID == cityID).ToList();

                cbCustomerCounty.DisplayMember = "Description";
                cbCustomerCounty.ValueMember = "CountyID";
                cbCustomerCounty.DataSource = countyList;
                cbCustomerCounty.Text = "";

            }
            else
            {

                List<County> countyList = db.Countys.ToList();

                cbCustomerCounty.DisplayMember = "Description";
                cbCustomerCounty.ValueMember = "CountyID";
                cbCustomerCounty.DataSource = countyList;
                cbCustomerCounty.Text = "";

            }
        }
        public void CustomerFill()
        {
            if (cbCustomerCounty.Text!="")
            {
                List<MyEntityCustomer> customer = db.Customers.Where(x => x.CountyID == countyID).Select(x => new MyEntityCustomer
                {
                   ID=x.CustomerID,
                   Name=x.CompanyName,
                   CityName=x.county.city.Description,
                   CountyName=x.county.Description,
                   Adress=x.Address
                }).ToList();
                dgvCustomer.DataSource = customer;
            }
            else
            {
                List<MyEntityCustomer> customer = db.Customers.Select(x => new MyEntityCustomer
                {
                    ID = x.CustomerID,
                    Name = x.CompanyName,
                    CityName = x.county.city.Description,
                    CountyName = x.county.Description,
                    Adress = x.Address
                }).ToList();
                dgvCustomer.DataSource = customer;
            }
        }
    }
}
