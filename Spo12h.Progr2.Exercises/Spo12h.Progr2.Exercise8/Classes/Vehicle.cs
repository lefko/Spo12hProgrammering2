using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise8.Classes
{
    abstract class Vehicle
    {
        private string vehicleType;

        public Vehicle()
        {
            
        }

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        
        virtual public string DescribeVehicle()
        {
            string output;

            output = string.Format("This vehicle is a {0}", vehicleType);

            return output;
        }
    }
}
