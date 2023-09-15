using System;

namespace LabEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceiptHeader();
            PrintBody();
            PrintFooter();
        }
        private static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintBody();
            PrintFooter();
        }
        private static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        private static void PrintFooter()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\u00A9 IT KARIERA");
        }


    }
}
