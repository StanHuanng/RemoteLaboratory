﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 扁平化UI
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void spbtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void spbtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("谢谢！");
        }
    }
}
