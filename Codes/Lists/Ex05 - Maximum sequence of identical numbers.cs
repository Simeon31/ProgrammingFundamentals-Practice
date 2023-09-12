using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Prossesing_Ex03
{
    class Ex03
    {
        static void Main(string[] args)
        {
            
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = 1;
            int tempCount = 1;
            int number = 1;


            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    tempCount++;
                }

                else
                {
                    tempCount = 1;
                }

                if (tempCount > count)
                {
                    count = tempCount;
                    number = nums[i];
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}
