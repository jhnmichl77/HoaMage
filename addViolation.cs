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
    public partial class addViolation : MaterialForm
    {
        public addViolation()
        {
            InitializeComponent();
            Shared.Set(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(tbxRuleName.Text) ||
                string.IsNullOrWhiteSpace(tbxDescription.Text) ||
                string.IsNullOrWhiteSpace(tbxPenalty.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal penalty;
            if (!decimal.TryParse(tbxPenalty.Text, out penalty))
            {
                MessageBox.Show("Invalid input. Please enter a valid amount.");
                tbxPenalty.Clear();
                return;
            }

            string query = "INSERT INTO Violations (RuleName, Description, Penalty) VALUES (?, ?, ?)";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("?", tbxRuleName.Text);
                        command.Parameters.AddWithValue("?", tbxDescription.Text);
                        command.Parameters.AddWithValue("?", tbxPenalty.Text);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Violation saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxRuleName.Clear();
                            tbxDescription.Clear();
                            tbxPenalty.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No data was inserted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
