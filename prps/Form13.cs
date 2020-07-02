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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form7 = new Form7();
            form7.Show(); // отображаем Form2
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form14 = new Form14();
            form14.Show(); // отображаем Form2
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
