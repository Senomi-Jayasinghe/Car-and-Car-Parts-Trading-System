using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCCarTraders.Controller;
using ABCCarTraders.Model;
using Microsoft.Data.SqlClient;

namespace ABCCarTraders
{
    public partial class OrderCarFormUI : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server Certificate=True");
        //INITIALIZE VARIABLES FOR MODES CANCEL AND EDIT
        public int orderId;
        public string mode;
        public byte[] CarPicture;

        public OrderCarFormUI()
        {
            InitializeComponent();
            ddlStatus.Items.Clear();

            // Add predefined status values to the combo box
            ddlStatus.Items.Add("Placed");
            ddlStatus.Items.Add("Canceled");
            ddlStatus.Items.Add("Processing");
            ddlStatus.Items.Add("Done");

            ddlStatus.SelectedIndex = 0;
        }

        public void SetMode(int orderId, string mode)
        {
            this.orderId = orderId;
            this.mode = mode;
            LoadColorsIntoComboBox();
            LoadOrderData(); // Load data based on the carId
            if (mode == "C") //CANCEL MODE
            {
                btnCancel.Text = "Cancel";
            }
            else if (mode == "E") //EDIT MODE
            {
                btnCancel.Text = "Edit";
            }
        }

        private void LoadOrderData()
        {   //Set Deatils to fields
            OrderController orderController = new OrderController();
            DataTable dt = orderController.GetCarOrder(orderId);

            foreach (DataRow dr in dt.Rows)
            {
                txtOrderId.Text = dr["order_id"].ToString();
                txtType.Text = dr["car_type"].ToString();
                txtBrand.Text = dr["car_brand"].ToString();
                ddlColors.SelectedValue = Convert.ToInt32(dr["car_color"]);
                txtFuelEco.Text = dr["car_fueleconomy"].ToString();
                txtEnginePw.Text = dr["car_engine_power"].ToString();
                dateManuDate.Value = Convert.ToDateTime(dr["car_manufacture_date"]);
                txtPrice.Text = dr["car_price"].ToString();
                ddlStatus.SelectedItem = dr["order_status"].ToString();
                byte[] carPictureBytes = (byte[])dr["car_picture"];
                CarPicture = carPictureBytes;

                if (CarPicture != null && CarPicture.Length > 0) // Ensure car.Picture is not null or empty
                {
                    using (MemoryStream ms = new MemoryStream(CarPicture))
                    {
                        try
                        {
                            Image carImage = Image.FromStream(ms);
                            picCar.SizeMode = PictureBoxSizeMode.StretchImage; // Set the size mode
                            picCar.Image = carImage; // Display in PictureBox
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading image: " + ex.Message);
                        }
                    }
                }
                else
                {
                    picCar.Image = null; // Clear the PictureBox if no image is available
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text == "Cancel")
            {
                orderId = Convert.ToInt32(txtOrderId.Text);
                OrderController orderController = new OrderController();
                orderController.CancelOrder(orderId);
            }
            if (btnCancel.Text == "Edit")
            {
                orderId = Convert.ToInt32(txtOrderId.Text);
                string status = ddlStatus.Text;
                OrderController orderController = new OrderController();
                orderController.EditOrder(orderId, status);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OrdersUI ordersUI = new OrdersUI();
            ordersUI.Show();
            this.Hide();
        }

      
        private void LoadColorsIntoComboBox()
        {
            try
            {
                con.Open();
                string query = "SELECT color_id, color_name FROM CarColor"; // Query to fetch color_id and color_name from the database

                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader reader = cmd.ExecuteReader()) // Execute the command and read the results
                {
                    // Create a list to hold color items
                    List<CarColor> colors = new List<CarColor>();
                    colors.Add(new CarColor { ColorId = null, ColorName = "Select a color" }); // Add "Select a color" as default

                    // Populate the list with colors from the database
                    while (reader.Read())
                    {
                        colors.Add(new CarColor
                        {
                            ColorId = (int)reader["color_id"],
                            ColorName = reader["color_name"].ToString()
                        });
                    }

                    // Bind the list to the ComboBox
                    ddlColors.DataSource = colors;
                    ddlColors.DisplayMember = "ColorName";  // Show the color name
                    ddlColors.ValueMember = "ColorId";      // Use color_id as the value
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
