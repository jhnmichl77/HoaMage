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
    public partial class Registration : Shared
    {
        public Registration()
        {
            InitializeComponent();
            ShowUserControl(new AccountAccess(), panel2);
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
