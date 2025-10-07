using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DentalClinicManag
{
    internal class ConnectionString
    {
        public SqlConnection GetCon() 
        {
            SqlConnection Con =  new SqlConnection();
            Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\23SOECE11033_UTSAV\DentalClinicManag\DentalDb.mdf;Integrated Security=True";
            return Con;

        }
    }
}
