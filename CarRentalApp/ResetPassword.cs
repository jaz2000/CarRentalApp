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
    public partial class ResetPassword : Form
    {
        private User _user;
        private readonly CarRentingEntities _db;
        public ResetPassword(User user)
        {
            InitializeComponent();
            _user = user;
            _db = new CarRentingEntities();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbPassword.Text;
                var confirm_password = tbConfirmPassword.Text;
                var user = _db.Users.FirstOrDefault(q => q.id == _user.id);
                if (confirm_password != password)
                {
                    MessageBox.Show("Password do not match. Please try again!");
                }

                user.password = Utils.HashPassWord(password);
                _db.SaveChanges();
                MessageBox.Show("Password was reset successfully");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured. Please try Again");
            }
        }
    }
}
