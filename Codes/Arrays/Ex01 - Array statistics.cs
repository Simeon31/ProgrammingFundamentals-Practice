using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            string[] numbersAsString = Console.ReadLine().Split().ToArray();
            numbers = new int[numbersAsString.Length];

            int min = int.MaxValue;
            int max = int.MinValue;
            long sum = 0;
            double avg;

            for (int i = 0; i < numbersAsString.Length; i++)
            {
                int current = int.Parse(numbersAsString[i]);
                sum += current;
                if (current > max)
                {
                    max = current;
                }
                if (current < min)
                {
                    min = current;
                }
            }
            avg = sum / (double)numbersAsString.Length;
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", avg);

        }
    }
}
