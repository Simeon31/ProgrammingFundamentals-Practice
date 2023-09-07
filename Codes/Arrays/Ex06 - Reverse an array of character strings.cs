using System;
using System.Linq;

namespace ConsoleApp136
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split().ToArray();
            Array.Reverse(str);

            foreach (string item in str)
            {
                Console.Write(" " + item);
            }

        }

    }
}

