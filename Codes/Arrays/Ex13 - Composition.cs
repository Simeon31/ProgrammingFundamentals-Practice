using System;
using System.Linq;

namespace WareHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string namesOfProducts = Console.ReadLine();
            while (!namesOfProducts.Equals("done"))
            {
                int index = Array.IndexOf(products, namesOfProducts);
                Console.WriteLine($"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");
                namesOfProducts = Console.ReadLine();
            }
        }
    }
}

