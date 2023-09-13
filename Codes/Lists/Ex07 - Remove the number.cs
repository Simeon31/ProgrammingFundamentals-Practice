using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation
{
    class Ex01
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int elements = numbers[numbers.Count - 1];


            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == elements)
                {
                    numbers.RemoveAll(x => x == elements);
                }

            }

            Console.WriteLine(String.Join(" ", numbers));


        }
    }
}
