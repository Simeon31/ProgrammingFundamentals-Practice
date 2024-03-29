using System;

namespace LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] seq = new long[n];
            seq[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i - k; j < i; j++)
                {
                    if (j >= 0)
                    {
                        sum += seq[j];
                    }
                    seq[i] = sum;
                }
            }
            Console.WriteLine(String.Join(" ", seq));
        }
    }
}
