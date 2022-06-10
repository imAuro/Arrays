using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class KadaneAlgo
    {
        /// <summary>
        /// TC:O(n3),SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int maxSubArray(List<int> A)
        {
            int ans = Int32.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < A.Count; j++)
                {
                    sum = GetSum(A, i, j);
                    ans = Math.Max(ans, sum);
                }
            }
            return ans;
        }
        public int GetSum(List<int> A, int start, int end)
        {
            int x = 0;
            for (int i = start; i <= end; i++)
            {
                x += A[i];
            }
            return x;
        }

        /// <summary>
        /// TC: O(n2), SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int maxSubArray2(List<int> A)
        {
            int ans = Int32.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < A.Count; j++)
                {
                    sum = sum + A[j];
                    ans = Math.Max(ans, sum);
                }
            }
            return ans;
        }

        /// <summary>
        /// TC:O(n), SC:O(1) Kadane's Algo
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int maxSubArray3(List<int> A)
        {
            int ans = Int32.MinValue;
            int sum = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (sum < 0) sum = A[i];
                else sum += A[i];
                ans = Math.Max(ans, sum);
            }
            return ans;
        }

    }
}
