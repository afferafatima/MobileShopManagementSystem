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
    public partial class BestSellingProducts : UserControl
    {
        List<Category> categories;
        int categoryIdx;
        int productIdx;
        Product SelectedProduct;
        Product cartProduct;
        public BestSellingProducts()
        {
            categories = CategoriesDL.Categories;
            InitializeComponent();
            InitializeDataTable();
            dataBinding();
        }
        private void InitializeDataTable()
        {
            // Column headers for the DataTable
            string[] columnHeaders = { "Category","Product ID", "Name", "Price" };
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
            for (int i = 0; i < CustomerDL.Customers.Count; i++)
            {
                for (int j = 0; j < CustomerDL.Customers[i].History.Count; j++)
                {
                    Category category = CategoriesDL.GetCategory(CustomerDL.Customers[i].History[j]);
                    Product product = CategoriesDL.GetProduct(category, CustomerDL.Customers[i].History[j]);
                    if (category != null && product != null)
                    {
                        DataTable.Rows.Add(category.Category1, product.Id, product.Name, product.SalePrice.ToString());
                    }
                }
            }
            DataTable.Refresh();
        }
       
        private void fillTextBox()
        {
            SelectedProduct = CategoriesDL.GetProduct(categoryIdx, productIdx);
            comboBoxCategories.Text = CategoriesDL.Categories[categoryIdx].Category1;
            txtName.Text = SelectedProduct.Name;
            txtProductId.Text = SelectedProduct.Id;
            ComboBoxQuantity.Text = "1";
            txtPrice.Text = SelectedProduct.SalePrice.ToString();
            txtTotalPrice.Text = (SelectedProduct.SalePrice * double.Parse(ComboBoxQuantity.Text)).ToString();

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            cartProduct = new Product(SelectedProduct.Id, SelectedProduct.Name, SelectedProduct.SalePrice, int.Parse(ComboBoxQuantity.Text));
            int custIdx = CustomerDL.getCustomerIndex(ExtraDLClass.Customer);
            if (SelectedProduct.Stock > 1)
            {

                CustomerDL.Customers[custIdx].addProductinCart(cartProduct);
                SelectedProduct.Stock -= int.Parse(ComboBoxQuantity.Text);
                AdminDL.Admin.Profit = AdminDL.Admin.Profit + (SelectedProduct.SalePrice - SelectedProduct.ActualPrice);
                MessageBox.Show("Added in Cart Successfully!!!");
                CustomerDL.writeData();

            }
            else
            {
                MessageBox.Show("Error!!!\nNot Enough Stock");
            }
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
