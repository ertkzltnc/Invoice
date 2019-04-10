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
    public partial class CountyForm : Form
    {
        InvoiceContext db = DbSingleTone.GetInstance();
        int cityID, countyID;
        public CountyForm()
        {
           
            InitializeComponent();
        }
        private void CountyForm_Load(object sender, EventArgs e)
        {
            GetCity();
            CountyFill();
        }
        public void GetCity()
        {
             List<City> cityList = db.Citys.ToList();

            cbCity.DisplayMember = "Description";
            cbCity.ValueMember = "CityID";
            cbCity.DataSource = cityList;
            cbCity.Text = "";
        }
        public void CountyFill()
        {
            if (cbCity.Text!="")
            {
                List<MyEntityCounty> county = db.Countys.Where(x => x.CityID == cityID).Select(x => new MyEntityCounty
                {
                    ID = x.CountyID,
                    CountyName = x.Description,
                    CityName = x.city.Description
                }).ToList();
                dgvCounty.DataSource = county;
            }
            else
            {
                List<MyEntityCounty> county = db.Countys.Select(x => new MyEntityCounty
                {
                    ID = x.CountyID,
                    CountyName = x.Description,
                    CityName = x.city.Description
                }).ToList();
                dgvCounty.DataSource = county;
            }
           
        }

        private void cbCity_TextChanged(object sender, EventArgs e)
        {
            cityID = Convert.ToInt32(cbCity.SelectedValue);
            CountyFill();
           
        }

        private void dgvCounty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                countyID = Convert.ToInt32(dgvCounty.Rows[dgvCounty.CurrentRow.Index].Cells[0].Value.ToString());

                County county = db.Countys.Find(countyID);
                txtCountyName.Text = county.Description;
                cbCity.Text = county.city.Description;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

            }
        }

        private void btnCountyDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvCounty.SelectedRows.Count == 1)
                    {
                        County county = db.Countys.Find(countyID);
                        db.Countys.Remove(county);
                        db.SaveChanges();
                        CountyFill();
                        txtCountyName.Text = "";
                        cbCity.Text = "";

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

        private void btnCountyUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                County county = db.Countys.Find(countyID);
                county.Description = txtCountyName.Text;
                county.CityID = Convert.ToInt32(cbCity.SelectedValue);
                db.SaveChanges();
                CountyFill();
                txtCountyName.Text = "";
                cbCity.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }

        private void btnCountyMultipleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvCounty.SelectedRows.Count > 1)
                    {
                        foreach (DataGridViewRow drow in dgvCounty.SelectedRows)
                        {
                            countyID = Convert.ToInt32(drow.Cells[0].Value);
                            County county = db.Countys.Find(countyID);
                            db.Countys.Remove(county);
                            db.SaveChanges();

                        }
                        CountyFill();
                        txtCountyName.Text = "";
                        cbCity.Text = "";

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

        private void btnCountyAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCountyName.Text != "" && cbCity.Text!="")
                {
                    County county = new County();
                    county.Description = txtCountyName.Text;
                    county.CityID = Convert.ToInt32(cbCity.SelectedValue);
                    db.Countys.Add(county);
                    db.SaveChanges();
                    CountyFill();
                    txtCountyName.Text = "";
                    cbCity.Text = "";

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

       
    }
}
