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
using System.Threading;

namespace prps
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form11 = new Form11();
            form11.Show(); // отображаем Form2
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

            foreach (Workers work in list)
            {
                if (Types.SelectedIndexWorker == work.name)
                {
                    work.lastday[0] = Convert.ToInt32(textBox1.Text);
                    work.lastday[1] = Convert.ToInt32(textBox2.Text);
                    work.lastday[2] = Convert.ToInt32(textBox3.Text);
                    MessageBox.Show("успешно!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            StreamWriter sw = new StreamWriter("workers.txt");
            int i = 0;
            foreach (Workers work in list)
            {
                if (i == list.Count - 1) {
                    sw.Write(work.GetData());
                    continue;
                }
                sw.WriteLine(work.GetData());
                i++;
            }
            sw.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
