﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class TelaDevs : Form
    {
        public TelaDevs()
        {
            InitializeComponent();
        }

        private void btnsai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}