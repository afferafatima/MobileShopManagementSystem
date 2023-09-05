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
    public partial class EditCustomerPersonalInfo : UserControl
    {
        BL.Customer Customer=ExtraDLClass.Customer;
        public EditCustomerPersonalInfo()
        {
            InitializeComponent();
            txtUsername.Text = Customer.Name1;
            txtPhoneNumber.Text = Customer.PhoneNumber;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomerPersonalInfo customerPersonalInfo = new CustomerPersonalInfo();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(customerPersonalInfo);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BL.Customer customer = ExtraDLClass.Customer;
            customer.Password1 = txtPassword.Text;
            customer.PhoneNumber = txtPhoneNumber.Text;
            CustomerDL.writeData();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(Validations.IsValidPassword( txtPassword.Text)&&Validations.isValidNumber(txtPhoneNumber.Text))
            {
                if(txtPassword.Text!=ExtraDLClass.Customer.Password1||txtPhoneNumber.Text!=ExtraDLClass.Customer.PhoneNumber)
                {
                    btnUpdate.Enabled = true;
                    return;
                }
            }
            btnUpdate.Enabled = false;

        }

       
    }
}
