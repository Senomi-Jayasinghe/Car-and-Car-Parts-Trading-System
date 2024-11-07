using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
using ABCCarTraders.Model;
using ABCCarTraders.Controller;

namespace ABCCarTraders
{
    public partial class CarFormUI : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server Certificate=True");
        //INITIALIZE VARIABLES FOR MODES EDIT, DELETE, AND ORDER
        public int carId;
        public string mode;
        public byte[] CarPicture;

        public CarFormUI()
        {
            InitializeComponent();
            LoadColorsIntoComboBox();
        }

        public void SetMode(int carId, string mode)
        {
            this.carId = carId;
            this.mode = mode;
            LoadColorsIntoComboBox(); //SET COLORS TO COMBO BOX
            LoadCarData(); // Load data based on the carId
            if (mode == "U") //UPDATE MODE
            {
                btnSave.Text = "Update";
            }
            else if (mode == "D") //DELETE MODE
            {
                btnSave.Text = "Delete";
            }
            else if (mode == "O") //ORDER MODE
            {
                btnSave.Text = "Order";
            }
        }

        private void CarFormUI_Load(object sender, EventArgs e)
        {
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
                    List<CarColor> colors = new List<CarColor>();// Create a list to hold color items
                    
                    colors.Add(new CarColor { ColorId = null, ColorName = "Select a color" });// Add "Select a color" as default
                    
                    while (reader.Read())// Populate the list with colors from the database
                    {
                        colors.Add(new CarColor
                        {
                            ColorId = (int)reader["color_id"],
                            ColorName = reader["color_name"].ToString()
                        });
                    }
                    ddlColors.DataSource = colors;  // Bind the list to the ComboBox
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
                picCar.Image = Image.FromFile(filePath);
                picCar.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            CarPicture = GetImageAsByteArray(picCar.Image);
        }

        private byte[] GetImageAsByteArray(Image image)
        { //GET PICTURE AS BYTE[]
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void LoadCarData()
        {   //Set Deatils to fields
            CarController carController = new CarController();
            Car car = carController.GetCarByID(carId);

            txtCarId.Text = car.CarId.ToString();
            txtType.Text = car.Type;
            txtBrand.Text = car.Brand;
            ddlColors.SelectedValue = car.ColorId;
            txtFuelEco.Text = car.FuelEconomy.ToString();
            txtEnginePw.Text = car.EnginePower.ToString();
            dateManuDate.Value = car.ManufactureDate;
            txtPrice.Text = car.Price.ToString();
            CarPicture = car.Picture;
            if (car.Picture != null && car.Picture.Length > 0) // Ensure car.Picture is not null or empty
            {
                using (MemoryStream ms = new MemoryStream(car.Picture))
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateCarForm()) //CHECK FOR VALIDATION
            {   //SAVE DATA TO CLASS CAR
                Car car = new Car();
                car.Type = txtType.Text;
                car.Brand = txtBrand.Text;

                CarColor selectedColor = (CarColor)ddlColors.SelectedItem;
                car.ColorId = selectedColor.ColorId.Value;

                car.FuelEconomy = Convert.ToDecimal(txtFuelEco.Text);
                car.EnginePower = Convert.ToDecimal(txtEnginePw.Text);
                car.ManufactureDate = Convert.ToDateTime(dateManuDate.Value.ToString("yyyy-MM-dd"));
                car.Price = Convert.ToDecimal(txtPrice.Text);

                car.EntryDate = DateTime.Now.ToString("yyyy-MM-dd");
                car.EntryUser = GlobalSession.UserId;

                car.Picture = CarPicture;

                if (btnSave.Text == "Save")
                {
                    try
                    {   //INSERT QUERY
                        con.Open();
                        string insertCar = "INSERT INTO Car (car_type, car_brand, car_color, car_fueleconomy, car_engine_power, car_manufacture_date, car_price, car_picture, " +
                            "entry_user, entry_date) " +
                               "VALUES (@carType, @carBrand, @carColor, @carFuelEconomy, @carEnginePower, @carManufactureDate, @carPrice, @carPicture, @entryUser, @entryDate)";

                        using (SqlCommand cmd = new SqlCommand(insertCar, con))
                        {
                            // Add parameters to the command
                            cmd.Parameters.AddWithValue("@carType", car.Type);
                            cmd.Parameters.AddWithValue("@carBrand", car.Brand);
                            cmd.Parameters.AddWithValue("@carColor", car.ColorId);
                            cmd.Parameters.AddWithValue("@carFuelEconomy", car.FuelEconomy);
                            cmd.Parameters.AddWithValue("@carEnginePower", car.EnginePower);
                            cmd.Parameters.AddWithValue("@carManufactureDate", car.ManufactureDate);
                            cmd.Parameters.AddWithValue("@carPrice", car.Price);

                            // Use byte array for the image data
                            cmd.Parameters.AddWithValue("@carPicture", CarPicture ?? (object)DBNull.Value);

                            cmd.Parameters.AddWithValue("@entryUser", car.EntryUser);
                            cmd.Parameters.AddWithValue("@entryDate", car.EntryDate);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        MessageBox.Show("Car details saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
                else if (btnSave.Text == "Update")
                {
                    car.CarId = Convert.ToInt32(txtCarId.Text);
                    CarController carController = new CarController();//UPDATE QUERY
                    carController.UpdateCar(car);
                }
                else if (btnSave.Text == "Delete")
                {
                    car.CarId = Convert.ToInt32(txtCarId.Text);
                    CarController carController = new CarController();//DELETE QUERY
                    carController.DeleteCar(car);
                }
                else if (btnSave.Text == "Order")
                {
                    car.CarId = Convert.ToInt32(txtCarId.Text);
                    CarController carController = new CarController();//ORDER QUERY
                    carController.OrderCar(car);
                }
            }
        }

        private bool ValidateCarForm()
        {
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.Clear();

            // Validate Car Type
            if (string.IsNullOrWhiteSpace(txtType.Text))
            {
                errorProvider.SetError(txtType, "Car type is required.");
                txtType.Focus();
                return false;
            }

            // Validate Car Brand
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                errorProvider.SetError(txtBrand, "Car brand is required.");
                txtBrand.Focus();
                return false;
            }

            // Validate Car Color
            CarColor selectedColor = (CarColor)ddlColors.SelectedItem;
            if (selectedColor == null || !selectedColor.ColorId.HasValue)
            {
                errorProvider.SetError(ddlColors, "Please select a color.");
                ddlColors.Focus();
                return false;
            }
            // Validate Fuel Economy
            if (string.IsNullOrWhiteSpace(txtFuelEco.Text))
            {
                errorProvider.SetError(txtFuelEco, "Valid fuel economy is required.");
                txtFuelEco.Focus();
                return false;
            }
            // Validate Engine Power
            if (string.IsNullOrWhiteSpace(txtEnginePw.Text))
            {
                errorProvider.SetError(txtEnginePw, "Valid engine power is required.");
                txtEnginePw.Focus();
                return false;
            }
            // Validate Manufacture Date
            if (dateManuDate.Value > DateTime.Now)
            {
                errorProvider.SetError(dateManuDate, "Invalid Date, Manufacture date cannot be in the future.");
                dateManuDate.Focus();
                return false;
            }
            // Validate Price
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                errorProvider.SetError(txtPrice, "Valid price is required.");
                txtPrice.Focus();
                return false;
            }
            // Validate Image
            if (picCar.Image == null)
            {
                errorProvider.SetError(picCar, "Car picture is required.");
                picCar.Focus();
                return false;
            }
            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {   //GO BACK TO TABLE
            CarsUI carsUI = new CarsUI();
            carsUI.Show();
            this.Hide();
        }
    }
}
