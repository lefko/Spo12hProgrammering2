using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise3A
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 1;
            Console.Write("\nEnter a number: ");
            number = int.Parse(Console.ReadLine());
            while (number <= 0)
            {
                Console.WriteLine("Enter a valid number");
            }
                
            string partialOutput = "1";
            string output;

            for (int i = 2; i <= number; i++)
            {
                sum += i;
                
                partialOutput = partialOutput +  "+" + i ;
            }

            output = partialOutput + "=" + sum;

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
