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
    public partial class AccountAccess : UserControl
    {
        public AccountAccess()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxUsername.Text))
            {
                MessageBox.Show("Username is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                MessageBox.Show("Password is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxConfirmPassword.Text))
            {
                MessageBox.Show("Confirm Password is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbxConfirmPassword.Text != tbxPassword.Text)
            {
                MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxEmailAddress.Text))
            {
                MessageBox.Show("Email Address is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbxRole.Text))
            {
                MessageBox.Show("Role not specified.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "Insert Into Accounts (Username, [Password], Email, Role) values (@Username, @Password, @Email, @Role)";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", tbxUsername.Text);
                        command.Parameters.AddWithValue("@Password", tbxPassword.Text);
                        command.Parameters.AddWithValue("@Email", tbxEmailAddress.Text);
                        command.Parameters.AddWithValue("@Role", cbxRole.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Registration parentForm = (Registration)this.FindForm();
                        if (parentForm != null)
                        {
                            parentForm.MarkCheckbox("AccountAccess");
                            Shared.ShowUserControl(new MemberInformation(), this.Parent);
                        }
                        else
                        {
                            MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

