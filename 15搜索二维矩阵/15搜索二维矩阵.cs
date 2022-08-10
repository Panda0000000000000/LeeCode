using System;

namespace _15搜索二维矩阵
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //从数组的右上角开始找
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int col = matrix[0].Length - 1;
            int row = 0;
            while (col>=0&&row>=0)
            {
                if (matrix[row][col]==target)
                {
                    return true;
                }
                if(matrix[row][col] > target)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }

            return false;
        }
    }
}
