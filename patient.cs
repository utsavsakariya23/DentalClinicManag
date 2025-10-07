using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManag
{
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();

            // Convert date to SQL-compatible format (yyyy-MM-dd)
            string dob = DOBDate.Value.ToString("yyyy-MM-dd");

            // Build SQL query safely formatted
            string query = "INSERT INTO PatientTbl (PatName, PatPhone, PatAddress, PatDOB, PatGender, PatAllergies) " +
                           "VALUES ('" + PatNameTb.Text + "', '" + PatPhoneTb.Text + "', '" + AddressTb.Text + "', '" + dob + "', '" + GenCb.SelectedItem.ToString() + "', '" + AllergyTb.Text + "')";

            try
            {
                // Use your MyPatient object to run query
                Pat.AddPatient(query);
                MessageBox.Show("Patient Successfully Added");
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select * from PatientTbl";
            DataSet ds = Pat.ShowPatient(query);
            PatientDGV.DataSource = ds.Tables[0];
        }
        private void patient_Load(object sender, EventArgs e)
        {
            Populate();

        }

        int key = 0;
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row index is valid
            if (e.RowIndex >= 0 && PatientDGV.Rows[e.RowIndex].Cells.Count >= 7)
            {
                DataGridViewRow row = PatientDGV.Rows[e.RowIndex];

                PatNameTb.Text = row.Cells[1].Value?.ToString();
                PatPhoneTb.Text = row.Cells[2].Value?.ToString();
                AddressTb.Text = row.Cells[3].Value?.ToString();
                GenCb.SelectedItem = row.Cells[5].Value?.ToString();
                AllergyTb.Text = row.Cells[6].Value?.ToString();

                // Store key (e.g., PatId)
                key = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select The Patient");
            }
            else
            {
                try
                {
                    string query = "Delete from PatientTbl where PatId = " + key + "";
                    Pat.DeletePatient(query);
                    MessageBox.Show("Patient Successfully Deleted.");
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();

            if (key == 0)
            {
                MessageBox.Show("Select The Patient");
            }
            else
            {
                try
                {
                    string dob = DOBDate.Value.ToString("yyyy-MM-dd"); // format DateTime safely

                    string query = "UPDATE PatientTbl SET " +
                                   "PatName = '" + PatNameTb.Text + "', " +
                                   "PatPhone = '" + PatPhoneTb.Text + "', " +
                                   "PatAddress = '" + AddressTb.Text + "', " +
                                   "PatDOB = '" + dob + "', " +
                                   "PatGender = '" + GenCb.SelectedItem.ToString() + "', " +
                                   "PatAllergies = '" + AllergyTb.Text + "' " +
                                   "WHERE PatId = " + key;

                    Pat.UpdatePatient(query); // call your existing method that takes a string query

                    MessageBox.Show("Patient Successfully Updated.");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
    }
}
