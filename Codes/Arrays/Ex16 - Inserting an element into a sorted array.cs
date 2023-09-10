using System;
using System.Linq;

namespace InsertingArrays_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int mid = -1;
            int insertIndex = -1;
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            while (startIndex != endIndex && (endIndex - startIndex > 1))
            {
                mid = startIndex + endIndex / 2;

                if (n == arr[mid])
                {
                    startIndex = mid;
                    endIndex = mid;
                    break;
                }
                if (n < arr[mid])
                {
                    endIndex = mid - 1;
                }
                else
                {
                    startIndex = mid + 1;
                }
            }

            if (n <= arr[startIndex])
            {
                insertIndex = startIndex;
            }
            else if (n >= arr[startIndex])
            {
                insertIndex = startIndex + 1;
            }
            insertIndex = (insertIndex < 0) ? 0 : insertIndex;

            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < insertIndex; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[insertIndex] = n;

            for (int i = insertIndex + 1; i < newArr.Length; i++)
            {
                newArr[i] = arr[i - 1];

            }

            Console.WriteLine(String.Join(" ", newArr));
        }
    }
}
