/*
    本题有三种解法
    二分
    二进制
    快慢指针

 */

namespace _65寻找重复数
{
    internal class _65寻找重复数
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        //快慢指针
        public int FindDuplicate(int[] nums)
        {
            int slow = 0;
            int fast = 0;
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow!=fast);
            fast = 0;
            while (slow!=fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return fast;
        }
    }
}