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
    public partial class CustomerProducts : UserControl
    {
        List<Category> categories;
        int categoryIdx;
        int productIdx;
        Product SelectedProduct;
        Product cartProduct;
        public CustomerProducts()
        {
            categories = CategoriesDL.Categories;
            InitializeComponent();
            InitializeComboBox();
            InitializeDataTable();
            dataBinding();
        }
        private void InitializeComboBox()
        {
            foreach(Category c in categories)
            {
                 comboBoxCategories.Items.Add(c.Category1);
            }
            for(int i=0;i<6;i++)
            {
                ComboBoxQuantity.Items.Add(i);
            }
        }
        private void InitializeDataTable()
        {
            // Column headers for the DataTable
            string[] columnHeaders = { "Category", "Product ID", "Name", "Price"  };
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
            foreach (Category category in CategoriesDL.Categories)
            {
                foreach (Product product in category.Products)
                {
                    DataTable.Rows.Add(category.Category1, product.Id, product.Name,product.SalePrice);
                }
            }
            DataTable.Refresh();
        }
        private void DataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryIdx = DataTable.CurrentRow.Index;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow = DataTable.Rows[e.RowIndex];
                // Retrieve the value of the clicked cell
                string category = clickedRow.Cells[0].Value?.ToString();
                string ProductID = clickedRow.Cells[1].Value?.ToString();
                categoryIdx = CategoriesDL.getCategoryIndex(category);
                productIdx = CategoriesDL.getProductIndex(categoryIdx, ProductID);
                fillTextBox();
            }
        }
        private void fillTextBox()
        {
            SelectedProduct = CategoriesDL.GetProduct(categoryIdx, productIdx);
            comboBoxCategories.Text = CategoriesDL.Categories[categoryIdx].Category1;
            txtName.Text = SelectedProduct.Name;
            txtProductId.Text = SelectedProduct.Id;
            ComboBoxQuantity.Text = "1";
            txtPrice.Text = SelectedProduct.SalePrice.ToString();
            txtTotalPrice.Text = (SelectedProduct.SalePrice*double.Parse(ComboBoxQuantity.Text)).ToString();
           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cartProduct = new Product(SelectedProduct.Id, SelectedProduct.Name, SelectedProduct.SalePrice, int.Parse(ComboBoxQuantity.Text));
            int custIdx=CustomerDL.getCustomerIndex(ExtraDLClass.Customer);
            if (SelectedProduct.Stock > 1)
            {
                
                CustomerDL.Customers[custIdx].addProductinCart(cartProduct);
                SelectedProduct.Stock -= int.Parse(ComboBoxQuantity.Text);
                AdminDL.Admin.Profit = AdminDL.Admin.Profit + (SelectedProduct.SalePrice-SelectedProduct.ActualPrice);
                MessageBox.Show("Added in Cart Successfully!!!");
                CustomerDL.writeData();

            }
            else
            {
                MessageBox.Show("Error!!!\nNot Enough Stock");
            }

        }
    }
}
