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
    public partial class UnitForm : Form
    {
        InvoiceContext db = DbSingleTone.GetInstance();
        int unitID;
        public UnitForm()
        {
            InitializeComponent();
        }
        private void UnitForm_Load(object sender, EventArgs e)
        {
            UnitFill();
            txtUnitName.Text = "";
        }
        public void UnitFill()
        {
            List<MyEntityUnit> unit = db.Units.Select(x => new MyEntityUnit
            {
                ID = x.UnitID,
                UnitName = x.UnitName
            }).ToList();
            dgvUnit.DataSource = unit;

        }
        private void btnUnitAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUnitName.Text != "")
                {
                    Unit unit = new Unit();
                    unit.UnitName = txtUnitName.Text;
                    db.Units.Add(unit);
                    db.SaveChanges();
                    txtUnitName.Text = "";
                    UnitFill();
                }
                else
                {
                    MessageBox.Show("Please fill in all fields");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("error : "+ex.Message);
            }
        }

        private void btnUnitDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvUnit.SelectedRows.Count == 1)
                    {
                        Unit unit = db.Units.Find(unitID);
                        db.Units.Remove(unit);
                        db.SaveChanges();
                        txtUnitName.Text = "";
                        UnitFill();
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

        private void btnUnitUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Unit unit = db.Units.Find(unitID);
                unit.UnitName = txtUnitName.Text;
                db.SaveChanges();
                txtUnitName.Text = "";
                UnitFill();

            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            }
        }

        private void btnUnitMultipleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure your data will be deleted?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvUnit.SelectedRows.Count > 1)
                    {
                        foreach (DataGridViewRow drow in dgvUnit.SelectedRows)
                        {
                            unitID = Convert.ToInt32(drow.Cells[0].Value);
                            Unit unit = db.Units.Find(unitID);
                            db.Units.Remove(unit);
                            db.SaveChanges();
                        }
                        txtUnitName.Text = "";
                        UnitFill();
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

        private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                unitID = Convert.ToInt32(dgvUnit.Rows[dgvUnit.CurrentRow.Index].Cells[0].Value.ToString());

                Unit unit = db.Units.Find(unitID);
                txtUnitName.Text = unit.UnitName;


            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

            }
        }

     
    }
}
