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
    public partial class CarsUI : Form
    {
        public CarsUI()
        {
            InitializeComponent();
        }

        private void CarsUI_Load(object sender, EventArgs e)
        {
            GetCarData();
        }

        private void GetCarData()
        {
            CarController carController = new CarController();
            grdCars.DataSource = carController.GetCars();
            //Set Data to Table
            grdCars.Columns["car_id"].HeaderText = "ID";
            grdCars.Columns["car_type"].HeaderText = "Type";
            grdCars.Columns["car_brand"].HeaderText = "Brand";
            grdCars.Columns["color_name"].HeaderText = "Color";
            grdCars.Columns["car_manufacture_date"].HeaderText = "Manufacture Date";

            if (GlobalSession.RoleId == 2) //IF THE USER IS AN ADMIN SHOW EDIT AND DELETE BUTTONS
            {
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    Name = "EditColumn"
                };
                grdCars.Columns.Add(editButtonColumn);

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Name = "DeleteColumn"
                };
                grdCars.Columns.Add(deleteButtonColumn);
            }
            grdCars.CellClick += grdCars_CellClick;
        }

        private void grdCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the user clicked on a valid row
            {
                int carId = Convert.ToInt32(grdCars.Rows[e.RowIndex].Cells["car_id"].Value);
                // Determine which column was clicked (Edit, Delete, or Order)
                if (grdCars.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    OpenCarForm(carId, "U");  // Open in Edit Mode
                }
                else if (grdCars.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    OpenCarForm(carId, "D");  // Open in Delete Mode
                }
            }
        }

        private void OpenCarForm(int carId, string mode)
        {
            // Open CarFormUI in the specified mode (D: Delete, U: Update)
            CarFormUI carForm = new CarFormUI();
            carForm.SetMode(carId, mode);
            carForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   //OPEN AN EMPTY CAR FORM
            CarFormUI carFormUI = new CarFormUI();
            carFormUI.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomeUI adminHomeUI = new AdminHomeUI();
            adminHomeUI.Show();
            this.Hide();
        }
    }
}
