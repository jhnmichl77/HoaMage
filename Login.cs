using System.Data;
using System.Data.OleDb;

namespace HoaMage

    {
    public partial class Login : Shared
    {

        public Login()
        {
            InitializeComponent();

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserCheck = "Admin001";
            string PassCheck = "Admin123";

            if (tbxUsername.Text == UserCheck)
            {
                if (tbxPassword.Text == PassCheck)
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void materialLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.TestConnection())
            {
                MessageBox.Show("Database connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Database connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
