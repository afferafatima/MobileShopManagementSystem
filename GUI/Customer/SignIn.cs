using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSMSGUI.DL;
using MSMSGUI.GUI.Main;
using MainMenu = MSMSGUI.GUI.Main.MainMenu;

namespace MSMSGUI.GUI.Panels
{
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text==AdminDL.Admin.Name1 && txtPassword.Text==AdminDL.Admin.Password1)
            {
                AdminForm admin= new AdminForm();
                Form form = FindForm();
                form.Hide();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void ToggleSwitchViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ToggleSwitchViewPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblViewPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
