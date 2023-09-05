using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMSGUI.BL
{
    public class Customer:User
    {
        public Customer(string userName, string Password):base(userName,Password)
        { 
        }
        public Customer(string userName,string Password,string Number):base(userName,Password,Number) 
        { 
            Cart = new List<Product>();
            history = new List<Product>();
        }
        public Customer(string userName,string Password,string Number,List<Product> cart,List<Product> history):base(userName,Password,Number)
        {
            this.Cart = cart;
            this.history= history;
        }
        private List<Product> cart;
        private List<Product> history;

        public List<Product> Cart { get => cart; set => cart = value; }
        public List<Product> History { get => history; set => history = value; }

        public void addProductinCart(Product product)
        {
            Cart.Add(product);
        }
        public string toString()
        {
            string line = this.Name + "," + this.Password + "," + this.phoneNumber +",";
            foreach(Product product in Cart)
            {
                line = line + "#" + product.toStringCustomer();
            }
            line = line + ",";
            foreach(Product product in history)
            {
                line = line + "#" + product.toStringCustomer();
            }
            return line;
        }
    }
}
