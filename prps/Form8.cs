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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            string line;
            StreamReader fs = new StreamReader("object.txt");
            while ((line = fs.ReadLine()) != null)
            {
                ObjectRep objrep = new ObjectRep();
                string[] splitLine = line.Split('|');
                objrep.address = splitLine[0];
                listBox1.Items.Add(objrep.address);
            }
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show(); // отображаем Form2
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Types.SelectedIndexObject = Convert.ToString(listBox1.SelectedItem);
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form form18 = new Form18();
            form18.Show(); // отображаем Form2
            this.Close();
        }
    }
}
