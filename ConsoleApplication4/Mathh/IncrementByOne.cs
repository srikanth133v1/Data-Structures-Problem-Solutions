using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Mathh
{
    using System;
    using System.Linq;

    // Increment Integer By One

    // Write a method which takes a non-negative integer as input, increments it by one, and returns the result.
    // The input integer is represented by an array whose elements are digits of the integer. The output is represented likewise.

    // For example, the input for the integer 926 would look like an integer array represented as {9, 2, 6}.

    class IncrementInteger
    {
        static int[] IncrementByOne(int[] value)
        {
            if (value.Length == 0)
            {
                return value;
            }
            int temp = value[value.Length - 1] + 1;
            int carry = 1;
            //if(temp>9){
            //    carry = temp/10;
            //}
            //value[value.Length-1] = temp%10;
            for (var i = value.Length - 1; i >= 0; i--)
            {
                temp = value[i] + carry;
                carry = temp / 10;
                value[i] = temp % 10;
                //Console.WriteLine("carry: "+carry + " i: "+ i);
            }
            if (carry > 0)
            {
                int[] valueTemp = new int[value.Length + 1];
                valueTemp[0] = carry;
                for (var j = 0; j < value.Length; j++)
                {
                    valueTemp[j + 1] = value[j];
                }
                value = valueTemp;
            }
            return value;
        }

        //static void Main()
        //{
        //    int[] value = { 9, 2, 6 };
        //    //int[] value = {9, 9};
        //    //int[] value = {9};
        //    //int[] value = {0};
        //    //int[] value = {};
        //    //int[] value = {9,9,9,9,9,9,9,9,9,9,9,9,9,9,9};
        //    //{1,0}

        //    int[] incrementedValue = IncrementByOne(value);

        //    PrintInteger(incrementedValue);
        //}

        static void PrintInteger(int[] value)
        {
            foreach (int digit in value)
                Console.Write(digit);
        }
    }

}
