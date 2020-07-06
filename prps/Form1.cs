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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line;
            bool WrongData = true;
            using (StreamReader fs = new StreamReader("injener.txt", Encoding.Unicode))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    Injener inj = new Injener();
                    string[] splitLine = line.Split(' ');
                    inj.name = splitLine[0];
                    inj.password = splitLine[1];

                    if (inj.SingIn(textBox1.Text, textBox2.Text)) {
                        Form form2 = new Form2();
                        form2.Show(); this.Hide();
                        WrongData = false;
                    }
                }
            }
            using (StreamReader fs = new StreamReader("gl.txt", Encoding.Unicode))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    GlInjener glinj = new GlInjener();
                    string[] splitLine = line.Split(' ');
                    glinj.name = splitLine[0];
                    glinj.password = splitLine[1];

                    if (glinj.SingIn(textBox1.Text, textBox2.Text)) {
                        Form form3 = new Form3();
                        form3.Show(); this.Hide();
                        WrongData = false;
                    }
                }
            }
            if (WrongData) MessageBox.Show("Неверное имя пользователя или пароль");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
