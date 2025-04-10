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
    public partial class Bill : MaterialForm
    {
        public Bill()
        {
            InitializeComponent();
            Shared.Set(this);
            loadAccounts();
        }
        Dictionary<string, string> bill = new Dictionary<string, string>();

        private void loadAccounts()
        {
            cbxAccounts.Items.Clear();
            bill.Clear();
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

                            cbxAccounts.Items.Add(accId);
                            if (!bill.ContainsKey(accId))
                            {
                                bill.Add(accId, fullName);
                            }
                        }
                    }
                }
            }
            if (cbxAccounts.Items.Count > 0)
            {
                cbxAccounts.SelectedIndex = 0;
            }
        }

        private void cbxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string billedTo = cbxAccounts.SelectedItem.ToString();
            if (bill.ContainsKey(billedTo))
            {
                tbxName.Text = bill[billedTo];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Payables (AccountID, BilledTo, Description, Amount, DateAdded, Status) VALUES (?, ?,?,?,?,?)";

            using(OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                connection.Open();
                using(OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", cbxAccounts.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@BilledTo", tbxName.Text);
                    command.Parameters.AddWithValue("@Description", tbxDescription.Text);
                    command.Parameters.AddWithValue("@Amount", tbxAmount.Text);
                    command.Parameters.AddWithValue("@DueDate", dtpDueDate.Value.Date);
                    command.Parameters.AddWithValue("@Status", "Unpaid");
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Bill saved successfully.");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving bill: " + ex.Message);
                    }
                }
            }
        }
    }
}
