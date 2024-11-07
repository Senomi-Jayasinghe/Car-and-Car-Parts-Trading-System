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
    public partial class CarPartOrder : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server Certificate=True");

        public CarPartOrder()
        {
            InitializeComponent();
        }

        private void LoadColorsIntoComboBox()
        {
            try
            {
                con.Open();

                // Query to fetch color_id and color_name from the database
                string query = "SELECT color_id, color_name FROM CarColor";

                SqlCommand cmd = new SqlCommand(query, con);

                // Execute the command and read the results
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Create a list to hold color items
                    List<CarColor> colors = new List<CarColor>();

                    // Add "Select a color" as default
                    colors.Add(new CarColor { ColorId = null, ColorName = "Select a color" });

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

        private void LoadCarsIntoComboBox()
        {
            try
            {
                con.Open();
                string query = "SELECT car_id, car_type FROM Car"; // Query to fetch car_id and car_type from the database

                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader reader = cmd.ExecuteReader()) // Execute the command and read the results
                {
                    List<Car> cars = new List<Car>();  // Create a list to hold car items

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
                    ddlCarType.DataSource = cars;
                    ddlCarType.DisplayMember = "Type";  // Show the car type
                    ddlCarType.ValueMember = "CarId";      // Use car_id as the value
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CarPartOrder_Load(object sender, EventArgs e)
        {
            LoadColorsIntoComboBox();
            LoadCarsIntoComboBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {   //GET VALUES FROM INPUT FIELDS
            string name = txtName.Text;
            int carType = Convert.ToInt32(ddlCarType.SelectedValue);
            int color = Convert.ToInt32(ddlColors.SelectedValue);
            //SEARCH QUERY
            CarPartController carPartController = new CarPartController();
            grdCarParts.DataSource = carPartController.SearchCarPart(name, carType, color);
            //FILL TABLE WITH DATA FROM DB
            grdCarParts.Columns["carpart_id"].HeaderText = "ID";
            grdCarParts.Columns["carpart_name"].HeaderText = "Name";
            grdCarParts.Columns["car_type"].HeaderText = "Car";  // This is from the Car table for carpart_car_id
            grdCarParts.Columns["carpart_manufacture_date"].HeaderText = "Manufacture Date";
            grdCarParts.Columns["carpart_price"].HeaderText = "Price";

            if (GlobalSession.RoleId == 1) // IF CUSTOMER
            {
                // Check if the Order column already exists to avoid duplication
                if (!grdCarParts.Columns.Contains("OrderColumn"))
                {
                    DataGridViewButtonColumn orderButtonColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Order",
                        Text = "Order",
                        UseColumnTextForButtonValue = true,
                        Name = "OrderColumn"
                    };
                    grdCarParts.Columns.Add(orderButtonColumn);
                }
            }
            grdCarParts.CellClick += grdCarParts_CellClick;
        }

        private void grdCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the user clicked on a valid row
            {
                int carPartsId = Convert.ToInt32(grdCarParts.Rows[e.RowIndex].Cells["carpart_id"].Value);

                if (grdCarParts.Columns[e.ColumnIndex].Name == "OrderColumn")
                {
                    OpenCarPartForm(carPartsId, "O");  // Open in Order Mode
                }
            }
        }

        private void OpenCarPartForm(int carId, string mode)
        {
            // Open CarPartForm in the specified mode (O: Order)
            CarPartForm carPartForm = new CarPartForm();
            carPartForm.SetMode(carId, mode);
            carPartForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerHomeUI customerHomeUI = new CustomerHomeUI();
            customerHomeUI.Show();
            this.Hide();
        }
    }
}
