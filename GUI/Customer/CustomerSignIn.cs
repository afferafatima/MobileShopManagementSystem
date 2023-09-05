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
    public partial class CustomerSignIn : UserControl
    {
        public CustomerSignIn()
        {
            InitializeComponent();
        }
        private void linlLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerSignUp customerSignUp = new CustomerSignUp();
            panel.Controls.Clear();
            panel.Controls.Add(customerSignUp); 
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            BL.Customer customer = new BL.Customer(txtUsername.Text,txtPassword.Text);
            int index = CustomerDL.getCustomerIndex(customer);
            if (index>-1)
            {
                ExtraDLClass.Customer = CustomerDL.GetCustomer(index);
                Main.Customer admin = new Main.Customer();
                Form form = FindForm();
                form.Hide();
                admin.Show();
            }
            else if(index==-1)
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
