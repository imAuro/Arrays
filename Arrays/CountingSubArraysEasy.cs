using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Arrays
{
    class CountingSubArraysEasy
    {
        /// <summary>
        /// TC: O(n2) SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int solve(List<int> A, int B)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < A.Count; j++)
                {
                    sum += A[j];
                    if (sum < B) count++;
                }
            }
            return count;

        }
    }
}
