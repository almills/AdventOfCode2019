using FluentAssertions;
using ProgramAlarm;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1,0,0,0,99", "2,0,0,0,99")]
        [InlineData("2,3,0,3,99", "2,3,0,6,99")]
        [InlineData("2,4,4,5,99,0", "2,4,4,5,99,9801")]
        [InlineData("1,1,1,4,99,5,6,0,99", "30,1,1,4,2,5,6,0,99")]
        public void Test1(string input, string output)
        {
            var actual = Intcode.Run(input);

            actual.Should().Be(output, because: "we needed to have converted it correctly to use the moons gravity");
        }
    }
}
