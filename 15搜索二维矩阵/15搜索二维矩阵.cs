/***************************************************
	日期：2022/08/28  15:43
	作者：夏
	描述：编写一个高效的算法来搜索 m x n 矩阵 matrix 中的一个目标值 target 。该矩阵具有以下特性：
        每行的元素从左到右升序排列。
        每列的元素从上到下升序排列。

                其实这道题的考点应该是二分查找,也应该是Z字形查找

        //Z字形查找
        //二分查找   就不写了 没必要

****************************************************/
using System;

namespace _15搜索二维矩阵
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] a = new int[1, 1] { { 1 } };
        }

        //从数组的右上角开始找 Z字形查找
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int col = matrix[0].Length - 1;
            int row = 0;    //行 
            while (col>=0&&row<matrix.Length)
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