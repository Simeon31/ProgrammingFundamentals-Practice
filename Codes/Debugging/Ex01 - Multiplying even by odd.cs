using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfOddAndEvenSum(n));
        }
        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;

           
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;

                }
                n /= 10;
            }

            return sum;
        }
        private static int GetMultipleOfOddAndEvenSum(int n)
        {
            int evenSum = GetSumOfEvenDigits(n);
            int oddSum = GetSumOfOddDigits(n);
            return evenSum * oddSum;
        }
    }
}
