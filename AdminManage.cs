using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HoaMage
{
    public partial class AdminManage : UserControl
    {
        public AdminManage()
        {
            InitializeComponent();
            
        }
        private void Tables()
        {

        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            using(OleDbConnection connection = new OleDbConnection(DatabaseHelper.myConn))
            {
                connection.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM MemberInformation", connection);
                DataTable members = new DataTable();
                da.Fill(members);
                dgvAdminDisplay.DataSource = members;
            }
        }
    }
}
