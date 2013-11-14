using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Spo12h.Progr2.Exercise6
{
    public class UsersCatalog
    {
        
        private List<User> users = new List<User>();
 
        internal void AddUser(string firstName, string lastName, string userName)
        {
            User newUser = new User(firstName, lastName, userName);
            users.Add(newUser);
        }

        public List<User> GetUsers()
        {
           throw new NotImplementedException(); 
        }

        public bool AddNewUser(string firstName, string lastName, string userName)
        {
            var newUser = new User(firstName, lastName, userName);

            return true;
        }



    }
}
