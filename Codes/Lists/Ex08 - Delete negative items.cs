using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Ex02
{
    class Ex02
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.RemoveAll(x => x < 0);

            if (numbers.Count == 0)
            {

                Console.WriteLine("Empty");

            }

            numbers.Reverse();

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
