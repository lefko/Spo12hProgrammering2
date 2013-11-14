using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h.Progr2.Slask
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        
        public User(string  firstName, string lastName, bool isActive)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IsActive = isActive;
        }

        public override string ToString()
        {
            string output;
            output = string.Format("First Name: {0}\n" +
                                   "LastName: {1}\n" +
                                   "User Active: {2}", FirstName, LastName, IsActive);
            return output;
        }
    }
}
