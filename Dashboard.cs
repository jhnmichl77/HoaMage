using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HoaMage
{
    public partial class Dashboard : Shared
    {
        bool sidebarExpand;
        public Dashboard()
        {
            InitializeComponent();
            int AID = Identification.AccountID;
            string Role = Identification.Role;
            tbxID.Text = AID + " " + Role.ToString();
            sidebarExpand = false;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {

        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            if (Identification.Role == "Admin")
            {
                ShowUserControl(new AdminManage(), pnlDisplay);
                //working
            }
            else
            {
                ShowUserControl(new HomeownerManage(), pnlDisplay);
                //working
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 30;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 30;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            if (Identification.Role == "Admin")
            {
                ShowUserControl(new AdminPayments(), pnlDisplay);
                //working
            }
            else
            {
                ShowUserControl(new HomeownerPayments(), pnlDisplay);
                //working
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (Identification.Role == "Admin")
            {
                ShowUserControl(new AdminRequest(), pnlDisplay);
                //working
            }
            else
            {
                ShowUserControl(new HomeownerRequest(), pnlDisplay);
                //working
            }
        }
    }
}
