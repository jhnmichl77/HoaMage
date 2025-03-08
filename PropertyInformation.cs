using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace HoaMage
{
    public partial class PropertyInformation : UserControl
    {
        public PropertyInformation()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int numOfOccupants;

            if (string.IsNullOrWhiteSpace(tbxResidenceName.Text))
            {
                MessageBox.Show("Please enter a residence name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxHomeAddress.Text))
            {
                MessageBox.Show("Please enter a home address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxUnitNumber.Text))
            {
                MessageBox.Show("Please enter a unit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(tbxNumOfOccupants.Text, out numOfOccupants))
            {
                MessageBox.Show("Please enter a valid number of occupants.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbxType.Text))
            {
                MessageBox.Show("Ownership type not specified.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "Insert Into PropertyInformation (ResidenceName, HomeAddress, UnitNumber, NumOfOccupants, OwnershipType) values (@ResidenceName, @HomeAddress, @UnitNumber, @NumOfOccupants, @OwnershipType)";
            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            try
            {
                
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ResidenceName", tbxResidenceName.Text);
                    command.Parameters.AddWithValue("@HomeAddress", tbxHomeAddress.Text);
                    command.Parameters.AddWithValue("@UnitNumber", tbxUnitNumber.Text);

                    command.Parameters.AddWithValue("@NumOfOccupants", Convert.ToInt32(tbxNumOfOccupants.Text));
                    command.Parameters.AddWithValue("@OwnershipType", cbxType.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Property Information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to save Proper Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            Registration parentForm = (Registration)this.FindForm();
            if (parentForm != null)
            {
                parentForm.MarkCheckbox("PropertyInformation");
                Shared.ShowUserControl(new VehicleInformation(), this.Parent);
            }
        }
    }
}
