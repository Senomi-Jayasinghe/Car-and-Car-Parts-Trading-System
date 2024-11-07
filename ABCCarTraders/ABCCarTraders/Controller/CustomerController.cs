using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;


namespace ABCCarTraders.Controller
{
    public class CustomerController
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server Certificate=True");
        
        public DataTable getCustomers()
        {
            string selectCustomers = "SELECT user_id, user_fullname, user_email FROM Users";
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(selectCustomers, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt); // Fills the DataTable with the result from the database
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
