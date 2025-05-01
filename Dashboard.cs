using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using System.Net.Mail;
using System.Net;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections.Generic;
using ClosedXML.Excel;

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
            LoadAnnouncements(flowLayoutPanel2, dgvAnnouncements);
            demographics();
            analyticsRequest();
            loadAccounting();
            loadBillables();
            loadPayables();
            LoadViolators();
        }
        private void loadPayables()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
                {
                    conn.Open();
                    string query = "SELECT PayableID, AccountID, FeeName, Amount, DateIssued, Status, DatePaid FROM Payables";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvPayables.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load payables: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (currentTable == "MemberInformation" && dgvDisplay.Columns.Contains("MemberProfile"))
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
                    searchQuery += $"PlateNumber LIKE '%{searchTerm}%' OR Model LIKE '%{searchTerm}%' OR Color LIKE '%{searchTerm}%'";
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
        private void LoadViolators()
        {
            string query = "SELECT * FROM Violators";
            DataTable dt = new DataTable();

            try
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }

                    if (dt.Rows.Count > 0)
                    {
                        dgvViolators.DataSource = dt;
                        if (dgvViolators.Columns.Contains("ID"))
                        {
                            dgvViolators.Columns["ID"].Visible = false;
                        }
                        if (dgvViolators.Columns.Contains("AccountID"))
                        {
                            dgvViolators.Columns["AccountID"].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No violators found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvViolators.DataSource = null;
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error loading violators: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Generate bills for all users now?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string billingMonth = Microsoft.VisualBasic.Interaction.InputBox("What month is this bill for? (e.g., May 2025)", "Billing Month", DateTime.Now.ToString("MMMM yyyy"));
            if (string.IsNullOrWhiteSpace(billingMonth)) return;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
                {
                    conn.Open();

                    // Load fees
                    List<(string FeeName, decimal Amount)> fees = new List<(string, decimal)>();
                    using (OleDbCommand feeCmd = new OleDbCommand("SELECT FeeName, Amount FROM Billables", conn))
                    using (OleDbDataReader feeReader = feeCmd.ExecuteReader())
                    {
                        while (feeReader.Read())
                        {
                            fees.Add((feeReader["FeeName"].ToString(), Convert.ToDecimal(feeReader["Amount"])));
                        }
                    }

                    // Join Accounts and MemberInformation
                    using (OleDbCommand cmd = new OleDbCommand(
                        "SELECT A.AccountID, A.Email, M.FirstName, M.LastName " +
                        "FROM Accounts A INNER JOIN MemberInformation M ON A.AccountID = M.AccountID", conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int accountId = Convert.ToInt32(reader["AccountID"]);
                            string email = reader["Email"].ToString();
                            string fullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();

                            // Check if user owns a car
                            bool hasCar = false;
                            using (OleDbCommand carCmd = new OleDbCommand("SELECT COUNT(*) FROM VehicleInformation WHERE AccountID = ?", conn))
                            {
                                carCmd.Parameters.AddWithValue("?", accountId);
                                hasCar = Convert.ToInt32(carCmd.ExecuteScalar()) > 0;
                            }

                            // Calculate applicable total
                            List<(string FeeName, decimal Amount)> applicableFees = new List<(string, decimal)>();
                            foreach (var fee in fees)
                            {
                                if (fee.FeeName == "Car Sticker" && !hasCar) continue;
                                applicableFees.Add(fee);
                            }

                            decimal totalAmount = applicableFees.Sum(f => f.Amount);
                            string finalFeeName = "Monthly Dues - " + billingMonth;

                            // Insert into Payables
                            using (OleDbCommand insertCmd = new OleDbCommand("INSERT INTO Payables (AccountID, FeeName, Amount, DateIssued, Status, DatePaid) VALUES (?, ?, ?, ?, ?, ?)", conn))
                            {
                                insertCmd.Parameters.AddWithValue("?", accountId);
                                insertCmd.Parameters.AddWithValue("?", finalFeeName);
                                insertCmd.Parameters.AddWithValue("?", totalAmount);
                                insertCmd.Parameters.AddWithValue("?", DateTime.Now.ToShortDateString());
                                insertCmd.Parameters.AddWithValue("?", "Unpaid");
                                insertCmd.Parameters.AddWithValue("?", DBNull.Value);
                                insertCmd.ExecuteNonQuery();
                            }

                            // Send PDF bill
                            SendBillingEmail(accountId, email, fullName, billingMonth, applicableFees, true);
                        }
                    }

                    MessageBox.Show("Bills and emails sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadPayables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadAccounting();
        }

        private void loadAccounting()
        {
            decimal Total = GetTotalCollected();
            decimal Outstanding = GetOutstandingAmount();
            decimal Expenses = GetTotalExpenses();
            decimal Available = Total - Expenses;

            cntTotal.Text = "₱" + Total.ToString("N2");
            cntOutstanding.Text = "₱" + Outstanding.ToString("N2");
            cntExpenses.Text = "₱" + Expenses.ToString("N2");
            cntAvailable.Text = "₱" + Available.ToString("N2");
        }

        private decimal GetTotalCollected()
        {
            decimal totalCollected = 0m;

            string payablesQuery = "SELECT SUM(Amount) FROM Payables WHERE Status = 'Paid'";
            string violatorsQuery = "SELECT SUM(Amount) FROM Violators WHERE Status = 'Paid'";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand())
            {
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = payablesQuery;
                object payablesResult = cmd.ExecuteScalar();
                totalCollected += payablesResult != DBNull.Value ? Convert.ToDecimal(payablesResult) : 0;

                cmd.CommandText = violatorsQuery;
                object violatorsResult = cmd.ExecuteScalar();
                totalCollected += violatorsResult != DBNull.Value ? Convert.ToDecimal(violatorsResult) : 0;
            }

            return totalCollected;
        }


        private decimal GetOutstandingAmount()
        {
            string query = "SELECT SUM(Amount) FROM Payables WHERE Status = 'Unpaid'";
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
            }
        }

        private decimal GetTotalExpenses()
        {
            string query = "SELECT SUM(Amount) FROM Expenses";
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
            }
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            using (expenses exp = new expenses())
            {
                exp.ShowDialog();
            }
            loadAccounting();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            string feeName = Interaction.InputBox("Enter Fee Name:", "New Fee", "").Trim();
            if (string.IsNullOrEmpty(feeName))
            {
                MessageBox.Show("Fee name is required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string amountInput = Interaction.InputBox("Enter Amount:", "New Fee", "0").Trim();
            if (!decimal.TryParse(amountInput, out decimal amount) || amount < 0)
            {
                MessageBox.Show("Please enter a valid, non-negative amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Billables (FeeName, Amount) VALUES (?, ?)";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", feeName);
                cmd.Parameters.AddWithValue("?", amount);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("New fee successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadBillables();
        }
        private void loadBillables()
        {
            string query = "SELECT * FROM Billables";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvFees.DataSource = dt;
            }

            dgvFees.Columns["FeeName"].HeaderText = "Fee Name";
            dgvFees.Columns["Amount"].DefaultCellStyle.Format = "N2";
        }

        private void btnDelFee_Click(object sender, EventArgs e)
        {
            if (dgvFees.CurrentRow == null)
            {
                MessageBox.Show("Please select a fee to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = Convert.ToInt32(dgvFees.CurrentRow.Cells["ID"].Value);
            string selectedFeeName = dgvFees.CurrentRow.Cells["FeeName"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{selectedFeeName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Billables WHERE ID = ?";

                using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", selectedId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Fee successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadBillables();
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (dgvPayables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment to void.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvPayables.SelectedRows[0];
            int payableID = Convert.ToInt32(selectedRow.Cells[0].Value);
            string status = selectedRow.Cells[5].Value.ToString();

            if (status != "Paid")
            {
                MessageBox.Show("Only paid transactions can be voided.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to void this payment?", "Confirm Void", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string query = "UPDATE Payables SET Status = 'Void', DatePaid = NULL WHERE PayableID = ?";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", payableID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Payment has been voided.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadPayables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to void payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadAccounting();
        }
        private const string SmtpServer = "smtp.gmail.com";
        private const int SmtpPort = 587;
        private const string FromEmail = "hoamageoop@gmail.com";
        private const string FromEmailPassword = "azpu tkad zkuj rkkx";
        private const string EmailDisplayName = "HoaMage Billing";
        private const string PdfSavePath = "C:\\Users\\johnm\\source\\repos\\jhnmichl77\\HoaMage\\bin\\Debug\\net8.0-windows";

        private string GeneratePDFBill(int accountId, string accountEmail, string accountName, string billingMonth, List<(string FeeName, decimal Amount)> feeBreakdown, string savePath)
        {
            if (string.IsNullOrEmpty(savePath))
            {
                throw new ArgumentException("savePath cannot be null or empty.", nameof(savePath));
            }

            Directory.CreateDirectory(savePath);

            string pdfPath = Path.Combine(savePath, $"Billing_{accountId}_{billingMonth.Replace(" ", "_")}.pdf");

            using (FileStream fs = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
            using (Document doc = new Document(PageSize.A4))
            using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
            {
                doc.Open();

                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Paragraph title = new Paragraph("Billing Statement", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                doc.Add(new Paragraph($"Billing Statement for {accountName}", headerFont));
                doc.Add(new Paragraph($"Billing Period: {billingMonth}\n\n", headerFont));

                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.DefaultCell.Padding = 5;

                iTextSharp.text.Font headerCellFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                PdfPCell headerCell1 = new PdfPCell(new Phrase("Fee Name", headerCellFont));
                PdfPCell headerCell2 = new PdfPCell(new Phrase("Amount", headerCellFont));
                table.AddCell(headerCell1);
                table.AddCell(headerCell2);
                table.HeaderRows = 1;

                decimal total = 0;
                foreach (var fee in feeBreakdown)
                {
                    table.AddCell(fee.FeeName);
                    table.AddCell("₱" + fee.Amount.ToString("N2"));
                    total += fee.Amount;
                }

                iTextSharp.text.Font totalCellFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                PdfPCell totalCell1 = new PdfPCell(new Phrase("Total", totalCellFont));
                PdfPCell totalCell2 = new PdfPCell(new Phrase("₱" + total.ToString("N2"), totalCellFont));
                table.AddCell(totalCell1);
                table.AddCell(totalCell2);

                doc.Add(table);
                doc.Close();
            }
            return pdfPath;
        }

        private void SendEmailWithAttachment(string toEmail, string subject, string body, string attachmentPath)
        {
            if (string.IsNullOrEmpty(toEmail))
                throw new ArgumentException("toEmail cannot be null or empty.", nameof(toEmail));

            if (string.IsNullOrEmpty(attachmentPath))
                throw new ArgumentException("attachmentPath cannot be null or empty.", nameof(attachmentPath));

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(FromEmail, EmailDisplayName);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.Attachments.Add(new Attachment(attachmentPath));

                using (SmtpClient client = new SmtpClient(SmtpServer, SmtpPort))
                {
                    client.Credentials = new NetworkCredential(FromEmail, FromEmailPassword);
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Send(mail);
                }
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"SMTP Error: {ex.StatusCode}\nMessage: {ex.Message}", "SMTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                throw new Exception("Error accessing attachment: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to send email.\n\nException Type: {ex.GetType().Name}\nMessage: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}",
                    "Email Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        public void SendBillingEmail(int accountId, string accountEmail, string accountName, string billingMonth, List<(string FeeName, decimal Amount)> feeBreakdown, bool sendEmail = true)
        {
            try
            {
                string pdfPath = GeneratePDFBill(accountId, accountEmail, accountName, billingMonth, feeBreakdown, PdfSavePath);

                string subject = $"Your {billingMonth} Billing Statement";
                string body = $"Dear {accountName},\n\nPlease find your billing statement for {billingMonth} attached.\n\nThank you,\nHoaMage";

                if (sendEmail)
                {
                    SendEmailWithAttachment(accountEmail, subject, body, pdfPath);
                    Console.WriteLine($"Billing email sent successfully to {accountEmail} for Account ID {accountId}.");
                }
                else
                {
                    Console.WriteLine($"Billing PDF generated and saved to {pdfPath} for Account ID {accountId}.  Email not sent.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send billing email.  Error details: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPayables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPayables.Rows[e.RowIndex];

                if (selectedRow.Cells["ProofImage"].Value != DBNull.Value && selectedRow.Cells["ProofImage"].Value != null)
                {
                    byte[] imageBytes = (byte[])selectedRow.Cells["ProofImage"].Value;

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        System.Drawing.Image proofImage = System.Drawing.Image.FromStream(ms);

                        viewProof proofForm = new viewProof(proofImage);
                        proofForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No proof of payment attached for this record.", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentTable != "Accounts" || e.RowIndex < 0) return;

            DataGridViewRow row = dgvDisplay.Rows[e.RowIndex];
            int accountId = Convert.ToInt32(row.Cells["AccountID"].Value);

            Form1 editForm = new Form1(accountId);
            editForm.FormClosed += (s, args) => LoadData();
            editForm.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Workbook|*.xlsx";
            saveDialog.FileName = "Hoamage.xlsx";
            ExportToExcelDocument(saveDialog, dgvDisplay);
        }
        private void ExportToExcelDocument(SaveFileDialog saveDialog, DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Sheet");

                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
                            worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                            worksheet.Cell(1, col + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                        }

                        for (int row = 0; row < dgv.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgv.Columns.Count; col++)
                            {
                                worksheet.Cell(row + 2, col + 1).Value = dgv.Rows[row].Cells[col].Value?.ToString();
                            }
                        }

                        worksheet.Columns().AdjustToContents();

                        workbook.SaveAs(saveDialog.FileName);
                    }

                    MessageBox.Show("Excel file created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Workbook|*.xlsx";
            saveDialog.FileName = "Request.xlsx";
            ExportToExcelDocument(saveDialog, dgvRequest);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Workbook|*.xlsx";
            saveDialog.FileName = "Rules.xlsx";
            ExportToExcelDocument(saveDialog, dgvViolations);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Workbook|*.xlsx";
            saveDialog.FileName = "Violators.xlsx";
            ExportToExcelDocument(saveDialog, dgvViolators);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Workbook|*.xlsx";
            saveDialog.FileName = "Payables.xlsx";
            ExportToExcelDocument(saveDialog, dgvPayables);
        }
    }
}
