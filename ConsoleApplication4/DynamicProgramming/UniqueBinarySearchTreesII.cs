using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class UniqueBinarySearchTreesII
    {
        public static int Cal(int A)
        {
            return  FactorialByNum(2 * A, A+1) / ((A + 1) * Factorial(A));
        }
        public static int Factorial(int n)
        {
            int prod = 1;

            for (int i = 2; i <= n; i++)
            {
                prod *= i;
            }
            return prod;
        }
        public static int FactorialByNum(int n, int start)
        {
            int prod = 1;

            for (int i = start; i <= n; i++)
            {
                prod *= i;
            }
            return prod;
        }
        //unsigned long int binomialCoeff(unsigned int a, unsigned int k)
        //{
        //    unsigned long int result = 1;

            
        //    if (k > a - k)
        //        k = a - k;

            
        //    for (int i = 0; i < k; ++i)
        //    {
        //        result *= (a - i);
        //        result /= (i + 1);
        //    }

        //    return result;
        //}

    }
}
