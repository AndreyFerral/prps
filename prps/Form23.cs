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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
            listBox1.Items.Add("Государственные органы");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form19 = new Form19();
            form19.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form24 = new Form24();
            form24.Show();
            this.Close();
        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }
    }
}
