using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Prossesing_Ex02
{
    class Ex02
    {
        static void Main(string[] args)
        {
			List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> results = new List<int>();
			int min = nums[0], max = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }
            for (int i = 1; i < nums.Count; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            for (int i = 0; i < nums.Count; i++)
			{
				if (nums[i] == min || nums[i] == max)
				{
					results.Add(nums[i]);
				}
			}

			results.Sort();
			Console.WriteLine(string.Join(" ", results));
		}
    }
}
