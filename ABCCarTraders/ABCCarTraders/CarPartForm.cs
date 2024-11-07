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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ABCCarTraders
{
    public partial class CarPartForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server Certificate=True");
        //INITIALIZE VARIABLES FOR MODES EDIT, DELETE AND ORDER
        public int carPartId;
        public string mode;
        public byte[] CarPartPicture;

        public CarPartForm()
        {
            InitializeComponent();
            LoadColorsIntoComboBox(); //LOAD COLORS TO COMBO BOX
            LoadCarsIntoComboBox(); //LOAD CARS TO COMBO BOX
        }

        private void CarPartForm_Load(object sender, EventArgs e)
        {
            
        }

        public void SetMode(int carPartId, string mode)
        {
            LoadColorsIntoComboBox(); //LOAD COLORS TO COMBO BOX
            LoadCarsIntoComboBox(); //LOAD CARS TO COMBO BOX
            this.carPartId = carPartId;
            this.mode = mode;
            LoadCarPartData(); // Load data based on the carId
            if (mode == "U")
            {
                btnSave.Text = "Update"; //UPDATE MODE
            }
            else if (mode == "D")
            {
                btnSave.Text = "Delete"; //DELETE MODE
            }
            else if (mode == "O")
            {
                btnSave.Text = "Order"; //ORDER MODE
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to allow only image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            // Show the file dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file path
                string filePath = openFileDialog.FileName;

                // Display the image in the PictureBox for preview
                picCarPart.Image = Image.FromFile(filePath);
                picCarPart.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            CarPartPicture = GetImageAsByteArray(picCarPart.Image);
        }

        private byte[] GetImageAsByteArray(Image image)
        {   // GET IMAGE AS BYTE ARRAY
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void LoadCarPartData() //GET DATA FOR EDIT, DELETE, ORDER MODES
        {   //Set Deatils to fields
            CarPartController carPartController = new CarPartController();
            CarPart carPart = carPartController.GetCarPartById(carPartId);

            txtCarPartId.Text = carPart.CarPartId.ToString();
            txtName.Text = carPart.Name.ToString();
            ddlCarType.SelectedValue = carPart.CarId;
            dateManuDate.Value = carPart.ManufactureDate;
            txtPrice.Text = carPart.Price.ToString();
            txtDesc.Text = carPart.Description.ToString();
            ddlColors.SelectedValue = carPart.ColorId;
            CarPartPicture = carPart.Picture;

            // Ensure carPart.Picture is not null or empty
            if (carPart.Picture != null && carPart.Picture.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(carPart.Picture))
                {
                    try
                    {
                        Image carPartImage = Image.FromStream(ms);
                        picCarPart.SizeMode = PictureBoxSizeMode.StretchImage; // Set the size mode
                        picCarPart.Image = carPartImage; // Display in PictureBox
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateCarPartForm()) //CHECK VALIDATION
            {   //SET DATA TO CARPART CLASS
                CarPart carPart = new CarPart();
                carPart.Name = txtName.Text;
                Car selectedCar = (Car)ddlCarType.SelectedItem;
                carPart.CarId = selectedCar.CarId;
                carPart.ManufactureDate = Convert.ToDateTime(dateManuDate.Value.ToString("yyyy-MM-dd"));
                carPart.Price = Convert.ToDecimal(txtPrice.Text);
                carPart.Description = txtDesc.Text;
                CarColor selectedColor = (CarColor)ddlColors.SelectedItem;
                carPart.ColorId = selectedColor.ColorId.Value;

                carPart.EntryDate = DateTime.Now.ToString("yyyy-MM-dd");
                carPart.EntryUser = GlobalSession.UserId;

                carPart.Picture = CarPartPicture;

                if (btnSave.Text == "Save")
                {
                    try
                    {   //INSERT QUERY
                        con.Open();
                        string insertCar = "INSERT INTO CarPart (carpart_name, carpart_car_id, carpart_manufacture_date, carpart_price, carpart_description, " +
                            "carpart_color_id, carpart_picture, entry_user, entry_date) " +
                               "VALUES (@carPartName, @carId, @carPartManufactureDate, @carPartPrice, @carPartDesc, @carPartColor, @carPartPicture, @entryUser, " +
                               "@entryDate)";

                        using (SqlCommand cmd = new SqlCommand(insertCar, con))
                        {
                            // Add parameters to the command
                            cmd.Parameters.AddWithValue("@carPartName", carPart.Name);
                            cmd.Parameters.AddWithValue("@carId", carPart.CarId);
                            cmd.Parameters.AddWithValue("@carPartManufactureDate", carPart.ManufactureDate);
                            cmd.Parameters.AddWithValue("@carPartPrice", carPart.Price);
                            cmd.Parameters.AddWithValue("@carPartDesc", carPart.Description);
                            cmd.Parameters.AddWithValue("@carPartColor", carPart.ColorId);

                            // Use byte array for the image data
                            cmd.Parameters.AddWithValue("@carPartPicture", CarPartPicture ?? (object)DBNull.Value);

                            cmd.Parameters.AddWithValue("@entryUser", carPart.EntryUser);
                            cmd.Parameters.AddWithValue("@entryDate", carPart.EntryDate);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        MessageBox.Show("Car Part details saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
                else if (btnSave.Text == "Update")
                {   //UPDATE QUERY
                    carPart.CarPartId = Convert.ToInt32(txtCarPartId.Text);
                    CarPartController carPartController = new CarPartController();
                    carPartController.UpdateCarParts(carPart);
                }
                else if (btnSave.Text == "Delete")
                {   //DELETE QUERY
                    carPart.CarPartId = Convert.ToInt32(txtCarPartId.Text);
                    CarPartController carPartController = new CarPartController();
                    carPartController.DeleteCarParts(carPart);
                }
                else if (btnSave.Text == "Order")
                {   //INSERT TO ORDER TABLE
                    carPart.CarPartId = Convert.ToInt32(txtCarPartId.Text);
                    CarPartController carPartController = new CarPartController();
                    carPartController.OrderCarParts(carPart);
                }
            }
        }

        private bool ValidateCarPartForm()
        {
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.Clear();

            // Validate CarPart Name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Car Part Name is required.");
                txtName.Focus();
                return false;
            }

            Car selectedCar = (Car)ddlCarType.SelectedItem;
            if (selectedCar == null)
            {
                errorProvider.SetError(ddlCarType, "Please select a car.");
                ddlCarType.Focus();
                return false;
            }

            if (dateManuDate.Value > DateTime.Now)
            {
                errorProvider.SetError(dateManuDate, "Invalid Date, Manufacture date cannot be in the future.");
                dateManuDate.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                errorProvider.SetError(txtPrice, "Valid price is required.");
                txtPrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                errorProvider.SetError(txtDesc, "Description is required.");
                txtDesc.Focus();
                return false;
            }

            CarColor selectedColor = (CarColor)ddlColors.SelectedItem;
            if (selectedColor == null || !selectedColor.ColorId.HasValue)
            {
                errorProvider.SetError(ddlColors, "Please select a color.");
                ddlColors.Focus();
                return false;
            }

            if (picCarPart.Image == null)
            {
                errorProvider.SetError(picCarPart, "CarPart picture is required.");
                picCarPart.Focus();
                return false;
            }

            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CarPartsUI carPartsUI = new CarPartsUI();
            carPartsUI.Show();
            this.Hide();
        }
    }
}
