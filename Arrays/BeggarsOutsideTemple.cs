using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Arrays
{
    public class BeggarsOutsideTemple
    {
        /// <summary>
        /// TC: O(n2) SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public List<int> solve(int A, List<List<int>> B)
        {
            int[] res = new int[A];
            for (int i = 0; i < B.Count; i++)
            {
                for (int j = B[i][0]; j <= B[i][1]; j++)
                {
                    res[j - 1] = res[j - 1] + B[i][2];
                }
            }
            return res.ToList();

        }
        public List<int> solve2(int A, List<List<int>> B)
        {
            int[] res = new int[A];

            for (int i = 0; i < B.Count; i++)
            {
                res[(B[i][0]) - 1] += B[i][2];
                if (B[i][1] != res.Length)
                {
                    res[B[i][1]] -= (B[i][2]);
                }
            }
            for (int i = 1; i < res.Length; i++)
            {
                res[i] = res[i - 1] + res[i];
            }
            return res.ToList();

        }
    }
}
