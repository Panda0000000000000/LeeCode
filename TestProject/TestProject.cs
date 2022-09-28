// See https://aka.ms/new-console-template for more information

//测试用的
using System.Collections.Generic;

PriorityQueue<int, int> a = new PriorityQueue<int, int>();

a.Enqueue(1, -1);
a.Enqueue(10, 0);
a.Enqueue(2, -2);

a.EnqueueDequeue(5,3);

Console.WriteLine(a.Peek().ToString());
Console.WriteLine(a.Dequeue().ToString());
Console.WriteLine(a.Dequeue().ToString());
Console.WriteLine(a.Dequeue().ToString());

Console.ReadKey();