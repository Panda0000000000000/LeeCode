namespace _64寻找峰值
{
    internal class _64寻找峰值
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int FindPeakElement(int[] nums)
        {
            int max=0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= nums[max])
                {
                    max = i;
                }
            }

            return max;
        }
    }
}