using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Prossesing_Ex04
{
    class Ex04
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                int rev = 0;
                while (nums[i] > 0)
                {

                    int r = nums[i] % 10;
                    rev = rev * 10 + r;
                    nums[i] = nums[i] / 10;
                }
                sum += rev;
            }
            Console.WriteLine(sum);
        }
    }
}
