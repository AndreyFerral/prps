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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox7.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show(); // отображаем Form2
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

            foreach (ObjectRep obj in list)
            {
                if (obj.lastday[0] != 0) { 
                    DateTime dt1 = new DateTime(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                    DateTime dt2 = new DateTime(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox6.Text));
                    DateTime dt3 = new DateTime(obj.firstday[2], obj.firstday[1], obj.firstday[0]);
                    DateTime dt4 = new DateTime(obj.lastday[2], obj.lastday[1], obj.lastday[0]);
                    /*
                    MessageBox.Show(Convert.ToString(dt1), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(Convert.ToString(dt2), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(Convert.ToString(dt3), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(Convert.ToString(dt4), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */
                    int compare1 = DateTime.Compare(dt3, dt1);
                    int compare2 = DateTime.Compare(dt3, dt4);
                    int compare3 = DateTime.Compare(dt3, dt2);
                    int compare4 = DateTime.Compare(dt4, dt1);
                    int compare5 = DateTime.Compare(dt4, dt3);
                    int compare6 = DateTime.Compare(dt4, dt2);

                    //MessageBox.Show("начало", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if ((compare1 > 0 || compare1 == 0) && (compare4 > 0 || compare4 == 0)) {
                        //MessageBox.Show("первая", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if ((compare2 < 0 || compare2 == 0) && (compare5 > 0 || compare5 == 0)) {
                            //MessageBox.Show("вторая", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if ((compare3 < 0 || compare3 == 0) && (compare6 < 0 || compare6 == 0)) {
                                //MessageBox.Show("третья", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                sum = sum + obj.cost;
                            }
                        }
                    }
                }
                
            }
            textBox7.Text = Convert.ToString(sum);
           // MessageBox.Show("успешно!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
