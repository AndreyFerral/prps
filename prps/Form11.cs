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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

            List<Workers> list = new List<Workers>();
            string line;
            StreamReader fs = new StreamReader("workers.txt");
            
                while ((line = fs.ReadLine()) != null)
                {
                    Workers work = new Workers();
                    string[] splitLine = line.Split('|');
                    work.name = splitLine[0];
                    work.job = splitLine[1];
                    work.firstday = new int[3];
                    work.firstday[0] = Convert.ToInt32(splitLine[2]);
                    work.firstday[1] = Convert.ToInt32(splitLine[3]);
                    work.firstday[2] = Convert.ToInt32(splitLine[4]);
                    work.lastday = new int[3];
                    work.lastday[0] = Convert.ToInt32(splitLine[5]);
                    work.lastday[1] = Convert.ToInt32(splitLine[6]);
                    work.lastday[2] = Convert.ToInt32(splitLine[7]);
                    list.Add(work);
                }
            fs.Close();

            foreach (Workers work in list) {
                if (Types.SelectedIndexWorker == work.name) {
                    textBox1.Text = work.name;
                    textBox2.Text = work.job;
                    textBox3.Text = work.firstday[0] + "." + work.firstday[1] + "." + work.firstday[2];
                    textBox4.Text = work.lastday[0] + "." + work.lastday[1] + "." + work.lastday[2];
                }
            }
             //MessageBox.Show(Types.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form form9 = new Form9();
            form9.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            form6.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
