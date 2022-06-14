using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Arrays
{
    class ClosestMinMax
    {
        /// <summary>
        /// TC: O(n) SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solve(List<int> A)
        {
            int max = A.Max();
            int min = A.Min();
            int imax = -1;
            int imin = -1;
            int size = Int32.MaxValue;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == max) imax = i;
                if (A[i] == min) imin = i;
                if (imax != -1 && imin != -1)
                {
                    size = Math.Min(size, Math.Abs(imin - imax) + 1);
                }

            }
            return size;
        }
    }
}
