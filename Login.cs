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
            reg.Show();
            this.Hide();

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
    }
}
