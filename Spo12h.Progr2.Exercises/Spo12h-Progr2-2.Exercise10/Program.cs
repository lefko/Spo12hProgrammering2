using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise10;

namespace Spo12h_Progr2_2.Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var languages = ListLoader.LoadLanguages();


            ExitProgram();
        }

        static void ExitProgram()
        {
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadLine();
        }
    }

    
}
