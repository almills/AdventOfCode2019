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
            var input = File.ReadAllLines("input.txt");
            var ints = input.Select(n => Convert.ToInt32(n)).ToArray();

            var result = FleetFuelCalculator.Calculate(ints);
        }
    }
}
