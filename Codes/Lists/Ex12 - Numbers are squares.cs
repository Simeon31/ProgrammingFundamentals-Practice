using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Sorting_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> squareNums = new List<double>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 1 == 0)
                {
                    squareNums.Add(nums[i]);
                }
            }
            squareNums.Sort((a, b) => b.CompareTo(a));

            foreach (var item in squareNums)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    Console.Write(" " + item);
                }
            }
        }
    }
}


