using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCCarTraders.Model;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace ABCCarTraders.Controller
{
    public class OrderController
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8O0T49\\SQLEXPRESS;Initial Catalog=ABCCarTradersDB;Integrated Security=True;Trust Server Certificate=True");

        public DataTable GetCarOrdersById(int userid) //GET CARS ORDERED BY A PARTICULAR USER
        {
            string selectCarOrdersById = "SELECT o.order_id, c.car_type, c.car_price, o.order_date, o.order_status FROM Orders o " +
                "JOIN OrderProduct op ON o.order_id = op.order_id JOIN Car c ON c.car_id = op.car_id WHERE o.user_id = " + userid;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(selectCarOrdersById, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt); // Fills the DataTable with the result from the database
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
            return dt;
        }

        public DataTable GetCarPartOrdersById(int userId)  //GET CAR PARTS ORDERED BY A PARTICULAR USER
        {
            string selectCarPartsOrderById = "SELECT o.order_id, cp.carpart_name, c.car_type, cp.carpart_price, o.order_date, o.order_status FROM Orders o " +
                "JOIN OrderProduct op ON o.order_id = op.order_id JOIN CarPart cp ON op.car_part_id = cp.carpart_id " +
                "JOIN Car c ON cp.carpart_car_id = c.car_id WHERE o.user_id = " + userId;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(selectCarPartsOrderById, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt); // Fills the DataTable with the result from the database
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
            return dt;
        }

        public DataTable GetOrders() //GET ALL CAR ORDERS
        {
            string selectCarOrdersById = "SELECT o.order_id, c.car_type, c.car_price, o.order_date, o.order_status FROM Orders o " +
                "JOIN OrderProduct op ON o.order_id = op.order_id JOIN Car c ON c.car_id = op.car_id";
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(selectCarOrdersById, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt); // Fills the DataTable with the result from the database
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
            return dt;
        }

        public DataTable GetCarParts() //GET ALL CAR PART ORDERS
        {
            string selectCarPartsOrderById = "SELECT o.order_id, cp.carpart_name, c.car_type, cp.carpart_price, o.order_date, o.order_status FROM Orders o " +
                "JOIN OrderProduct op ON o.order_id = op.order_id JOIN CarPart cp ON op.car_part_id = cp.carpart_id " +
                "JOIN Car c ON cp.carpart_car_id = c.car_id";
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(selectCarPartsOrderById, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt); // Fills the DataTable with the result from the database
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
            return dt;
        }

        public DataTable GetCarOrder(int orderid) //BY ORDER ID
        {
            string getCarOrder = "SELECT op.order_id, o.order_status, c.car_id, c.car_type, c.car_brand, c.car_color, c.car_fueleconomy, " +
                "c.car_engine_power, c.car_manufacture_date, c.car_price, c.car_picture FROM OrderProduct op JOIN Car c ON op.car_id = c.car_id " +
                "JOIN Orders o ON op.order_id = o.order_id WHERE op.order_id = " + orderid;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(getCarOrder, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt); // Fills the DataTable with the result from the database
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
            return dt;
        }

        public DataTable GetCarPartOrder(int orderId) //BY ORDER ID
        {
            string getCarOrder = "SELECT op.order_id, o.order_status, c.carpart_id, c.carpart_name, c.carpart_car_id, c.carpart_manufacture_date, c.carpart_price, " +
                "c.carpart_description, c.carpart_color_id, c.carpart_picture FROM OrderProduct op JOIN CarPart c ON op.car_part_id = c.carpart_id " +
                "JOIN Orders o ON op.order_id = o.order_id WHERE op.order_id = " + orderId;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(getCarOrder, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt); // Fills the DataTable with the result from the database
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
            return dt;
        }

        public void CancelOrder(int orderid)
        {
            con.Open();
            try
            {
                string cancelOrder = "UPDATE Orders SET order_status = 'Canceled' WHERE order_id = " + orderid;
                using (SqlCommand cmd = new SqlCommand(cancelOrder, con))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cancel Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void EditOrder(int orderid, string status)
        {
            con.Open();
            try
            {
                string cancelOrder = "UPDATE Orders SET order_status = '" + status + "' WHERE order_id = " + orderid;
                using (SqlCommand cmd = new SqlCommand(cancelOrder, con))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Edit Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
