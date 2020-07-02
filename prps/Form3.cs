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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show(); // отображаем Form2
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.Show(); // отображаем Form2
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.Show(); // отображаем Form2
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
