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
        string imagePath;
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (cbxNoVehicle.Checked)
            {
                MessageBox.Show("Registration Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Registration parentForm = (Registration)this.FindForm();
                if (parentForm != null)
                {
                    parentForm.MarkCheckbox("VehicleInfo");

                    if (!parentForm.IsFromDashboard)
                    {
                        Login login = new Login();
                        login.Show();
                    }
                    parentForm.Close();
                }
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    int AccountID;
                    using (OleDbCommand cmd = new OleDbCommand("SELECT MAX(AccountID) FROM Accounts", connection))
                    {
                        object result = cmd.ExecuteScalar();
                        AccountID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                    if (AccountID == 0)
                    {
                        MessageBox.Show("No valid AccountID found. Please register an account first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "INSERT INTO VehicleInformation (AccountID, PlateNumber, Make, Model, Color, VehicleImage) VALUES (@AccountID, @PlateNumber, @Make, @Model, @Color, @VehicleImage)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", AccountID);
                        command.Parameters.AddWithValue("@PlateNumber", tbxLicencePlate.Text);
                        command.Parameters.AddWithValue("@Make", tbxMake.Text);
                        command.Parameters.AddWithValue("@Model", tbxModel.Text);
                        command.Parameters.AddWithValue("@Color", tbxColor.Text);
                        command.Parameters.AddWithValue("@VehicleImage", imagePath);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Registration parentForm = (Registration)this.FindForm();
                        if (parentForm != null)
                        {
                            parentForm.MarkCheckbox("VehicleInfo");

                            if (!parentForm.IsFromDashboard)
                            {
                                Login login = new Login();
                                login.Show();
                            }
                            parentForm.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string selectedImagePath = Shared.uploadImage();

            if (cbxNoVehicle.Checked)
            {
                imagePath = null;
                pbxVehicleImage.Image = null;
                return;
            }

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                imagePath = selectedImagePath;
                pbxVehicleImage.Image = Shared.LoadImage(imagePath);

            }
        }
    }
}
