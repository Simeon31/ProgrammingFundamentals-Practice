using System;
using System.Linq;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
               
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
          
        }
    }
}
