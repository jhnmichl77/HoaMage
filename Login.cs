using System.Data.OleDb;

namespace HoaMage

    {
    public partial class Login : Shared
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
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

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\johnm\\source\\repos\\HoaMage\\HoaMageDB.accdb;");
                myConn.Open();
                MessageBox.Show("Connection Successful!");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
