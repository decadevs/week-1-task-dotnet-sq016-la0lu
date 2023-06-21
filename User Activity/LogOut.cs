using SureBank.User_Bank_Interaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureBank.User_Activity
{
    public static class LogOut
    {
        //LogIn login = new LogIn();
        //LogOut logout = new LogOut();
        public static void Exit()
        {
            Console.WriteLine("Bye For Now!\n\n\n");
            Console.WriteLine("************************************");
            Console.WriteLine("\n\n\n Press 0 to log in again");
            int pressZero = int.Parse(Console.ReadLine());
            if (pressZero == 0)
            {
                Console.Clear();
                UserMenu.DisplayUserMenu();
            }
        }
    }
}
