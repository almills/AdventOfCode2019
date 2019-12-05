using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using RocketEquation;
using System.IO;
using System.Linq;

namespace RocketEquationTests
{
    public class FleetFuelCalculatorTests
    {
        [Fact]
        public void Test1()
        {
            var result = FleetFuelCalculator.Calculate(GetInput());
        }

        [Fact]
        public void Test2()
        {
            var result = FleetFuelCalculator.CaluclateWithFuel(GetInput());
        }


        private IEnumerable<int> GetInput()
        {
            var input = File.ReadAllLines("input.txt");
            return input.Select(n => Convert.ToInt32(n)).ToArray();
        }
    }
}
