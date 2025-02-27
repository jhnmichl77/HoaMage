﻿using System;
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
    public partial class MemberInformation : UserControl
    {
        public MemberInformation()
        {
            InitializeComponent();
        }

        private void MemberInformation_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Registration parentForm = (Registration)this.FindForm();

            if (parentForm != null)
            {
                parentForm.MarkCheckbox("MemberInformation");
                Shared.ShowUserControl(new PropertyInformation(), this.Parent);
            }
        }
    }
}
