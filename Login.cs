namespace HoaMage
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
        }
    }
}
