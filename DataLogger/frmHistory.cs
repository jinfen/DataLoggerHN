﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace DataLogger
{
    public partial class frmHistory : Form
    {
        ResourceManager res_man;    // declare Resource manager to access to specific cultureinfo
        CultureInfo cul;            //declare culture info
        public frmHistory()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
