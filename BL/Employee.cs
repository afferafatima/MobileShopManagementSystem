using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMSGUI.BL
{
    public class Employee:User 
    {
        public Employee()
        {

        }
        public Employee(string username,string password,string phonenumber,int attendance,double OneDaySalary,bool Voucher):base(username,password,phonenumber)
        {
            this.Attendance = attendance;
            this.OneDaySalary = OneDaySalary;
            this.Voucher = Voucher;
            lastAttendanceDateTime= DateTime.Now;
        }
        public Employee(string username, string password, string phonenumber, int attendance, double OneDaySalary, bool Voucher,DateTime lastAttendanceDateTime) : base(username, password, phonenumber)
        {
            this.Attendance = attendance;
            this.OneDaySalary = OneDaySalary;
            this.Voucher = Voucher;
            this.lastAttendanceDateTime = lastAttendanceDateTime;
        }

        private bool Voucher;
        private int Attendance;
        private double OneDaySalary;
        private DateTime lastAttendanceDateTime;

        public bool Voucher1 { get => Voucher; set => Voucher = value; }
        public int Attendance1 { get => Attendance; set => Attendance = value; }
        public double OneDaySalary1 { get => OneDaySalary; set => OneDaySalary = value; }

        public string toString()
        {
            return this.Name + "," + this.Password + "," + this.PhoneNumber + "," + this.Attendance + "," + this.OneDaySalary + "," + this.Voucher+","+lastAttendanceDateTime.ToString();
        }
    }
}
