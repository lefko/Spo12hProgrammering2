using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Spo12h.Progr2_2.Exercise3.Classes;

namespace Spo12h.Progr2_2.Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ListLoader listLoader = new ListLoader();

            listLoader.Loader();

            DrawApp();
            string searchTerm = GetInput();

            IEnumerable<string> searchResult = ExecuteSearch(listLoader, searchTerm);
           
            PrintResult(searchResult);

            Console.ReadLine();
        }

        static void DrawApp()
        {
            Console.WriteLine("\nEXERCISE 3");
            Console.WriteLine("-----------\n");
        }

        static string GetInput()
        {
            Console.Write("Enter a search term: ");
            string input = Console.ReadLine();

            return input;
        }

        static IEnumerable<string> ExecuteSearch(ListLoader list, string searchTerm)
        {
            searchTerm = searchTerm.ToLower();
            return  from l in list.languageList
                    where l.ToLower().Contains(searchTerm)
                    select l;

            //return searchResult;

        }

        static void PrintResult(IEnumerable<string> results)
        {
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
