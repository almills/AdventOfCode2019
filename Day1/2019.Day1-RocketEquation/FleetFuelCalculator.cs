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

        public static int CaluclateWithFuel(IEnumerable<int> masses)
        {
            var fleetFuel = 0;
            foreach (int i in masses)
            {
                int fuel = FuelCalculator.RequiredFuel(i);
                int totalFuel = 0;
                while (fuel > 0)
                {
                    totalFuel += fuel;
                    fuel = FuelCalculator.RequiredFuel(fuel);
                }
                fleetFuel += totalFuel;
            }
            

            return fleetFuel;
        }
    }
}
