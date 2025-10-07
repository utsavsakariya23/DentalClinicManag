using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManag
{
    public partial class treatment : Form
    {
        public treatment()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void Populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select * from TreatmentTbl";
            DataSet ds = Pat.ShowPatient(query);
            TreatmentDGV.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into TreatmentTbl values('" + TreatNameTb.Text + "'," + TreatCost.Text + ",'" + TreatDesc.Text + "')";

            MyPatient Pat = new MyPatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Treatment Successfully Added");
                Populate();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void TreatmentDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row index is valid
            if (e.RowIndex >= 0 && TreatmentDGV.Rows[e.RowIndex].Cells.Count >= 4)
            {
                DataGridViewRow row = TreatmentDGV.Rows[e.RowIndex];

                TreatNameTb.Text = row.Cells[1].Value?.ToString();
                TreatCost.Text = row.Cells[2].Value?.ToString();
                TreatDesc.Text = row.Cells[3].Value?.ToString();
                // Store key (e.g., PatId)
                key = Convert.ToInt32(row.Cells[0].Value);
            }

        }

        private void treatment_Load(object sender, EventArgs e)
        {
            Populate();
        }
        int key = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select The Treatment");
            }
            else
            {
                try
                {
                    string query = "UPDATE TreatmentTbl SET " +
                        "TreatName = '" + TreatNameTb.Text + "', " +
                        "TreatCost = '" + TreatCost.Text + "', " +
                        "TreatDesc = '" + TreatDesc.Text + "' " +
                        "WHERE TreatId = " + key;

                    Pat.UpdatePatient(query);

                    MessageBox.Show("Treatment Successfully Updated.");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select The Treatment");
            }
            else
            {
                try
                {
                    string query = "Delete from TreatmentTbl where TreatId = " + key + "";
                    Pat.DeletePatient(query);
                    MessageBox.Show("Treatment Successfully Deleted.");
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }
    }
}

