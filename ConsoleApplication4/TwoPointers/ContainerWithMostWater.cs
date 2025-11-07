using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.TwoPointers
{
    public class ContainerWithMostWater
    {
        public static int Find(List<int> A)
        {
            if (null == A || A.Count <= 1)
            {
                return 0;
            }

            int left = 0, right = A.Count - 1;
            int maxArea = 0;
            while (left < right)
            {
                maxArea = Math.Max(maxArea, Math.Min(A[left], A[right]) * Math.Abs(right - left));

                if (A[left] < A[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
        public static int maxArea(List<int> height)
        {

            if (height == null || height.Count < 2)
            {

                return 0;

            }

            int maxArea = 0;



            int left = 0;

            int right = height.Count - 1;

            // two pointers scan from two sides to middle

            while (left < right)
            {

                int area = Math.Min(height[left], height[right]) * Math.Abs(left - right);


                if (maxArea < area)
                {

                    maxArea = area;

                }
                Console.WriteLine(left + " " + right);
                // Console.WriteLine(maxArea);

                // because the area is decide by the shorter edge

                // so only way to increase the area is to increase the

                // shorter edge



                if (height[left] < height[right])
                {

                    left++;

                }

                else
                {

                    right--;

                }



            }



            return maxArea;

        }
    }
}
