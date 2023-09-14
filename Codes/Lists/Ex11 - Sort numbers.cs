using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Sorting
{
    class Ex01
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            numbers.Sort();

            Console.WriteLine(String.Join(" <= ", numbers));
        }
    }
}
