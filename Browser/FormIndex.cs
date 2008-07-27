﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lextm.SharpSnmpLib.Browser
{
    partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
            nudIndex.Maximum = decimal.MaxValue;
        }

        public int Index
        {
            get
            {
                return (int)nudIndex.Value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
