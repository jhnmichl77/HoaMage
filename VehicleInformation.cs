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

namespace HoaMage
{
    public partial class VehicleInformation : UserControl
    {
        public VehicleInformation()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxMake.Text))
            {
                MessageBox.Show("Car Make is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxModel.Text))
            {
                MessageBox.Show("Car Model is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxColor.Text))
            {
                MessageBox.Show("Car Color is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxLicencePlate.Text))
            {
                MessageBox.Show("Please enter LicensePlate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "Insert Into VehicleInformation (PlateNumber, Make, Model, Color) values (@PlateNumber, @Make, @Model, @Color)";
            using(OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PlateNumber", tbxLicencePlate.Text);
                        command.Parameters.AddWithValue("@Make", tbxMake.Text);
                        command.Parameters.AddWithValue("@Modle", tbxModel.Text);
                        command.Parameters.AddWithValue("@Color", tbxColor.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected>0)
                        {
                            MessageBox.Show("Vehicle Information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Registration parentForm = (Registration)this.FindForm();
                            if (parentForm != null)
                            {
                                parentForm.MarkCheckbox("VehicleInfo");
                                HomeownerDashBoard dashboard = new HomeownerDashBoard();
                                dashboard.Show();
                                parentForm.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to save Vehicle Information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
        }
    }
}
