/***************************************************
	日期：2022/09/02  19:54
	作者：夏
	描述：
****************************************************/

using System.Collections.Generic;

namespace _42前_K_个高频元素
{
    internal class _42前_K_个高频元素
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            // 统计次数
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = dic[nums[i]] + 1;
                }
                else
                {
                    dic[nums[i]] = 1;
                }
            }
            Dictionary<int, int>.KeyCollection keycol = dic.Keys;

            int[] dicKey = new int[keycol.Count];
            keycol.CopyTo(dicKey, 0);

            // 堆排序
            HeapSort(dicKey);

            int[] res = new int[k];
            int count = 0, idx = dicKey.Length - 1;
            while (count < k)
            {
                res[count++] = dicKey[idx--];
            }

            void HeapSort(int[] nums)
            {
                // 建堆
                // 向上排序
                for (int start = nums.Length / 2 - 1; start >= 0; start--)
                {
                    Heapify(nums, start, nums.Length);
                }
                // 将最大节点放到尾部
                for (int tail = nums.Length - 1; tail > 0; tail--)
                {
                    Swap(nums, 0, tail);
                    // 重建堆
                    Heapify(nums, 0, tail);
                }
            }


            void Heapify(int[] nums, int i, int len)
            {
                int MaxIdx = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;
                if (left < len && dic[nums[left]] > dic[nums[MaxIdx]]) MaxIdx = left;
                if (right < len && dic[nums[right]] > dic[nums[MaxIdx]]) MaxIdx = right;

                // 置换
                if (i != MaxIdx)
                {
                    Swap(nums, i, MaxIdx);
                    // 继续下探检查父节点是否小于子节点
                    Heapify(nums, MaxIdx, len);
                }
            }

            void Swap(int[] nums, int a, int b)
            {
                int temp = nums[a];
                nums[a] = nums[b];
                nums[b] = temp;
            }

            return res;
        }

        

        //优先队列
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int,int> cache = new Dictionary<int,int>();
            PriorityQueue<int,int> priorityQueue = new PriorityQueue<int,int>();

            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (cache.ContainsKey(nums[i]))
                {
                    cache[nums[i]]++;
                }
                else
                {
                    cache.Add(nums[i], 1);
                }
            }

            foreach (var item in cache)
            {
                priorityQueue.Enqueue(item.Key, -item.Value);
            }

            int[] resault = new int[k];
            for (int i = 0; i < k; i++)
            {
                resault[i] = priorityQueue.Dequeue();
            }

            return resault;
        }
    }
}
