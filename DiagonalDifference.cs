using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    static class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftToRight = 0, rightToLeft = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                leftToRight += arr[i][i];
            }
            for (int i = arr.Count - 1, j = 0; i >= 0; i--, j++)
            {
                rightToLeft += arr[i][j];
            }
            return Math.Abs(leftToRight - rightToLeft);
        }

    }
}
