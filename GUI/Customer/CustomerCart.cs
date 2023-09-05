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
    public partial class CustomerCart : UserControl
    {
        double TotalBill = 0;
        Product cartProduct;
        Product shopProduct;
        public CustomerCart()
        {
            InitializeComponent();
            CalculateBill();
            InitializeDataTable();
            dataBinding();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtProductId.Text != null)
            {
                btnRemove.Visible = true;
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Visible = false;
                btnRemove.Enabled = false;
            }
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
            foreach (Product product in CustomerDL.Customers[ExtraDLClass.getCustomerIdx()].Cart)
            {
                double price = product.SalePrice * product.Stock;
                DataTable.Rows.Add(product.Id, product.Name, product.SalePrice.ToString(), product.Stock.ToString(), price.ToString());
            }
            DataTable.Refresh();
        }

        private void DataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idx = DataTable.CurrentRow.Index;
                MessageBox.Show(idx.ToString());
                cartProduct = CustomerDL.Customers[ExtraDLClass.getCustomerIdx()].Cart[idx];
                fillTextBox();
            }
        }
        private void CalculateBill()
        {
            TotalBill = 0;
            foreach (Product product in CustomerDL.Customers[ExtraDLClass.getCustomerIdx()].Cart)
            {
                TotalBill = TotalBill
                     + product.SalePrice;
            }
            txtBill.Text = TotalBill.ToString() + " RS.";
        }
        private void fillTextBox()
        {
            txtName.Text = cartProduct.Name;
            txtBoxQuantity.Text = cartProduct.Stock.ToString();
            txtPrice.Text = cartProduct.SalePrice.ToString();
            txtProductId.Text = cartProduct.Id.ToString();
            txtTotalPrice.Text = (cartProduct.SalePrice * cartProduct.Stock).ToString();
            CalculateBill();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int idx = DataTable.CurrentRow.Index;
            if (idx < CustomerDL.Customers[ExtraDLClass.getCustomerIdx()].Cart.Count)
            {
                cartProduct = CustomerDL.Customers[ExtraDLClass.getCustomerIdx()].Cart[idx];
                CustomerDL.Customers[ExtraDLClass.getCustomerIdx()].Cart.RemoveAt(idx);
                dataBinding();
                MessageBox.Show("Product removed from the cart...");
            }
            CustomerDL.writeData();
        }
        private void updateinShop()
        {

        }
        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for shopping.!!\n Your total bill is "+TotalBill.ToString()+"Rs.");
            int customerIdx = ExtraDLClass.getCustomerIdx();
            List<Product> History = CustomerDL.Customers[customerIdx].History;
            List<Product> CartItems = CustomerDL.Customers[customerIdx].Cart;
            foreach (Product cartItem in CartItems)
            {
                History.Add(cartItem);
            }
            CustomerDL.Customers[customerIdx].History = History;
            CustomerDL.Customers[customerIdx].Cart.Clear();
            dataBinding();
            CustomerDL.writeData();
        }
    }
}
