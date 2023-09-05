using MSMSGUI.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMSGUI.DL
{
    public class ExtraDLClass
    {
        private static Customer customer;
        public static Customer Customer { get => customer; set => customer = value; }
        private static int Customeridx;
        public static int getCustomerIdx()
        {
            Customeridx = CustomerDL.getCustomerIndex(Customer);
            return Customeridx;
        }
    }
}
