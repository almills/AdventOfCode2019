using System;
using System.Linq;

namespace ProgramAlarm
{
    public static class Intcode
    {
        public static string Run(string input)
        {
            int[] values = input.Split(new char[',']).Select(s => int.Parse(s)).ToArray();

            return string.Join(',', values);
        }
    }
}
