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
    public partial class Payment : MaterialForm
    {
        public Payment(string reference, string billedto, string amount, string description)
        {
            InitializeComponent();
            Shared.Set(this);
            tbxReference.Text = reference;
            tbxBilled.Text = billedto;
            tbxAmount.Text = amount;
            tbxDescription.Text = description;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxCardname.Text)
                || string.IsNullOrEmpty(tbxCardNumber.Text)
                || string.IsNullOrEmpty(tbxExpiry.Text)
                || string.IsNullOrEmpty(tbxCVV.Text))
            {
                MessageBox.Show("A field is missing!", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!long.TryParse(tbxCardNumber.Text, out long cardNumber) || tbxCardNumber.Text.Length != 16)
            {
                MessageBox.Show("Invalid Card Number! It must be a 16-digit number.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!DateTime.TryParseExact(tbxExpiry.Text, "MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime expiryDate) || expiryDate <= DateTime.Now)
            {
                MessageBox.Show("Invalid Expiry Date! Please enter a valid date in MM/YY format.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (tbxCVV.Text.Length != 3 || !int.TryParse(tbxCVV.Text, out _))
            {
                MessageBox.Show("Invalid CVV! It must be a 3-digit number.", "Error", MessageBoxButtons.OK);
                return;
            }


            try
            {
                string updateQuery = "UPDATE Payables SET Status = 'Paid' WHERE PayableID = ?";

                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("?", tbxReference.Text);  
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Payment Successful! Status has been updated to 'Paid'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbxCardname.Clear();
                tbxCardNumber.Clear();
                tbxExpiry.Clear();
                tbxCVV.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
