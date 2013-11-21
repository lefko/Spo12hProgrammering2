using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2_2.LinqExample
{
    class Program
    {
        public class City
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public int Population { get; set; }

            public City(string name, string country, int population)
            {
                this.Name = name;
                this.Country = country;
                this.Population = population;
            }
        }
        static void Main(string[] args)
        {
            var cities = new List<City>
            {
                new City("Helsingborg", "Sweden", 20000),
                new City("Kiev", "Ukraine", 200000),
                new City("Prague", "Czech Republic", 1000000),
                new City("Tokyo", "Japan", 35000000)
            };

            // Declarative coding(functional programming). We say what we want not how to do it.
            var largeCities = from city in cities
                                       where city.Population > 1000000
                                       where city.Country == "Japan"
                                       select city.Name;

            foreach (var city in largeCities)
            {
                Console.WriteLine(city);
            }

            

            Console.ReadLine();
        }
    }
}
