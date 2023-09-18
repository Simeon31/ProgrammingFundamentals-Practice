using System;

using System.Linq;
using System.Numerics;

namespace ExercisesWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] nums = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger n =  nums[0];
            BigInteger number = nums[1];
            
            string result = String.Empty;

            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    result = number % n + result;
                    number /= n;

                    result = result.ToString();
                }
                
                Console.WriteLine(result);
            }

        }

    }
}
