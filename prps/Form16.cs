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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            
            List<ObjectRep> list = new List<ObjectRep>();
            string line;
            StreamReader fs = new StreamReader("object.txt");

            while ((line = fs.ReadLine()) != null)
            {
                ObjectRep obj = new ObjectRep();
                string[] splitLine = line.Split('|');
                obj.address = splitLine[0];
                obj.problem = splitLine[1];
                obj.cost = Convert.ToInt32(splitLine[2]);
                obj.brigade = splitLine[3];
                obj.firstday = new int[3];
                obj.firstday[0] = Convert.ToInt32(splitLine[4]);
                obj.firstday[1] = Convert.ToInt32(splitLine[5]);
                obj.firstday[2] = Convert.ToInt32(splitLine[6]);
                obj.lastday = new int[3];
                obj.lastday[0] = Convert.ToInt32(splitLine[7]);
                obj.lastday[1] = Convert.ToInt32(splitLine[8]);
                obj.lastday[2] = Convert.ToInt32(splitLine[9]);
                obj.fixproblem = splitLine[10];
                list.Add(obj);
            }
            fs.Close();

            foreach (ObjectRep obj in list)
            {
                if (Types.SelectedIndexObject == obj.address)
                {
                    textBox1.Text = obj.address;
                    textBox2.Text = obj.problem;
                    textBox4.Text = Convert.ToString(obj.cost);
                    textBox3.Text = obj.brigade;
                    textBox5.Text = Convert.ToString(obj.firstday[0] + "." + obj.firstday[1] + "." + obj.firstday[2]);
                    textBox7.Text = Convert.ToString(obj.lastday[0] + "." + obj.lastday[1] + "." + obj.lastday[2]);
                    textBox6.Text = obj.fixproblem;
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form17 = new Form17();
            form17.Show(); // отображаем Form2
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form8 = new Form8();
            form8.Show(); // отображаем Form2
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
