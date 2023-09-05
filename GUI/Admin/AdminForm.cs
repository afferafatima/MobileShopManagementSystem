using MSMSGUI.GUI.Admin;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            pnlRight.Visible = true;
            pnlLeft.BringToFront();
        }

      
        private void BtnPersonalInfo_Click(object sender, EventArgs e)
        {
            AdminPersonalInfo personalInfo=new AdminPersonalInfo();
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(personalInfo);
            pnlRight.BringToFront();
        }

      

        private void BtnEmployeesInfo_Click(object sender, EventArgs e)
        {
            AdminEmployees employeesInfo=new AdminEmployees();
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(employeesInfo);
            pnlRight.BringToFront();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            AdminProducts adminProducts=new AdminProducts();
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(adminProducts);
            pnlRight.BringToFront();
        }

        

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu=new MainMenu();
            this.Hide();
            mainMenu.Show();
            
        }

        private void BtnProfit_Click(object sender, EventArgs e)
        {
            Profit profit=new Profit();
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(profit);
            pnlRight.BringToFront();
        }

        private void btnSoldProducts_Click(object sender, EventArgs e)
        {
            SoldProducts soldProducts=new SoldProducts();
            pnlRight.Controls.Clear();  
            pnlRight.Controls.Add(soldProducts);
            pnlRight.BringToFront();

        }
    }
}
