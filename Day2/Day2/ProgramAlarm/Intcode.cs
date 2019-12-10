using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramAlarm
{
    public static class Intcode
    {
        private static readonly int MAGIC_NUMBER = 19690720;

        public static int Run(IList<int> output, int noun, int verb)
        {
            output[1] = noun;
            output[2] = verb;

            for (int i = 0; i < output.Count; i += 4)
            {           
                switch (output[i])
                {
                    case 99:
                        return output[0];
                    case 1:
                        var posToUpdate = output[i + 3];
                        var a = output[i + 1];
                        var b = output[i + 2];
                        output[posToUpdate] = output[a] + output[b];
                        break;
                    case 2:
                        posToUpdate = output[i + 3];
                        a = output[i + 1];
                        b = output[i + 2];
                        output[posToUpdate] = output[a] * output[b];
                        break;
                }
            }

            return output[0];
        }

        public static int Run(string input, int noun, int verb)
        {
            int[] values = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            return Run(values, noun, verb);
        }


        public static int DumbRun(string input)
        {
            for (int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    var result = Run(input, i, j);

                    if(result == MAGIC_NUMBER)
                    {
                        return 100 * i + j;
                    }
                }
            }

            return 0;
        }
    }
}
