using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise2.Jonathan
{
    class Program
    {
        static AppartmentBooking booking = new AppartmentBooking();

        static void Main(string[] args)
        {
            bool done = false;
            


            DrawMenu();
            

            int choice = 0;

            while (choice != 4)
            {
                DrawChoicesMenu();

                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1: AddNewBooking();
                        break;
                    case 2:
                        Console.Write("Enter a name to find bookings: ");
                        string name = Console.ReadLine();
                        booking.GetBooking(name); 
                        break;
                    case 3: DisplayAllBookings();
                        break;
                    case 4:
                        choice = 4;
                        break;
                    default:
                        choice = 0;
                        break;
                }

      

        }

         
        }

        static void DrawMenu()
        {
            Console.WriteLine();
            Console.WriteLine("**********************************************");
            Console.WriteLine("************ Appartment Booking **************");
            Console.WriteLine("**********************************************");

            Console.WriteLine("\n");
        }

        static void DrawChoicesMenu()
        {
            Console.WriteLine("1. Make new Booking");
            Console.WriteLine("2. Find booking(s) by Person Name");
            Console.WriteLine("3. Display All Bookings");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("Enter Choice: ");
        }

        static void AddNewBooking()
        {
            Console.Write("Enter name of Guest: ");
            string name = Console.ReadLine();

            if (name == "list")
            {
                string[] bookings = booking.GetAllBookings();
                foreach (string stingbooking in bookings)
                {
                    Console.WriteLine(stingbooking);
                }
            }

            Console.Write("Enter Start Date: ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter End Date: ");
            DateTime end = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();


            bool isSuccess = booking.MakeBooking(start, end, name);

            if (isSuccess)
                Console.WriteLine(booking.ToString() + "\n");
            else
                Console.WriteLine("Requested dates not available \n");
        }

        static void DisplayAllBookings()
        {
            string[] allBookings = booking.GetAllBookings();
            var i = 0;
            foreach (string allBooking in allBookings)
            {
                Console.WriteLine(allBooking + "\n");
            }
        }
    }
}
