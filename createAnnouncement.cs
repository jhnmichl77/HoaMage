using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace HoaMage
{
    public partial class createAnnouncement : MaterialForm
    {
        public createAnnouncement()
        {
            InitializeComponent();
            Shared.Set(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "Insert into Announcements (Regarding, Context, DayDate) Values (?, ?, ?)";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Regarding", tbxRe.Text);
                    command.Parameters.AddWithValue("@Context", tbxText.Text);
                    command.Parameters.AddWithValue("@DayDate", dtpDate.Value.Date);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Announcement Created Successfully", "Information", MessageBoxButtons.OK);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            tbxRe.Clear();
            tbxText.Clear();
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
