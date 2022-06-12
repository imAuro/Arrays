using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Arrays
{
    class SubMatrixSumQueries
    {
        /// <summary>
        /// TC:O(q*n*m) SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <param name="E"></param>
        /// <returns></returns>
        public List<int> solve(List<List<int>> A, List<int> B, List<int> C, List<int> D, List<int> E)
        {

            List<int> res = new List<int>();

            int q = B.Count();
            int sum = 0;

            for (int i = 0; i < q; i++)
            {
                sum = 0;
                int r1 = B[i];
                int c1 = C[i];
                int r2 = D[i];
                int c2 = E[i];
                for (int a = r1 - 1; a < r2; a++)
                {
                    for (int b = c1 - 1; b < c2; b++)
                    {
                        sum += A[a][b];
                    }
                }

                res.Add(sum);
            }
            return res;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <param name="E"></param>
        /// <returns></returns>
        public List<int> solve2(List<List<int>> A, List<int> B, List<int> C, List<int> D, List<int> E)
        {

            int[,] rowPrefixSum = new int[A.Count, A[0].Count];
            for (int i = 0; i < A[0].Count; i++)
            {
                rowPrefixSum[0, i] = A[0][i];
            }

            for (int i = 1; i < A.Count; i++)
            {
                for (int j = 0; j < A[0].Count; j++)
                {
                    rowPrefixSum[i, j] = rowPrefixSum[i - 1, j] + A[i][j];
                }
            }
            int q = B.Count();
            int sum = 0;
            List<int> res = new List<int>();
            for (int i = 0; i < q; i++)
            {
                sum = 0;
                int r1 = B[i];
                int c1 = C[i];
                int r2 = D[i];
                int c2 = E[i];
                for (int k = c1 - 1; k < c2; k++)
                {
                    sum = sum + rowPrefixSum[r2 - 1, k];
                    sum = sum % 1000000007;
                    if (r1 > 1)
                    {
                        sum = sum - rowPrefixSum[r1 - 2, k];
                        sum = sum % 1000000007;
                    }
                }
                sum = sum % 1000000007;
                if (sum < 0)
                {
                    sum = sum + 1000000007;
                }
                res.Add(sum);
            }
            return res;

        }


        /// <summary>
        /// Optimised soln
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <param name="E"></param>
        /// <returns></returns>
        public List<int> solve3(List<List<int>> A, List<int> B, List<int> C, List<int> D, List<int> E)
        {

            int[,] rowPrefixSum = new int[A.Count, A[0].Count];
            for (int i = 0; i < A[0].Count; i++)
            {
                rowPrefixSum[0, i] = A[0][i];
            }

            for (int i = 1; i < A.Count; i++)
            {
                for (int j = 0; j < A[0].Count; j++)
                {
                    rowPrefixSum[i, j] = rowPrefixSum[i - 1, j] + A[i][j];
                    rowPrefixSum[i, j] = rowPrefixSum[i, j] % 1000000007;
                }
            }
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 1; j < A[0].Count; j++)
                {
                    rowPrefixSum[i, j] = rowPrefixSum[i, j - 1] + rowPrefixSum[i, j];
                    rowPrefixSum[i, j] = rowPrefixSum[i, j] % 1000000007;
                }
            }
            int q = B.Count();
            int sum = 0;
            List<int> res = new List<int>();
            for (int i = 0; i < q; i++)
            {
                sum = 0;
                int r1 = B[i];
                int c1 = C[i];
                int r2 = D[i];
                int c2 = E[i];
                sum = rowPrefixSum[r2 - 1, c2 - 1];
                sum = sum % 1000000007;
                if (r1 > 1)
                {
                    sum = sum - rowPrefixSum[r1 - 2, c2 - 1];
                    sum = sum % 1000000007;
                }
                if (c1 > 1)
                {
                    sum = sum - rowPrefixSum[r2 - 1, c1 - 2];
                    sum = sum % 1000000007;
                }
                if (r1 > 1 && c1 > 1)
                {
                    sum = sum + rowPrefixSum[r1 - 2, c1 - 2];
                    sum = sum % 1000000007;
                }
                if (sum < 0)
                {
                    sum = sum + 1000000007;
                }
                res.Add(sum);
            }
            return res;

        }



    }
}
