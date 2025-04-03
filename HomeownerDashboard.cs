using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.OleDb;
namespace HoaMage
{
    public partial class HomeownerDashboard : MaterialForm
    {
        private int currentAccountId = Shared.Identification.AccountID;
        private int currentPropertyId = Shared.Identification.PropertyID;
        public HomeownerDashboard()
        {
            InitializeComponent();
            Shared.Set(this);
            InitializeDgvOccupants();
            loadMemberInformation();
            loadPropertyInformation();
            loadVehicleInformation();
            loadOccupants();
        }
        private void loadMemberInformation()
        {
            string query = "SELECT FirstName, LastName, MiddleInitial, Birthday, Gender, ContactNumber, MemberProfile FROM MemberInformation WHERE AccountID = @AccountID";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", currentAccountId);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tbxFirstname.Text = reader["FirstName"].ToString();
                                tbxLastname.Text = reader["LastName"].ToString();
                                tbxMiddleInitial.Text = reader["MiddleInitial"].ToString();
                                dtpBirthdate.Value = Convert.ToDateTime(reader["Birthday"]);
                                tbxGender.Text = reader["Gender"].ToString();
                                tbxContactNumber.Text = reader["ContactNumber"].ToString();
                                string imagePath = reader["MemberProfile"].ToString();
                                if (!string.IsNullOrEmpty(imagePath))
                                {
                                    pbxMemberProfile.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    pbxMemberProfile.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given AccountID.");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message);
                }
            }
        }
        private void loadPropertyInformation()
        {
            string query = "Select ResidenceName, HomeAddress, BlockNumber, UnitNumber, NumOfOccupants, OwnershipType from PropertyInformation where AccountID = @AccountID";
            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", currentAccountId);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tbxResidence.Text = reader["ResidenceName"].ToString();
                                tbxAddress.Text = reader["HomeAddress"].ToString();
                                tbxBlockNumber.Text = reader["BlockNumber"].ToString();
                                tbxUnitNumber.Text = reader["UnitNumber"].ToString();
                                tbxOccupantNum.Text = reader["NumOfOccupants"].ToString();
                                cbxOwnership.Text = reader["OwnershipType"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given AccountID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message);
                }
            }
        }
        private Dictionary<string, Image> occupantImages = new Dictionary<string, Image>();
        private void loadVehicleInformation()
        {
            string query = "SELECT PlateNumber, Make, Model, Color, VehicleImage FROM VehicleInformation WHERE AccountID = @AccountID";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", currentAccountId);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {


                            while (reader.Read())
                            {
                                tbxPlateNumber.Text = reader["PlateNumber"].ToString();
                                tbxMake.Text = reader["Make"].ToString();
                                tbxModel.Text = reader["Model"].ToString();
                                tbxColor.Text = reader["Color"].ToString();
                                string imagePath = reader["VehicleImage"].ToString();
                                if (!string.IsNullOrEmpty(imagePath))
                                {
                                    pbxVehicleImage.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    pbxVehicleImage.Image = null;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading vehicle data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InitializeDgvOccupants()
        {
            dgvOccupants.Columns.Clear();

            dgvOccupants.ColumnCount = 5;
            dgvOccupants.Columns[0].Name = "ID";
            dgvOccupants.Columns[1].Name = "Name";
            dgvOccupants.Columns[2].Name = "Gender";
            dgvOccupants.Columns[3].Name = "Age";
            dgvOccupants.Columns[4].Name = "Birthday";

            DataGridViewTextBoxColumn imagePathColumn = new DataGridViewTextBoxColumn();
            imagePathColumn.Name = "ImagePath";
            imagePathColumn.HeaderText = "Image Path";
            imagePathColumn.Visible = false; // Hide the column
            dgvOccupants.Columns.Add(imagePathColumn);
        }

        private void loadOccupants()
        {
            string query = "SELECT OccupantID, OccupantName, OccupantGender, OccupantAge, OccupantBirthday, OccupantImage FROM Occupants WHERE PropertyID = @PropertyID";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PropertyID", currentPropertyId);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            dgvOccupants.Rows.Clear(); // Clear previous data

                            while (reader.Read())
                            {
                                string occupantID = reader["OccupantID"].ToString();
                                string imagePath = reader["OccupantImage"].ToString();

                                dgvOccupants.Rows.Add(
                                    occupantID,
                                    reader["OccupantName"].ToString(),
                                    reader["OccupantGender"].ToString(),
                                    reader["OccupantAge"].ToString(),
                                    Convert.ToDateTime(reader["OccupantBirthday"]).ToString("MM/dd/yyyy"),
                                    imagePath // Store path in the hidden column
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvOccupants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string imagePath;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOccupants.Rows[e.RowIndex];

                lblName.Text = row.Cells["Name"].Value.ToString();
                lblGender.Text = row.Cells["Gender"].Value.ToString();
                lblBirthday.Text = row.Cells["Birthday"].Value.ToString();
                lblAge.Text = row.Cells["Age"].Value.ToString();
                imagePath = row.Cells["ImagePath"].Value.ToString();

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pbxOccupantImage.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pbxOccupantImage.Image = null;
                }
            }
        }


        private void btnAddOccupant_Click(object sender, EventArgs e)
        {
            OccupantForm occupantForm = new OccupantForm();
            if (occupantForm.ShowDialog() == DialogResult.OK)  
            {
                loadOccupants();  
            }
        }

        private void btnMemberEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMemberEdit.Checked)
            {
                tbxFirstname.Enabled = true;
                tbxLastname.Enabled = true;
                tbxMiddleInitial.Enabled = true;
                dtpBirthdate.Enabled = true;
                tbxGender.Enabled = true;
                tbxContactNumber.Enabled = true;
            }
            else
            {
                tbxFirstname.Enabled = false;
                tbxLastname.Enabled = false;
                tbxMiddleInitial.Enabled = false;
                dtpBirthdate.Enabled = false;
                tbxGender.Enabled = false;
                tbxContactNumber.Enabled = false;
            }
        }

        private void btnPropertyEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPropertyEdit.Checked)
            {
                tbxResidence.Enabled = true;
                tbxAddress.Enabled = true;
                tbxBlockNumber.Enabled = true;
                tbxUnitNumber.Enabled = true;
                tbxOccupantNum.Enabled = true;
                cbxOwnership.Enabled = true;
            }
            else
            {
                tbxResidence.Enabled = false;
                tbxAddress.Enabled = false;
                tbxBlockNumber.Enabled = false;
                tbxUnitNumber.Enabled = false;
                tbxOccupantNum.Enabled = false;
                cbxOwnership.Enabled = false;
            }
        }

        private void btnVehicleEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (btnVehicleEdit.Checked)
            {
                tbxMake.Enabled = true;
                tbxModel.Enabled = true;
                tbxPlateNumber.Enabled = true;
                tbxColor.Enabled = true;
            }
            else
            {
                tbxMake.Enabled = false;
                tbxModel.Enabled = false;
                tbxPlateNumber.Enabled = false;
                tbxColor.Enabled = false;
            }
        }

        private void btnDeleteOccupant_Click(object sender, EventArgs e)
        {
            if (dgvOccupants.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvOccupants.SelectedRows[0];
                string occupantID = selectedRow.Cells["ID"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this occupant?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Occupants WHERE OccupantID = @OccupantID";

                    using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
                    {
                        try
                        {
                            connection.Open();
                            using (OleDbCommand command = new OleDbCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@OccupantID", occupantID);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    dgvOccupants.Rows.Remove(selectedRow);
                                    MessageBox.Show("Occupant deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error: Unable to delete occupant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Please select an occupant to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditOccupant_Click(object sender, EventArgs e)
        {
            if (dgvOccupants.SelectedRows.Count > 0)
            {
                // Get selected occupant details
                DataGridViewRow selectedRow = dgvOccupants.SelectedRows[0];
                int occupantID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                int age = Convert.ToInt32(selectedRow.Cells["Age"].Value);
                DateTime birthday = Convert.ToDateTime(selectedRow.Cells["Birthday"].Value);
                string imagePath = selectedRow.Cells["ImagePath"].Value.ToString();

                // Open OccupantForm for editing, passing occupant details
                OccupantForm occupantForm = new OccupantForm(occupantID, name, gender, age, birthday, imagePath);
                if (occupantForm.ShowDialog() == DialogResult.OK)
                {
                    loadOccupants(); // Refresh the occupants list after editing
                }
            }
            else
            {
                MessageBox.Show("Please select an occupant to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
