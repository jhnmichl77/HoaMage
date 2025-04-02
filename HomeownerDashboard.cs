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
            MessageBox.Show(currentPropertyId.ToString());
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
            string query = "Select PlateNumber, Make, Model, Color, VehicleImage from VehicleInformation where AccountID = @AccountID";

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
                            dgvOccupants.Rows.Clear();

                            while (reader.Read())
                    {
                        string occupantID = reader["OccupantID"].ToString();
                        string imagePath = reader["OccupantImage"].ToString();
                        Image occupantImage = null;

                        if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                        {
                            occupantImage = Image.FromFile(imagePath);
                            occupantImages[occupantID] = occupantImage; // Store image using ID
                        }

                        dgvOccupants.Rows.Add(
                            occupantID,
                            reader["OccupantName"].ToString(),
                            reader["OccupantGender"].ToString(),
                            reader["OccupantAge"].ToString(),
                            Convert.ToDateTime(reader["OccupantBirthday"]).ToString("MM/dd/yyyy")
                        );
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
        private void InitializeDgvOccupants()
        {
            dgvOccupants.Columns.Clear();

            dgvOccupants.ColumnCount = 5;
            dgvOccupants.Columns[0].Name = "ID";
            dgvOccupants.Columns[1].Name = "Name";
            dgvOccupants.Columns[2].Name = "Gender";
            dgvOccupants.Columns[3].Name = "Age";
            dgvOccupants.Columns[4].Name = "Birthday";
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
                            dgvOccupants.Rows.Clear();  
                            while (reader.Read())
                            {
                                dgvOccupants.Rows.Add(
                                    reader["OccupantID"].ToString(),
                                    reader["OccupantName"].ToString(),
                                    reader["OccupantGender"].ToString(),
                                    reader["OccupantAge"].ToString(),
                                    Convert.ToDateTime(reader["OccupantBirthday"]).ToString("MM/dd/yyyy"),
                                    reader["OccupantImage"].ToString()
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
            // Ensure the row index is valid (avoid header row clicks)
            dgvOccupants.Columns.Clear();

            dgvOccupants.ColumnCount = 5;
            dgvOccupants.Columns[0].Name = "ID";
            dgvOccupants.Columns[1].Name = "Name";
            dgvOccupants.Columns[2].Name = "Gender";
            dgvOccupants.Columns[3].Name = "Age";
            dgvOccupants.Columns[4].Name = "Birthday";

            // Add an image column but do not store the path
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "OccupantImage";
            imgColumn.HeaderText = "Photo";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvOccupants.Columns.Add(imgColumn);
        }

        private void btnAddOccupant_Click(object sender, EventArgs e)
        {
            OccupantForm occupantForm = new OccupantForm();
            occupantForm.Show();
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
    }
}
