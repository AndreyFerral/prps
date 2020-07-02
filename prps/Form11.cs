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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form9 = new Form9();
            form9.Show(); // отображаем Form2
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            form6.Show(); // отображаем Form2
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
