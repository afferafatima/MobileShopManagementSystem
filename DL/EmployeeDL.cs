using MSMSGUI.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMSGUI.DL
{
    public class EmployeeDL
    {
        private static string path = "Employees.txt";
        private static List<Employee> employees = new List<Employee>();
        //Store Data in File
        public static void writeData()
        {
            StreamWriter myFile = new StreamWriter(path);
            if (File.Exists(path))
            {
                foreach (Employee employee in employees)
                {
                    if (Employees.IndexOf(employee) != Employees.Count - 1)
                    {
                        myFile.WriteLine(employee.toString());
                    }
                    else
                    {
                        myFile.Write(employee.toString());
                    }
                }
            }
            myFile.Flush();
            myFile.Close();
        }
        public static void writeData(Employee emp)
        {
            StreamWriter myFile = new StreamWriter(path,true);
            if (File.Exists(path))
            {
                myFile.WriteLine(emp.toString());
            }
            myFile.Flush();
            myFile.Close();
        }
        //Read Data from file
        public static void readData()
        {
            StreamReader myFile = new StreamReader(path);
            string line = " ";
            while ((line = myFile.ReadLine()) != null)
            {
                string[] temp = line.Split(',');
                Employee employee = new Employee(temp[0],temp[1],temp[2],int.Parse(temp[3]),double.Parse(temp[4]),bool.Parse(temp[5]), DateTime.Parse(temp[6]));
                employees.Add(employee);
            }
            myFile.Close();
        }
        public static void addEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public static int EmployeeExists(string username,string password)
        {
            foreach(Employee employee in employees)
            {
                if((employee.Name1==username) && ( employee.Password1 == password))
                {
                    return employees.IndexOf(employee);
                }
            }
            return -1;
        }
        public static Employee GetEmployee(int idx)
        {
            return employees[idx];
        }
        public static void removeEmployee(int idx)
        {
            employees.RemoveAt(idx);
        }
        public static void updateEmployeeInfo(int idx,Employee emp)
        {
            employees.Insert(idx, emp);
            employees.RemoveAt(idx+1);
        }
        public static List<Employee> Employees { get => employees; set => employees = value; }
    }
}
