using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentingEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentingEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //var cars = _db.TypeOfCars.Select(q => new { CarId = q.id, CarName = q.name }).ToList();
            try
            {
                PopuluateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
           // gvVehicleListing.Columns[0].HeaderText = "ID";
            //gvVehicleListing.Columns[1].HeaderText = "NAME";
        }

        private void btAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                var addEditVehicle = new AddEditVehicle(this);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
                //  gvVehicleListing.Refresh();
                //MessageBox.Show("Insert Operation Completed. Refresh Grid to See Changes");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
            
            
        }

        private void btEditCar_Click(object sender, EventArgs e)
        {
            //get id of selected row
            try
            {
                var id = (int)gvVehicleListing.SelectedRows[0].Cells["Id"].Value;

                //query database for record
                var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);

                //lauch AddEditVehicle window with data
                var addEditVehicle = new AddEditVehicle(car,this);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
                // gvVehicleListing.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btDeleteCar_Click(object sender, EventArgs e)
        {
            //get id of selected row
            try
            {
                var id = (int)gvVehicleListing.SelectedRows[0].Cells["Id"].Value;

                //query database for record
                var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Record?",
                    "Delete",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    //delete vehicle from table
                    _db.TypeOfCars.Remove(car);
                    _db.SaveChanges();
                    //MessageBox.Show($"Delete Operation Completed. Refresh Grid To see Changes");
                }
                

                PopuluateGrid();
                
                
            }
            catch(Exception ex) { 
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopuluateGrid();
        }

        public void PopuluateGrid()
        {
            var cars = _db.TypeOfCars.Select(q => new
            {
                Make = q.Make,
                Model = q.Model,
                VIN = q.VIN,
                Year = q.Year,
                LicensePlateNumber = q.LicensePlateNumber,
                q.Id
            }).ToList();
            gvVehicleListing.DataSource = cars;
            gvVehicleListing.Columns[4].HeaderText = "License Plate Number";
            gvVehicleListing.Columns[5].Visible = false;
        }
    }
}
