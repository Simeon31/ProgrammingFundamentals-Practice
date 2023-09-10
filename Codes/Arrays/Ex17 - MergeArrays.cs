using System;
using System.Linq;

namespace MergeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr01 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr02 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr03 = new int[arr01.Length + arr02.Length];
            int n = 0;
            int i = 0;
            int j = 0;
            

            while (i < arr01.Length && j < arr02.Length)
            {

                if (arr01[i] < arr02[j])
                {

                    arr03[n] = arr01[i];

                    i++;
                }
                else
                {
                    arr03[n] = arr02[j];
                    j++;
                }

                n++;
            }

            while (i < arr01.Length)
            {
                arr03[n] = arr01[i];
                i++;
                n++;
            }

            while (j < arr02.Length)
            {
                arr03[n] = arr02[j];
                j++;
                n++;
            }

            Console.WriteLine(String.Join(" ", arr03));
        }
    }
}
