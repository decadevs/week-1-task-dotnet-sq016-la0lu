using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SureBank.Models;
using SureBank.User_Activity;
using static SureBank.Storage.StoreUserData;

namespace SureBank.Storage
{
    public class StoreUserData
    {
        public List<Users> UserList = new();
        public List<AccountInfos> _acc = new();


        public bool AddUsers(Users user)
        {    
            int initialUsersNo = UserList.Count;
            if (!UserList.Exists(X => X.Email == user.Email))
            {
                UserList.Add(user);
            }
            else
            {
                Console.WriteLine("user does not exist!");
            }
            return UserList.Count > initialUsersNo;
        }


        public Users? GetUsersByEmailAndPassword(string email, string password) 
        {
            return UserList.Find (X => X.Email == email && X.Password == password);
        }



    }
}
