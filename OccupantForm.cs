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
            public OccupantForm()
            {
                InitializeComponent();
                Shared.Set(this);

            }
            public int age;
            public string imagePath;

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
                        command.Parameters.AddWithValue("@AccountID", Identification.AccountID); // Replace with actual username

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
            int propertyID = GetPropertyID();
            if (propertyID == -1)
            {
                MessageBox.Show("No PropertyID found for this account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbxOccupantName.Text))
            {
                MessageBox.Show("Occupant Name is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tbxGender.Text))
            {
                MessageBox.Show("Occupant Gender is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(tbxAge.Text, out age) || age < 0)
            {
                MessageBox.Show("Age input is invalid!.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tbxAge.Text))
            {
                MessageBox.Show("Occupant Age is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            
            string query = "Insert Into Occupants (PropertyID, OccupantName, OccupantGender, OccupantAge, OccupantBirthday,OccupantImage) values (@PropertyID, @OccupantName, @OccupantGender, @OccupantAge, @OccupantBirthday, @OccupantImage)";
            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PropertyID", propertyID);     
                        command.Parameters.AddWithValue("@OccupantName", tbxOccupantName.Text);
                        command.Parameters.AddWithValue("@OccupantGender", tbxGender.Text);
                        command.Parameters.AddWithValue("@OccupantAge", Convert.ToInt32(tbxAge.Text));
                        DateTime selectedBirthday = dtpBirthday.Value;
                        command.Parameters.AddWithValue("@OccupantBirthday", dtpBirthday.Value.ToString("MM/dd/yyyy"));
                        command.Parameters.AddWithValue("@OccupantImage", imagePath);
                        command.ExecuteNonQuery();
                        


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            MessageBox.Show("Occupant Added Succesfully!.", "Success", MessageBoxButtons.OK);
            this.Hide();
        }
            private void label1_Click(object sender, EventArgs e)
            {
                OpenFileDialog openFile = new OpenFileDialog { Title = "Select an Image",
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"};

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFile.FileName;  
                    pbxOccupantImage.Image = Image.FromFile(imagePath);  
                
                }       

            }
        }
    }
