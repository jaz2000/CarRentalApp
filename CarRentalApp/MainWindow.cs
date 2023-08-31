using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainWindow : Form
    {
        private Login _login;
        public User _user;
        public string _RoleName;
        public MainWindow()
        {
            InitializeComponent();
           
        }
        public MainWindow(Login login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _RoleName = user.UserRoles.FirstOrDefault().Role.shortname;


        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.ShowDialog();
            addRentalRecord.MdiParent = this;
            
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var OpenForms = Application.OpenForms.Cast<Form>();
            //var isOpen =OpenForms.Any(q=>q.Name=="ManageVehicleListing");

            if (!Utils.FormIsOpen("ManageVehicleListing"))
            {
                var vehicleListing = new ManageVehicleListing();
                vehicleListing.MdiParent = this;
                vehicleListing.Show();
            }

            
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecords();
            manageRentalRecords.MdiParent = this;
            manageRentalRecords.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var OpenForms = Application.OpenForms.Cast<Form>();
            //var isOpen = OpenForms.Any(q => q.Name == "ManageUsers");
            if (!Utils.FormIsOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_user.password == Utils.DefaultHashedPassWord())
            {
                var resetPassword = new ResetPassword(_user);


                resetPassword.ShowDialog();
            }
            var username = _user.username;
            tsiLoginText.Text = $"Logged In As : {username}";
            if(_RoleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible= false;
            }
        }
    }
}
