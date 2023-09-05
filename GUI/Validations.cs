using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSMSGUI.GUI
{
    public class Validations
    {
        public static bool IsValidUsername(string Username)
        {
            if (string.IsNullOrEmpty(Username))
            {
                return false;
            }
            if (Username.Length < 3 || Username.Length > 20)
            {
                return false;
            }
            if (!Regex.IsMatch(Username, "^[a-zA-Z]+$"))
            {
                return false;
            }
            return true;
        }
        public static bool IsValidPassword(string Password)
        {
            if (string.IsNullOrEmpty(Password))
            {
                return false;
            }
            if (Password.Length < 8 || Password.Length > 20)
            {
                return false;
            }
            if (!Regex.IsMatch(Password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$"))
            {
                return false;
            }
            return true;
        }
        public static bool IsValidPhoneNumber(string number)
        {
            if (double.TryParse(number, out _) && number.Length == 11)
            {
                return true;
            }
            return false;
        }
        public static bool IsValidCNIC(string number)
        {
            if (double.TryParse(number, out double x) && number.Length == 13)
            {
                return true;
            }

            return false;
        }
        public static bool isValidNumber(string number)
        {
            if(double.TryParse(number, out _))
            {
                return true;
            }
            return false;
        }
        public static bool isValidInteger(string number)
        {
            if (int.TryParse(number, out int i) && i>0)
            {
                return true;
            }
            return false;
        }

    }
}
