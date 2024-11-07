using ABCCarTraders.Model;
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
using ABCCarTraders.Controller;

namespace ABCCarTraders
{
    public partial class CarOrder : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server Certificate=True");

        public CarOrder()
        {
            InitializeComponent();
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
                    List<CarColor> colors = new List<CarColor>(); // Create a list to hold color items

                    colors.Add(new CarColor { ColorId = null, ColorName = "Select a color" }); // Add "Select a color" as default

                    while (reader.Read()) // Populate the list with colors from the database
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

        private void CarOrder_Load(object sender, EventArgs e)
        {
            LoadColorsIntoComboBox(); //LOAD COLORS INTO COMBO BOX
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string type = txtType.Text; //GET VALUES FROM INPUTS
            string brand = txtBrand.Text;
            int color = Convert.ToInt32(ddlColors.SelectedValue);
            CarController carController = new CarController(); //SEARCH QUERY
            grdCars.DataSource = carController.SearchCar(type, brand, color); //SET DATA TO TABLE
            grdCars.Columns["car_id"].HeaderText = "ID";
            grdCars.Columns["car_type"].HeaderText = "Type";
            grdCars.Columns["car_brand"].HeaderText = "Brand";
            grdCars.Columns["color_name"].HeaderText = "Color";
            grdCars.Columns["car_manufacture_date"].HeaderText = "Manufacture Date";

            //int roleId = 1;
            if (GlobalSession.RoleId == 1) // IF CUSTOMER
            {
                // Check if the Order column already exists to avoid duplication
                if (!grdCars.Columns.Contains("OrderColumn"))
                {
                    DataGridViewButtonColumn orderButtonColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Order",
                        Text = "Order",
                        UseColumnTextForButtonValue = true,
                        Name = "OrderColumn"
                    };
                    grdCars.Columns.Add(orderButtonColumn);
                }
            }
            grdCars.CellClick += grdCars_CellClick;
        }

        private void grdCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the user clicked on a valid row
            {
                int carId = Convert.ToInt32(grdCars.Rows[e.RowIndex].Cells["car_id"].Value);

                if (grdCars.Columns[e.ColumnIndex].Name == "OrderColumn")
                {
                    OpenCarForm(carId, "O");  // Open in Order Mode
                }
            }
        }

        private void OpenCarForm(int carId, string mode)
        {
            // Open CarFormUI in the specified mode (O: Order)
            CarFormUI carForm = new CarFormUI();
            carForm.SetMode(carId, mode);
            carForm.Show();
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
