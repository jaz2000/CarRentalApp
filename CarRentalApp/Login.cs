using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentingEntities _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentingEntities();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();
                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text;

                //byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                //StringBuilder sBuilder = new StringBuilder();

                //for (int i = 0; i < data.Length; i++)
                //{
                //    sBuilder.Append(data[i].ToString("x2"));
                //}

                var hashed_password = Utils.HashPassWord(password);

                var user = _db.Users.FirstOrDefault(q => q.username == username && q.password == hashed_password && q.isActive == true);




                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var role = user.UserRoles.FirstOrDefault();
                    var roleShortName = role.Role.shortname;
                    var mainWindow = new MainWindow(this,user);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again");
            }
        }
    }
}
