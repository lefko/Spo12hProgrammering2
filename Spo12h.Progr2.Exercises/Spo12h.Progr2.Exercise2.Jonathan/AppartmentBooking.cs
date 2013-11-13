using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise2.Jonathan
{
    class AppartmentBooking
    {
        private class Booking
        {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Name { get; set; }
        }

        private Booking b;
        private List<Booking> bookingsList = new List<Booking>();
        private int count = 0;

        public List<string> GetBooking(string name)
        {
            List<string> personBookings = new List<string>();

            foreach (Booking booking in bookingsList)
            {

                if (booking.Name == name)
                {
                    var output = new StringBuilder();
                    output.AppendFormat("Name: {0}, Arrival Date: {1}, Departure Date: {2}", booking.Name, booking.StartDate, booking.EndDate);
                    personBookings.Add(output.ToString()); 
                }
            }

            return personBookings;
        }

        public bool MakeBooking(DateTime start, DateTime end, string name)
        {
            bool isSuccess = false;

            if (bookingsList.Count == 0)
            {
                isSuccess = true;
            }
            else
            {
                foreach (Booking booking in bookingsList)
                {

                    if ((start < booking.StartDate || start > booking.EndDate) &&
                             (end < booking.StartDate) || end > booking.EndDate)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                        break;
                    }
                }
            }

            if (isSuccess)
                AddNewBooking(start, end, name);

            return isSuccess;
        }

        private void AddNewBooking(DateTime start, DateTime end, string name)
        {
            this.b = new Booking { StartDate = start.Date, EndDate = end.Date, Name = name };
            bookingsList.Add(b);
        }

        public string[] GetAllBookings()
        {
            string[] bookings = new string[bookingsList.Count];
            var i = 0;
            foreach (Booking booking in bookingsList)
            {
                var output = new StringBuilder();
                output.AppendFormat("Name: {0}, Arrival Date: {1}, Departure Date: {2}", booking.Name, booking.StartDate, booking.EndDate);
                bookings[i] = output.ToString();
                i++;
            }

            return bookings;
        }


        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendFormat("Mr/Mrs {0} you have booked an apartment from {1} to {2}. Congratulations! \n", b.Name, b.StartDate, b.EndDate);
            output.AppendLine();

            return output.ToString();

        }
    }
}
