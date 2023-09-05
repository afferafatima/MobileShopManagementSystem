using MSMSGUI.BL;
using MSMSGUI.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMSGUI.GUI.Panels
{
    public partial class SoldProducts : UserControl
    {
        public SoldProducts()
        {
            InitializeComponent();
            InitializeDataTable();
            dataBinding();
        }

        private void InitializeDataTable()
        {
            // Column headers for the DataTable
            string[] columnHeaders = { "Category", "Product ID", "Name", "ActualPrice", "SalePrice", "Profit" };
            // Add columns using a loop

            foreach (var columnHeader in columnHeaders)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = columnHeader;
                DataTable.Columns.Add(col);
            }
        }
        private void dataBinding()
        {
            DataTable.DataSource = null;
            DataTable.Rows.Clear();
            for(int i=0;i<CustomerDL.Customers.Count;i++)
            {
                for(int j=0;j<CustomerDL.Customers[i].History.Count; j++)
                {
                    Category category = CategoriesDL.GetCategory(CustomerDL.Customers[i].History[j]);
                    Product product = CategoriesDL.GetProduct(category, CustomerDL.Customers[i].History[j]);
                    if (category != null && product != null)
                    {
                        double profit = product.SalePrice - product.ActualPrice;
                        DataTable.Rows.Add(category.Category1, product.Id,product.Name, product.ActualPrice.ToString(), product.SalePrice.ToString(), profit.ToString());
                    }
                }
            }
            DataTable.Refresh();
        }

       
    }
}
