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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            listBox1.Items.Add("Проспект Ленина, 44");
            listBox1.Items.Add("Объект2");
            listBox1.Items.Add("Объект3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show(); // отображаем Form2
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form16 = new Form16();
            form16.Show(); // отображаем Form2
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form15 = new Form15();
            form15.Show(); // отображаем Form2
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
