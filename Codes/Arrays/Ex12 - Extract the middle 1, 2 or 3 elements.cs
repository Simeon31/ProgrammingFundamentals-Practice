using System;
using System.Linq;

namespace ExtractingMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (seq.Length == 1)
            {
                GetMiddleOne(seq);
            }
            else if (seq.Length % 2 == 0)
            {
                GetMiddleTwo(seq);
            }
            else
            {
                GetMiddleThree(seq);
            }

        }

        private static void GetMiddleThree(int[] seq)
        {
            Console.WriteLine($"{{ {seq[seq.Length / 2 - 1]}, {seq[seq.Length / 2]}, {seq[seq.Length / 2 + 1]} }}");
        }

        private static void GetMiddleTwo(int[] seq)
        {
            Console.WriteLine($"{{ {seq[seq.Length / 2 - 1]}, {seq[seq.Length / 2]} }}");
        }

        private static void GetMiddleOne(int[] seq)
        {
            Console.WriteLine($"{{ {seq[0]} }}");
        }
    }
}


