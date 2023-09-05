using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMSGUI.BL
{
    public class Product
    {

        private string id;
        private string name;
        private double actualPrice;
        private double salePrice;
        private int stock;

        public Product(string id, string name, double actualPrice, double salePrice, int stock)
        {
            Id = id;
            Name = name;
            ActualPrice = salePrice;
            SalePrice = actualPrice;
            Stock = stock;
        }
        public Product(string id, string name, double salePrice, int stock)
        {
            Id = id;
            Name = name;
            this.salePrice = salePrice;
            Stock = stock;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
       
        public int Stock { get => stock; set => stock = value; }
        public double ActualPrice { get => actualPrice; set => actualPrice = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }
        public string toString()
        {
            return id + "," + name + "," + actualPrice + "," + salePrice + "," + stock;
        }
        public string toStringCustomer()
        {
            return id + ";" + name + ";" + salePrice + ";" + stock;

        }
    }
}
