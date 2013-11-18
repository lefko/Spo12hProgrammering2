using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spo12h.Progr2.Exercise8.Classes;

namespace Spo12h.Progr2.Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData vehicleData = new VehicleData();

            Car car1 = new Car();
            Boat boat1 = new Boat();

            vehicleData.PrintVehicle(car1);
            vehicleData.PrintVehicle(boat1);

            Console.ReadLine();
        }
    }
}
