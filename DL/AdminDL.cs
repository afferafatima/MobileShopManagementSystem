using MSMSGUI.BL;
using MSMSGUI.GUI.Main;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace MSMSGUI.DL
{
    internal class AdminDL
    { 
        private static Admin admin= new Admin();
        public static Admin Admin { get => admin; set => admin = value; }
        public static void changeUsername(string username)
        {
            admin.Name1 = username;
        }
        public static void changePassword(string password)
        {
            admin.Password1 = password;
        }
        public static void readData()
        {
            StreamReader myFile = new StreamReader("Admin.txt");
            string line;
            if (File.Exists("Admin.txt"))
            {
                while ((line = myFile.ReadLine()) != null)
                {
                    string[] temp = line.Split(',');
                    Admin a = new Admin(temp[0], temp[1], double.Parse(temp[2]));
                    admin = a;
                }
                myFile.Close();
            }
        }
        public static void writeData()
        {
            StreamWriter myFile = new StreamWriter("Admin.txt");
            if(File.Exists("Admin.txt"))
            {
                myFile.WriteLine(Admin.Name1 + "," + Admin.Password1);
            }
            myFile.Flush();
            myFile.Close();
        }
    }
}
