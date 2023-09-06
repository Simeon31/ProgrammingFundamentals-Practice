using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            string Str = "World";
            object c = str + " " + Str;
            string d = (string)c;
            Console.WriteLine(d);
        }
    }
}
