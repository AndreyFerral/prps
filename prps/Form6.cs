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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            listBox1.Items.Add("Работник1");
            listBox1.Items.Add("Работник2");
            listBox1.Items.Add("Работник3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show(); // отображаем Form2
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form11 = new Form11();
            form11.Show(); // отображаем Form2
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form10 = new Form10();
            form10.Show(); // отображаем Form2
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
