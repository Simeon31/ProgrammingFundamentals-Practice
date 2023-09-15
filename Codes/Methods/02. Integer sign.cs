using System;

namespace ConsoleApp108
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }
        
          private static void PrintSign(int num)
        {
         
            if (num > 0)
            {
                Console.WriteLine("The number {0} is positive.", num);
            }
            else if (num < 0)
            {
                Console.WriteLine("The number {0} is negative.",num);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", num);
            }
        }
        
    }
}
