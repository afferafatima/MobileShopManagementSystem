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
    public partial class AdminPersonalInfo : UserControl
    {
        public AdminPersonalInfo()
        {
            InitializeComponent();
            txtUsername.Text = MSMSGUI.DL.AdminDL.Admin.Name1;
            txtPassword.Text = MSMSGUI.DL.AdminDL.Admin.Password1;
        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {

            EditAdminPersonalInfo editAdminPersonalInfo = new EditAdminPersonalInfo();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(editAdminPersonalInfo);
        }

        private void ToggleSwitchViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitchViewPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        
    }
}
