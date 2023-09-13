using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Ex03
{
    class Ex03
    {                                                       
        static void Main(string[] args)
        {
            List<string> str = Console.ReadLine().Split('|').ToList();
            str.Reverse();

            List<string> list = new List<string>();

            for (int i = 0; i < str.Count; i++)
            {
                List<string> nums = str[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (string num in nums)
                {
                    list.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
