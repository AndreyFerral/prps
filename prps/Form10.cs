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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            form6.Show(); // отображаем Form2
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                Workers AdWork = new Workers();
                AdWork.name = textBox1.Text;
                AdWork.job = textBox2.Text;
                AdWork.firstday = new int[3];
                AdWork.firstday[0] = Convert.ToInt32(textBox3.Text);
                AdWork.firstday[1] = Convert.ToInt32(textBox4.Text);
                AdWork.firstday[2] = Convert.ToInt32(textBox5.Text);
                AdWork.lastday = new int[3]; AdWork.lastday[0] = 0;
                AdWork.lastday[1] = 0; AdWork.lastday[2] = 0;
                */
                StreamWriter streamWriter = File.AppendText("workers.txt");
                streamWriter.WriteLine();
                streamWriter.Write(textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text + "|0|0|0");
                streamWriter.Close();

                MessageBox.Show("Данные успешно записаны!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
