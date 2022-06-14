using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Arrays
{
    class RainWaterTrapped
    {
        public int trap(List<int> A)
        {
            int[] rightA = new int[A.Count];
            rightA[A.Count - 1] = A[A.Count - 1];
            for (int i = A.Count - 2; i >= 0; i--)
            {
                rightA[i] = Math.Max(rightA[i + 1], A[i]);
            }
            int sum = 0;
            int leftA = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                leftA = Math.Max(leftA, A[i]);
                int min = Math.Min(leftA, rightA[i]);
                int water = min - A[i];
                if (water > 0)
                {
                    sum = sum + water;
                }
            }
            return sum;

        }
    }
}
