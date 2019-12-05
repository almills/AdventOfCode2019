using System;

namespace RocketEquation
{
    public static class FuelCalculator
    {
        public static int RequiredFuel(int mass)
        {
            var step1 = Math.Floor((double) mass / 3);
            var step2 = step1 - 2;

            return (int)step2;
        }
    }
}
