using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);
            Console.Write($"Hello, {firstname} {lastname}. You are {age} years old.");
        }
    }
}
