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

namespace HoaMage
{
    public partial class MemberInformation : UserControl
    {
        public MemberInformation()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxFirstname.Text))
            {
                MessageBox.Show("Firstname is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxLastname.Text))
            {
                MessageBox.Show("Lastname is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxMI.Text))
            {
                MessageBox.Show("Middle Initial is Empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsRadioButtonChecked(gbxGender))
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxContact.Text))
            {
                MessageBox.Show("Please enter contact details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using(OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
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
                    string query = "Insert Into MemberInformation (AccountID, FirstName, LastName, MiddleInitial, Birthday, Gender, ContactNumber) values (@AccountID, @FirstName, @LastName, @MiddleInitial, @Birthday, @Gender, @ContactNumber)";


                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", AccountID);
                        command.Parameters.AddWithValue("@FirstName", tbxFirstname.Text);
                        command.Parameters.AddWithValue("@LastName", tbxLastname.Text);
                        command.Parameters.AddWithValue("@MiddleInitial", tbxMI.Text);
                        command.Parameters.AddWithValue("@Birthday", Convert.ToDateTime(dtpBirthday.Value.Date));
                        string gender = "";
                        if (rbtMale.Checked)
                            gender = "Male";
                        else if (rbtFemale.Checked)
                            gender = "Female";
                        else if (rbtOthers.Checked)
                            gender = "Others";
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@ContactNumber", tbxContact.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Member Information successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Registration parentForm = (Registration)this.FindForm();
                        if (parentForm != null)
                        {
                            parentForm.MarkCheckbox("MemberInformation");
                            Shared.ShowUserControl(new PropertyInformation(), this.Parent);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to save Member Information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsRadioButtonChecked(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
