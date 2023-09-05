using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMSGUI.BL
{
    public class Category
    {
        public Category(string category, List<Product> products)
        {
            Category1 = category;
            Products = products;
        }
        private string category;
        private List<Product> products;
        public List<Product> Products { get => products; set => products = value; }
        public string Category1 { get => category; set => category = value; }

    }
}
