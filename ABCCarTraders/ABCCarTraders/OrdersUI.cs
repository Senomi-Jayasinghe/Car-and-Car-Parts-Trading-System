using ABCCarTraders.Controller;
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
    public partial class OrdersUI : Form
    {
        public OrdersUI()
        {
            InitializeComponent();
        }

        private void OrdersUI_Load(object sender, EventArgs e)
        {
            GetOrderData();
        }

        private void GetOrderData()
        {
            int roleid = GlobalSession.RoleId;
            int userId = GlobalSession.UserId;
            OrderController orderController = new OrderController();
            if (roleid == 1) //FOR CUSTOMERS
            {
                grdCarOrders.DataSource = orderController.GetCarOrdersById(userId);
                grdCarOrders.Columns["order_id"].HeaderText = "ID";
                grdCarOrders.Columns["car_type"].HeaderText = "Car";  // This is from the Car table for carpart_car_id
                grdCarOrders.Columns["car_price"].HeaderText = "Price";
                grdCarOrders.Columns["order_date"].HeaderText = "Order Date";
                grdCarOrders.Columns["order_status"].HeaderText = "Status";

                DataGridViewButtonColumn cancelButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Cancel",
                    Text = "Cancel",
                    UseColumnTextForButtonValue = true,
                    Name = "CancelColumn"
                };
                grdCarOrders.Columns.Add(cancelButtonColumn);

                // Handle CellFormatting to control visibility of Cancel button based on status
                grdCarOrders.CellFormatting += (s, e) =>
                {
                    if (grdCarOrders.Columns[e.ColumnIndex].Name == "CancelColumn")
                    {
                        var orderStatus = grdCarOrders.Rows[e.RowIndex].Cells["order_status"].Value?.ToString();
                        e.Value = orderStatus == "Placed" ? "Cancel" : "";
                        e.FormattingApplied = true;
                    }
                };

                // Handle CellClick event to open another form with order ID and mode
                grdCarOrders.CellClick += (s, e) =>
                {
                    if (grdCarOrders.Columns[e.ColumnIndex].Name == "CancelColumn")
                    {
                        // Check if the button is available (i.e., status is "Placed")
                        var orderStatus = grdCarOrders.Rows[e.RowIndex].Cells["order_status"].Value?.ToString();
                        if (orderStatus == "Placed")
                        {
                            // Get the order ID from the selected row
                            int orderId = Convert.ToInt32(grdCarOrders.Rows[e.RowIndex].Cells["order_id"].Value);

                            // Define the mode for the next form
                            string mode = "C";

                            // Open the next form with order ID and mode
                            OrderCarFormUI ordercarForm = new OrderCarFormUI();
                            ordercarForm.SetMode(orderId, mode);
                            ordercarForm.Show();
                            this.Hide();
                        }
                    }
                };

                grdCarPartOrders.DataSource = orderController.GetCarPartOrdersById(userId);
                grdCarPartOrders.Columns["order_id"].HeaderText = "ID";
                grdCarPartOrders.Columns["carpart_name"].HeaderText = "Name";
                grdCarPartOrders.Columns["car_type"].HeaderText = "Car";
                grdCarPartOrders.Columns["carpart_price"].HeaderText = "Price";
                grdCarPartOrders.Columns["order_date"].HeaderText = "Order Date";
                grdCarPartOrders.Columns["order_status"].HeaderText = "Status";

                DataGridViewButtonColumn cancelPartButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Cancel",
                    Text = "Cancel",
                    UseColumnTextForButtonValue = true,
                    Name = "CancelColumn"
                };
                grdCarPartOrders.Columns.Add(cancelPartButtonColumn);

                // Handle CellFormatting to control visibility of Cancel button based on status
                grdCarPartOrders.CellFormatting += (s, e) =>
                {
                    if (grdCarPartOrders.Columns[e.ColumnIndex].Name == "CancelColumn")
                    {
                        // Get the status value of the current row
                        var orderStatus = grdCarPartOrders.Rows[e.RowIndex].Cells["order_status"].Value?.ToString();

                        // Show or hide the Cancel button based on the order status
                        e.Value = orderStatus == "Placed" ? "Cancel" : "";
                        e.FormattingApplied = true; // Indicate formatting is handled
                    }
                };

                // Handle CellClick event to open another form with order ID and mode
                grdCarPartOrders.CellClick += (s, e) =>
                {
                    if (grdCarPartOrders.Columns[e.ColumnIndex].Name == "CancelColumn")
                    {
                        // Check if the button is available (i.e., status is "Placed")
                        var orderStatus = grdCarPartOrders.Rows[e.RowIndex].Cells["order_status"].Value?.ToString();
                        if (orderStatus == "Placed")
                        {
                            // Get the order ID from the selected row
                            int orderId = Convert.ToInt32(grdCarPartOrders.Rows[e.RowIndex].Cells["order_id"].Value);

                            // Define the mode for the next form
                            string mode = "C";

                            // Open the next form with order ID and mode
                            OrderCarPartForm ordercarpartForm = new OrderCarPartForm();
                            ordercarpartForm.SetMode(orderId, mode);
                            ordercarpartForm.Show();
                            this.Hide();
                        }
                    }
                };


            }
            else if (roleid == 2) // FOR ADMINS
            {
                grdCarOrders.DataSource = orderController.GetOrders();
                grdCarOrders.Columns["order_id"].HeaderText = "ID";
                grdCarOrders.Columns["car_type"].HeaderText = "Car";  // This is from the Car table for carpart_car_id
                grdCarOrders.Columns["car_price"].HeaderText = "Price";
                grdCarOrders.Columns["order_date"].HeaderText = "Order Date";
                grdCarOrders.Columns["order_status"].HeaderText = "Status";

                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    Name = "EditColumn"
                };
                grdCarOrders.Columns.Add(editButtonColumn);

                // Handle CellClick event to open another form with order ID and mode
                grdCarOrders.CellClick += (s, e) =>
                {
                    if (grdCarOrders.Columns[e.ColumnIndex].Name == "EditColumn")
                    {
                        // Get the order ID from the selected row
                        int orderId = Convert.ToInt32(grdCarOrders.Rows[e.RowIndex].Cells["order_id"].Value);

                        // Define the mode for the next form
                        string mode = "E";

                        // Open the next form with order ID and mode
                        OrderCarFormUI ordercarForm = new OrderCarFormUI();
                        ordercarForm.SetMode(orderId, mode);
                        ordercarForm.Show();
                        this.Hide();
                    }
                };

                grdCarPartOrders.DataSource = orderController.GetCarParts();
                grdCarPartOrders.Columns["order_id"].HeaderText = "ID";
                grdCarPartOrders.Columns["carpart_name"].HeaderText = "Name";
                grdCarPartOrders.Columns["car_type"].HeaderText = "Car";
                grdCarPartOrders.Columns["carpart_price"].HeaderText = "Price";
                grdCarPartOrders.Columns["order_date"].HeaderText = "Order Date";
                grdCarPartOrders.Columns["order_status"].HeaderText = "Status";

                DataGridViewButtonColumn editButtonColumnParts = new DataGridViewButtonColumn
                {
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    Name = "EditColumn"
                };
                grdCarPartOrders.Columns.Add(editButtonColumnParts);

                // Handle CellClick event to open another form with order ID and mode
                grdCarPartOrders.CellClick += (s, e) =>
                {
                    if (grdCarPartOrders.Columns[e.ColumnIndex].Name == "EditColumn")
                    {
                        // Get the order ID from the selected row
                        int orderId = Convert.ToInt32(grdCarPartOrders.Rows[e.RowIndex].Cells["order_id"].Value);

                        // Define the mode for the next form
                        string mode = "E";

                        // Open the next form with order ID and mode
                        OrderCarPartForm ordercarpartForm = new OrderCarPartForm();
                        ordercarpartForm.SetMode(orderId, mode);
                        //ordercarpartForm.Show();
                        this.Hide();
                    }
                };
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int roleid = GlobalSession.RoleId;
            if (roleid == 1)
            {
                CustomerHomeUI customerHomeUI = new CustomerHomeUI();
                customerHomeUI.Show();
                this.Hide();
            }
            else if (roleid == 2)
            {
                AdminHomeUI adminHomeUI = new AdminHomeUI();
                adminHomeUI.Show();
                this.Hide();
            }
        }
    }
}
