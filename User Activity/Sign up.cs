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
    public static class Sign_up 
    { 
        public static void SignupPrompt() 
        {
            Console.OutputEncoding = Encoding.UTF8;
            string sm = "\u263A";

            Console.Clear();
            Console.WriteLine("Thank you choosing to be a Sure Banker!\nKindly fill the following details");
            
            Console.WriteLine("\nFirst Name: ");
            string? firstname = Console.ReadLine();
            while (firstname == null || !Validations.ValidateName(firstname))
            {
                Console.Clear() ;
                Console.WriteLine("Invalid, begin name with capital letter\nFirst Name: ");
                firstname = Console.ReadLine();
            }

            Console.WriteLine("Last Name: ");
            string? lastname = Console.ReadLine();
            while (lastname == null || !Validations.ValidateName(lastname))
            {
                Console.Clear();
                Console.WriteLine("Invalid, please begin name with capital letter\nLast Name: ");
                lastname = Console.ReadLine();
            }
            
            //Email Validation
            Console.WriteLine("Email Address: ");
            string? email = Console.ReadLine();
            while (!Validations.ValidateEmail(email)) 
            {
                Console.Clear();
                Console.WriteLine("Please input a valid email\nEmail Address: ");
                email = Console.ReadLine();
            }

            Console.WriteLine("Password: ");
            string? password = Console.ReadLine();
            while (!Validations.ValidatePassword(password))
            {
                Console.Clear();
                Console.WriteLine("Password must consist of a minimum of 8 alphanumeric characters\nPassword: ");
                password = Console.ReadLine();
            }

            string FullName = firstname + " " + lastname;
            Users user = new(FullName, email, password);
            StoreUserData storeUserData = new StoreUserData();
            storeUserData.AddUsers(user);

            //if (!storeUserData.AddUsers(user)) 
            //{
            //    Console.WriteLine("Unrecognized user! try again.");
            //    SignupPrompt();
            //}

            Console.Clear();
            Console.WriteLine($"Congratulations {FullName}, you are now a SURE BANKER!");
            Console.WriteLine($"\t{sm} {sm} {sm} {sm} {sm} {sm} {sm} {sm} {sm} {sm} {sm} {sm} {sm}");
            Console.WriteLine("\npress 0 to see menu");
            int? enter = int.Parse(Console.ReadLine());
            if (enter == 0)
            {
                Console.Clear();
                CustomerMenu.DisplayCustomerMenu();
            }
            else
                Console.WriteLine("press 0 to see menu");
        }
    }
}
