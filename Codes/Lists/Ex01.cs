using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Introduction_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("nums[{0}] = {1}", i, list[i]);
            }
        }
    }
}
