using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private ManageVehicleListing _manageVehicleListing;
        private readonly CarRentingEntities _db;
        public AddEditVehicle(ManageVehicleListing manageVehicleListing = null)
        {
            
            InitializeComponent();
            this.Text = "Add New Vehicle";
            lblTitle.Text = "Add New Vehicle";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentingEntities();
        }

        public AddEditVehicle(TypeOfCar carToEdit,ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            this.Text = "Edit Vehicle";
            lblTitle.Text = "Edit Vehicle";
            _manageVehicleListing = manageVehicleListing;   
            if(carToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
            }
            else
            {
                isEditMode = true;
                _db = new CarRentingEntities();
                PopulateFields(carToEdit);
            }
            
        }
        private void PopulateFields(TypeOfCar car)
        {
            lblId.Text = car.Id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.VIN;
            tbYear.Text = car.Year.ToString();
            tbLicenseNum.Text = car.LicensePlateNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEditMode)
                {
                    var id = int.Parse(lblId.Text);
                    var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);
                    car.Model = tbModel.Text;
                    car.Make = tbMake.Text;
                    car.VIN = tbVIN.Text;
                    car.Year = int.Parse(tbYear.Text);
                    car.LicensePlateNumber = tbLicenseNum.Text;
                }

                else
                {
                    bool isvalid = true;
                    if (string.IsNullOrWhiteSpace(tbMake.Text) || string.IsNullOrEmpty(tbModel.Text))
                    {
                        isvalid = false;
                        MessageBox.Show("Please ensure that you provide a make and a model");
                    }
                    if (isvalid)
                    {
                        var newCar = new TypeOfCar
                        {
                            LicensePlateNumber = tbLicenseNum.Text,
                            Make = tbMake.Text,
                            Model = tbModel.Text,
                            VIN = tbVIN.Text,
                            Year = int.Parse(tbYear.Text)
                        };
                        _db.TypeOfCars.Add(newCar);

                    }
                    

                }
                _db.SaveChanges();
                _manageVehicleListing.PopuluateGrid();
                MessageBox.Show("Operation Completed. Refresh Grid To see Changes");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
