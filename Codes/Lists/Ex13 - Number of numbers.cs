using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Sorting_Ex03
{
    class Ex03
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] counts = new int[nums.Max() + 1];

            foreach (int num in nums)
            {
                counts[num]++;
            }
            
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
                    
            }
        }
    }
}
