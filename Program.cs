﻿using BenchmarkDotNet.Running;
using Coding_Practice.Arrays;
using Coding_Practice.Practice;
using System.Collections.Generic;

namespace Coding_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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


            CustomLinkedList<int> l = new CustomLinkedList<int>(10);
            l.append(5);
            l.append(16);
            l.prepend(1);
            l.insert(2, 99);
            l.insert(20, 7);
            l.remove(2);
            l.reverse();

            Console.ReadKey();
        }
    }
}
