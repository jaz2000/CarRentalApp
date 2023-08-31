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
    public partial class ManageUsers : Form
    {
        private readonly CarRentingEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db= new CarRentingEntities();
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
            
        }

        private void btResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;

                //query database for record
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                

                //var genericPassword = "Password@123";

                var hashed_password = Utils.DefaultHashedPassWord();

                user.password = hashed_password;

                _db.SaveChanges();
                MessageBox.Show($"{user.username}'s password has been reset!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;

                //query database for record
                var user = _db.Users.FirstOrDefault(q => q.id == id);


                user.isActive = user.isActive==true?false:true;

                _db.SaveChanges();
                MessageBox.Show($"{user.username}'s active status has been changed!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var users = _db.Users
                .Select(q => new
                {
                    q.id,
                    q.username,
                    q.UserRoles.FirstOrDefault().Role.name,
                    q.isActive
                }
                ).ToList();
            gvUserList.DataSource = users;
            gvUserList.Columns["username"].HeaderText = "Username";
            gvUserList.Columns["name"].HeaderText = "Name";
            gvUserList.Columns["isActive"].HeaderText = "Active";

            gvUserList.Columns["id"].Visible = false;
        }
    }
}
