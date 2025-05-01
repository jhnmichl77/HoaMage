using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace HoaMage
{
    public partial class Form1 : MaterialForm
    {
        private int accountId;
        public Form1(int id)
        {
            InitializeComponent();
            Shared.Set(this);
            accountId = id;
            loadAccount();

        }
        private void loadAccount()
        {
            LoadMemberInformation();
            loadPropertyInformation();
            loadVehicleInformation();
        }
        private void LoadMemberInformation()
        {
            string query = "SELECT * FROM MemberInformation WHERE AccountID = ?";
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", accountId);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbxFirstname.Text = reader["FirstName"].ToString();
                            tbxLastname.Text = reader["LastName"].ToString();
                            tbxMI.Text = reader["MiddleInitial"].ToString();
                            dtpBirthdate.Value = Convert.ToDateTime(reader["Birthday"]);
                            tbxContactNum.Text = reader["ContactNumber"].ToString();
                            string imagePath = reader["MemberProfile"].ToString();
                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                            {
                                pbxMemberImg.Image = Image.FromFile(imagePath);
                            }
                            else
                            {
                                pbxMemberImg.Image = null;
                            }
                        }
                    }
                }
            }


        }
        private void loadPropertyInformation()
        {
            string query = "SELECT * FROM PropertyInformation WHERE AccountID = ?";
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", accountId);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbxResidence.Text = reader["ResidenceName"].ToString();
                            tbxAddress.Text = reader["HomeAddress"].ToString();
                            tbxBlock.Text = reader["BlockNumber"].ToString();
                            tbxUnit.Text = reader["UnitNumber"].ToString();
                            tbxNumOccupant.Text = reader["NumOfOccupants"].ToString();
                            cbxOwnership.Text = reader["OwnershipType"].ToString();
                        }
                    }
                }
            }
        }
        private void loadVehicleInformation()
        {
            string query = "SELECT * FROM VehicleInformation WHERE AccountID = ?";
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", accountId);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbxPlateNumber.Text = reader["PlateNumber"].ToString();
                            tbxMake.Text = reader["Make"].ToString();
                            tbxModel.Text = reader["Model"].ToString();
                            tbxColor.Text = reader["Color"].ToString();
                            string imagePath = reader["VehicleImage"].ToString();
                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                            {
                                pbxVehicleImg.Image = Image.FromFile(imagePath);
                            }
                            else
                            {
                                pbxVehicleImg.Image = null;
                            }
                        }
                    }
                }
            }
        }
        private void UpdateMemberInformation()
        {
            string query = @"UPDATE MemberInformation SET 
                        FirstName = ?, 
                        LastName = ?, 
                        MiddleInitial = ?, 
                        Birthday = ?, 
                        ContactNumber = ?, 
                        MemberProfile = ?
                     WHERE AccountID = ?";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", tbxFirstname.Text);
                    cmd.Parameters.AddWithValue("?", tbxLastname.Text);
                    cmd.Parameters.AddWithValue("?", tbxMI.Text);
                    cmd.Parameters.AddWithValue("?", Convert.ToDateTime(dtpBirthdate.Value));
                    cmd.Parameters.AddWithValue("?", tbxContactNum.Text);

                    string memberImagePath = pbxMemberImg.ImageLocation;
                    cmd.Parameters.AddWithValue("?", !string.IsNullOrEmpty(memberImagePath) && File.Exists(memberImagePath) ? memberImagePath : DBNull.Value);

                    cmd.Parameters.AddWithValue("?", accountId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void UpdatePropertyInformation()
        {
            string query = @"UPDATE PropertyInformation SET 
                        ResidenceName = ?, 
                        HomeAddress = ?, 
                        BlockNumber = ?, 
                        UnitNumber = ?, 
                        NumOfOccupants = ?, 
                        OwnershipType = ?
                     WHERE AccountID = ?";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", tbxResidence.Text);
                    cmd.Parameters.AddWithValue("?", tbxAddress.Text);
                    cmd.Parameters.AddWithValue("?", tbxBlock.Text);
                    cmd.Parameters.AddWithValue("?", tbxUnit.Text);
                    cmd.Parameters.AddWithValue("?", tbxNumOccupant.Text);
                    cmd.Parameters.AddWithValue("?", cbxOwnership.Text);
                    cmd.Parameters.AddWithValue("?", accountId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void UpdateVehicleInformation()
        {
            string query = @"UPDATE VehicleInformation SET 
                        PlateNumber = ?, 
                        Make = ?, 
                        Model = ?, 
                        Color = ?, 
                        VehicleImage = ?
                     WHERE AccountID = ?";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", tbxPlateNumber.Text);
                    cmd.Parameters.AddWithValue("?", tbxMake.Text);
                    cmd.Parameters.AddWithValue("?", tbxModel.Text);
                    cmd.Parameters.AddWithValue("?", tbxColor.Text);

                    string vehicleImagePath = pbxVehicleImg.ImageLocation;
                    cmd.Parameters.AddWithValue("?", !string.IsNullOrEmpty(vehicleImagePath) && File.Exists(vehicleImagePath) ? vehicleImagePath : DBNull.Value);

                    cmd.Parameters.AddWithValue("?", accountId);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Member Profile Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbxMemberImg.Image = Image.FromFile(ofd.FileName);
                    pbxMemberImg.ImageLocation = ofd.FileName;
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Vehicle Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbxVehicleImg.Image = Image.FromFile(ofd.FileName);
                    pbxVehicleImg.ImageLocation = ofd.FileName;
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMemberInformation();
            UpdatePropertyInformation();
            UpdateVehicleInformation();
            MessageBox.Show("Information updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
