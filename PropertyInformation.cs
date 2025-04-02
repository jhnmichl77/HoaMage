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
            if (string.IsNullOrWhiteSpace(tbxBlockNumber.Text))
            {
                MessageBox.Show("Please enter a block number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxUnitNumber.Text))
            {
                MessageBox.Show("Please enter a unit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(tbxNumOfOccupants.Text, out int numOfOccupants))
            {
                MessageBox.Show("Please enter a valid number of occupants.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbxType.Text))
            {
                MessageBox.Show("Ownership type not specified.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
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
                    
                    string query = "Insert Into PropertyInformation (AccountID, ResidenceName, HomeAddress, BlockNumber, UnitNumber, NumOfOccupants, OwnershipType) values (@AccountID, @ResidenceName, @HomeAddress, @BlockNumber, @UnitNumber, @NumOfOccupants, @OwnershipType)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("AccountID", AccountID);
                        command.Parameters.AddWithValue("@ResidenceName", tbxResidenceName.Text);
                        command.Parameters.AddWithValue("@HomeAddress", tbxHomeAddress.Text);
                        command.Parameters.AddWithValue("@BlockNumber", tbxBlockNumber.Text);
                        command.Parameters.AddWithValue("@UnitNumber", tbxUnitNumber.Text);
                        command.Parameters.AddWithValue("@NumOfOccupants", Convert.ToInt32(tbxNumOfOccupants.Text));
                        command.Parameters.AddWithValue("@OwnershipType", cbxType.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Property Information successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Registration parentForm = (Registration)this.FindForm();
                        if (parentForm != null)
                        {
                            parentForm.MarkCheckbox("PropertyInformation");
                            Shared.ShowUserControl(new VehicleInformation(), this.Parent);
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            
        }
    }
}
