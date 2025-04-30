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
    public partial class viewRequest : MaterialForm
    {
        public viewRequest(string type, string subject, string context, string status, string dateSubmitted)
        {
            InitializeComponent();
            Shared.Set(this);
            checkRole();

            tbxReqType.Text = type;
            tbxReqSubject.Text = subject;
            tbxReqContext.Text = context;
            cbxStatus.Text = status;
            DateTime formattedDate = Convert.ToDateTime(dateSubmitted);
            tbxReqDate.Text = formattedDate.ToShortDateString();
        }

        private void checkRole()
        {
            bool isAdmin = Shared.Identification.Role == "Admin";

            tbxReqDate.Enabled = false;
            tbxReqSubject.Enabled = false;
            tbxReqType.Enabled = false;
            tbxReqContext.Enabled = false;
            cbxStatus.Enabled = isAdmin;
            btnSave.Visible = isAdmin;
            btnReply.Visible = isAdmin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newStatus = cbxStatus.Text;
            string subject = tbxReqSubject.Text;
            string dateSubmitted = tbxReqDate.Text; 

            string query = "UPDATE Request SET Status = ? WHERE ReqSubject = ? AND DateSubmitted = ?";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("?", newStatus);
                command.Parameters.AddWithValue("?", subject);
                command.Parameters.AddWithValue("?", Convert.ToDateTime(dateSubmitted));


                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Request status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Request not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


    }
}
