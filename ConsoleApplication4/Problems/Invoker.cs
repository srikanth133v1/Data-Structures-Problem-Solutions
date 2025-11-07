using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Problems
{
    public class Invoker
    {
        public static void Invoke()
        {
           var res = new BinaryStrings().GenerateAll("1??0?101");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
