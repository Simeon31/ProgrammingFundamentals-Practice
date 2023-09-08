using System;
using System.Linq;

namespace ProcessingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if ("reverse".Equals(commands[0].ToLower()))
                {
                    Array.Reverse(arr);
                }

                if ("distinct".Equals(commands[0].ToLower()))
                {
                    arr = arr.Distinct().ToArray();
                }
                if ("replace".Equals(commands[0].ToLower()))
                {
                    int index = int.Parse(commands[1]);
                    string newWord = commands[2];
                    arr[index] = newWord;

                }
                
            }
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
