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
    public partial class profilePage : MaterialForm
    {
        string username = Shared.Identification.Username;
        public profilePage()
        {
            InitializeComponent();
            Shared.Set(this);
            this.Text = username;
        }
    }
}
