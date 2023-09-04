using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int y = b;
            b = a;
            Console.WriteLine("Before:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + y);
            Console.WriteLine("After:");
            Console.WriteLine("a = " + y);
            Console.WriteLine("b = " + a);
        }
    }
}
