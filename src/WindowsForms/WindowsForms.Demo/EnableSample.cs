﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Demo
{
    public partial class EnableSample : Form
    {
        public EnableSample()
        {
            InitializeComponent();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            txtMain.Enabled = true;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            txtMain.Enabled = false;
        }
    }
}