using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class WaveArray
    {
        public static List<int> Arrange(List<int> input)
        {
            List<int> output = new List<int>();
            if (null == input || input.Count <= 1)
            {
                return input;
            }

            input.Sort();

            for (int i = 0; i < input.Count - 1; i += 2)
            {
                output.Add(input[i + 1]);
                output.Add(input[i]);
            }
            if (input.Count % 2 == 1)
            {
                output.Add(input[input.Count - 1]);
            }
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            return output;
        }
    }
}
