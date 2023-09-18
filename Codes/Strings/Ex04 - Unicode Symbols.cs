using System;
using System.Text;

namespace ExercisesWithStrings.Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            byte[] buffer = Encoding.UTF8.GetBytes(str);

            
            foreach (byte item in buffer)
            {
                Console.Write($"{"\\u" + item.ToString("x4")}");
            }
        }

    }
}
