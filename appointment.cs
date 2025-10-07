using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DentalClinicManag
{
    public partial class appointment : Form
    {
        public appointment()
        {
            InitializeComponent();
        }
        ConnectionString MyCon = new ConnectionString();

        private void fillpatient()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from PatientTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatName", typeof(string));
            dt.Load(Rdr);
            PatientCb.ValueMember = "PatName";
            PatientCb.DataSource = dt;
            Con.Close();
        }
        private void filltreatment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from TreatmentTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TreatName", typeof(string));
            dt.Load(Rdr);
            TreatmentCb.ValueMember = "TreatName";
            TreatmentCb.DataSource = dt;
            Con.Close();
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && AppointmentDGV.Rows[e.RowIndex].Cells.Count >= 5)
            {
                DataGridViewRow row = AppointmentDGV.Rows[e.RowIndex];

                PatientCb.SelectedValue = row.Cells[1].Value?.ToString();
                TreatmentCb.SelectedValue = row.Cells[2].Value?.ToString();
                // Store key (e.g., PatId)
                key = Convert.ToInt32(row.Cells[0].Value);
            }
        }
        void Populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select * from AppointmentTbl";
            DataSet ds = Pat.ShowPatient(query);
            AppointmentDGV.DataSource = ds.Tables[0];
        }
        private void appointment_Load(object sender, EventArgs e)
        {
            fillpatient();
            filltreatment();
            Populate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into AppointmentTbl values('" + PatientCb.SelectedValue.ToString() + "','" + TreatmentCb.SelectedValue.ToString() + "','" + Date.Value.Date + "','" + Time.Value.TimeOfDay + "')";

            MyPatient Pat = new MyPatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Appointment Successfully Added");
                Populate();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select The Appointment");
            }
            else
            {
                try
                {
                    string query = "Delete from AppointmentTbl where ApId = " + key + "";
                    Pat.DeletePatient(query);
                    MessageBox.Show("Appointment Successfully Cancelled.");
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select The Appointment");
            }
            else
            {
                try
                {
                    string query = "Delete from AppointmentTbl where ApId = " + key + "";
                    Pat.DeletePatient(query);
                    MessageBox.Show("Appointment Successfully Cancelled.");
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
                MessageBox.Show("Select The Appointment");
            }
            else
            {
                try
                {
                    // FIX 3: Force ISO 8601 format for Date and Time
                    string apDateString = Date.Value.Date.ToString("yyyy-MM-dd");
                    string apTimeString = Time.Value.TimeOfDay.ToString("hh\\:mm\\:ss"); // Format as HH:MM:SS

                    // Build the fixed query
                    string query = "UPDATE AppointmentTbl SET " +
                                   "Patient = '" + PatientCb.SelectedValue.ToString() + "', " +
                                   // FIX 1: Added parentheses () to ToString()
                                   "Treatment = '" + TreatmentCb.SelectedValue.ToString() + "', " +
                                   "ApDate = '" + apDateString + "', " +
                                   // FIX 2: Added the missing comma (', ') before the ApTime assignment
                                   "ApTime = '" + apTimeString + "' " +
                                   "WHERE ApId = " + key;

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
    }
}
