using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdminPass.Text == "")
            {
                MessageBox.Show("Enter The Admin Password");
            }
            else if (AdminPass.Text == "Password")
            {
                user U = new user();
                U.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Wrong Passwordd. Contactt The Admin");
            }
        }
    }
}
