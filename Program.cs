using MSMSGUI.DL;
using MSMSGUI.GUI.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMSGUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EmployeeDL.readData();

            MSMSGUI.DL.AdminDL.readData();
            CategoriesDL.readData();
            CustomerDL.readData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
        }
    }
}
