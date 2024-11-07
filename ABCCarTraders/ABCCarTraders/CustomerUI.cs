using ABCCarTraders.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders
{
    public partial class CustomerUI : Form
    {
        public CustomerUI()
        {
            InitializeComponent();
            CustomerController controller = new CustomerController();
            grdCustomers.DataSource = controller.getCustomers(); //SET DATA TO TABLE
            grdCustomers.Columns["user_id"].HeaderText = "ID";
            grdCustomers.Columns["user_fullname"].HeaderText = "Full Name";
            grdCustomers.Columns["user_email"].HeaderText = "Email";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomeUI adminHomeUI = new AdminHomeUI();
            adminHomeUI.Show();
            this.Hide();
        }
    }
}
