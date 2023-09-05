using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMSGUI.BL
{
    public class Admin:Person
    {
        public Admin() { }
        public Admin(string username,string password):base(username,password)
        {

        }
        public Admin(string username, string password, double profit):this(username,password)
        {
            this.Profit = profit;
        }
        private double profit;
        public double Profit { get => profit; set => profit = value; }
        public string toString()
        {
            return this.Name1 + "," + this.Password1 + "," + this.Profit;
        }
    }
}
