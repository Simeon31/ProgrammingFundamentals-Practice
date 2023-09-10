using System;
using System.Linq;

namespace Searching_Elements_In_SortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(SearchArray(arr,n));
        }

        public static object SearchArray(int[] arr, int n)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (n == arr[mid])
                {
                    Console.WriteLine("Yes");
                  
                    return null;

                }
                else if (n < arr[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return "No";
        }
    }
}
