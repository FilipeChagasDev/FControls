﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + (textBox1.Text.Trim() != "" ? textBox1.Text : "user") + " !");
        }
    }
}
