using SureBank.User_Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SureBank.User_Bank_Interaction
{
    public static class CustomerMenu
    {


        private static string[] options;
         static CustomerMenu()
        {
            options = new string[]
           {
                "Create an Account",
                "Deposit Funds",
                "Withdraw Funds",
                "Transfer Funds",
                "Check Balance",
                "Exit"

           };
        }
        public static void DisplayCustomerMenu()
        {
            Console.WriteLine(" what do you want to do today?\n");

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{1 + i}. {options[i]}");
            }

            Console.WriteLine("\nselect an option ");
            int option = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 1:
                    CustomerMenu.SelectAccountOption(option);
                    break;
                case 2:
                    CustomerMenu.SelectAccountOption(option);
                    break;
                case 6:
                    LogOut.Exit();
                    break;

            }
        }

        public static void SelectAccountOption(int option)
        {
            //CreateAccount createAccount = new CreateAccount();

            do
            {
                Console.WriteLine("********Choose the account type********");
                Console.WriteLine("1. Savings Account\n2. Current Account");
                int accounttype = int.Parse(Console.ReadLine());

                if (accounttype == 1)
                {
                    Console.Clear();
                    CreateAccount.CreateSavings();
                    //Console.W
                }
                else if (accounttype == 2)
                {
                    Console.Clear();
                    CreateAccount.CreateCurrent();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try again");
                    CustomerMenu.SelectAccountOption(option);
                }
            }
            while (option < 1 || option > 2);
        }
    }    
}
