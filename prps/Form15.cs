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
                StreamWriter streamWriter = File.AppendText("object.txt");
                streamWriter.WriteLine();
                streamWriter.Write(textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + comboBox1.Text + "|" + textBox5.Text + "|" + textBox6.Text + "|" + textBox7.Text + "|0|0|0|В процессе");
                streamWriter.Close();

                MessageBox.Show("Данные успешно записаны!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}
