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
using System.Reflection;
using static Shared;

namespace HoaMage
{
    public partial class OccupantForm : MaterialForm
    {
        private int occupantID = -1; 
        public int age;
        public string imagePath;

        public OccupantForm()
        {
            InitializeComponent();
            Shared.Set(this);

        }

        public OccupantForm(int id, string name, string gender, int age, DateTime birthday, string imagePath)
        {
            InitializeComponent();
            Shared.Set(this);

            occupantID = id;
            tbxOccupantName.Text = name;
            tbxGender.Text = gender;
            tbxAge.Text = age.ToString();
            dtpBirthday.Value = birthday;

            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                pbxOccupantImage.Image = Shared.LoadImage(imagePath);
                this.imagePath = imagePath;
            }

            btnSave.Text = "Update"; // Change button text to indicate update
        }

        private int GetPropertyID()
        {
            int propertyID = -1;
            string query = "SELECT PropertyID FROM PropertyInformation WHERE AccountID = @AccountID";
            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", Identification.AccountID);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            propertyID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return propertyID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command;

                    if (occupantID == -1)
                    {
                        int propertyID = GetPropertyID();
                        if (propertyID == -1)
                        {
                            MessageBox.Show("No PropertyID found for this account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (string.IsNullOrEmpty(tbxOccupantName.Text) || string.IsNullOrEmpty(tbxGender.Text) || string.IsNullOrEmpty(tbxAge.Text))
                        {
                            MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!int.TryParse(tbxAge.Text, out age) || age < 0)
                        {
                            MessageBox.Show("Age input is invalid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        string insertQuery = "INSERT INTO Occupants (PropertyID, OccupantName, OccupantGender, OccupantAge, OccupantBirthday, OccupantImage) VALUES (?, ?, ?, ?, ?, ?)";
                        command = new OleDbCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("?", propertyID);
                        command.Parameters.AddWithValue("?", tbxOccupantName.Text);
                        command.Parameters.AddWithValue("?", tbxGender.Text);
                        command.Parameters.AddWithValue("?", Convert.ToInt32(tbxAge.Text));
                        command.Parameters.AddWithValue("?", dtpBirthday.Value.ToString("MM/dd/yyyy"));
                        command.Parameters.AddWithValue("?", imagePath);

                    }
                    else
                    {
                        string updateQuery = "UPDATE Occupants SET OccupantName = ?, OccupantGender = ?, OccupantAge = ?, OccupantBirthday = ?, OccupantImage = ? WHERE OccupantID = ?";
                        command = new OleDbCommand(updateQuery, connection);

                        command.Parameters.AddWithValue("?", tbxOccupantName.Text);
                        command.Parameters.AddWithValue("?", tbxGender.Text);
                        command.Parameters.AddWithValue("?", Convert.ToInt32(tbxAge.Text));
                        command.Parameters.AddWithValue("?", dtpBirthday.Value.ToString("MM/dd/yyyy"));
                        command.Parameters.AddWithValue("?", imagePath);
                        command.Parameters.AddWithValue("?", occupantID);


                    }

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(occupantID == -1 ? "Occupant Added Successfully!" : "Occupant Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save occupant data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string selectedImagePath = Shared.uploadImage();
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                imagePath = selectedImagePath;
                pbxOccupantImage.Image = Shared.LoadImage(imagePath);
            }
        }
    }
}
