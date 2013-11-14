using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Slask
{
    class Program
    {
        static void Main(string[] args)
        {

            // TODO: 1. Skapa en lista med users
            // TODO: 2. Lägg några users i listan
            // TODO: 3. Skriv ut users på skärmen

            var users = new List<User>();


            users.Add(new User("Andreas", "Lefkopoulos", true));
            users.Add(new User("Dag", "", true));
            users.Add(new User("Anna", "", false));

            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
                Console.WriteLine();
            }

            Console.ReadLine();
        }

       
    }
}
