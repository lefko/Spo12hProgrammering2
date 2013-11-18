using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise8.Classes
{
    class Boat : Vehicle
    {
        private bool hasEngine;

        public Boat() : base("Boat")
        {
            hasEngine = false;
        }

        public Boat(bool hasEngine) : base("Boat")
        {
            this.hasEngine = hasEngine;
        }

        public void AddEngine()
        {
            hasEngine = true;
        }

        public void RemoveEngine()
        {
            hasEngine = false;
        }

        public override string DescribeVehicle()
        {
            string engineStatus;
            if (hasEngine)
                engineStatus = "It has an engine.";
            else
                engineStatus = "It does not have an egnine.";

            string output = string.Format("This is a boat. {0}", engineStatus);

            return output;
        }
    }
}
