using MSMSGUI.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMSGUI.DL
{
    public class CustomerDL
    {
        private static string path = "Customers.txt";
        private static List<Customer> customers = new List<Customer>();
        public static List<Customer> Customers { get => customers; set => customers = value; }
        public static void writeData()
        {
            StreamWriter myFile = new StreamWriter(path);
            if (File.Exists(path))
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    if (i == customers.Count - 1)
                    {
                        myFile.Write(customers[i].toString());
                    }
                    else
                    {
                        myFile.WriteLine(customers[i].toString());
                    }
                }
            }
            myFile.Flush();
            myFile.Close();
        }
        public static void readData()
        {
            StreamReader myFile = new StreamReader(path);
            string line = " ";
            while ((line = myFile.ReadLine()) != null)
            {
                string[] temp = line.Split(',');
                List<Product> cart = new List<Product>();
                List<Product> history = new List<Product>();
                if (temp.Length >= 4)
                {
                    string[] cartItems = temp[3].Split('#');
                    for (int j = 0; j < cartItems.Length; j++)
                    {
                        string[] temp2 = cartItems[j].Split(';');
                        for (int i = 0; i < temp2.Length - 1; i += 4)
                        {
                            Product product = new Product(temp2[i], temp2[i + 1], double.Parse(temp2[i + 2]), int.Parse(temp2[i + 3]));
                            cart.Add(product);
                        }
                    }
                    if (temp.Length >= 5)
                    {
                        string[] HistoryItem = temp[4].Split('#');
                        for (int j = 0; j < HistoryItem.Length; j++)
                        {
                            string[] temp2 = HistoryItem[j].Split(';');
                            for (int i = 0; i < temp2.Length - 1; i += 4)
                            {
                                Product product = new Product(temp2[i], temp2[i + 1], double.Parse(temp2[i + 2]), int.Parse(temp2[i + 3]));
                                history.Add(product);
                            }
                        }
                    }
                }
                Customer customer = new Customer(temp[0], temp[1], temp[2], cart, history);
                addCustomer(customer);
            }
            myFile.Close();
        }
        public static void addCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public static int getCustomerIndex(Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Name1 == customer.Name1 && customers[i].Password1 == customer.Password1)
                {
                    return Customers.IndexOf(customers[i]);
                }
            }
            return -1;
        }
        public static Customer GetCustomer(int index)
        {
            return customers[index];
        }
        public static bool isCustomerExist(Customer customer)
        {
            foreach (Customer customer1 in customers)
            {
                if (customer1 == customer)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
