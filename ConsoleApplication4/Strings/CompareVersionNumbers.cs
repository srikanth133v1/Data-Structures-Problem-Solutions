using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Strings
{
    public class CompareVersionNumbers
    {
        public static int Compare(string a, string b)
        {
            #region Old
            //if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            //{
            //    return 0;
            //}
            //string[] aTokens = a.Split(new char[] { '.' }, StringSplitOptions.None);
            //string[] bTokens = b.Split(new char[] { '.' }, StringSplitOptions.None);

            //if (a == b)
            //{
            //    return 0;
            //}
            //int i = 0, j = 0;
            //while (i < aTokens.Length && j < bTokens.Length)
            //{
            //    string left = aTokens[i].Trim();
            //    string right = bTokens[j].Trim();


            //    int idxA = 0, idxB = 0;
            //    while (idxA < left.Length && left[idxA] == '0')
            //    {
            //        idxA++;
            //    }
            //    while (idxB < right.Length && right[idxB] == '0')
            //    {
            //        idxB++;
            //    }
            //    if ((left.Length - idxA) < (right.Length - idxB))
            //    {
            //        return -1;
            //    }
            //    else if ((left.Length - idxA) > (right.Length - idxB))
            //    {
            //        return 1;
            //    }
            //    while (idxA < left.Length && idxB < right.Length)
            //    {

            //        if (left[idxA] < right[idxB])
            //        {
            //            return -1;
            //        }
            //        if (left[idxA] > right[idxB])
            //        {
            //            return 1;
            //        }
            //        idxA++;
            //        idxB++;
            //        //if (aTokens[i][idxA] == bTokens[j][idxB])
            //        //{
            //        //    continue;
            //        //}
            //    }
            //    //Int64 left = Convert.ToInt64(aTokens[i]);
            //    //Int64 right = Convert.ToInt64(bTokens[j]);
            //    //Console.WriteLine(left + " " + right);
            //    i++;
            //    j++;
            //    if (idxA < left.Length && idxB == right.Length)
            //    {
            //        return 1;
            //    }
            //    if (idxB < left.Length && idxA == right.Length)
            //    {
            //        return -1;
            //    }
            //    if (left == right)
            //    {
            //        continue;
            //    }

            //}
            //if (i == aTokens.Length && j == bTokens.Length)
            //{
            //    return 0;
            //}
            //if (i < aTokens.Length && j == bTokens.Length)
            //{
            //    while (i < aTokens.Length)
            //    {
            //        int idxA = 0;
            //        string left = aTokens[i].Trim();

            //        while (idxA < left.Length && left[idxA] == '0')
            //        {
            //            idxA++;
            //        }
            //        if (idxA < left.Length)
            //        {
            //            return 1;
            //        }
            //        i++;
            //    }
            //    return 0;
            //}
            //if (j < bTokens.Length && i == aTokens.Length)
            //{
            //    while (j < bTokens.Length)
            //    {
            //        int idxA = 0;
            //        string right = bTokens[j].Trim();

            //        while (idxA < right.Length && right[idxA] == '0')
            //        {
            //            idxA++;
            //        }
            //        if (idxA < right.Length)
            //        {
            //            return -1;
            //        }
            //        j++;
            //    }
            //    return 0;
            //}
            //return 0;
            #endregion

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return 0;
            }
            string[] aTokens = a.Split(new char[] { '.' }, StringSplitOptions.None);
            string[] bTokens = b.Split(new char[] { '.' }, StringSplitOptions.None);

            if (a == b)
            {
                return 0;
            }
            int i = 0, j = 0;
            while (i < aTokens.Length && j < bTokens.Length)
            {
                string left = aTokens[i].Trim();
                string right = bTokens[j].Trim();


                int idxA = 0, idxB = 0;
                while (idxA < left.Length && left[idxA] == '0')
                {
                    idxA++;
                }
                while (idxB < right.Length && right[idxB] == '0')
                {
                    idxB++;
                }
                if ((left.Length - idxA) < (right.Length - idxB))
                {
                    return -1;
                }
                else if ((left.Length - idxA) > (right.Length - idxB))
                {
                    return 1;
                }
                while (idxA < left.Length && idxB < right.Length)
                {

                    if (left[idxA] < right[idxB])
                    {
                        return -1;
                    }
                    if (left[idxA] > right[idxB])
                    {
                        return 1;
                    }
                    idxA++;
                    idxB++;
                    //if (aTokens[i][idxA] == bTokens[j][idxB])
                    //{
                    //    continue;
                    //}
                }
                //Int64 left = Convert.ToInt64(aTokens[i]);
                //Int64 right = Convert.ToInt64(bTokens[j]);
                //Console.WriteLine(left + " " + right);
                i++;
                j++;
                if (idxA < left.Length && idxB == right.Length)
                {
                    return 1;
                }
                if (idxB < left.Length && idxA == right.Length)
                {
                    return -1;
                }
                if (left == right)
                {
                    continue;
                }

            }
            if (i == aTokens.Length && j == bTokens.Length)
            {
                return 0;
            }
            if (i < aTokens.Length && j == bTokens.Length)
            {
                while (i < aTokens.Length)
                {
                    int idxA = 0;
                    string left = aTokens[i].Trim();

                    while (idxA < left.Length && left[idxA] == '0')
                    {
                        idxA++;
                    }
                    if (idxA < left.Length)
                    {
                        return 1;
                    }
                    i++;
                }
                return 0;
            }
            if (j < bTokens.Length && i == aTokens.Length)
            {
                while (j < bTokens.Length)
                {
                    int idxA = 0;
                    string right = bTokens[j].Trim();

                    while (idxA < right.Length && right[idxA] == '0')
                    {
                        idxA++;
                    }
                    if (idxA < right.Length)
                    {
                        return -1;
                    }
                    j++;
                }
                return 0;
            }
            return 0;

        }
    }
}
