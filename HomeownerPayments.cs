using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaMage
{
    public partial class HomeownerPayments : UserControl
    {
        public HomeownerPayments()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.Show();
        }
    }
}
