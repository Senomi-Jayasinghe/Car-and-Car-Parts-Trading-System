using ABCCarTraders.Properties;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace ABCCarTraders
{
    public partial class LoginUI : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server " +
            "Certificate=True");    //CONNECTION

        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validation()) //CHECK FOR VALIDATION
            {
                string userName = txtUsername.Text;
                string password = txtPassword.Text; //GET USRNAME AND PASSWORD

                con.Open();
                string SelectUserQuery = "Select count(1) as Count from UserLogin where Upper(login_username) = '" + userName.ToUpper() + "' " +
                    "AND login_password = '" + password + "'"; //SEARCH FOR USER
                SqlCommand cmd = new SqlCommand(SelectUserQuery, con);
                int IsUserExist = (int)cmd.ExecuteScalar(); 
                con.Close();
                if (IsUserExist == 1) //IF USER EXISTS
                {
                    int roleId = setSession(userName); //SET SESSION
                    if (roleId == 1) //For customers
                    {
                        CustomerHomeUI customerHomeUI = new CustomerHomeUI();
                        customerHomeUI.Show();
                    }
                    else if (roleId == 2) //For Admins
                    {
                        AdminHomeUI adminHomeUI = new AdminHomeUI();
                        adminHomeUI.Show();
                    }
                    con.Close();
                    this.Hide();
                }
                else
                {   //ERROR MESSAGE
                    MessageBox.Show("Invalid User Credentials", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //SIGNIN BUTTON REDIRECT SIGNIN PAGE
            SignUpUI signUpUI = new SignUpUI();
            signUpUI.Show();

            this.Hide();
        }

        private bool Validation()
        {   //VALIDATION
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                //Required Email Validation
                errorProvider.SetError(txtUsername, "Username is required.");
                txtUsername.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                //Required Password Validation
                errorProvider.SetError(txtPassword, "Password is required.");
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private int setSession(string userName)
        {   //SET SESSION
            con.Open();
            int loginRoleId = 0;
            string getSessionQuery = "Select login_role_id, login_user_id from UserLogin where Upper(login_username) = '" + userName.ToUpper() + "'";
            //GET ROLE OF USER
            try
            {
                SqlCommand cmd = new SqlCommand(getSessionQuery, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        loginRoleId = reader.GetInt32(reader.GetOrdinal("login_role_id"));
                        int loginUserId = reader.GetInt32(reader.GetOrdinal("login_user_id"));
                        
                        GlobalSession.UserName = userName; //SET SESSION TO GLOBAL SESSION
                        GlobalSession.RoleId = loginRoleId;
                        GlobalSession.UserId = loginUserId;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return loginRoleId;
        }
    }
}
