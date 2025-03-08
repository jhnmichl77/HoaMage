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
            string query = "Insert Into MemberInformation (FirstName, LastName, MiddleInitial, Birthday, Gender, ContactNumber) values (@FirstName, @LastName, @MiddleInitial, @Birthday, @Gender, @ContactNumber)";

            using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", tbxFirstname.Text);
                        command.Parameters.AddWithValue("@LastName", tbxLastname.Text);
                        command.Parameters.AddWithValue("@MiddleInitial", tbxMI.Text);
                        command.Parameters.Add("@Birthday", OleDbType.Date).Value = Convert.ToDateTime(dtpBirthday.Text);
                        string gender = "";
                        if (rbtMale.Checked)
                            gender = "Male";
                        else if (rbtFemale.Checked)
                            gender = "Female";
                        else if (rbtOthers.Checked)
                            gender = "Others";
                        command.Parameters.AddWithValue("@Gender", gender); 
                        command.Parameters.AddWithValue("@ContactNumber", tbxContact.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member Information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Registration parentForm = (Registration)this.FindForm();
                            if (parentForm != null)
                            {
                                parentForm.MarkCheckbox("MemberInformation");
                                Shared.ShowUserControl(new PropertyInformation(), this.Parent);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to save Member Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
