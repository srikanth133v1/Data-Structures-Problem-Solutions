using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Queues
{
    public static class QueueInvoker
    {
        public static void Invoke()
        {
            //Console.WriteLine( FirstNonRepeatingChar.Build("aababbaccd"));
            Console.WriteLine(FirstNonRepeatingChar.Build("aaabbcdbbaac"));
        }
    }
}
