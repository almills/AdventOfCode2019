using System;
using System.Collections.Generic;
using System.Text;

namespace RocketEquation
{
    public static class FleetFuelCalculator
    {
        public static int Calculate(IEnumerable<int> masses)
        {
            int total = 0;

            foreach(int i in masses)
            {
                total += FuelCalculator.RequiredFuel(i);
            }

            return total;
        }
    }
}
