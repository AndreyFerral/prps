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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            List<Brigade> list = new List<Brigade>();
            string line;
            StreamReader fs = new StreamReader("brigade.txt");

            while ((line = fs.ReadLine()) != null)
            {
                Brigade brig = new Brigade();
                string[] splitLine = line.Split('|');
                brig.name = splitLine[0];
                brig.workers = new string[3]; brig.workers[0] = splitLine[1];
                brig.workers[1] = splitLine[2]; brig.workers[2] = splitLine[3];
                list.Add(brig);
            }
            fs.Close();

            foreach (Brigade brig in list)
            {
                if (Types.SelectedIndexBrigade == brig.name)
                {
                    textBox1.Text = brig.name;
                    textBox2.Text = brig.workers[0];
                    textBox3.Text = brig.workers[1];
                    textBox4.Text = brig.workers[2];
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form13 = new Form13();
            form13.Show(); // отображаем Form2
            this.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Brigade> list = new List<Brigade>();
            string line;
            StreamReader fs = new StreamReader("brigade.txt");

            while ((line = fs.ReadLine()) != null)
            {
                Brigade brig = new Brigade();
                string[] splitLine = line.Split('|');
                brig.name = splitLine[0];
                brig.workers = new string[3]; brig.workers[0] = splitLine[1];
                brig.workers[1] = splitLine[2]; brig.workers[2] = splitLine[3];
                list.Add(brig);
            }
            fs.Close();

            foreach (Brigade brig in list)
            {
                if (Types.SelectedIndexBrigade == brig.name)
                {
                    brig.name = textBox1.Text;
                    Types.SelectedIndexBrigade = brig.name;
                    brig.workers[0] = textBox2.Text;
                    brig.workers[1] = textBox3.Text;
                    brig.workers[2] = textBox4.Text;
                    MessageBox.Show("успешно!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            StreamWriter sw = new StreamWriter("brigade.txt");
            int i = 0;
            foreach (Brigade brig in list)
            {
                if (i == list.Count - 1)
                {
                    sw.Write(brig.GetData());
                    continue;
                }
                sw.WriteLine(brig.GetData());
                i++;
            }
            sw.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
