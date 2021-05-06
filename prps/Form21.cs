using System;
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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form19 = new Form19();
            form19.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form22 = new Form22();
            form22.Show();
            this.Close();
        }
    }
}
