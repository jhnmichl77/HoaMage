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
    public partial class PropertyInformation : UserControl
    {
        public PropertyInformation()
        {
            InitializeComponent();
        }

        private void PropertyInformation_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Registration parentForm = (Registration)this.FindForm();

            if (parentForm != null)
            {
                parentForm.MarkCheckbox("PropertyInformation");
                Shared.ShowUserControl(new VehicleInformation(), this.Parent);
            }
        }
    }
}
