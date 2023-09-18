using System;

namespace ExercisesWithStrings.Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string str01 = Console.ReadLine();

            Palindrom(str01);
            
        }
        private static void Palindrom(string str01)
        {
            bool check = true;
            int storage = str01.Length;

            for (int i = 0; i < storage / 2; i++)
            {
                if (str01[i] != str01[storage - 1 - i]) 
                    check = false;
            }

            if (check == true)
            {

                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
          
        }
    }
}
