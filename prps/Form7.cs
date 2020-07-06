using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace prps
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            string line;
            StreamReader fs = new StreamReader("brigade.txt");
            while ((line = fs.ReadLine()) != null)
            {
                Brigade brig = new Brigade();
                string[] splitLine = line.Split('|');
                brig.name = splitLine[0];
                listBox1.Items.Add(brig.name);
            }
            fs.Close();
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
            Types.SelectedIndexBrigade = Convert.ToString(listBox1.SelectedItem);
            Form form13 = new Form13();
            form13.Show(); // отображаем Form2
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
