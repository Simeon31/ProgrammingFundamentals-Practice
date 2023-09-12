using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Prossesing
{
    class Ex01
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.Write(" " + nums[i]);
                }
            }
        }
    }
}
