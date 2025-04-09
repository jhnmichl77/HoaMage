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
    public partial class Citation : MaterialForm
    {
        public Citation()
        {
            InitializeComponent();
            Shared.Set(this);
            loadRules();
            loadAccounts();
        }
        Dictionary<string, string> rulePenalty = new Dictionary<string, string>();
        Dictionary<string, string> violator = new Dictionary<string, string>();
        private void loadAccounts()
        {
            cbxViolator.Items.Clear();
            violator.Clear();
            string query = "Select AccountID, FirstName, LastName From MemberInformation";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            string fullName = $"{firstName} {lastName}";
                            string accId = reader["AccountID"].ToString();

                            cbxViolator.Items.Add(accId);
                            if (!violator.ContainsKey(accId))
                            {
                                violator.Add(accId, fullName);
                            }
                        }
                    }
                }
            }
            if (cbxViolator.Items.Count > 0)
            {
                cbxViolator.SelectedIndex = 0;
            }
        }
        private void loadRules()
        {
            cbxRuleViolated.Items.Clear();
            rulePenalty.Clear();

            string query = "Select RuleName, Penalty From Violations";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ruleName = reader["RuleName"].ToString();
                            string penalty = reader["Penalty"].ToString();

                            cbxRuleViolated.Items.Add(ruleName);
                            if (!rulePenalty.ContainsKey(ruleName))
                            {
                                rulePenalty.Add(ruleName, penalty);
                            }
                        }
                    }
                }
            }
            if (cbxRuleViolated.Items.Count > 0)
            {
                cbxRuleViolated.SelectedIndex = 0;
            }
        }

        private void cbxRuleViolated_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ruleSelected = cbxRuleViolated.SelectedItem.ToString();

            if (rulePenalty.ContainsKey(ruleSelected))
            {
                tbxAmount.Text = rulePenalty[ruleSelected];
            }
        }

        private void cbxViolator_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selViolator = cbxViolator.SelectedItem.ToString();
            if (violator.ContainsKey(selViolator))
            {
                tbxName.Text = violator[selViolator];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxViolator.Text) ||
                string.IsNullOrWhiteSpace(tbxName.Text) ||
                string.IsNullOrWhiteSpace(cbxRuleViolated.Text) ||
                string.IsNullOrWhiteSpace(tbxAmount.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (dtpViolationDay.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Violation date cannot be in the future.");
                return;
            }

            string query = "INSERT INTO Violators (AccountID, ViolatorName, Violation, ViolationDate, Penalty, Status) VALUES (?, ?, ?, ?, ?, ?)";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {


                        if (!int.TryParse(cbxViolator.Text, out int accountId))
                        {
                            MessageBox.Show("Invalid Account ID.");
                            return;
                        }

                        command.Parameters.AddWithValue("?", accountId);
                        command.Parameters.AddWithValue("?", tbxName.Text);
                        command.Parameters.AddWithValue("?", cbxRuleViolated.Text);
                        command.Parameters.AddWithValue("?", dtpViolationDay.Value.Date);

                        if (int.TryParse(tbxAmount.Text, out int penalty))
                        {
                            command.Parameters.AddWithValue("?", penalty);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid amount for the penalty.");
                            return;
                        }
                        command.Parameters.AddWithValue("?", "Unpaid");
                        command.ExecuteNonQuery();
                        MessageBox.Show("Record saved successfully.");
                        tbxName.Clear();
                        tbxAmount.Clear();
                        cbxViolator.SelectedIndex = 0;
                        cbxRuleViolated.SelectedIndex = 0;
                        dtpViolationDay.Value = DateTime.Today;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
