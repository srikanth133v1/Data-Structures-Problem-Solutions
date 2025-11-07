using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Hashing
{
    public class Fraction
    {
        public static string Cal(Int64 a, Int64 b)
        {
            Int64 A = (Int64)a, B = (Int64)b;
            if (A == 0 || B == 0)
            {
                return "0";
            }
            bool isNegative = false;
            if (A < 0 && B > 0)
            {
                isNegative = true;
                A = -A;

            }
            else if (A > 0 && B < 0)
            {
                isNegative = true;
                B = -B;

            }
            else if (A < 0 && B < 0)
            {
                A = -A;
                B = -B;
                /*if(A==Int32.MinValue){
                    A = Int32.MaxValue;
                }
                if(B==Int32.MinValue){
                    B = Int32.MaxValue;
                }*/

            }
            Int64 floor = A / B;
            Int64 reminder = A % B;
            Int64 prevReminder = 0;
            bool isRepeating = false;
            StringBuilder sb = new StringBuilder();
            sb.Append(floor);
            if (reminder == 0)
            {
                if (isNegative)
                {
                    sb.Insert(0, "-");
                }
                return sb.ToString();
            }
            sb.Append(".");
            Int64 num = (reminder * 10) / B;
            Dictionary<Int64, Int64> dictRem = new Dictionary<Int64, Int64>();
            List<Int64> idx = new List<Int64>();
            dictRem.Add(reminder, num);
            while (true)
            {
                ////Console.WriteLine("reminder before: " + reminder);
                prevReminder = reminder;
                reminder = reminder * 10;
                num = reminder / B;
                ////Console.WriteLine("num: " + num);
                ////Console.WriteLine("B: " + B);
                sb.Append(num);
                ////Console.WriteLine("sb: " + sb);
                reminder = reminder % B;
                // //Console.WriteLine("reminder after: " + reminder);
                if (reminder == 0)
                {
                    break;
                }

                if (dictRem.ContainsKey(reminder))
                {
                    isRepeating = true;
                    break;
                }
                dictRem.Add(reminder, num);
                idx.Add(reminder);
                // //Console.WriteLine(reminder);

            }
            //sb.Append(num);
            ////Console.WriteLine("as: " + sb.ToString() + "dic:" + dictRem.Count);
            if (isRepeating)
            {
                ////Console.WriteLine("b length"+ sb.Length);
                //Console.WriteLine("idx length"+ idx.Count);
                int remIdx = idx.IndexOf(reminder);
                int partialSuffix = idx.Count - remIdx;
                //Console.WriteLine("psuf"+partialSuffix);
                //Console.WriteLine("sb: " + sb);
                sb.Remove(sb.Length - partialSuffix, partialSuffix);
                dictRem = new Dictionary<Int64, Int64>();
                sb.Append("(");
                //reminder = prevReminder;
                //Console.WriteLine("rem: "+ reminder);
                while (true)
                {

                    reminder = reminder * 10;
                    num = reminder / B;
                    reminder = reminder % B;
                    if (dictRem.ContainsKey(reminder))
                    {
                        break;
                    }
                    dictRem.Add(reminder, num);
                    // //Console.WriteLine(reminder);
                    sb.Append(num);
                    //Console.WriteLine("sb: " + sb);
                }
                sb.Append(")");
            }
            if (isNegative)
            {
                sb.Insert(0, "-");
            }
            return sb.ToString();
        }
    }
}
