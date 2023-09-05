using Guna.UI2.WinForms;
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
using System.Web.UI;
using System.Windows.Forms;

namespace MSMSGUI.GUI.Panels
{
    public partial class AdminProducts : System.Windows.Forms.UserControl
    {
        int categoryIdx = -1;
        int productIdx = -1;
        public AdminProducts()
        {
            InitializeComponent();
            timer.Enabled = true;
            InitializeDataTable();
            dataBinding();

        }
        private void EnableButtons(bool add, bool edit, bool delete, bool print, bool save, bool update)
        {
            btnAdd.Enabled = add;
            btnDelete.Enabled = delete;
            btnEdit.Enabled = edit;
            btnSave.Enabled = save;
            btnPrint.Enabled = print;
            btnUpdate.Enabled = update;
        }
        private void VisibleButtons(bool add, bool edit, bool delete, bool print, bool save, bool cancel, bool update)
        {
            btnAdd.Visible = add;
            btnDelete.Visible = delete;
            btnEdit.Visible = edit;
            btnSave.Visible = save;
            btnPrint.Visible = print;
            btnCancel.Visible = cancel;
            btnUpdate.Visible = update;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            categoryIdx = CategoriesDL.getCategoryIndex(txtCategory.Text);
            if (categoryIdx > -1)
            {
                productIdx = CategoriesDL.getProductIndex(categoryIdx, txtProductId.Text);
                if (productIdx > -1)
                {
                    Product product = CategoriesDL.GetProduct(categoryIdx, productIdx);
                    txtName.Text = product.Name;
                    txtQuantity.Text = product.Stock.ToString();
                    txtSalePrice.Text = product.SalePrice.ToString();
                    txtActualPrice.Text = product.ActualPrice.ToString();
                    EnableButtons(false, true, true, true, true, false);
                }
                else
                {
                    if (validInputs())
                    {
                        EnableButtons(true, false, false, true, true, false);
                    }
                    else
                    {
                        EnableButtons(false, false, false, true, true, false);
                    }
                }
            }
            else
            {
                if (validInputs())
                {
                    EnableButtons(true, false, false, true, true, false);
                }
                else
                {
                    EnableButtons(false, false, false, true, true, false);
                }
            }

        }

        private bool validInputs()
        {
            if (Validations.isValidInteger(txtQuantity.Text) && Validations.isValidNumber(txtActualPrice.Text) && Validations.isValidNumber(txtSalePrice.Text))
            {
                if (double.Parse(txtActualPrice.Text) <double.Parse(txtSalePrice.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!Validations.isValidInteger(txtQuantity.Text))
            {
                errorProvider.SetError(txtQuantity, "Enter only integer value");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtActualPrice_TextChanged(object sender, EventArgs e)
        {
            if (!Validations.isValidNumber(txtActualPrice.Text))
            {
                errorProvider.SetError(txtActualPrice, "Enter Valid Numeric Value... ");

            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtSalePrice_TextChanged(object sender, EventArgs e)
        {
            if (!Validations.isValidNumber(txtSalePrice.Text))
            {
                errorProvider.SetError(txtSalePrice, "Enter Valid Numeric Value... ");

            }
            else
            {
                errorProvider.Clear();
            }
        }

      
        private Product GetProduct()
        {
            Product product = new Product(txtProductId.Text, txtName.Text, double.Parse(txtActualPrice.Text), double.Parse(txtSalePrice.Text), int.Parse(txtQuantity.Text));
            return product;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = GetProduct();
            if (categoryIdx == -1)
            {
                List<Product> products = new List<Product> { product };
                Category category = new Category(txtCategory.Text, products);
                CategoriesDL.addCategory(category);
                MessageBox.Show("New Category Added Successfully");
            }
            else if (categoryIdx > -1)
            {
                CategoriesDL.AddProduct(categoryIdx, product);
                MessageBox.Show("New Product added successfully");
            }
            dataBinding();
            clearTextbox();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            VisibleButtons(false, false, false, false, false, true, true);
            EnableButtons(false, false, false, false, false, false);
            btnCancel.Enabled = true;
            timer.Enabled = false;
            UpdateTimer.Enabled = true;
            txtCategory.Enabled = true;
            txtProductId.Enabled = true;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CategoriesDL.DeleteProduct(categoryIdx,productIdx);
            MessageBox.Show("Deleted Successfully");
            clearTextbox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            VisibleButtons(true,true,true,true,true,false,false);
            EnableButtons(false,true,true,true,true,false);
            timer.Enabled = true;
            UpdateTimer.Enabled= false;
            txtCategory.Enabled = false;
            txtProductId.Enabled = false;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            Product product = CategoriesDL.GetProduct(categoryIdx, productIdx);
            if(validInputs()&&(txtActualPrice.Text!=product.ActualPrice.ToString()||txtSalePrice.Text!=product.SalePrice.ToString()||txtQuantity.Text!=product.Stock.ToString()))
            {
                btnUpdate.Enabled = true; btnCancel.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled=false; 
            }

        }
        private void clearTextbox()
        {
            txtCategory.Text = null;
            txtName.Text = null;
            txtProductId.Text= null;
            txtQuantity.Text= null;
            txtSalePrice.Text= null;
            txtActualPrice.Text= null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            for(int i=0; i < CategoriesDL.Categories.Count;i++)
            {
                MessageBox.Show(CategoriesDL.Categories[i].Category1.ToString());
                for(int j=0;j< CategoriesDL.Categories[i].Products.Count;j++)
                {
                    MessageBox.Show(CategoriesDL.Categories[i].Products[j].toString());
                }
            }
            CategoriesDL.writeData();
            MessageBox.Show(CategoriesDL.Categories[0].Products[0].toString());
            MessageBox.Show("Now you won't loss your data!!!");

        }
        private void InitializeDataTable()
        {
            // Column headers for the DataTable
            string[] columnHeaders = { "Category", "Product ID", "Name", "Stock", "Actual Price" , "Sale Price" };
            // Add columns using a loop

            foreach (var columnHeader in columnHeaders)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = columnHeader;
                DataGrid.Columns.Add(col);
            }
        }
        private void dataBinding()
        {
            DataGrid.DataSource = null;
            DataGrid.Rows.Clear();
            foreach (Category category in CategoriesDL.Categories)
            {
                foreach (Product product in category.Products)
                {
                    DataGrid.Rows.Add(category.Category1,product.Id,product.Name,product.Stock,product.ActualPrice,product.SalePrice);
                }
            }
            DataGrid.Refresh();
        }
        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryIdx = DataGrid.CurrentRow.Index;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow =DataGrid.Rows[e.RowIndex];
                // Retrieve the value of the clicked cell
                string category = clickedRow.Cells[0].Value?.ToString();
                string ProductID = clickedRow.Cells[1].Value?.ToString();
                txtCategory.Text = category;
                txtProductId.Text = ProductID;
                categoryIdx=CategoriesDL.getCategoryIndex(category);
                productIdx = CategoriesDL.getProductIndex(categoryIdx,ProductID);
                fillTextBox();
            }
        }
        private void fillTextBox()
        {
            Product product = CategoriesDL.GetProduct(categoryIdx, productIdx);
            
            txtCategory.Text = CategoriesDL.Categories[categoryIdx].Category1;
            txtName.Text = product.Name;
            txtProductId.Text = product.Id;
            txtQuantity.Text = product.Stock.ToString();
            txtSalePrice.Text = product.SalePrice.ToString();
            txtActualPrice.Text = product.ActualPrice.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validInputs())
            {
                Product product= new Product(txtProductId.Text,txtName.Text,double.Parse(txtActualPrice.Text), double.Parse(txtSalePrice.Text),int.Parse(txtQuantity.Text));
                 CategoriesDL.UpdateProduct(categoryIdx,productIdx,product);
                 MessageBox.Show("Update Successfully");
                 VisibleButtons(true, true, true, true, true, false, false);
                 TextBoxClear();
                 dataBinding();
            }
            timer.Enabled = true;
            UpdateTimer.Enabled = false;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        private void TextBoxClear()
        {
            txtCategory.Text = null; txtName.Text=null; txtProductId.Text = null;
            txtQuantity.Text=null;
            txtSalePrice.Text = null;
            txtActualPrice.Text = null;
        }
    }
}
