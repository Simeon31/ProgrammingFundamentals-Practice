using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            int num01 = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(num01);
        }
    }
}
