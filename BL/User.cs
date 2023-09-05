using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMSGUI.BL
{
    public class User:Person
    {
        public User()
        {

        }
        public User(string username,string password,string PhoneNumber) :base(username,password)
        {
        this.PhoneNumber = PhoneNumber;
        }
        public User(string username, string password):base(username, password)
        {
        }
        protected string phoneNumber;
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
