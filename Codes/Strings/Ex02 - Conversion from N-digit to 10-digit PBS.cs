using System;
using System.Linq;
using System.Numerics;

namespace ExercisesWithStrings.Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] read = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger n = read[0];
            BigInteger number = read[1];
            BigInteger result = 0;
            BigInteger power = 1;

            if (n < 2 && n > 10)
            {
                return;
            }
            while (number > 0)
            {
                BigInteger digit = number % 10;
                result += digit * power;
                power *= n;
                number /= 10;
            }
         
            Console.WriteLine(result);

        }
    }
}
