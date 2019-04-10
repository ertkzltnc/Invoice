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
    public partial class CityForm : Form
    {
        InvoiceContext db = DbSingleTone.GetInstance();
        int cityID;
        public CityForm()
        {
            InitializeComponent();
        }
        

        private void CityForm_Load(object sender, EventArgs e)
        {
            
            CityFill();
           
        }
        public void CityFill()
        {
            List<MyEntityCity> city = db.Citys.Select(x => new MyEntityCity
            {
                ID=x.CityID,
                CityName=x.Description
            }).ToList();
         
            dgvCity.DataSource = city;
           

        }
        private void btnCityAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCityName.Text!="")
                {
                    City city = new City();
                    city.Description = txtCityName.Text;
                    db.Citys.Add(city);
                    db.SaveChanges();
                    txtCityName.Text = "";
                    CityFill();
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

        private void dgvCity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cityID = Convert.ToInt32(dgvCity.Rows[dgvCity.CurrentRow.Index].Cells[0].Value.ToString());

                City city = db.Citys.Find(cityID);
                txtCityName.Text = city.Description;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

            }
        }

        private void btnCityDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvCity.SelectedRows.Count == 1)
                    {
                        City city = db.Citys.Find(cityID);
                        db.Citys.Remove(city);
                        db.SaveChanges();
                        txtCityName.Text = "";
                        CityFill();
                        MessageBox.Show("your transaction took place.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCityMultipleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvCity.SelectedRows.Count > 1)
                    {
                        foreach (DataGridViewRow drow in dgvCity.SelectedRows)
                        {
                            cityID = Convert.ToInt32(drow.Cells[0].Value);
                            City city = db.Citys.Find(cityID);
                            db.Citys.Remove(city);
                            db.SaveChanges();
                        }
                        txtCityName.Text = "";
                        CityFill();
                        MessageBox.Show("your transaction took place.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCityUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                City city = db.Citys.Find(cityID);
                city.Description = txtCityName.Text;
                db.SaveChanges();
                txtCityName.Text = "";
                CityFill();

            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }
    }
}
