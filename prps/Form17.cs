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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form16 = new Form16();
            form16.Show(); // отображаем Form2
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
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
                        obj.lastday[0] = Convert.ToInt32(textBox1.Text);
                        obj.lastday[1] = Convert.ToInt32(textBox3.Text);
                        obj.lastday[2] = Convert.ToInt32(textBox4.Text);
                        obj.fixproblem = textBox2.Text;
                        MessageBox.Show("успешно!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }

                StreamWriter sw = new StreamWriter("object.txt");
                int i = 0;
                foreach (ObjectRep obj in list)
                {
                    if (i == list.Count - 1)
                    {
                        sw.Write(obj.GetData());
                        continue;
                    }
                    sw.WriteLine(obj.GetData());
                    i++;
                }
                sw.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
