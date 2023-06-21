using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureBank.Models
{
    public class Users
    {

        public int Id { get; set; } = 0;
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public Users(string fullName, string password, string email)
        {
            Id = Id++;
            FullName = fullName;
            Password = password;
            Email = email;
        }
       




    }

}
