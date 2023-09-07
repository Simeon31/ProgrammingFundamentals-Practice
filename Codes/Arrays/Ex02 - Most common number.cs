using System;
using System.Linq;

namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int element = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int tempNum = arr[i];
                int tempCount = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == tempNum)
                    {
                        tempCount++;
                    }
                    if (tempCount > count)
                    {
                        element = tempNum;
                        count = tempCount;
                    }
                }
            }
            Console.WriteLine(element);
        }
    }
}
