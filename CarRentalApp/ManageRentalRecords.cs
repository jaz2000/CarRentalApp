using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentingEntities _db;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentingEntities();
        }

        private void btAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.MdiParent = this.MdiParent;
            addRentalRecord.Show();
        }

        private void btEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;

                //query database for record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                //lauch AddEditVehicle window with data

                var addEditRentalRecord = new AddEditRentalRecord(record);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.Show();

                // gvVehicleListing.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;   

                //query database for record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                //delete vehicle from table
                _db.CarRentalRecords.Remove(record);
                PopuluateGrid();
                _db.SaveChanges();
                MessageBox.Show($"Delete Operation Completed. Refresh Grid To see Changes");
                gvRecordList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopuluateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopuluateGrid();
        }

        private void PopuluateGrid()
        {
            var records = _db.CarRentalRecords.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.id,
                q.Cost,
                Car = q.TypeOfCar.Make + " " + q.TypeOfCar.Model

            }).ToList();
            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateIn"].HeaderText = "DateIn";
            gvRecordList.Columns["DateOut"].HeaderText = "DateOut";
            gvRecordList.Columns["Id"].Visible = false;
        }
    }
}
