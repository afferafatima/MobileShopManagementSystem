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

namespace MSMSGUI.GUI.Admin
{
    public partial class Profit : UserControl
    {
        public Profit()
        {
            InitializeComponent();
            txtProfit.Text=AdminDL.Admin.Profit.ToString()+" RS.";
        }
    }
}
