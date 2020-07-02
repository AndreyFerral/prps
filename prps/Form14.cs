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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form13 = new Form13();
            form13.Show(); // отображаем Form2
            this.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}
