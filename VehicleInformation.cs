using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaMage
{
    public partial class VehicleInformation : UserControl
    {
        public VehicleInformation()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Registration parentForm = (Registration)this.FindForm();
            if (parentForm != null)
            {
                parentForm.MarkCheckbox("VehicleInfo");

                HomeownerDashBoard dashboard = new HomeownerDashBoard();
                dashboard.Show();

                parentForm.Close();
            }
        }
    }
}
