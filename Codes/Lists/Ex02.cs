using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Introduction_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = Console.ReadLine().Split().ToList();

            Console.Write(string.Join("; ", name));
        }
    }
}
