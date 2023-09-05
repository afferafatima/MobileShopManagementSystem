﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSMSGUI.GUI;
using MSMSGUI.GUI;
using MSMSGUI.GUI.Panels;

namespace MSMSGUI.GUI.Main
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

       

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            MainMenuRightPnl.Controls.Clear(); 
            MainMenuRightPnl.Controls.Add(signIn);
           
        }

       
        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            CustomerSignIn customerSignIn  = new CustomerSignIn();
            MainMenuRightPnl.Controls.Clear();
            MainMenuRightPnl.Controls.Add(customerSignIn);

        }
       
    }
}
