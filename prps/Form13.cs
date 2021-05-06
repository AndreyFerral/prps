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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

            List<Brigade> list = new List<Brigade>();
            string line;
            StreamReader fs = new StreamReader("brigade.txt");

            while ((line = fs.ReadLine()) != null)
            {
                Brigade brig = new Brigade();
                string[] splitLine = line.Split('|');
                brig.name = splitLine[0];
                brig.workers = new string[3];
                brig.workers[0] = splitLine[1];
                brig.workers[1] = splitLine[2];
                brig.workers[2] = splitLine[3];
                list.Add(brig);
            }
            fs.Close();

            foreach (Brigade brig in list)
            {
                if (Types.SelectedIndexBrigade == brig.name)
                {
                    textBox4.Text = brig.name;
                    textBox3.Text = brig.workers[0] + "\t" + brig.workers[1] + "\t" + brig.workers[2];
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form7 = new Form7();
            form7.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form14 = new Form14();
            form14.Show();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
