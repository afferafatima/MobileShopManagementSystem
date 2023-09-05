using MSMSGUI.BL;
using MSMSGUI.DL;
using MSMSGUI.GUI.Main;
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
    public partial class CustomerSignUp : UserControl
    {
        public CustomerSignUp()
        {
            InitializeComponent();
        }
        private void LinkLblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerSignIn customerSignIn = new CustomerSignIn();
            Panel.Controls.Clear();
            Panel.Controls.Add(customerSignIn);
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            BL.Customer customer =new BL.Customer(txtUsername.Text,txtPassword.Text,txtPhoneNumber.Text);

            CustomerDL.addCustomer(customer);
            CustomerDL.writeData();
            List<BL.Customer> customers = CustomerDL.Customers;
            for (int i = 0; i < customers.Count; i++)
            {
                if (i == customers.Count - 1)
                {
                    MessageBox.Show(customers[i].toString());
                }
                else
                {
                    MessageBox.Show(customers[i].toString());
                }
            }
            MessageBox.Show("Sucessfully SignedUp");
            CustomerSignIn customerSignIn = new CustomerSignIn();
            Panel.Controls.Clear();
            Panel.Controls.Add(customerSignIn);
        }
        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
