using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMSGUI.BL
{
    public class Person
    {
        public Person() { }
        public Person(string Name, string Password)
        {
            this.Name = Name;
            this.Password = Password;
        }
        protected string Name;
        protected string Password;
        public string Name1 { get => Name; set => Name = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
}
