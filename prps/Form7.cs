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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            listBox1.Items.Add("Бригада1");
            listBox1.Items.Add("Бригада2");
            listBox1.Items.Add("Бригада3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show(); // отображаем Form2
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form12 = new Form12();
            form12.Show(); // отображаем Form2
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form13 = new Form13();
            form13.Show(); // отображаем Form2
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
