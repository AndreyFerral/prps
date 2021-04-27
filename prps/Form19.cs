using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prps
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
            listBox1.Items.Add("Шаблон 'Государственные органы'");
            listBox1.Items.Add("Шаблон 'Налоговые органы'");
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}
