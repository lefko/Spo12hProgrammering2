using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise6
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        public User(string fName, string lName, string uName)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Username = uName;
        }
    }
}
