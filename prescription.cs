using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DentalClinicManag
{
    public partial class prescription : Form
    {
        public prescription()
        {
            InitializeComponent();
        }
        ConnectionString MyCon = new ConnectionString();

        private void fillpatient()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Patient from AppointmentTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Patient", typeof(string));
            dt.Load(Rdr);
            PatientCb.ValueMember = "Patient";
            PatientCb.DataSource = dt;
            Con.Close();
        }
        private void fillTreatment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TreatName from TreatmentTbl ", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Patient", typeof(string));
            dt.Load(Rdr);
            PatientCb.ValueMember = "Patient";
            PatientCb.DataSource = dt;
            Con.Close();
        }
        private void GetTreatment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from AppointmentTbl where Patient='" + PatientCb.SelectedValue.ToString() + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreatmentTb.Text = dr["Treatment"].ToString();
            }
            Con.Close();
        }
        private void GetPrice()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from TreatmentTbl where TreatName='" + TreatmentTb.Text + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreatCostTb.Text = dr["TreatCost"].ToString();
            }
            Con.Close();
        }

        private void prescription_Load(object sender, EventArgs e)
        {
            fillpatient();
            Populate();
            PrescriptionDGV.CellClick += PrescriptionDGV_CellClick;

        }

        private void PatientCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTreatment();
        }

        private void TreatmentTb_TextChanged(object sender, EventArgs e)
        {
            GetPrice();
        }

        void Populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select * from PrescriptionTbl";
            DataSet ds = Pat.ShowPatient(query);
            PrescriptionDGV.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into PrescriptionTbl values('" + PatientCb.SelectedValue.ToString() + "','" + TreatmentTb.Text + "'," + TreatCostTb.Text + ",'" + MedicinesTb.Text + "'," + QtyTb.Text + ")";

            MyPatient Pat = new MyPatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Prescription Successfully Added");
                Populate();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void PrescriptionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //PatientCb.SelectedValue = PrescriptionDGV.SelectedRows[0].Cells[1].Value.ToString();
            //TreatmentTb.Text = PrescriptionDGV.SelectedRows[0].Cells[2].Value.ToString();
            //TreatCostTb.Text = PrescriptionDGV.SelectedRows[0].Cells[3].Value.ToString();
            //MedicinesTb.Text = PrescriptionDGV.SelectedRows[0].Cells[4].Value.ToString();
            //QtyTb.Text = PrescriptionDGV.SelectedRows[0].Cells[5].Value.ToString();
            //if (TreatmentTb.Text == "")
            //    key = 0;
            //else
            //    key = Convert.ToInt32(PrescriptionDGV.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void PrescriptionDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PrescriptionDGV.Rows[e.RowIndex];

                // Get values from DataGridView cells (column order must match your SELECT query)
                string patName = row.Cells[1].Value?.ToString();
                string treatName = row.Cells[2].Value?.ToString();
                string treatCost = row.Cells[3].Value?.ToString();
                string medicines = row.Cells[4].Value?.ToString();
                string medQty = row.Cells[5].Value?.ToString();

                // Assign them to TextBoxes on your form
                PatientCb.Text = patName;
                TreatmentTb.Text = treatName;
                TreatCostTb.Text = treatCost;
                MedicinesTb.Text = medicines;
                QtyTb.Text = medQty;

                // Store the primary key (PrescId)
                key = Convert.ToInt32(row.Cells[0].Value);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select The Prescription To Be Deleted");
            }
            else
            {
                try
                {
                    string query = "Delete from PrescriptionTbl where PrescId=" + key + "";
                    Pat.DeletePatient(query);
                    MessageBox.Show("Prescription Successfully Deleted");
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
                MessageBox.Show("Select The Prescription");
            }
            else
            {
                try
                {
                    string query = "UPDATE PrescriptionTbl SET " +
                        "PatName = '" + PatientCb.SelectedValue.ToString() + "', " +
                        "TreatName = '" + TreatmentTb.Text + "', " +
                        "TreatCost = '" + TreatCostTb.Text + "', " +
                        "Medicines = '" + MedicinesTb.Text + "', " +
                        "MedQty = '" + QtyTb.Text + "' " +
                        "WHERE PrescId = " + key;

                    Pat.UpdatePatient(query);
                    MessageBox.Show("Prescription Successfully Updated.");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        void filter()
        {
            MyPatient Pat = new MyPatient();

            string query = "select * from PrescriptionTbl where PatName like '%" + SearchTb.Text + "%' ";
            DataSet ds = Pat.ShowPatient(query);
            PrescriptionDGV.DataSource = ds.Tables[0];
        }
        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            patient pat = new patient();
            pat.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            treatment treat = new treatment();
            treat.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            appointment app = new appointment();
            app.Show();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
    }

}
