using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Strings
{
    class StrStr
    {
        public static int strStr(string B, string A)
        {


            if (string.IsNullOrEmpty(B))
            {
                return -1;
            }
            if (string.IsNullOrEmpty(A))
            {
                return -1;
            }

            int i = 0, j = 0;
            int startIndex = -1;
            bool isSequence = true;
            int tempJ = 0;
            while (j < B.Length)
            {
                if (A[i] == B[j])
                {
                    tempJ = j;
                    if (startIndex == -1)
                    {
                        startIndex = j;
                    }
                    while (i <= A.Length)
                    {
                        if (A[i] == B[tempJ])
                        {
                           // Console.WriteLine(A[i] + " " + B[tempJ]);
                            i++;
                            if (i == A.Length)
                            {
                                return startIndex;
                            }
                            tempJ++;
                            if (tempJ == B.Length)
                            {
                                i = 0;
                                j++;
                                startIndex = -1;
                                break;
                            }
                        }
                        else
                        {
                            j++;
                            i = 0;
                            startIndex = -1;
                            break;
                        }

                    }
                }
                else
                {
                    startIndex = -1;
                    j++;
                    i = 0;

                }
            }

            if (i < A.Length)
            {
                return -1;
            }
            return startIndex;

        }
    }

}
