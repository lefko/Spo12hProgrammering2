using System;
using System.Collections.Generic;
using System.Linq;
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
            var listLoad = new ListLoader();

            DrawApp();

            GetInput();
        }

        static void DrawApp()
        {
            Console.WriteLine("\nEXERCISE 3");
            Console.WriteLine("-----------\n");
        }

        static int GetInput()
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
    }
}
