using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HoaMage
{
    public partial class HomeownerDashBoard : Shared
    {
        public HomeownerDashBoard()
        {
            InitializeComponent();
        }

        private DatabaseHelper dbHelper = new DatabaseHelper();

        public DataTable GetHomeowners()
        {
            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM homeowners";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public void AddHomeowner(string name, string address, string contact)
        {
            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO homeowners (name, address, contact_number) VALUES (@Name, @Address, @Contact)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void HomeownerDashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
