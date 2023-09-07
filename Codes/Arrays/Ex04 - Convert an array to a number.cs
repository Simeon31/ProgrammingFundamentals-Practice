using System;
using System.Linq;

namespace ConsoleApp136
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] condensedArray = new int[numbers.Length-1];

            for (int i = 0; i < numbers.Length; i++)
            {
                 
                if (numbers.Length == 1)
                {
                    Console.WriteLine(numbers[i]);
                    return;
                }
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    condensedArray[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condensedArray;
            }
            Console.WriteLine(numbers[0]);
        }

    }
}

