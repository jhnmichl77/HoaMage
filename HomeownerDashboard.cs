﻿using System;
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
    public partial class HomeownerDashboard : MaterialForm
    {
        public HomeownerDashboard()
        {
            InitializeComponent();
            Shared.Set(this);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddOccupant_Click(object sender, EventArgs e)
        {
            OccupantForm occupantForm = new OccupantForm();
            occupantForm.Show();
        }
    }
}
