using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Sessions.Jonathan2
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, int>();
            products.Add("cucumber", 20);
            products.Add("apple", 10);
            products.Add("milk", 15);
            products.Add("coffee", 20);


            Console.Write("Cashier name: ");
            var cashier = Console.ReadLine();

            var r = new Receipt(cashier);
            while (true)
            {
                var scanned = Console.ReadLine();
                if (scanned == "done")
                    break;
                if (products.ContainsKey(scanned))
                {
                    r.AddItem(scanned, products[scanned]);
                }
                else
                {
                    Console.WriteLine("No, that doesn´t exist");
                }
            }

            Console.WriteLine(r.ToString());

            Console.ReadLine();
        }
    }
}
