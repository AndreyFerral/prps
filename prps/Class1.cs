using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Injener
    {
        public string name;     // логин для входа в систему
        public string password;

        public Injener()
        {
            this.name = "";
            this.password = "";
        }

        public bool SingIn(string name, string password)
        {
            if (name == this.name && password == this.password) return true;
            else return false;
        }
        public void show()
        {
            MessageBox.Show(name + " " + password);
        }
    }
    public class GlInjener : Injener
    {
        public GlInjener() : base() { }
    }
}
