using SureBank.User_Activity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SureBank.Models;

namespace SureBank.User_Bank_Interaction
{
    public class UserMenu
    {
        //LogIn login = new LogIn();
       // LogOut logout = new LogOut();
        //CustomerMenu customerMenu = new CustomerMenu();
        //CreateAccount createAccount = new CreateAccount();


        public static void DisplayUserMenu()
        { 
             Console.ForegroundColor = ConsoleColor.Blue;
           
      
            try
            {
                int UserOption = 0;

                while (UserOption < 1 || UserOption > 2)
                {

                    Console.WriteLine("******** SURE BANK AFRICA ********\n\t====================");
                    Console.WriteLine("  safe and secure banking for all  \n\t====================\n");
                    Console.WriteLine("1. LOGIN\n2. Don't have an account? SIGN UP");
                    UserOption = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

                if (UserOption == 1)
                {
                    Console.Clear();
                    LogIn.LoginPrompt();
                }
                else if (UserOption == 2)
                {
                    //Console.Clear();
                    Sign_up.SignupPrompt();
                    Console.Clear();
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Input is Invalid, Try again");
                DisplayUserMenu();
            }

           
        }
    }
}
