using MSMSGUI.GUI.Customer;
using MSMSGUI.GUI.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMSGUI.GUI.Main
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();

        }

        private void BtnPersonalInfo_Click(object sender, EventArgs e)
        {
            CustomerPersonalInfo customerPersonalInfo = new CustomerPersonalInfo();
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(customerPersonalInfo);
            pnlRight.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            CustomerProducts customerProducts = new CustomerProducts(); 
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(customerProducts);
            pnlRight.BringToFront();
        }

        private void BtnCart_Click(object sender, EventArgs e)
        {
            CustomerCart customerCart = new CustomerCart();
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(customerCart);
            pnlRight.BringToFront();
        }

        private void BtnBestSelling_Click(object sender, EventArgs e)
        {
            BestSellingProducts bestSellingProducts = new BestSellingProducts();
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(bestSellingProducts);
            pnlRight.BringToFront();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            CustomerHistory customerHistory = new CustomerHistory();    
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(customerHistory);
            pnlRight.BringToFront();
        }
    }
}
