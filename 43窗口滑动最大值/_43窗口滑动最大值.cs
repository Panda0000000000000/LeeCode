using System.Reflection;
using System.Security.AccessControl;
using System.Xml.Serialization;

namespace _43窗口滑动最大值
{
    internal class _43窗口滑动最大值
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            MaxSlidingWindow_1(new int[] { 9, 10, 9, -7, -4, -8, 2, -6 }, 5);
        }

        //超出时间限制  就是一段一段的找
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            int len = nums.Length;
            int move_Len = len - k + 1;
            int[] resault = new int[move_Len];

            int l = 0, r = k - 1;
            for (int i = 0; i < move_Len; i++)
            {
                resault[i] = GetMaxValue(nums, l, r);
                l++;
                r++;
            }

            int GetMaxValue(int[] nums, int a, int b)
            {
                int maxValue = nums[a];
                for (int i = a + 1; i <= b; i++)
                {
                    if (nums[i] > maxValue)
                    {
                        maxValue = nums[i];
                    }
                }

                return maxValue;
            }

            return resault;
        }

        //优先队列
        public static int[] MaxSlidingWindow_1(int[] nums, int k)
        {
            PriorityQueue<int[], int> priorityQueue = new PriorityQueue<int[], int>();
            int move_Len = nums.Length - k + 1;
            int[] resault = new int[move_Len];
            int[] cache = new int[k];

            int l = 0, r = k - 1;
            if (priorityQueue.Count < k)
            {
                for (int j = 0; j <= r; j++)
                {
                    priorityQueue.Enqueue(new int[] { nums[j] ,j}, -nums[j]);
                    cache[j] = nums[j];
                }
            }
            for (int i = 0; i < move_Len; i++)
            {
                int[] res = priorityQueue.Dequeue();
                while (res[1]<l)
                {
                    res = priorityQueue.Dequeue();
                }
                resault[i] = res[0];

                if (res[1]!=l)
                {
                    priorityQueue.Enqueue(res, -res[0]);
                }
                
                l++;
                r++;
                if (r<nums.Length)
                {
                    priorityQueue.Enqueue(new int[] { nums[r], r }, -nums[r]);
                }
            }
            return resault;
        }
    }
}