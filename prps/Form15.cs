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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form8 = new Form8();
            form8.Show(); // отображаем Form2
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                ObjectRep AdObjectRep = new ObjectRep();
                AdObjectRep.address = textBox1.Text;
                AdObjectRep.address = textBox2.Text;
                AdObjectRep.workers = new string[3];
                AdObjectRep.workers[0] = textBox2.Text;
                AdObjectRep.workers[1] = textBox3.Text;
                AdObjectRep.workers[2] = textBox4.Text;
                */

                StreamWriter streamWriter = File.AppendText("object.txt");
                streamWriter.WriteLine();
                streamWriter.Write(textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text + "|" + textBox6.Text + "|" + textBox7.Text + "|0|0|0|В процессе");
                streamWriter.Close();

                MessageBox.Show("Данные успешно записаны!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
    }
}
