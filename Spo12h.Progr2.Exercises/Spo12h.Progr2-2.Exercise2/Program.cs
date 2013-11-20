using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spo12h.Progr2_2.Exercise2.Classes;

namespace Spo12h.Progr2_2.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                CustomStack<int> intStack = new CustomStack<int>();
                CustomStack<string> strStack = new CustomStack<string>();

                intStack.Push(5);
                intStack.Push(10);

                strStack.Push("Hej");
                strStack.Push("Laban");

                Console.WriteLine("Peek the int Stack");
                Console.WriteLine(intStack.Peek());

                Console.WriteLine("Peek the string Stack");
                Console.WriteLine(strStack.Peek());

                Console.WriteLine("Int Pop");
                var intPop = intStack.Pop();
                Console.WriteLine(intPop);
                Console.WriteLine("Peek the int Stack");
                Console.WriteLine(intStack.Peek());

                Console.WriteLine("String Pop");
                var strPop = strStack.Pop();
                Console.WriteLine(strPop);
                Console.WriteLine("Peek the string Stack");
                Console.WriteLine(strStack.Peek());
            }
            catch (Exception)
            {
                
                throw new InvalidExpressionException();
            }

            Console.ReadLine();

        }
    }
}
