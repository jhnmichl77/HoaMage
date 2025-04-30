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
            loadViolations();
            loadPayables();
            loadTransactions();
            LoadAnnouncements(flowLayoutPanel2, dgvAnnouncements);
            demographics();
            analyticsRequest();
            loadAccounting();
        }
        private void demographics()
        {
            int Population = 0;
            int Adults = 0;
            int Minors = 0;
            int SeniorCitizens = 0;

            string query = "SELECT BirthDay FROM MemberInformation UNION ALL SELECT OccupantBirthday FROM Occupants";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Population++;

                        DateTime birthDate = reader["BirthDay"] != DBNull.Value ? Convert.ToDateTime(reader["BirthDay"]) : DateTime.MinValue;

                        int age = 0;
                        if (birthDate != DateTime.MinValue)
                        {
                            age = DateTime.Now.Year - birthDate.Year;
                            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                            {
                                age--;
                            }
                        }

                        if (age >= 18 && age < 60)
                        {
                            Adults++;
                        }
                        else if (age < 18)
                        {
                            Minors++;
                        }
                        else if (age >= 60)
                        {
                            SeniorCitizens++;
                        }
                    }
                }
            }

            cntPopul.Text = Population.ToString();
            cntAdult.Text = Adults.ToString();
            cntMinor.Text = Minors.ToString();
            cntSC.Text = SeniorCitizens.ToString();
        }
        private void analyticsRequest()
        {
            int totalRequests = 0;
            int unresolved = 0;
            int resolved = 0;

            string query = "SELECT Status FROM Request";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        totalRequests++;

                        string status = reader["Status"].ToString().Trim().ToLower();

                        if (status == "resolved")
                        {
                            resolved++;
                        }
                        else
                        {
                            unresolved++;
                        }
                    }
                }
            }

            cntRequest.Text = totalRequests.ToString();
            cntSolved.Text = resolved.ToString();
            cntUnresolved.Text = unresolved.ToString();
        }


        public static void LoadAnnouncements(FlowLayoutPanel panel, DataGridView dgv = null)
        {
            panel.Controls.Clear();

            string query = "SELECT ID, Regarding, Context, DayDate FROM Announcements";
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);

                    DataView view = new DataView(table);
                    view.RowFilter = $"DayDate >= #{DateTime.Now.ToString("MM/dd/yyyy")}#";
                    DataTable filteredTable = view.ToTable();

                    if (dgv != null)
                    {
                        dgv.DataSource = null;
                        dgv.DataSource = filteredTable;
                    }

                    foreach (DataRow row in filteredTable.Rows)
                    {
                        string title = row["Regarding"].ToString();
                        DateTime date = Convert.ToDateTime(row["DayDate"]);
                        string context = row["Context"].ToString();

                        announceCard card = new announceCard();
                        card.SetData(title, date, context);
                        panel.Controls.Add(card);
                    }
                }
            }
        }


        private void LoadData()
        {
            if (string.IsNullOrEmpty(currentTable)) return;

            string query = $"SELECT * FROM {currentTable}";
            DataSet ds = DatabaseHelper.ExecuteQuery(query);

            if (ds.Tables.Count > 0)
            {
                dgvDisplay.DataSource = ds.Tables[0];

                if (currentTable == "Accounts" && dgvDisplay.Columns.Contains("Password"))
                {
                    dgvDisplay.Columns["Password"].Visible = false;
                }
                if (currentTable == "VehicleInformation" && dgvDisplay.Columns.Contains("VehicleImage"))
                {
                    dgvDisplay.Columns["VehicleImage"].Visible = false;
                }
                if (currentTable == "Occupants" && dgvDisplay.Columns.Contains("OccupantImage"))
                {
                    dgvDisplay.Columns["OccupantImage"].Visible = false;
                }
                if(currentTable == "MemberInformation" && dgvDisplay.Columns.Contains("MemberProfile"))
                {
                    dgvDisplay.Columns["MemberProfile"].Visible = false;
                }
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
            demographics();

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
            demographics();
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
                viewForm.FormClosed += (s, args) => loadRequest();
                viewForm.Show();
                analyticsRequest();

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

            }
            LoadAnnouncements(flowLayoutPanel1, dgvAnnouncements);

        }
        private void loadTransactions()
        {
            string query = "SELECT PayableID, AccountID, BilledTo, Amount, DateAdded, Status, DatePaid FROM Payables";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                OleDbCommand command = new OleDbCommand(query, connection);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    dgvTransactions.Rows.Clear();

                    while (reader.Read())
                    {
                        string pId = reader["PayableID"].ToString();
                        string accountId = reader["AccountID"].ToString();
                        string billedTo = reader["BilledTo"].ToString();
                        string amount = reader["Amount"].ToString();
                        string dateAdded = reader["DateAdded"].ToString();
                        string status = reader["Status"].ToString();
                        string datePaid = reader["DatePaid"] == DBNull.Value ? "" : reader["DatePaid"].ToString();

                        dgvTransactions.Rows.Add(pId, accountId, billedTo, amount, dateAdded, status, datePaid);
                    }

                    reader.Close();
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
                                LoadAnnouncements(flowLayoutPanel1, dgvAnnouncements);
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
        private void loadAccounting()
        {
            decimal Total = 0;
            decimal Outstanding = 0;
            decimal Expenses = 0;
            decimal Available = 0;

             
            Total = GetTotalCollected();         
            Outstanding = GetOutstandingAmount();  
            Expenses = GetTotalExpenses();        
            Available = Total - Expenses;
             
            cntTotal.Text = "₱" + Total.ToString("N2");          
            cntOutstanding.Text = "₱" + Outstanding.ToString("N2");
            cntExpenses.Text = "₱" + Expenses.ToString("N2");
            cntAvailable.Text = "₱" + Available.ToString("N2");
        }

        private decimal GetTotalCollected()
        {
            decimal totalCollected = 0;

            string query = "SELECT SUM(Amount) FROM Payables WHERE Status = 'Paid'"; 
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                totalCollected = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            return totalCollected;
        }
        private decimal GetOutstandingAmount()
        {
            decimal outstandingAmount = 0;

            string query = "SELECT SUM(Amount) FROM Payables WHERE Status = 'Unpaid'"; 
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                outstandingAmount = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            return outstandingAmount;
        }
        private decimal GetTotalExpenses()
        {
            decimal totalExpenses = 0;

            string query = "SELECT SUM(Amount) FROM Expenses"; 
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                totalExpenses = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            return totalExpenses;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTransactions.SelectedRows[0];
                string paymentID = selectedRow.Cells["PaymentID"].Value.ToString();   

                string query = "UPDATE Payments SET Status = 'Voided' WHERE PaymentID = @PaymentID";
                using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", paymentID);

                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Payment has been voided successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadPayables();  
                        }
                        else
                        {
                            MessageBox.Show("Failed to void the payment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a payment to return.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            using(expenses exp = new expenses())
            {
                exp.ShowDialog();
                loadPayables();
            }
        }
    }
}