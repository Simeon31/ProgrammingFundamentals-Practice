using System;
using System.Linq;

namespace Arrays_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr01 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr02 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] tempArr;
            bool equalsLetter = true;

            if (arr01.Length > arr02.Length)
            {
                tempArr = arr01;
                arr01 = arr02;
                arr02 = tempArr;
            }

            for (int i = 0; i < arr01.Length; i++)
            {
                if (arr01[i] < arr02[i])
                {
                    equalsLetter = false;
                    Console.WriteLine(new string(arr01));
                    Console.WriteLine(new string(arr02));
                    break;
                }
                
                else if(arr02[i] < arr01[i])
                {
                    equalsLetter = false;
                    Console.WriteLine(new string(arr02));
                    Console.WriteLine(new string(arr01));
                    break;
                }
            }

            if (equalsLetter && arr01.Length == arr02.Length)
            {
                Console.WriteLine(new string(arr01));
                Console.WriteLine(new string(arr02));
            }

            else if(equalsLetter)
            {
                Console.WriteLine(new string(arr01));
                Console.WriteLine(new string(arr02));
            }
        }

    }
}
