using System;
using System.Linq;

namespace ProgramAlarm
{
    public static class Intcode
    {
        public static string Run(string input)
        {
            int[] values = input.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            for(int i = 0; i < values.Length; i += 4)
            {
                switch(values[i])
                {
                    case 1:
                        var posToUpdate = values[i + 3];
                        var a = values[i + 1];
                        var b = values[i + 2];
                        values[posToUpdate] = values[a] + values[b];
                        break;
                    case 2:
                        posToUpdate = values[i + 3];
                        a = values[i + 1];
                        b = values[i + 2];
                        values[posToUpdate] = values[a] * values[b];
                        break;
                    case 99:
                        string.Join(',', values);
                        break;
                }   
            }

            return string.Join(',', values);
        }
    }
}
