using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCCarTraders.Model;
using Microsoft.Data.SqlClient;

namespace ABCCarTraders.Controller
{
    public class CarController
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server Certificate=True");

        public DataTable GetCars()
        {
            string selectCars = "SELECT c.car_id, c.car_type, c.car_brand, cc.color_name, c.car_manufacture_date FROM Car c JOIN CarColor cc " +
                "ON c.car_color = cc.color_id";
            DataTable dtCars = new DataTable();
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(selectCars, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtCars); // Fills the DataTable with the result from the database
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
            return dtCars;
        }

        public Car GetCarByID(int carId)
        {//GET CAR DATA BY ID TO FILL THE CAR FORM WHEN IN EDIT, DELETE OR ORDER MODE
            string selectCarById = "Select car_id, car_type, car_brand, car_color, car_fueleconomy, car_engine_power, car_manufacture_date, car_price, " +
                "car_picture from Car where car_id = " + carId;
            Car car = new Car();
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(selectCarById, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            car.CarId = Convert.ToInt32(reader["car_id"]);
                            car.Type = reader["car_type"].ToString();
                            car.Brand = reader["car_brand"].ToString();
                            car.ColorId = Convert.ToInt32(reader["car_color"]);
                            car.FuelEconomy = Convert.ToDecimal(reader["car_fueleconomy"]);
                            car.EnginePower = Convert.ToInt32(reader["car_engine_power"]);
                            car.ManufactureDate = Convert.ToDateTime(reader["car_manufacture_date"]);
                            car.Price = Convert.ToDecimal(reader["car_price"]);
                            byte[] carPictureBytes = (byte[])reader["car_picture"];
                            car.Picture = carPictureBytes;
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

            return car;
        }

        public void UpdateCar(Car car)
        {
            try
            {
                // Define the SQL UPDATE query using parameters
                string updateCar = "UPDATE Car SET car_type = @carType, car_brand = @carBrand, car_color = @carColor, " +
                                   "car_fueleconomy = @carFuelEconomy, car_engine_power = @carEnginePower, " +
                                   "car_manufacture_date = @carManufactureDate, car_price = @carPrice, " +
                                   "car_picture = @carPicture, " +
                                   "entry_user = @entryUser, entry_date = @entryDate WHERE car_id = @carId";

                using (SqlCommand cmd = new SqlCommand(updateCar, con))
                {
                    // Add parameters to the command to prevent SQL injection and handle types correctly
                    cmd.Parameters.AddWithValue("@carType", car.Type);
                    cmd.Parameters.AddWithValue("@carBrand", car.Brand);
                    cmd.Parameters.AddWithValue("@carColor", car.ColorId);
                    cmd.Parameters.AddWithValue("@carFuelEconomy", car.FuelEconomy);
                    cmd.Parameters.AddWithValue("@carEnginePower", car.EnginePower);
                    cmd.Parameters.AddWithValue("@carManufactureDate", car.ManufactureDate);
                    cmd.Parameters.AddWithValue("@carPrice", car.Price);
                    cmd.Parameters.AddWithValue("@carPicture", car.Picture);
                    cmd.Parameters.AddWithValue("@entryUser", car.EntryUser);
                    cmd.Parameters.AddWithValue("@entryDate", car.EntryDate);
                    cmd.Parameters.AddWithValue("@carId", car.CarId); // Use car ID to identify the record to update
                    
                    con.Open(); // Open the connection
                    
                    cmd.ExecuteNonQuery(); // Execute the UPDATE query
                }
                MessageBox.Show("Update Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        public void DeleteCar(Car car)
        {//DELETE QUERY FOR CAR
            con.Open();
            try
            {
                string deleteCar = "Delete from Car where car_id = " + car.CarId;
                using (SqlCommand cmd = new SqlCommand(deleteCar, con))
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

        public void OrderCar(Car car)
        {//INSERT ORDER
            con.Open();
            try
            {
                string orderCar = "Insert into Orders (user_id, order_date, order_status) VALUES (" + car.EntryUser + ", '" + car.EntryDate + "', 'Placed');" +
                    "select CAST(scope_identity() as int)";
                SqlCommand cmd = new SqlCommand(orderCar, con);
                int order_id = (int)cmd.ExecuteScalar(); //Get order_id";

                string orderItem = "Insert into OrderProduct (order_id, car_id) VALUES (" + order_id + ", " + car.CarId + ")";
                SqlCommand cmdorder = new SqlCommand(orderItem, con);
                cmdorder.ExecuteNonQuery();

                MessageBox.Show("Order Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public DataTable SearchCar(string type, string brand, int color)
        {
            con.Open();
            string searchQuery = "SELECT c.car_id, c.car_type, c.car_brand, cc.color_name, c.car_manufacture_date FROM Car c JOIN CarColor cc " +
                "ON c.car_color = cc.color_id WHERE (c.car_type = '" + type + "' OR '' = '" + type + "') " +
                "AND (c.car_brand = '" + brand + "' OR '' = '" + brand + "') AND (c.car_color = " + color + " OR 0 = " + color + ")";
            DataTable dtCars = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(searchQuery, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtCars); // Fills the DataTable with the result from the database
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
            return dtCars;
        }
    }
}
