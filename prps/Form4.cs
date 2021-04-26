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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show(); // отображаем Form2
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
                int sum = 0;
                int count = 0;
                int count2 = 0;

                foreach (ObjectRep obj in list)
                {
                    DateTime dt1 = new DateTime(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text));
                    DateTime dt2 = new DateTime(Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text));
                    DateTime dt3 = new DateTime(obj.firstday[2], obj.firstday[1], obj.firstday[0]);
                    int compare1 = DateTime.Compare(dt3, dt1);
                    int compare3 = DateTime.Compare(dt3, dt2);

                    if (obj.lastday[0] != 0)
                    {
                        DateTime dt4 = new DateTime(obj.lastday[2], obj.lastday[1], obj.lastday[0]);
                        int compare2 = DateTime.Compare(dt3, dt4);
                        int compare4 = DateTime.Compare(dt4, dt1);
                        int compare5 = DateTime.Compare(dt4, dt3);
                        int compare6 = DateTime.Compare(dt4, dt2);

                        if ((compare1 > 0 || compare1 == 0) && (compare4 > 0 || compare4 == 0))
                        {
                            if ((compare2 < 0 || compare2 == 0) && (compare5 > 0 || compare5 == 0))
                            {
                                if ((compare3 < 0 || compare3 == 0) && (compare6 < 0 || compare6 == 0))
                                {
                                    sum = sum + obj.cost;
                                    count++;
                                }
                            }
                        }
                    }
                    else
                    {
                        if ((compare1 > 0 || compare1 == 0))
                        {
                            if ((compare3 < 0 || compare3 == 0))
                            {
                                count2++;
                            }
                        }
                    }
                    textBox7.Text = Convert.ToString(sum);
                    textBox8.Text = Convert.ToString(count2);
                    textBox9.Text = Convert.ToString(count);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
