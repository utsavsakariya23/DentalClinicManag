using System;
using System.Collections;
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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }
        void Populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select * from UserTbl";
            DataSet ds = Pat.ShowPatient(query);
            UserDGV.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string query = "insert into UserTbl values('" + UNameTb.Text + "','" + PasswordTb.Text + "','" + PhoneTb.Text + "')";

            MyPatient Pat = new MyPatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("User Successfully Added");
                Populate();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void user_Load(object sender, EventArgs e)
        {
            Populate();
            UserDGV.CellClick += UserDGV_CellClick;
        }
        int key = 0;
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select The User To Be Deleted");
            }
            else
            {
                try
                {
                    string query = "Delete from UserTbl where UId=" + key + "";
                    Pat.DeletePatient(query);
                    MessageBox.Show("User Successfully Deleted");
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
                MessageBox.Show("Select The User");
            }
            else
            {
                try
                {
                    string query = "UPDATE UserTbl SET " +
                        "Uname = '" + UNameTb.Text + "', " +
                        "Upass = '" + PasswordTb.Text + "', " +
                        "Phone = '" + PhoneTb.Text + "' " +
                        "WHERE Uid = " + key;

                    Pat.UpdatePatient(query);

                    MessageBox.Show("User Successfully Updated.");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UserDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row index is valid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = UserDGV.Rows[e.RowIndex];

                string uname = row.Cells[1].Value?.ToString();
                string upass = row.Cells[2].Value?.ToString();
                string phone = row.Cells[3].Value?.ToString();

                //MessageBox.Show($"Uname={uname}, Upass={upass}, Phone={phone}");

                UNameTb.Text = uname;
                PasswordTb.Text = upass;
                PhoneTb.Text = phone;

                key = Convert.ToInt32(row.Cells[0].Value);
            }
        }
    }

}
