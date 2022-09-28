namespace _70寻找数组的中心索引
{
    internal class _70寻找数组的中心索引
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int PivotIndex(int[] nums)
        {
            int total = nums.Sum();
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (2 * sum + nums[i]==total)
                {
                    return i;
                }

                sum+=nums[i];
            }

            return -1;
        }
    }
}