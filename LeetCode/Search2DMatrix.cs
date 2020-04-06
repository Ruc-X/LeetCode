using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAns
{
    class Search2DMatrix
    {
        private static void Main()
        {
            int[][] matrix;
            matrix = new int[3][] { new int[4] { 1, 2, 5, 7 }, new int[4] { 10, 11, 16, 20 }, new int[4] { 23, 30, 34, 50 } };
            int target = 3;
            int m = matrix.Length;
            int n = matrix[0].Length;
            int left = 0, right = m * n-1;
            int mid = left + (right - left) / 2;
            while(left<=right)
            {
                int i = (mid) / n;
                int j = (mid) % n;
                if (target == matrix[i][j])
                {
                    Console.WriteLine("true");
                    return;
                }
                else if (target > matrix[i][j])
                    left = mid + 1;
                else
                    right = mid - 1;
                mid = left + (right - left) / 2;
            }
            Console.WriteLine("false");
            return;
        }
    }
}
