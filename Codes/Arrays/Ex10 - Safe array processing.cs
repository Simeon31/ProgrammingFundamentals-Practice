using System;
using System.Collections.Generic;
using System.Linq;

namespace SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "END")
            {
                if (command[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                else if (command[0] == "Distinct")
                {
                   
                    input = input.Distinct().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    if (0 <= index && index < input.Length)
                    {
                        string replacingWord = command[2];
                        input[index] = replacingWord;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
