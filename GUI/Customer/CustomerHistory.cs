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

namespace MSMSGUI.GUI.Customer
{
    public partial class CustomerHistory : UserControl
    {
        public CustomerHistory()
        {
            InitializeComponent();
            InitializeDataTable();
            dataBinding();
        }

        private void InitializeDataTable()
        {
            // Column headers for the DataTable
            string[] columnHeaders = { "Product ID", "Name", "Price", "Quantity", "TotalPrice" };
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
            foreach (Product product in CustomerDL.Customers[ExtraDLClass.getCustomerIdx()].History)
            {
                double price = product.SalePrice * product.Stock;
                DataTable.Rows.Add(product.Id, product.Name, product.SalePrice.ToString(), product.Stock.ToString(), price.ToString());
            }
            DataTable.Refresh();
        }
    }
}
