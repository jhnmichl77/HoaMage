using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HoaMage
{
    public partial class Registration : Shared
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        public Registration()
        {
            InitializeComponent();
            ShowUserControl(new AccountAccess(), panel2);
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void MarkCheckbox(string section)
        {
            if (section == "AccountAccess")
            {
                cbxAccountAccess.Checked = true;
            }
            else if (section == "MemberInformation")
            {
                cbxMemberInformation.Checked = true;
            }
            else if (section == "PropertyInformation")
            {
                cbxPropertyInformation.Checked = true;
            }
            else if (section == "VehicleInformation")
            {
                cbxVehicleInformation.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
