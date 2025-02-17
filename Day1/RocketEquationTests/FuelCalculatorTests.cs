using FluentAssertions;
using RocketEquation;
using System.Collections.Generic;
using Xunit;

namespace RocketEquationTests
{
    public class FuelCalculatorTests
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void Test1(int mass, int fuel)
        {
            var actual = FuelCalculator.RequiredFuel(mass);

            actual.Should().Be(fuel, because: "that is how much fuel we need to take off");
        }

        [Theory]
        [InlineData(1969, 966)]
        [InlineData(14, 2)]
        [InlineData(100756, 50346)]
        public void Test2(int mass, int expectedFuel)
        {
            var input = new List<int>() { mass };
            var acutal = FleetFuelCalculator.CaluclateWithFuel(input);

            acutal.Should().Be(expectedFuel, because: "that is how much fuel we need to take off");
        }
    }
}
