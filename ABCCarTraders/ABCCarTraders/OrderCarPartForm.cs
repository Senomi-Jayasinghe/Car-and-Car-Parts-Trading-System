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
    public partial class OrderCarPartForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server Certificate=True");
        //INITIALIZE VARIABLES FOR MODES CANCEL AND EDIT
        public int orderId;
        public string mode;
        public byte[] CarPartPicture;

        public OrderCarPartForm()
        {
            InitializeComponent();
        }

        private void OrderCarPartForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        public void SetMode(int orderId, string mode)
        {
            this.orderId = orderId;
            this.mode = mode;
            LoadColorsIntoComboBox(); //LOAD COLORS TO COMBO BOX
            LoadCarsIntoComboBox(); //LOAD CARS TO COMBO BOX

            ddlStatus.Items.Clear();

            // Add predefined status values to the combo box
            ddlStatus.Items.Add("Placed");
            ddlStatus.Items.Add("Canceled");
            ddlStatus.Items.Add("Processing");
            ddlStatus.Items.Add("Done");

            ddlStatus.SelectedIndex = 0;

            LoadOrderData(); // Load data based on the carId
            if (mode == "C") //CANCEL MODE
            {
                btnCancel.Text = "Cancel";
            }
            else if (mode == "E") //EDIT MODE
            {
                btnCancel.Text = "Edit";
            }
            this.Show();
        }

        private void LoadOrderData() //GET DATA FOR EDIT, DELETE, ORDER MODES
        {   //Set Deatils to fields
            OrderController orderController = new OrderController();
            DataTable dt = orderController.GetCarPartOrder(orderId);

            foreach (DataRow dr in dt.Rows)
            {
                txtOrderId.Text = dr["order_id"].ToString();
                txtName.Text = dr["carpart_name"].ToString();
                ddlCarType.SelectedValue = Convert.ToInt32(dr["carpart_car_id"]);
                dateManuDate.Value = Convert.ToDateTime(dr["carpart_manufacture_date"]);
                txtPrice.Text = dr["carpart_price"].ToString();
                txtDesc.Text = dr["carpart_description"].ToString();
                ddlColors.SelectedValue = Convert.ToInt32(dr["carpart_color_id"]);
                ddlStatus.SelectedItem = dr["order_status"].ToString();
                byte[] carPartPictureBytes = (byte[])dr["carpart_picture"];
                CarPartPicture = carPartPictureBytes;

                // Ensure carPart.Picture is not null or empty
                if (CarPartPicture != null && CarPartPicture.Length > 0) // Ensure car.PartPicture is not null or empty
                {
                    using (MemoryStream ms = new MemoryStream(CarPartPicture))
                    {
                        try
                        {
                            Image carpartImage = Image.FromStream(ms);
                            picCarPart.SizeMode = PictureBoxSizeMode.StretchImage; // Set the size mode
                            picCarPart.Image = carpartImage; // Display in PictureBox
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading image: " + ex.Message);
                        }
                    }
                }
                else
                {
                    picCarPart.Image = null; // Clear the PictureBox if no image is available
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (mode == "C")
            {
                OrderController orderController = new OrderController();
                orderController.CancelOrder(orderId);
            }
            if (mode == "E")
            {
                string status = ddlStatus.Text.ToString();
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

        private void LoadCarsIntoComboBox()
        {
            try
            {
                con.Open();

                string query = "SELECT car_id, car_type FROM Car"; // Query to fetch car_id and car_type from the database
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader reader = cmd.ExecuteReader()) // Execute the command and read the results
                {
                    List<Car> cars = new List<Car>(); // Create a list to hold car items

                    // Add "Select a car" as default
                    cars.Add(new Car { CarId = -1, Type = "Select a car" });

                    // Populate the list with colors from the database
                    while (reader.Read())
                    {
                        cars.Add(new Car
                        {
                            CarId = (int)reader["car_id"],
                            Type = reader["car_type"].ToString()
                        });
                    }
                    // Bind the list to the ComboBox
                    ddlCarType.DisplayMember = "Type";  // Show the car type
                    ddlCarType.ValueMember = "CarId";      // Use car_id as the value
                    ddlCarType.DataSource = cars;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
