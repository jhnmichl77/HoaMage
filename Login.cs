using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;


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
            string username = tbxUsername.Text.Trim();
            string password = Shared.HashPassword(tbxPassword.Text.Trim());

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "SELECT AccountID, [Role] FROM Accounts WHERE [Username]=? AND [Password]=?";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    using(OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", username);
                        command.Parameters.AddWithValue("?", password);
                        //MessageBox.Show($"Username: {username}\nPassword: {password}", "Debug");

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int AccountID = reader.GetInt32(0);
                                string UserRole = reader.GetString(1);
                                string propertyQuery = "SELECT PropertyID FROM PropertyInformation WHERE AccountID=?";
                                using (OleDbCommand propertycommnad = new OleDbCommand(propertyQuery, connection))
                                {
                                    propertycommnad.Parameters.AddWithValue("?", AccountID);
                                    using(OleDbDataReader propertyRead = propertycommnad.ExecuteReader())
                                    {
                                        if (propertyRead.Read())
                                        {
                                            int PropertyID = propertyRead.GetInt32(0);
                                            Identification.Username = username;
                                            Identification.AccountID = AccountID;
                                            Identification.Role = UserRole;
                                            Identification.PropertyID = PropertyID;

                                            if (UserRole == "Admin")
                                            {
                                                Dashboard dashboard = new Dashboard();
                                                dashboard.Show();
                                                this.Hide();
                                            }
                                            else
                                            {
                                                HomeownerDashboard homeownerDashboard = new HomeownerDashboard();
                                                homeownerDashboard.Show();
                                                this.Hide();
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Credentials", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
