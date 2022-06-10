using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class LengthOfLongestConsecutiveOnes
    {
        /// <summary>
        /// TC:O(n2) SC: O(1)
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
    }
}
