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
    public partial class CarPartsUI : Form
    {
        public CarPartsUI()
        {
            InitializeComponent();
        }

        private void CarPartsUI_Load(object sender, EventArgs e)
        {
            GetCarPartsData(); //GET CAR PARTS FROM DB
        }

        private void GetCarPartsData()
        {
            CarPartController carPartController = new CarPartController();
            grdCarParts.DataSource = carPartController.GetCarParts();
            grdCarParts.Columns["carpart_id"].HeaderText = "ID";
            grdCarParts.Columns["carpart_name"].HeaderText = "Name";
            grdCarParts.Columns["car_type"].HeaderText = "Car";  // This is from the Car table for carpart_car_id
            grdCarParts.Columns["carpart_manufacture_date"].HeaderText = "Manufacture Date";
            grdCarParts.Columns["carpart_price"].HeaderText = "Price";
            int roleid = 2;
            if (roleid == 2) //IF ADMIN
            {
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Edit", //SHOW EDIT BUTTON
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    Name = "EditColumn"
                };
                grdCarParts.Columns.Add(editButtonColumn);
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Delete", //SHOW DELETE BUTTON
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Name = "DeleteColumn"
                };
                grdCarParts.Columns.Add(deleteButtonColumn);
            }
            grdCarParts.CellClick += grdCarParts_CellClick;
        }

        private void grdCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the user clicked on a valid row
            {
                int carPartId = Convert.ToInt32(grdCarParts.Rows[e.RowIndex].Cells["carpart_id"].Value);

                // Determine which column was clicked (Edit, Delete, or Order)
                if (grdCarParts.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    OpenCarPartForm(carPartId, "U");  // Open in Edit Mode
                }
                else if (grdCarParts.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    OpenCarPartForm(carPartId, "D");  // Open in Delete Mode
                }
            }
        }

        private void OpenCarPartForm(int carPartId, string mode)
        {
            // Open CarPartForm in the specified mode (D: Delete, U: Update)
            CarPartForm carPartForm = new CarPartForm();
            carPartForm.SetMode(carPartId, mode);
            carPartForm.Show();
            this.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {   //GO TO CAR PART FORM
            CarPartForm carPartForm = new CarPartForm();
            carPartForm.Show();
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
