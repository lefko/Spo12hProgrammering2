using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise8.Classes
{
    class Car : Vehicle
    {
        private bool engineIsRunning;

        public Car() : base ("Car")
        {
            engineIsRunning = true;
        }

        public void StartEngine()
        {
            engineIsRunning = true;
        }

        public void StopEngine()
        {
            engineIsRunning = false;
        }

        public override string DescribeVehicle()
        {
            string output;

            string engineStatus;

            if (engineIsRunning)
                engineStatus = "The engine is running....You are ready to rob the bank";
            else
                engineStatus = "The engine is not running... You are probably going to jail";

            output = string.Format("This is a Car. {0}", engineStatus);

            return output;
        }
    }
}
