using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double perimeter = 2 * (a + b);
            double c =  (a * a) + (b * b);
            double square = a * b;
            decimal diagonal = (decimal) Math.Sqrt(c);

            Console.WriteLine(perimeter);
            Console.WriteLine(square);
            Console.WriteLine(diagonal);

        }
    }
}
