using System;
using System.Data;
using System.Data.OleDb;
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
            loadRequest();
            loadAnnouncements();
            loadViolations();
            loadPayables();
            loadTransactions();
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
        private void loadRequest()
        {
            string query = "SELECT * FROM Request";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                connection.Open();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRequest.DataSource = dt;
                }
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
            currentTable = "Occupants";
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
                case "Occupants":
                    searchQuery += $"OccupantName LIKE '%{searchTerm}%' OR PropertyID LIKE '%{searchTerm}%'";
                    break;
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

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvRequest.CurrentRow != null)
            {

                string type = dgvRequest.CurrentRow.Cells[2].Value.ToString();
                string subject = dgvRequest.CurrentRow.Cells[3].Value.ToString();
                string context = dgvRequest.CurrentRow.Cells[4].Value.ToString();
                string status = dgvRequest.CurrentRow.Cells[5].Value.ToString();
                string dateSubmitted = dgvRequest.CurrentRow.Cells[6].Value.ToString();

                viewRequest viewForm = new viewRequest(type, subject, context, status, dateSubmitted);
                viewForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a request to view.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            using (createAnnouncement announcement = new createAnnouncement())
            {
                announcement.ShowDialog();
                loadAnnouncements();
            }

        }
        private void loadTransactions()
        {
            string query = "SELECT * FROM Payables"; 

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);

                DataSet dataSet = new DataSet();

                try
                {
                    dataAdapter.Fill(dataSet, "Payables");

                    dgvPayables.Rows.Clear();
                    dgvPayables.Columns.Clear();

                    dgvPayables.DataSource = dataSet.Tables["Payables"];

                    foreach (DataGridViewColumn column in dgvPayables.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void loadPayables()
        {
            string query = "SELECT PayableID, BilledTo, Description, Amount, DateAdded, Status FROM Payables";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable payablesTable = new DataTable();
                        adapter.Fill(payablesTable);  

                        dgvPayables.Rows.Clear();  

                        foreach (DataRow row in payablesTable.Rows)
                        {
                            dgvPayables.Rows.Add(
                                row["PayableID"].ToString(),
                                row["BilledTo"].ToString(),
                                row["Description"].ToString(),
                                row["Amount"].ToString(),
                                row["DateAdded"].ToString(),
                                row["Status"].ToString()
                            );
                        }
                    }
                }
            }
        }

        private void loadAnnouncements()
        {
            dgvAnnouncements.Rows.Clear();
            string query = "SELECT ID, Regarding, Context, DayDate FROM Announcements";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["ID"].ToString();
                            string regarding = reader["Regarding"].ToString();
                            string context = reader["Context"].ToString();
                            DateTime date = Convert.ToDateTime(reader["DayDate"]);
                            dgvAnnouncements.Rows.Add(id, regarding, context, date);
                        }
                    }
                }
            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (dgvAnnouncements.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an announcement to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedID = Convert.ToInt32(dgvAnnouncements.SelectedRows[0].Cells[0].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete the selected announcement?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string query = "DELETE FROM Announcements WHERE ID = @ID";

                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", selectedID);

                        try
                        {
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Announcement deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadAnnouncements();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the selected announcement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void loadViolations()
        {
            dgvViolations.Rows.Clear();
            string query = "SELECT * FROM Violations";
            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ruleid = reader["ID"].ToString();
                            string rulename = reader["RuleName"].ToString();
                            string description = reader["Description"].ToString();
                            string penalty = reader["Penalty"].ToString();
                            dgvViolations.Rows.Add(ruleid, rulename, description, penalty);
                        }
                    }
                }
            }
        }

        private void btnNewViolation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (addViolation newViolation = new addViolation())
            {
                newViolation.ShowDialog();
                loadViolations();
            }
        }

        private void btnDeleteViolation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvViolations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a violation to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int violationID = Convert.ToInt32(dgvViolations.SelectedRows[0].Cells[0].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this violation?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string query = "DELETE FROM Violations WHERE ID = @ID";

                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", violationID);

                        try
                        {
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Violation deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadViolations();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the violation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        

        private void btnIssue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Citation cite = new Citation())
            {
                cite.ShowDialog();
                loadPayables();
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            using (Bill bill = new Bill())
            {
                bill.ShowDialog();
                loadPayables();
            }
        }
        

        private void btnDelBill_Click(object sender, EventArgs e)
        {
            if (dgvPayables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bill to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int billID = Convert.ToInt32(dgvPayables.SelectedRows[0].Cells[0].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this bill?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string query = "DELETE FROM Payables WHERE PayableID = @ID";

                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", billID);

                        try
                        {
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Bill deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadPayables();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the bill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
