using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Arrays
{
    class RowToColumnZero
    {
        public List<List<int>> solve(List<List<int>> A)
        {
            var result = A.Select(x => new List<int>()).ToList();
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[0].Count; j++)
                {
                    if (A[i][j] == 0)
                    {
                        int r1 = i;
                        while (r1 < A.Count)
                        {
                            result[r1][j] = 0;
                            r1++;
                        }
                        r1 = i;
                        while (r1 >= 0)
                        {
                            result[r1][j] = 0;
                            r1--;
                        }
                        int c1 = j;
                        while (c1 < A[0].Count)
                        {
                            result[i][c1] = 0;
                            c1++;
                        }
                        c1 = j;
                        while (c1 >= 0)
                        {
                            result[i][c1] = 0;
                            c1--;
                        }
                    }

                }
            }
            return result;
        }
    }
}
