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
    public partial class CustomerHomeUI : Form
    {
        public CustomerHomeUI()
        {
            InitializeComponent();
        }

        private void btnHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //REDIRECT TO CUSTOMER HOME PAGE
            CustomerHomeUI customerHomeUI = new CustomerHomeUI();
            customerHomeUI.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {   //SHOW DROP DOWN OF MENU WHEN PROFILE IS CLICKED
            ddlMenu.Show(btnMenu, new Point(0, btnMenu.Height));
        }

        private void ddlProfile_Click(object sender, EventArgs e)
        {   //REDIRECT TO USER PROFILE
            UserProfileUI userProfileUI = new UserProfileUI();
            userProfileUI.Show();
        }

        private void ddlLogOut_Click(object sender, EventArgs e)
        {
            // Clear session
            GlobalSession.UserName = string.Empty;
            GlobalSession.RoleId = 0;
            GlobalSession.UserId = 0;

            // Redirect to login form
            LoginUI loginUI = new LoginUI();
            loginUI.Show();
            this.Hide();
        }

        private void pnlCars_Paint(object sender, PaintEventArgs e)
        {
            Color customRed = Color.FromArgb(207, 2, 2);

            // Created a Pen object with the custom color and width
            using (Pen pen = new Pen(customRed, 1)) // 1 is the thickness of the border
            {
                // Draw the rectangle border inside the panel
                e.Graphics.DrawRectangle(pen, 0, 0, pnlCars.Width - 1, pnlCars.Height - 1);
            }
        }

        private void picCar_Paint(object sender, PaintEventArgs e)
        {
            Color customRed = Color.FromArgb(207, 2, 2);

            // Created a Pen object with the custom color and width
            using (Pen pen = new Pen(customRed, 1)) // 1 is the thickness of the bottom border
            {
                // Style line at the bottom of the PictureBox
                e.Graphics.DrawLine(pen, 0, picCar.Height - 1, picCar.Width - 1, picCar.Height - 1);
            }
        }

        private void pnlCarParts_Paint(object sender, PaintEventArgs e)
        {
            Color customRed = Color.FromArgb(207, 2, 2);

            // Created a Pen object with the custom color and width
            using (Pen pen = new Pen(customRed, 1)) // 1 is the thickness of the border
            {
                // Draw the rectangle border inside the panel
                e.Graphics.DrawRectangle(pen, 0, 0, pnlCarParts.Width - 1, pnlCarParts.Height - 1);
            }
        }

        private void picCarparts_Paint(object sender, PaintEventArgs e)
        {
            Color customRed = Color.FromArgb(207, 2, 2);

            // Created a Pen object with the custom color and width
            using (Pen pen = new Pen(customRed, 1)) // 1 is the thickness of the bottom border
            {
                // Style line at the bottom of the PictureBox
                e.Graphics.DrawLine(pen, 0, picCarparts.Height - 1, picCarparts.Width - 1, picCarparts.Height - 1);
            }
        }

        private void pnlOrders_Paint(object sender, PaintEventArgs e)
        {
            Color customRed = Color.FromArgb(207, 2, 2);

            // Created a Pen object with the custom color and width
            using (Pen pen = new Pen(customRed, 1)) // 1 is the thickness of the border
            {
                // Draw the rectangle border inside the panel
                e.Graphics.DrawRectangle(pen, 0, 0, pnlOrders.Width - 1, pnlOrders.Height - 1);
            }
        }

        private void picOrders_Paint(object sender, PaintEventArgs e)
        {
            Color customRed = Color.FromArgb(207, 2, 2);

            // Created a Pen object with the custom color and width
            using (Pen pen = new Pen(customRed, 1)) // 1 is the thickness of the bottom border
            {
                // Style line at the bottom of the PictureBox
                e.Graphics.DrawLine(pen, 0, picOrders.Height - 1, picOrders.Width - 1, picOrders.Height - 1);
            }
        }

        private void pnlCars_Click(object sender, EventArgs e)
        {   //REDIRECT TO CAR SEARCH AND ORDER PAGE
            CarOrder carOrder = new CarOrder();
            carOrder.Show();
            this.Hide();
        }

        private void pnlCarParts_Click(object sender, EventArgs e)
        {   //REDIRECT TO CARPART SEARCH AND ORDER PAGE
            CarPartOrder carPartOrder = new CarPartOrder();
            carPartOrder.Show();
            this.Hide();
        }

        private void pnlOrders_Click(object sender, EventArgs e)
        {   //TRACK AND VIEW ORDERS
            OrdersUI ordersUI = new OrdersUI();
            ordersUI.Show();
            this.Hide();
        }
    }
}
