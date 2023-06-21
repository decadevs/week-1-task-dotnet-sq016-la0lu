using SureBank.Models;
using SureBank.Storage;
using SureBank.User_Bank_Interaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureBank.User_Activity
{
    public  class LogIn
    {
        //User Log in function
        public static void LoginPrompt() 
        {
            Console.OutputEncoding = Encoding.UTF8;
            string sm = "\u263A";

            Console.Clear();
            Console.WriteLine($"Hi, Sure Banker!{sm} Input your email address and password to Log in.");
            Console.WriteLine("\nEmail address? ");
            string? email = Console.ReadLine();
            while (!Validations.ValidateEmail(email)) 
            {
                Console.Clear();
                Console.WriteLine("Invalid Email, Try again!\nEmail address? ");
                email = Console.ReadLine();
            }

            Console.WriteLine("\nPassword? ");
            string? password = Console.ReadLine();
            while (!Validations.ValidatePassword(password))
            {
                Console.Clear();
                Console.WriteLine("invalid password\npassword? ");
                password = Console.ReadLine();
            }
            Users user = new("", email, password);
            StoreUserData storeUser = new StoreUserData();
            storeUser.GetUsersByEmailAndPassword(email, password);
            
            Console.Clear();
            Console.WriteLine($"Hello Sure Banker {sm}, Welcome Back");
            CustomerMenu.DisplayCustomerMenu();
           
        }
    }
}
