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
    }
    public class GlInjener : Injener
    {
        public GlInjener() : base() { }
    }

    public class Workers
    {
        public string name;
        public string job;
        public int[] firstday;
        public int[] lastday;

        public Workers()
        {
            this.name = "";
            this.job = "";
            this.firstday = new int[3]; this.firstday[0] = 0; this.firstday[1] = 0; this.firstday[2] = 0;
            this.lastday = new int[3]; this.lastday[0] = 0; this.lastday[1] = 0; this.lastday[2] = 0;
        }

        public string GetData() {
            return name + "|" + job + "|" + Convert.ToString(firstday[0]) + "|" + Convert.ToString(firstday[1]) + "|" + Convert.ToString(firstday[2])
                + "|" + Convert.ToString(lastday[0]) + "|" + Convert.ToString(lastday[1]) + "|" + Convert.ToString(lastday[2]);
        }

    }

    public class Brigade
    {
        public string name;
        public string[] workers;

        public Brigade() { }
        public string GetData()
        {
            return name + "|" + workers[0] + "|" + workers[1] + "|" + workers[2];
        }
    }

    public class ObjectRep
    {
        public string address;
        public string problem;
        public int cost;
        public string brigade;
        public int[] firstday;
        public int[] lastday;
        public string fixproblem;

        public ObjectRep()
        {
            this.address = "";
            this.problem = "";
            this.cost = 0;
            this.brigade = "";
            this.firstday = new int[3];  this.firstday[0] = 0; this.firstday[1] = 0; this.firstday[2] = 0;
            this.lastday = new int[3]; this.lastday[0] = 0; this.lastday[1] = 0; this.lastday[2] = 0;
            this.fixproblem = "";
        }

        public string GetData()
        {
            return address + "|" + problem + "|" + Convert.ToString(cost) + "|" + brigade + "|" +
            Convert.ToString(firstday[0]) + "|" + Convert.ToString(firstday[1]) + "|" + Convert.ToString(firstday[2]) + "|" +
            Convert.ToString(lastday[0]) + "|" + Convert.ToString(lastday[1]) + "|" + Convert.ToString(lastday[2]) + "|" + fixproblem;
        }
    }
    public static class Types
    {
        public static string SelectedIndexWorker;
        public static string SelectedIndexBrigade;
        public static string SelectedIndexObject;
    }

}
