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
    public partial class EditAdminPersonalInfo : UserControl
    {
        public EditAdminPersonalInfo()
        {
            InitializeComponent();
            btnCancel.Enabled = true;
            timer.Enabled = true;
            txtUsername.Text = AdminDL.Admin.Name1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
                   
            if(Validations.IsValidUsername(txtUsername.Text)&& Validations.IsValidPassword(txtPassword.Text))
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                    btnUpdate.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            AdminPersonalInfo adminPersonalInfo = new AdminPersonalInfo();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(adminPersonalInfo);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BL.Admin admin =new BL.Admin(txtUsername.Text,txtPassword.Text);
            AdminDL.Admin = admin;
            AdminDL.writeData();
            MessageBox.Show("Updated Successfully");
            AdminPersonalInfo adminPersonalInfo=new AdminPersonalInfo();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(adminPersonalInfo);
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!Validations.IsValidUsername(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Username Can not be Empty\nUsername only consist of alphabets\nUsername length must be greater that 8 and less than 20\n Username must contain at least one lowercase letter, one uppercase letter...");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
                if (!Validations.IsValidPassword(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "Password cannot be empty\nPassword length must be greater that 8 and less than 20\nPassword must contain at least one lowercase letter, one uppercase letter, and one digit");
                }
                else
                {
                    errorProvider1.Clear();
                }
            
        }
    }
}
