using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MaximumAbsDifference
    {
        /// <summary>
        /// TC: O(n2) SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int maxArr(List<int> A)
        {
            int sum = 0;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A.Count; j++)
                {
                    int diff = Math.Abs(A[i] - A[j]) + Math.Abs(i - j);
                    sum = Math.Max(diff, sum);
                }
            }
            return sum;
        }

        /// <summary>
        /// TC:O(n) SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int maxArr2(List<int> A)
        {
            int max1 = Int32.MinValue;
            int max2 = Int32.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                max1 = Math.Max(max1, A[i] + i + 1);
                max2 = Math.Max(max2, A[i] - i - 1);
            }
            int min1 = Int32.MaxValue;
            int min2 = Int32.MaxValue;
            for (int i = 0; i < A.Count; i++)
            {
                min1 = Math.Min(min1, A[i] + i + 1);
                min2 = Math.Min(min2, A[i] - i - 1);
            }
            return Math.Max(max1 - min1, max2 - min2);
        }
    }
}
