﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prps
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form11 = new Form11();
            form11.Show(); // отображаем Form2
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
