using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SureBank
{
    public  class Validations
    {
        public static bool ValidateName(string name) 
        {
            Regex regex = new Regex(@"^[A-Z][a-zA-Z]*$");
            return regex.IsMatch(name);
        }

        public static bool ValidateEmail(string email) 
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
            return regex.IsMatch(email);
        }
        public static bool ValidatePassword(string password) 
        {
            Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            return regex.IsMatch(password);
        }
    }
}
