using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ABCCarTraders
{
    public partial class SignUpUI : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server " +
            "Certificate=True");

        public SignUpUI()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (Validation()) //CHECK VALIDATION
            {
                string username = txtEmail.Text;
                string fullname = txtName.Text;
                string password = txtConfirmPassword.Text; //GET VALUES

                if (!IsEmailExist(username)) //IF THE USER IS NOT AN EXISTING USER
                {
                    EnterDetails(username, fullname, password); //Register User to System
                    CustomerHomeUI customerHomeUI = new CustomerHomeUI();
                    customerHomeUI.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email already exists in system, try loging in or use a different email", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error); //ERROR MESSAGE
                }
            }
        }

        private bool Validation() //CHECK VALIDATION
        {
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtEmail.Text))  //Required Email Validation
            {
                errorProvider.SetError(txtEmail, "Email is required.");
                txtEmail.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtName.Text)) //Required Password Validation
            {
                errorProvider.SetError(txtName, "Name is required.");
                txtName.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtNewPassword.Text)) //Required Password Validation
            {
                errorProvider.SetError(txtNewPassword, "Enter a Password.");
                txtNewPassword.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text)) //Required Confirm Password Validation
            {
                errorProvider.SetError(txtConfirmPassword, "Please confirm your Password.");
                txtConfirmPassword.Focus();
                return false;
            }
            else if (!(txtNewPassword.Text == txtConfirmPassword.Text)) //CHECK IF PASSWORD IS EQUAL TO CONFIRMED PASSWORD
            {
                MessageBox.Show("Password does not match Confirm Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return false;
            }
            return true;
        }

        private bool IsEmailExist(string username)
        {
            //Check whether email already exists in the system
            con.Open();
            string SelectUserQuery = "Select count(1) as Count from UserLogin where Upper(login_username) = '" + username.ToUpper() + "'";
            SqlCommand cmd = new SqlCommand(SelectUserQuery, con);
            int IsExist = (int)cmd.ExecuteScalar();
            con.Close();
            return Convert.ToBoolean(IsExist);
        }

        private void EnterDetails(string username, string fullname, string password)
        {
            //Entering User Details to System
            string InsertUserDetails = "Insert into Users (user_fullname, user_email) VALUES ('" + fullname + "', '" + username + "'); " +
                "select CAST(scope_identity() as int)";
            SqlCommand cmduser = new SqlCommand(InsertUserDetails, con);
            int user_id = (int)cmduser.ExecuteScalar(); //Get user_id

            //Entering Login Credentials to the System
            string InsertLoginDetails = "Insert into UserLogin (login_username, login_password, login_user_id, login_role_id) " +
                "VALUES ('" + username + "', '" + password + "', " + user_id + ", 1)"; //Only customers can signup, hence the user_role is 1 (Customer)

            SqlCommand cmdlogin = new SqlCommand(InsertLoginDetails, con);
            cmdlogin.ExecuteNonQuery();

            //Set Session
            GlobalSession.UserName = username;
            GlobalSession.UserId = user_id;
            GlobalSession.RoleId = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginUI loginUI = new LoginUI();
            loginUI.Show();
            this.Hide();
        }
    }
}
