using Coding_Practice.Arrays;
using Coding_Practice.Practice;

namespace Coding_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //TwoSum twoSum = new TwoSum();
            //twoSum.TwoSumCal([2, 3, 4, 5, 6, 7, 8], 10);
            //Console.WriteLine(twoSum.TwoSumCalOptimised([2, 3, 4, 5, 6, 7, 8], 10));

            //PairMapping.Pair();

            //var summary = BenchmarkRunner.Run<BenchmarkTest>();

            //int[] arr = [1, 2, 3, 4, 5, 6, 7];
            //RotateArray rotateArray = new RotateArray();
            //rotateArray.Rotate1(arr, 3);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = LongestWord.LongestWordIn("This is most@#$% of the funny time and good");
            //Console.WriteLine(result);

            //ContainsDuplicate cd = new ContainsDuplicate();
            //cd.ContainsDuplicateCal1([0,1,2,3,4,5,3,6,7]);

            //MoveZeroes mz = new MoveZeroes();
            //mz.MoveZeroesCal([1,2,3,0,5,0,8,0,9,0,7,2]);
            MinCoins mc = new MinCoins();
            //Console.WriteLine(mc.MinCoinsBruteForce([1, 5, 10], 11));
            var res = mc.MinCoinsDP([1, 5, 10], 11);
            Console.WriteLine(res.Item1.ToString());
            Console.WriteLine(string.Join(",", res.Item2));

            //HashTable<string, string> hash = new HashTable<string, string>();

            //hash.AddData("key1", "value1");
            //hash.AddData("key2", "value2");
            //hash.AddData("key3", "value3");
            //hash.AddData("key4", "value4");

            //if (hash.TryGetValue("key1", out var key))
            //{
            //    Console.WriteLine(key);
            //}

            //hash.Remove("key2");


            //CustomLinkedList<int> l = new CustomLinkedList<int>(10);
            //l.append(5);
            //l.append(16);
            //l.prepend(1);
            //l.insert(2, 99);
            //l.insert(20, 7);
            //l.remove(2);
            //l.reverse();


            //PriorityQueue<string> pq = new PriorityQueue<string>(new MinComparer());

            //pq.EnQueue("Task A", 5);
            //pq.EnQueue("Task B", 2);
            //pq.EnQueue("Task C", 8);

            //Console.WriteLine(pq.DeQueue());
            //Console.WriteLine(pq.DeQueue());
            //Console.WriteLine(pq.DeQueue());


            Console.ReadKey();

        }
    }
}
