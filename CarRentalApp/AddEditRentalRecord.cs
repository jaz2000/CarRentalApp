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
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;
        private readonly CarRentingEntities _db;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            this.Text = "Add New Rental Record";
            lblTitle.Text = "Add New Rental Record";
            isEditMode = false;
            _db = new CarRentingEntities();
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit )
        {
            InitializeComponent();
            this.Text = "Edit Rental Record";
            lblTitle.Text = "Edit Rental Record";
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
            }
            else
            {
                isEditMode = true;
                _db = new CarRentingEntities();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            tbcustname.Text=recordToEdit.CustomerName;
            dtRent.Value=(DateTime)recordToEdit.DateRented;
            dtret.Value=(DateTime)recordToEdit.DateReturned;
            tbcost.Text=recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();
            
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string custname = tbcustname.Text;
                DateTime daterent = dtRent.Value;
                DateTime dateret = dtret.Value;
                double cost = !string.IsNullOrWhiteSpace(tbcost.Text) ? Convert.ToDouble(tbcost.Text) :0;
                string cartype = typeofcar.Text;

                bool isvalid = true;
                string errormessage = "";
                if (string.IsNullOrWhiteSpace(custname))
                {
                    errormessage += "Please give a customer name \n\r";
                    isvalid = false;
                }
                if (string.IsNullOrWhiteSpace(cartype))
                {
                    errormessage += "please fill the field for type of car \n\r";
                    isvalid = false;
                }
                if (daterent > dateret || dateret >= DateTime.Now.Date)
                {
                    errormessage += "invalid date selection\n\r";
                    isvalid = false;
                }
                if (isvalid)
                {
                    var rentalRecord = new CarRentalRecord();
                    if (isEditMode)
                    {
                        var id = int.Parse(lblRecordId.Text);
                        rentalRecord = _db.CarRentalRecords.FirstOrDefault(q=>q.id== id);
                        

                    }
                    rentalRecord.CustomerName = custname;
                    rentalRecord.DateRented = daterent;
                    rentalRecord.DateReturned = dateret;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)typeofcar.SelectedValue;
                    if(!isEditMode)
                        _db.CarRentalRecords.Add(rentalRecord);
                    _db.SaveChanges();

                    MessageBox.Show(
                        $"Customer Name: {custname}\n\r" +
                        $"Date Rented: {daterent}\n\r" +
                        $"Date Returned: {dateret}\n\r" +
                        $"Cost: {cost}\n\r" +
                        $"Type of car: {typeofcar.Text}\n\r"
                    );
                        
                    
                    Close();
                }
                else
                {
                    MessageBox.Show(errormessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var cars = carRentingEntities.TypeOfCars.ToList();
            var cars = _db
                .TypeOfCars
                .Select(q => new
                { 
                    Id = q.Id, 
                    Name = q.Make + " " + q.Model 
                })
                .ToList();

            typeofcar.DisplayMember = "Name";
            typeofcar.ValueMember = "Id";
            typeofcar.DataSource = cars;
        }

    }
}