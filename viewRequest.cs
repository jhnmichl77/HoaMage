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
    public partial class viewRequest : MaterialForm
    {
        public viewRequest(string type, string subject, string context, string status, string dateSubmitted)
        {
            InitializeComponent();
            Shared.Set(this);
            checkRole();

            tbxReqType.Text = type;
            tbxReqSubject.Text = subject;
            tbxReqContext.Text = context;
            cbxStatus.Text = status;
            DateTime formattedDate = Convert.ToDateTime(dateSubmitted);
            tbxReqDate.Text = formattedDate.ToShortDateString();
        }

        private void checkRole()
        {
            bool isAdmin = Shared.Identification.Role == "Admin";

            tbxReqDate.Enabled = false;
            tbxReqSubject.Enabled = false;
            tbxReqType.Enabled = false;
            tbxReqContext.Enabled = false;
            cbxStatus.Enabled = isAdmin;
            btnSave.Visible = isAdmin;
            btnReply.Visible = isAdmin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
