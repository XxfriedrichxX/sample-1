﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_1.AdminControls
{
    public partial class AC_Form : UserControl
    {
        public AC_Form()
        {
            InitializeComponent();
        }

        private void Form2btn_Click(object sender, EventArgs e)
        {
            Forms2 labas = new Forms2();
            labas.Show();
        }
    }
}
