using System;
using System.IO;
using Day3;
using FluentAssertions;
using Xunit;

namespace Day3.UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("R75,D30,R83,U83,L12,D49,R71,U7,L72", "U62,R66,U55,R34,D71,R55,D58,R83", 159)]
        [InlineData("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51", "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7", 135)]
        public void Test1(string wire1, string wire2, int expectedDistance)
        {
            var actualDistance = ManhattanDistance.Calculate(wire1, wire2);

            actualDistance.Should().Be(expectedDistance, because: "It should");
        }

        [Fact]
        public void Test2()
        {
            var input = File.ReadAllLines("input.txt");

            var actualDistance = ManhattanDistance.Calculate(input[0], input[1]);

            actualDistance.Should().Be(0, because: "It should");
        }
    }
}
