using MSMSGUI.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MSMSGUI.DL
{
    public class CategoriesDL
    {
        private static string path = "Categories.txt";
        private static List<Category> categories=new List<Category>();
        public static List<Category> Categories { get => categories; set => categories = value; }
        public static void readData()
        {
            StreamReader myFile = new StreamReader(path);
            string line = "";
            while((line = myFile.ReadLine()) != null)
            {
                string[] temp = line.Split(',');
                Product product = new Product(temp[1], temp[2], double.Parse(temp[3]), double.Parse(temp[4]), int.Parse(temp[5]));

                // Check if the category already exists
                string categoryName = temp[0];
                Category existingCategory = categories.Find(c => c.Category1 == categoryName);
                if (existingCategory != null)
                {
                    existingCategory.Products.Add(product);
                }
                else
                {
                    List<Product> products = new List<Product> { product };
                    Category newCategory = new Category(categoryName, products);
                    categories.Add(newCategory);
                }
            }
            myFile.Close();
        }
        public static void writeData()
        {
            StreamWriter myFile = new StreamWriter(path);
            for (int i = 0; i < categories.Count(); i++)
            {
                for (int j = 0; j < categories[i].Products.Count; j++)
                {
                    myFile.WriteLine(categories[i].Category1.ToString() + "," + categories[i].Products[j].toString());
                }
            }
            myFile.Flush();
            myFile.Close();
        }
        public static List<Product> GetProducts(string category)
        {
            List<Product> a = new List<Product>();

            for (int idx = 0; idx < categories.Count; idx++)
            {
                if (categories[idx].Category1.ToLower() == category.ToLower())
                {
                    return categories[idx].Products;
                }
            }
            return a;
        }
        public static bool isCategoryExist(string name)
        {
            foreach (Category category in categories)
            {
                if (category.Category1.ToLower() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static int getCategoryIndex(string category)
        {

            for (int idx = 0; idx < categories.Count; idx++)
            {
                if (categories[idx].Category1.ToLower() == category.ToLower())
                {
                    return idx;
                }
            }
            return -1;
        }
        public static int getProductIndex(int category,string productId)
        {
            List<Product> products = categories[category].Products;
            for (int i = 0; i < products.Count;i++)
            {
                if (productId == products[i].Id)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void addCategory(Category category)
        {
            categories.Add(category);
        }
        public static Product GetProduct(int CategoryIdx,int ProductIdx)
        {
            return categories[CategoryIdx].Products[ProductIdx];
        }
        public static Product GetProduct(Category category, Product product)//from customer data
        {
            foreach(Category c in Categories)
            {
                if(c.Category1== category.Category1)
                {
                    foreach (Product p in c.Products)
                    {
                        if(p.Id==product.Id&&p.Name==product.Name)
                        {
                            return p;
                        }    
                    }
                }
            }
            return null;
        }
        public static void AddProduct(int categoryIdx,Product product)
        {
            categories[categoryIdx].Products.Add(product);
        }
        public static void DeleteProduct(int categoryIdx,Product product)
        {
            categories[categoryIdx].Products.Remove(product);
        }
        public static void DeleteProduct(int categoryIdx,int productIdx)
        {
            categories[categoryIdx].Products.RemoveAt(productIdx);
        }
        public static void UpdateProduct(int categoryIdx,int productIdx,Product product)
        {
            categories[categoryIdx].Products.Insert(productIdx, product);
            categories[categoryIdx].Products.RemoveAt(productIdx+1);
        }
        public static Category GetCategory(Product cartProduct)
        {
            
            foreach (var category in Categories)
            {
                var product = category.Products.Find(p => p.Id == cartProduct.Id && p.Name == cartProduct.Name);
                if (product != null)
                {
                    return category;
                }
            }
            return null;
        }


    }
}
