using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Problems
{
    public class BinaryStrings
    {
        private List<string> AllStr;
        public List<string> GenerateAll(string input)
        {
            AllStr = new List<string>();
            Build(input.ToArray<char>(), 0);
            return AllStr;
        }

        public void Build(char[] inputCh, int index)
        {
            if (index == inputCh.Length)
            {
                AllStr.Add(new string(inputCh));
                return;
            }
            if (inputCh[index] == '?')
            {
                inputCh[index] = '0';
                Build(inputCh.ToArray<char>(), index + 1);
                inputCh[index--] = '1';
                Build(inputCh.ToArray<char>(), index + 1);
            }
            else
            {
                Build(inputCh, index + 1);
            }
        }

    }
}
