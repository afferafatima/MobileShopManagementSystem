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
    public partial class CustomerPersonalInfo : UserControl
    {
        BL.Customer customer = ExtraDLClass.Customer;
        public CustomerPersonalInfo()
        {
            InitializeComponent();
            txtPhoneNumber.Text=customer.PhoneNumber;
            txtPassword.Text = customer.Password1;
            txtUsername.Text = customer.Name1;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCustomerPersonalInfo editCustomerPersonalInfo = new EditCustomerPersonalInfo();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(editCustomerPersonalInfo);
        }
    }
}
