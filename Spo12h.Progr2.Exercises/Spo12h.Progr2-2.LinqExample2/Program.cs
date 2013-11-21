using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2_2.LinqExample2
{
    class Program
    {
        class ShoppingCartLine
        {
            public string Product { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
        }
        static void Main(string[] args)
        {
            var cart = new List<ShoppingCartLine>
            {
                new ShoppingCartLine {Product = "Pillow", Price = 100, Quantity = 2},
                new ShoppingCartLine {Product = "Lamp", Price = 300, Quantity = 1},
                new ShoppingCartLine {Product = "Rug", Price = 200, Quantity = 3}
            };

            var totalsQuery = from line in cart
                         let lineTotal = line.Price * line.Quantity
                         orderby lineTotal
                         select new
                            {
                                Product = line.Product,
                                Total = lineTotal
                            };

            cart.Add(new ShoppingCartLine
            {
                Product = "Soap",
                Price = 20,
                Quantity = 5
            });

            foreach (var total in totalsQuery)
            {
                Console.WriteLine("You are spending {0} on {1}s", total.Total, total.Product);
            }

            Console.WriteLine("---------");

            cart.Add(new ShoppingCartLine
            {
                Product = "Candle", Price = 10, Quantity = 20
            });

            var totals = totalsQuery.ToList();
            foreach (var total in totals)
            {
                Console.WriteLine("You are spending {0} on {1}s", total.Total, total.Product);
            }

            int grandTotal = 0;
            foreach (var total in totals)
              grandTotal += total.Total;
            

            Console.WriteLine("TOTAL: {0}", grandTotal);

            Console.ReadLine();

        }
    }
}
