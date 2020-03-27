using System;

namespace RotateImage
{
    class RotateImage
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            matrix = new int[3, 3] { {1,2,3},{4,5,6 }, {7,8,9} };
            int[,] num;
            int length = matrix.GetLength(0) - 1;
            num = new int[length + 1, length + 1];
            float mid_Num=(float)(length)/2;
            for(int i=0;i<=length;i++)
            {
                for(int j=0;j<=length;j++)
                {
                     num[j, length - i] = matrix[i, j];
                }
            }
            for(int i=0;i<=length;i++)
            {
                for(int j=0;j<=length;j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j <= length; j++)
                {
                    Console.Write("{0} ", num[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
