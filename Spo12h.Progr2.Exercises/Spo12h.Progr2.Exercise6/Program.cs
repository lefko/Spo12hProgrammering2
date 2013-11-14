using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var users = new UsersCatalog();

            Console.Write("Enter your Name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lName = Console.ReadLine();
            Console.Write("Enter desired Username: ");
            string uName = Console.ReadLine();

            users.AddUser(fName, lName, uName);

            logger.AddLoggEntry("User " + uName +  " created Succefully");
            
            

            List<string> allLogEntries = logger.GetLogg();

            foreach (string allLogEntry in allLogEntries)
            {
                Console.WriteLine(allLogEntry);
            }

            Console.ReadLine();

        }
    }
}
