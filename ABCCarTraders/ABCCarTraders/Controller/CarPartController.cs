using ABCCarTraders.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ABCCarTraders.Controller
{
    public class CarPartController
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server Certificate=True");

        public DataTable GetCarParts() //GET CARPARTS FOR TABLE
        {
            string selectCarParts = "SELECT cp.carpart_id, cp.carpart_name, c.car_type, cp.carpart_manufacture_date, cp.carpart_price FROM CarPart cp " +
                "JOIN Car c ON cp.carpart_car_id = c.car_id";
            DataTable dtCarParts = new DataTable();
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(selectCarParts, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtCarParts); // Fills the DataTable with the result from the database
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dtCarParts;
        }

        public CarPart GetCarPartById(int carpartId) //GET DATA TO FILL CARPART FORM IN EDIT, DELETE AND ORDER MODE
        {
            string selectCarPartById = "Select carpart_id, carpart_name, carpart_car_id, carpart_manufacture_date, carpart_price, carpart_description, " +
                "carpart_color_id, carpart_picture from CarPart where carpart_id = " + carpartId;
            CarPart carpart = new CarPart();
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(selectCarPartById, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            carpart.CarPartId = Convert.ToInt32(reader["carpart_id"]);
                            carpart.Name = reader["carpart_name"].ToString();
                            carpart.CarId = Convert.ToInt32(reader["carpart_car_id"]);
                            carpart.ManufactureDate = Convert.ToDateTime(reader["carpart_manufacture_date"]);
                            carpart.Price = Convert.ToDecimal(reader["carpart_price"]);
                            carpart.Description = reader["carpart_description"].ToString();
                            carpart.ColorId = Convert.ToInt32(reader["carpart_color_id"]);

                            byte[] carPartPictureBytes = (byte[])reader["carpart_picture"];
                            carpart.Picture = carPartPictureBytes;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return carpart;
        }

        public void UpdateCarParts(CarPart carPart)
        {
            try
            {
                // Define the SQL UPDATE query using parameters
                string updateCarPart = "UPDATE CarPart SET carpart_name = @carPartName, carpart_car_id = @carId, carpart_manufacture_date = @carPartManufactureDate, " +
                    "carpart_price = @carPartPrice, carpart_description = @carPartDesc, carpart_color_id = @carPartColor, carpart_picture = @carPartPicture, " +
                    "entry_user = @entryUser, entry_date = @entryDate WHERE carpart_id = @carPartId";

                using (SqlCommand cmd = new SqlCommand(updateCarPart, con))
                {
                    // Add parameters to the command to prevent SQL injection and handle types correctly
                    cmd.Parameters.AddWithValue("@carPartName", carPart.Name);
                    cmd.Parameters.AddWithValue("@carId", carPart.CarId);
                    cmd.Parameters.AddWithValue("@carPartManufactureDate", carPart.ManufactureDate);
                    cmd.Parameters.AddWithValue("@carPartPrice", carPart.Price);
                    cmd.Parameters.AddWithValue("@carPartDesc", carPart.Description);
                    cmd.Parameters.AddWithValue("@carPartColor", carPart.ColorId);
                    cmd.Parameters.AddWithValue("@carPartPicture", carPart.Picture);
                    cmd.Parameters.AddWithValue("@entryUser", carPart.EntryUser);
                    cmd.Parameters.AddWithValue("@entryDate", carPart.EntryDate);
                    cmd.Parameters.AddWithValue("@carPartId", carPart.CarPartId); // Use carPart ID to identify the record to update

                    con.Open(); // Open the connection

                    // Execute the UPDATE query
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Update Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void DeleteCarParts(CarPart carPart)
        {
            con.Open();
            try
            {
                string deleteCarPart = "Delete from CarPart where carpart_id = " + carPart.CarPartId;
                using (SqlCommand cmd = new SqlCommand(deleteCarPart, con))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Delete Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void OrderCarParts(CarPart carPart)
        {
            con.Open();
            try
            {
                string orderCar = "Insert into Orders (user_id, order_date, order_status) VALUES (" + carPart.EntryUser + ", '" + carPart.EntryDate + "', " +
                    "'Placed');" +
                    "select CAST(scope_identity() as int)";
                SqlCommand cmd = new SqlCommand(orderCar, con);
                int order_id = (int)cmd.ExecuteScalar(); //Get order_id";
                string orderItem = "Insert into OrderProduct (order_id, car_part_id) VALUES (" + order_id + ", " + carPart.CarPartId + ")";
                SqlCommand cmdorder = new SqlCommand(orderItem, con);
                cmdorder.ExecuteNonQuery();
                MessageBox.Show("Order Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public DataTable SearchCarPart(string name, int carType, int color)
        {
            con.Open();
            string searchQuery = "SELECT cp.carpart_id, cp.carpart_name, c.car_type, cp.carpart_manufacture_date, cp.carpart_price FROM CarPart cp " +
                "JOIN Car c ON cp.carpart_car_id = c.car_id WHERE (cp.carpart_name = '" + name + "' OR '' = '" + name + "') " +
                "AND (cp.carpart_car_id =" + carType + " OR -1 = " + carType + ") AND (cp.carpart_color_id = " + color + " OR 0 = " + color + ")";

            DataTable dtCarParts = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(searchQuery, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtCarParts); // Fills the DataTable with the result from the database
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dtCarParts;
        }
    }
}
