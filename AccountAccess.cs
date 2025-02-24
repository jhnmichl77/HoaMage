using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (string.IsNullOrWhiteSpace(tbxUsername.Text) || string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                   MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   return;
            }
            Registration parentForm = (Registration)this.FindForm();

            if (parentForm != null)
            {
                parentForm.MarkCheckbox("AccountAccess"); 
                Shared.ShowUserControl(new MemberInformation(), this.Parent); 
            }
            
        }

        private void AccountAccess_Load(object sender, EventArgs e)
        {

        }
    }
}
