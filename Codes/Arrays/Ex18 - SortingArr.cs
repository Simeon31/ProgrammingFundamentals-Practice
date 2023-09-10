using System;
using System.Linq;

namespace SortingArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int swap = arr[i];
                int index = i;
                while (index > 0 && arr[index - 1] >= swap)
                {
                    arr[index] = arr[index - 1];
                    index--;
                }
                arr[index] = swap;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
