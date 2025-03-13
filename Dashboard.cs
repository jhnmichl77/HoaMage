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
            tbxID.Text = AID.ToString();
            sidebarExpand = false;
        }

        private void HomeownerDashBoard_Load(object sender, EventArgs e)
        {

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
                if(sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                }
            }
            else
            {
                sidebarContainer.Width += 30;
                if(sidebarContainer.Width == sidebarContainer.MaximumSize.Width){
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
    }
}
