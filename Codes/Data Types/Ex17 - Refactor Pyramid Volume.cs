using System;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
           double B = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double H = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double V = double.Parse(Console.ReadLine());
            V = (B * H * V) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);
        }
    }
}

