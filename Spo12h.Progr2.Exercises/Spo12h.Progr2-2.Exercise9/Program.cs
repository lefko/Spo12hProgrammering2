using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2_2.Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create new calculator instance
            var calc = new Calculator();
            // Define the logic through a lambda expression
            calc.CalcLogic = (a, b) => a + b;
            // This should PRINT the number 15 to the console
            calc.PrintCalculation(12, 3);

            //Product
            //calc.CalcLogic = (a, b) => a*b;


            // Create a delegate called CalcDelegate that returns a double and takes
            // two arguments. Both of these arguments should be of type double as well.

        }
        
    }
}
