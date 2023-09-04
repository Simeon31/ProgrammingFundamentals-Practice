using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int remainder = number % secondNumber;
                sum += remainder;
            }

            Console.WriteLine(sum);
        }
    }
}
