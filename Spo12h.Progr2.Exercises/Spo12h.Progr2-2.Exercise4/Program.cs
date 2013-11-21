using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Spo12h.Progr2_2.Exercise4.Classes;

namespace Spo12h.Progr2_2.Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 30);

            var listLoad = new ListLoader();
            listLoad.Load();

            DrawApp();
            int minYear = GetInputMinYear();
            int maxYear = GetInputMaxYear();
            Console.WriteLine();

            var selection = from l in listLoad.list
                            where l.ReleaseYear >= minYear
                            where l.ReleaseYear <= maxYear
                            orderby l.ReleaseYear ascending
                            select new {l.ReleaseYear, l.Name};

            foreach (var languageData in selection)
            {
                Console.WriteLine("{0}\t{1}", languageData.ReleaseYear, languageData.Name);
            }

            Console.ReadLine();
        }

        
        static void DrawApp()
        {
            Console.WriteLine("\nEXERCISE 3");
            Console.WriteLine("-----------\n");
        }

        static int GetInputMinYear()
        {
            bool isRunning = true;

            int input = 0;
           
                while (isRunning)
                {
                    Console.Write("Enter a minimum Year: ");
                    try
                    {
                        input = int.Parse(Console.ReadLine());
                        isRunning = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter a valid year!!! \n");
                    }
                }
                return input;
        }

        static int GetInputMaxYear()
        {
            bool isRunning = true;

            int input = 0;

            while (isRunning)
            {
                Console.Write("Enter a maximum Year: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                    isRunning = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a valid year!!! \n");
                }
            }
            return input;
        }
    }
}
