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
    public partial class announceCard : UserControl
    {
        public announceCard()
        {
            InitializeComponent();
        }
        public void SetData(string title, DateTime date, string context)
        {
            lblTitle.Text = title;
            tbxDate.Text = date.ToString("MMMM dd, yyyy");
            tbxContext.Text = context;
        }

        private void tbxDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
