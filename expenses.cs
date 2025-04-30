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
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace HoaMage
{
    public partial class expenses : MaterialForm
    {
        public expenses()
        {
            InitializeComponent();
            Shared.Set(this);
            loadExpenses();
            LoadExpensePieChart();
        }
        private void LoadExpensePieChart()
        {
            var model = new PlotModel { Title = "Expenses Category Breakdown" };
            var pieSeries = new PieSeries
            {
                StrokeThickness = 0.25,
                InsideLabelPosition = 0.8,
                AngleSpan = 360,
                StartAngle = 0
            };

            string query = "SELECT Category, SUM(Amount) AS Total FROM Expenses GROUP BY Category";
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string category = reader["Category"].ToString();
                        double total = Convert.ToDouble(reader["Total"]);
                        pieSeries.Slices.Add(new PieSlice(category, total));
                    }
                }
            }

            model.Series.Add(pieSeries);

            PlotView pieChart = new PlotView
            {
                Model = model,
                Dock = DockStyle.Fill
            };

            panelPieChart.Controls.Clear(); 
            panelPieChart.Controls.Add(pieChart);
        }
        private void loadExpenses()
        {
            string query = "SELECT Title, Category, Amount, DateIssued, ReferenceNum FROM Expenses";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dgvExpenses.DataSource = dt;
                }
            }
            LoadExpensePieChart();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = tbxTitle.Text.Trim();
            string category = cbxCategory.Text.Trim();
            string amountText = tbxAmount.Text.Trim();
            string referenceNum = tbxReferenceNum.Text.Trim();
            string dateIssued = dtpDate.Value.ToShortDateString();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(amountText))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount))
            {
                MessageBox.Show("Amount must be a valid number.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Expenses (Title, Category, Amount, DateIssued, ReferenceNum) " +
                           "VALUES (?, ?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", title);
                cmd.Parameters.AddWithValue("?", category);
                cmd.Parameters.AddWithValue("?", amount);
                cmd.Parameters.AddWithValue("?", dateIssued);
                cmd.Parameters.AddWithValue("?", referenceNum);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            loadExpenses();

            MessageBox.Show("Expense successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbxTitle.Clear();
            cbxCategory.SelectedIndex = 0;
            tbxAmount.Clear();
            tbxReferenceNum.Clear();

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = tbxSearch.Text.Trim();

            string query = "SELECT Title, Category, Amount, DateIssued, ReferenceNum FROM Expenses WHERE Title LIKE @Search OR Category LIKE @Search OR ReferenceNum LIKE @Search";

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Search", "%" + searchQuery + "%");

                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvExpenses.DataSource = dt;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                if (dgvExpenses.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvExpenses.SelectedRows[0];

                    tbxTitle.Text = row.Cells["Title"].Value.ToString();
                    cbxCategory.SelectedItem = row.Cells["Category"].Value.ToString();
                    tbxAmount.Text = row.Cells["Amount"].Value.ToString();
                    dtpDate.Value = DateTime.Parse(row.Cells["DateIssued"].Value.ToString());
                    tbxReferenceNum.Text = row.Cells["ReferenceNum"].Value.ToString();

                    tbxReferenceNum.Enabled = true;
                    btnEdit.Text = "Update";
                }
                else
                {
                    MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (btnEdit.Text == "Update")
            {
                UpdateExpense();
                btnEdit.Text = "Edit";
                tbxReferenceNum.Enabled = true;
                tbxTitle.Clear();
                cbxCategory.SelectedIndex = 0;
                tbxAmount.Clear();
                tbxReferenceNum.Clear();
            }

        }

        private void UpdateExpense()
        {

            if (string.IsNullOrWhiteSpace(tbxTitle.Text) ||
                cbxCategory.SelectedItem == null ||
                string.IsNullOrWhiteSpace(tbxAmount.Text) ||
                string.IsNullOrWhiteSpace(tbxReferenceNum.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string title = tbxTitle.Text.Trim();
                string category = cbxCategory.SelectedItem.ToString();
                double amount = Convert.ToDouble(tbxAmount.Text.Trim());
                string dateIssued = dtpDate.Value.ToShortDateString();
                string referenceNum = tbxReferenceNum.Text.Trim();

                string query = "UPDATE Expenses SET Title = ?, Category = ?, Amount = ?, DateIssued = ? WHERE ReferenceNum = ?";

                using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", title);
                    cmd.Parameters.AddWithValue("?", category);
                    cmd.Parameters.AddWithValue("?", amount);
                    cmd.Parameters.AddWithValue("?", dateIssued);
                    cmd.Parameters.AddWithValue("?", referenceNum);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Expense updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadExpenses(); // Reload the DataGridView after update
                    }
                    else
                    {
                        MessageBox.Show("No matching record found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    string referenceNum = dgvExpenses.SelectedRows[0].Cells["ReferenceNum"].Value.ToString();

                    string query = "DELETE FROM Expenses WHERE ReferenceNum = ?";

                    using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", referenceNum);

                        try
                        {
                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Expense deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadExpenses(); 
                                tbxTitle.Clear();
                                cbxCategory.SelectedIndex = 0;
                                tbxAmount.Clear();
                                tbxReferenceNum.Clear();  
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete. Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
