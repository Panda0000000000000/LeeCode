using System.Data;

namespace _69一维数组的动态和
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            RunningSum(new int[] { 1, 2, 3, 4 });
        }

        public static int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}