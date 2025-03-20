using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace HoaMage
{
    public partial class Dashboard : MaterialForm
    {
        private string currentTable = "";
        public Dashboard()
        {
            InitializeComponent();
            Shared.Set(this);
        }

        private void LoadData()
        {
            if (string.IsNullOrEmpty(currentTable)) return;

            string query = $"SELECT * FROM {currentTable}";
            DataSet ds = DatabaseHelper.ExecuteQuery(query);

            if (ds.Tables.Count > 0)
            {
                dgvDisplay.DataSource = ds.Tables[0];
            }
            else
            {
                dgvDisplay.DataSource = null;
            }
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            currentTable = "MemberInformation";
            LoadData();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            currentTable = "PropertyInformation";
            LoadData();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            currentTable = "VehicleInformation";
            LoadData();
        }

        private void btnOccupants_Click(object sender, EventArgs e)
        {
            currentTable = "OccupantInformation";
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            register.IsFromDashboard = true;
            register.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTable))
            {
                MessageBox.Show("Please select a table first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxSearch.Text))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            string searchTerm = tbxSearch.Text.Trim();
            string searchQuery = $"SELECT * FROM {currentTable} WHERE ";

            switch (currentTable)
            {
                case "Accounts":
                    searchQuery += $"Username LIKE '%{searchTerm}%' OR Role LIKE '%{searchTerm}%'";
                    break;
                case "MemberInformation":
                    searchQuery += $"FirstName LIKE '%{searchTerm}%' OR LastName LIKE '%{searchTerm}%'";
                    break;
                case "PropertyInformation":
                    searchQuery += $"HomeAddress LIKE '%{searchTerm}%' OR ResidenceName LIKE '%{searchTerm}%'";
                    break;
                case "VehicleInformation":
                    searchQuery += $"PlateNumber LIKE '%{searchTerm}%' OR Model LIKE '%{searchTerm}%'";
                    break;
                //case "OccupantInformation":
                //searchQuery += $"FullName LIKE '%{searchTerm}%' OR PropertyID LIKE '%{searchTerm}%'";
                //break;
                default:
                    MessageBox.Show("Invalid table selection.");
                    return;
            }

            DataSet ds = DatabaseHelper.ExecuteQuery(searchQuery);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dgvDisplay.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No matching records found.");
                dgvDisplay.DataSource = null;
            }
            tbxSearch.Clear();
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTable))
            {
                MessageBox.Show("Please select a table first.");
                return;
            }

            if (dgvDisplay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvDisplay.SelectedRows[0].Cells[0].Value);
            string deleteQuery = $"DELETE FROM {currentTable} WHERE AccountID = {id}";

            if (DatabaseHelper.ExecuteNonQuery(deleteQuery) > 0)
            {
                MessageBox.Show("Record deleted successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to delete record.");
            }
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            currentTable = "Accounts";
            LoadData();
        }

        private void btnEdit_CheckedChanged(object sender, EventArgs e)
        {
            bool enableEditing = true;
            if (enableEditing)
            {
                dgvDisplay.ReadOnly = false;
            }
            else
            {
                dgvDisplay.ReadOnly = true;

            }
        }
        private void dgvDisplay_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {//edit unfinished
            if (string.IsNullOrEmpty(currentTable))
            {
                return;
            }

            DataGridViewRow row = dgvDisplay.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells[0].Value);

            string columnName = dgvDisplay.Columns[e.ColumnIndex].Name;
            string newValue = row.Cells[e.ColumnIndex].Value.ToString();

            string updateQuery = $"UPDATE {currentTable} SET {columnName} = '{newValue}' WHERE AccountID = {id}";

            if (DatabaseHelper.ExecuteNonQuery(updateQuery) > 0)
            {
                MessageBox.Show("Record updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update record.");
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
