using System;

namespace ConsoleApp103
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(Reverse(str));
        }
        public static string Reverse(string Input)
        {


            char[] charArray = Input.ToCharArray();


            string reversedString = String.Empty;


            for (int i = charArray.Length - 1; i > -1; i--)
            {


                reversedString += charArray[i];
            }


            return reversedString;
        }
    }
}
