using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class LongestConsecutiveOnes
    {
        /// <summary>
        /// TC:O(n2), SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solve(string A)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Equals('1') == true) count++;
                if (A[i].Equals('0') == true)
                {
                    int j = i - 1;
                    int left = 0;
                    while (j >= 0 && A[j].Equals('1') == true)
                    {
                        left++;
                        j--;
                    }
                    j = i + 1;
                    int right = 0;
                    while (j < A.Length && A[j].Equals('1') == true)
                    {
                        right++;
                        j++;
                    }
                    sum = Math.Max(sum, left + right + 1);
                }
            }
            if (sum == 0 || sum > count)
            {
                return count;
            }

            return sum;
        }

        /// <summary>
        /// TC: O(n), SC:O(n)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solve2(string A)
        {
            int[] lefty = new int[A.Length];
            if (A[0].Equals('1'))
            {
                lefty[0] = 1;
            }
            int max = lefty[0];
            int count = max;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i].Equals('1'))
                {
                    lefty[i] = lefty[i - 1] + 1;
                    max = Math.Max(max, lefty[i]);
                    count++;
                }
            }

            int[] righty = new int[A.Length];
            if (A[A.Length - 1].Equals('1'))
            {
                righty[A.Length - 1] = 1;
            }
            for (int i = A.Length - 2; i >= 0; i--)
            {
                if (A[i].Equals('1'))
                {
                    righty[i] = righty[i + 1] + 1;
                }
            }

            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i].Equals('0')) max = Math.Max(max, righty[i + 1] + lefty[i - 1] + 1);
            }
            if (max == 0 || max > count) return count;
            return max;

        }
    }

}
