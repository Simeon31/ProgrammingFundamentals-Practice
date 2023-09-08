using System;
using System.Linq;

namespace RenewWarehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse) .ToArray();
            string commands = Console.ReadLine();
            while (commands != "done")
            {
                string[] command = commands.Split().ToArray();
                string itemName = command[0];
                long goodsStock = 0;
                long qtyToOrder = long.Parse(command[1]);
                int indexOfProducts = Array.IndexOf(products, itemName);

                if (indexOfProducts < quantities.Length)
                {
                    goodsStock = quantities[indexOfProducts];
                   
                }
                
                if (goodsStock >= qtyToOrder)
                {
                    decimal totalPrice = qtyToOrder * prices[indexOfProducts];
                    Console.WriteLine($"{products[indexOfProducts]} x {qtyToOrder} costs {totalPrice:F2}");
                    quantities[indexOfProducts] -= qtyToOrder;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[indexOfProducts]}");
                }
                commands = Console.ReadLine();
            }
        }
    }
}
