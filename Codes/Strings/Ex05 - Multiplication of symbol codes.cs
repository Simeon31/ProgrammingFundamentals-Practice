using System;
using System.Linq;

namespace ExercisesWithStrings.Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split().ToArray();

            CalculateTheSumOfMultipliedStrings(str[0], str[1]);
        }
        private static void CalculateTheSumOfMultipliedStrings(string str01, string str02)
        {
            int sum = 0;
            for (int i = 0; i < Math.Max(str01.Length, str02.Length); i++)
            {
                int num1 = 1;
                int num2 = 1;

                if (i < str01.Length)
                {
                    num1 = str01[i];
                }
                if (i < str02.Length)
                {
                    num2 = str02[i];
                }

                sum += num1 * num2;
            }
            Console.WriteLine(sum);
        }
    }
}
