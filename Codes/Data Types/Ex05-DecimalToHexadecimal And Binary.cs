using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01 = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(num01, 16).ToUpper();
            string num02 = Convert.ToString(num01, 2);
            Console.WriteLine(hexadecimal);
            Console.WriteLine(num02);
        }
    }
}
