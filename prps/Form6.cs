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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            string line;
            StreamReader fs = new StreamReader("workers.txt");
            while ((line = fs.ReadLine()) != null)
            {
                Workers work = new Workers();
                string[] splitLine = line.Split('|');
                work.name = splitLine[0];
                listBox1.Items.Add(work.name);
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
            Types.SelectedIndexWorker = Convert.ToString(listBox1.SelectedItem);
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

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
