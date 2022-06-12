using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Arrays
{
    class GoodSubArrays
    {
        public int solve(List<int> A, int B)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < A.Count; j++)
                {
                    sum += A[j];
                    if (sum > B && (j - i + 1) % 2 != 0) count++;
                    if (sum < B && (j - i + 1) % 2 == 0) count++;
                }
            }
            return count;

        }
    }
}
