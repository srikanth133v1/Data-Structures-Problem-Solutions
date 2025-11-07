using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Stacks
{
    public class StackInvoker
    {
        public static void Invoke()
        {
            // Console.WriteLine(EvaluateExpression.Eval(new List<string>() { "4", "13", "5", "/", "+" }));
            //ReverseString.Reverse("abcd");

            // Console.WriteLine(SimplifyDirectoryPath.Eval(@"/"));
            //Console.WriteLine(RedundantBraces.Find("(a + (a + b))"));
            // Console.WriteLine(LargestRectangleInHistogram.Area(new List<int>() { 6, 2, 5, 4, 5, 1, 6 }));
            //Console.WriteLine(CheckBalancedParentheses.Check("({})"));

            Console.WriteLine(EvaluateExpression.CalHelper(new string[] { "5", "2","C", "D","+"}));
        }
    }
}
