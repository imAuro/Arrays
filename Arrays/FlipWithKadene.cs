using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Arrays
{
    class FlipWithKadene
    {
        /// <summary>
        /// TC:O(N) SC:O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public List<int> flip(string A)
        {
            int sum = 0;
            int ans = 0;
            int start = 0;
            int ansStart = -1;
            int ansEnd = -1;
            List<int> res = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Equals('0'))
                {
                    sum = sum + 1;
                }
                else
                {
                    sum = sum - 1;
                }
                if (sum < 0)
                {
                    sum = 0;
                    start = i + 1;
                }
                if (sum > ans)
                {
                    ans = sum;
                    ansStart = start;
                    ansEnd = i;
                }
            }
            if (ansStart == -1) return res;

            res.Add(ansStart + 1);
            res.Add(ansEnd + 1);
            return res;
        }
    }
}
